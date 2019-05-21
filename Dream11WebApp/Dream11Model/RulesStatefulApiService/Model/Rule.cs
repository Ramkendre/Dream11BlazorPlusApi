using System;
using System.Collections.Generic;
using System.Text;

namespace RulesStatefulServiceApiService.Model
{
    public abstract class Rule
    {
        public abstract PlayerMatchStatistics Validate(ValidationContext context);

        public static Rule<TEntityType> Create<TEntityType>(TEntityType entity, Func<TEntityType, PlayerMatchStatistics> rule)
        {
            Rule<TEntityType> newRule = new Rule<TEntityType>();
            newRule.rule = rule;
            newRule.entity = entity;
            return newRule;
        }
    }

    public class Rule<T> : Rule
    {
        internal T entity;
        internal Func<T, PlayerMatchStatistics> rule;

        public override PlayerMatchStatistics Validate(ValidationContext context)
        {
            return rule(entity);
        }
    }
}
