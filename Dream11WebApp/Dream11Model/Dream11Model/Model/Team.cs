using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream11Model.Model
{
    public class Team
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; }

        public int MatchId { get; set; }
        [JsonIgnore]
        public Match Match { get; set; }

        public string Logo { get; set; }
        [JsonIgnore]
        public ICollection<Player> Players { get; set; }
        
    }
}
