using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FabricApplication.Models.BAL
{
    public class PlayerEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string PlayerRoleName { get; set; }

        public string playerimage { get; set; }

        public int? Points { get; set; }

        public double? Credits { get; set; }
        [JsonIgnore]
        public IEnumerable<PlayerScore> PlayerScores { get; set; }
    }
}