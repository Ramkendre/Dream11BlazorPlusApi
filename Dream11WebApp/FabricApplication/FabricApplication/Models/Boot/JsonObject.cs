using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FabricApplication.Models.Boot
{
    public class JsonObject
    {
        Match objnew = new Match
        {
            Id = 1,
            Name = "Ind Vs Aus",
            Location = "Pune",
            MatchPlayers = new List<MatchPlayer>
            {
                new MatchPlayer
                {
                  Player =new Player
                  {
                      FirstName="Pintya",
                      LastName="Punekar",
                      Address="pune",
                      Age=22,
                      Location="pune"
                  }
                },
                new MatchPlayer
                {
                    Player = new Player
                    {
                      FirstName="Ganya",
                      LastName="Mumbaikar",
                      Address="Mumbai",
                      Age=22,
                      Location="Mumbai"
                    }
                }
            }
        };
    }
}