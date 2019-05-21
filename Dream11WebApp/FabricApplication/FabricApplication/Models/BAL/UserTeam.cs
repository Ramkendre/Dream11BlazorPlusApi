using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FabricApplication.Models.BAL
{
    public class UserTeam
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<Player> Players { get; set; }
        public string UserTeamName { get; set; }
        public List<Contest> Contests { get; set; }
    }
}