using FabricApplication.Models.BAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;


namespace FabricApplication.Models.DAL
{

    public class CommanClass
    {
        //private readonly ServiceFabricEntities dbcontext;
      public static ServiceFabricEntities7 GetConnection()
        {
            var dbcontext = new ServiceFabricEntities7();

            return dbcontext;
        }
    }

    //public class Matches
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Location { get; set; }
    //    public DateTime? Date { get; set; }
    //    public IEnumerable<FabricApplication.Models.DAL.MatchPlayer> MatchPlayers { get; set; }

    //    public IEnumerable<FabricApplication.Models.DAL.PlayerScore> PlayerScores { get; set; }
    //    public IEnumerable<FabricApplication.Models.DAL.Teamlog> Teamlogs { get; set; }
    //}
    //public class Players
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int? Age { get; set; }
    //    public string Address { get; set; }
    //    public string PlayerRoleName { get; set; }

    //    public IEnumerable<FabricApplication.Models.DAL.MatchPlayer> MatchPlayers { get; set; }

    //    public IEnumerable<FabricApplication.Models.DAL.UserPlayer> UsersPlayers { get; set; }



    //    public IEnumerable<FabricApplication.Models.DAL.PlayerScore> PlayerScores { get; set; }
    //}

    //public class MatchPlayer
    //{
    //    public int Id { get; set; }

    //    public int? PlayerId { get; set; }

    //    public int? MatchId { get; set; }

    //    public string PlayerFirstName { get; set; }
    //    public string PlayerLastName { get; set; }
    //    public string MatchName { get; set; }

    //    // public IEnumerable<FabricApplication.Models.DAL.Players> Players { get; set; }
    //}

    //public class Teamlog
    //{
    //    public int Id { get; set; }

    //    public int? TeamId { get; set; }

    //    public int? MatchId { get; set; }

    //    public string TeamLogs { get; set; }
    //    public string UserTeamTeamName { get; set; }
    //}

    //public class PlayerScore
    //{
    //    public int Id { get; set; }

    //    public int? MatchId { get; set; }

    //    public int? PlayerId { get; set; }
    //    public int? Points { get; set; }
    //    public double Credits { get; set; }
    //}

    //public class user
    //{
    //    public int Id { get; set; }
    //    public string Firstname { get; set; }
    //    public string Lastname { get; set; }
    //    public string Username { get; set; }

    //    public string Emailaddress { get; set; }

    //    public int? age { get; set; }

    //    //public IEnumerable<FabricApplication.Models.DAL.userplayer> UsersPlayers { get; set; }

    //    //  public IEnumerable<Userplayer> Userplayers { get; set; }
    //}

    //public class userplayer
    //{
    //    public int Id { get; set; }

    //    public int? UserId { get; set; }
    //    public int? PlayerId { get; set; }

    //    public int? UserTeamId { get; set; }

    //    public string PlayerFirstName { get; set; }
    //    public string PlayerLastName { get; set; }

    //    //public string UserFirstName { get; set; }

    //    //public string UserLastName { get; set; }
    //    //public string UserUserName { get; set; }

    //    //public string UserEmailAddress { get; set; }
    //    //public int? UserAge { get; set; }

    //    public user users { get; set; }

    //    public Userteam userTeam { get; set; }

    //}

    //public class UserPlayer
    //{
    //    public int Id { get; set; }

    //    public int? UserId { get; set; }
    //    public int? PlayerId { get; set; }

    //    public int? UserTeamId { get; set; }

    //    public string PlayerFirstName { get; set; }
    //    public string PlayerLastName { get; set; }

    //    //public string UserFirstName { get; set; }

    //    //public string UserLastName { get; set; }
    //    //public string UserUserName { get; set; }

    //    //public string UserEmailAddress { get; set; }
    //    //public int? UserAge { get; set; }

    //    public Userteam userTeam { get; set; }

    //    public user user { get; set; }


    //}

    //public class Userteam
    //{
    //    public int Id { get; set; }
    //    public string TeamName { get; set; }
    //}


}