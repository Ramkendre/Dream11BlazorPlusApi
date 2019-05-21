using System.Collections.Generic;
using System.Linq;

namespace RulesStatefulServiceApiService.Model
{
    public class ValidationContext
    {

        List<Rule> rules = new List<Rule>();

        public ValidationContext(params Rule[] rules)
        {
            this.rules = rules.ToList();
        }

        public List<PlayerMatchStatistics> GetResults()
        {
            var results = new List<PlayerMatchStatistics>();
            foreach (var rule in rules)
            {
                results.Add(rule.Validate(this));
            }

            return results;
        }

        public void AddRule(Rule r)
        {
            this.rules.Add(r);
        }

    }
}