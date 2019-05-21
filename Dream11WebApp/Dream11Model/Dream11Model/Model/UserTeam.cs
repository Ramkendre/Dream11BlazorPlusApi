using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream11Model.Model
{
    public class UserTeam
    {
        public int UserTeamId { get; set; }
        public virtual User User { get; set; }
        public virtual List<UserTeamPlayers> Players { get; set; }
        public string UserTeamName { get; set; }
        public virtual List<ContestUserTeam> ContestUserTeams { get; set; }
    } 
}
