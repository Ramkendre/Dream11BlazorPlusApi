using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FabricApplication.Models.DAL
{
    public class BaseClass
    {
        public class Matches
        {
            public int MatchId { get; set; }
            public string MatchName { get; set; }
            public string Location { get; set; }
            public DateTime? Date { get; set; }
            public IEnumerable<FabricApplication.Models.DAL.MatchPlayer> MatchPlayers { get; set; }

            public IEnumerable<FabricApplication.Models.DAL.PlayerScore> PlayerScores { get; set; }
        }

        public class Players
        {
            public int PlayerId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int? Age { get; set; }
            public string Address { get; set; }
            public int? Points { get; set; }
            public string PlayerRoleName { get; set; }
        }

        public class MatchPlayer
        {
            public int Id { get; set; }

            public int? PlayerId { get; set; }

            public int? MatchId { get; set; }

            public string PlayerFirstName { get; set; }
            public string PlayerLastName { get; set; }
            public string MatchName { get; set; }

            // public IEnumerable<FabricApplication.Models.DAL.Players> Players { get; set; }
        }

        public class PlayerScore
        {
            public int Id { get; set; }

            public int? MatchId { get; set; }

            public int? PlayerId { get; set; }
            public int? Points { get; set; }
        }
        public class user
        {
            public int Id { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Username { get; set; }

            public string Emailid { get; set; }

            public int? age { get; set; }
        }
        public class Userplayer
        {
            public int Id { get; set; }

            public int? Userid { get; set; }
            public int? Playerid { get; set; }

            public int? UserTeamid { get; set; }

            public string PlayerName { get; set; }

            public string UserTeamName { get; set; }
        }
    }
}