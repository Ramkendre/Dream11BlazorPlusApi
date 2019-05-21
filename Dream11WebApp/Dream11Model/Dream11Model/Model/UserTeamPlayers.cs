using System;
using System.Collections.Generic;
using System.Text;

namespace Dream11Model.Model
{
    public class UserTeamPlayers
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public UserTeam UserTeam { get; set; }
        public int UserTeamId { get; set; }
        public bool IsCaptain { get; set; }
        public bool IsViceCaptain { get; set; }
        public decimal Point { get; set; }
    }
}
