using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricApplication.Models.BAL
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string PlayerRoleName { get; set; }
        public Team Team { get; set; }
        public string Image { get; set; }
        public decimal Points { get; set; }
        public decimal Credits { get; set; }
        public bool IsSelected { get; set; }
      //  public IEnumerable<MatchPlayer> MatchPlayers { get; set; }??????????
       // public IEnumerable<userplayer> UsersPlayers { get; set; }
       // public IEnumerable<PlayerScore> PlayerScores { get; set; }???????????

    }
}
