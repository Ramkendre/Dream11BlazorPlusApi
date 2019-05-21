using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream11Model.Model
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string PlayerRoleName { get; set; }
        public int TeamId { get; set; }
        public  Team Team { get; set; }
        public string Image { get; set; }
        public decimal Points { get; set; }
        public decimal Credits { get; set; }
        public bool IsSelected { get; set; }
        public List<UserTeamPlayers> UserTeams { get; set; }
        public bool IsCaptain { get; set; }
        public bool IsViceCaptain { get; set; }
    }
}
