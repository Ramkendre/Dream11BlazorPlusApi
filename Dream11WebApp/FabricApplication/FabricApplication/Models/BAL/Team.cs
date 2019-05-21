using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricApplication.Models.BAL
{
    public class Team
    {
        public int Id { get; set; }
        
        public string TeamName { get; set; }

        public Match Match { get; set; }

        public string Logo { get; set; }
        public List<Player> Players { get; set; }
    }
}
