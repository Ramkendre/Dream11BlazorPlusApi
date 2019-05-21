using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricApplication.Models.BAL
{
    public class MatchPlayer
    {
        public int Id { get; set; }

        public int? PlayerId { get; set; }
        public int? MatchId { get; set; }

        //public string PlayerFirstName { get; set; }
        //public string PlayerLastName { get; set; }
        public string MatchName { get; set; }
        //[JsonIgnore]
        // public PlayerEntity player { get; set; }

       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string PlayerRoleName { get; set; }
        public string PlayerImage { get; set; }
        public int? Points { get; set; }

        public double? Credits { get; set; }

        public bool IsSelected { get; set; }

        
        
        // public IEnumerable<FabricApplication.Models.DAL.Players> Players { get; set; }
    }
}
