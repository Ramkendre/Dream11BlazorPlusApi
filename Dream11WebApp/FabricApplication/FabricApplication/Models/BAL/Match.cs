using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricApplication.Models.BAL
{
    public class Match
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SeriesName { get; set; }
        public string Sport { get; set; }
        public string TImeSlot { get; set; }
        public IEnumerable<Team> Teams { get; set; }
        public string Location { get; set; }
        public DateTime? Date { get; set; }
        
     //   public string TeamName { get; set; }
       
     //   public int UserId { get; set; }
       // public IEnumerable<MatchPlayer> MatchPlayers { get; set; }
        //[JsonIgnore]
        //public List<UserMatch> UserMatches { get; set; }
        //[JsonIgnore]
        //public List<FabricApplication.PlayerScore> PlayerScores { get; set; }
}

   

   
}
