using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricApplication.Models.BAL
{
    public class PlayerScore
    {
        public int Id { get; set; }

        //public int? MatchId { get; set; }
        public int? PlayerId { get; set; }
        public int? Points { get; set; }
        public double Credits { get; set; }
        
    }
}
