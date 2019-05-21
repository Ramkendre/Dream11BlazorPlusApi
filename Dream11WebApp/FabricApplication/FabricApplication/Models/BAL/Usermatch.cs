using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricApplication.Models.BAL
{
    public class Usermatch
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string TeamTeamName { get; set; }
        public int PlayerId { get; set; }
        public string PlayerFirstName { get; set; }
        public string PlayerLastName { get; set; }
        public int MatchId { get; set; }
        public string MatchName { get; set; }
    }
}
