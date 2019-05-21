using FabricApplication.Models.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FabricApplication.Models.DAL
{
    public class PlayerRespository
    {
        //private readonly ServiceFabricEntities7 dbcontext;

        //public PlayerRespository()
        //{
        //    dbcontext = new ServiceFabricEntities7();
        //}
        public Players GettingPlayerId(int id)
        {
            //var teams = dbcontext.Players.Where(a => a.Id == id)
            //                .Select(t => new Players
            //                {
            //                    PlayerId = t.Id,
            //                    FirstName = t.FirstName,
            //                    LastName = t.LastName,
            //                    Age = t.Age,
            //                    Address= t.Address,
            //                    MatchPlayers = t.MatchPlayers.Select(p => new FabricApplication.Models.DAL.MatchPlayer
            //                    {
            //                        Id = p.Id,
            //                        PlayerId = p.PlayerId,
            //                        MatchId = p.MatchId,
            //                        MatchName = p.Match.Name,
            //                    })
            //                }).ToList();

            var players = AutoMapper.Mapper.Map<List<Players>>(CommanClass.GetConnection().Players.Where(a => a.Id == id).ToList());

            return players.FirstOrDefault();
        }

        public IEnumerable<Players> GettingPlayerId()
        {
            var players = AutoMapper.Mapper.Map<List<Players>>(CommanClass.GetConnection().Players.ToList());

            return players;
        }
        public IEnumerable<PlayerEntity> GettingPlayerBasedOnTeamId(int userid, int matchid, int teamid) //IEnumerable<userplayer>
        {
            var player = AutoMapper.Mapper.Map<List<userplayer>>(CommanClass.GetConnection().UserMatches.Where(a => a.UserId == userid && a.MatchId == matchid && a.TeamId == teamid).ToList());
            //foreach (var player in players)
            //{
            //    player.player.Id = player.player.Id;
            //    player.player.FirstName = player.player.FirstName;
            //    player.player.LastName = player.player.LastName;
            //    player.player.Age = player.player.Age;
            //    player.player.Address = player.player.Address;
            //    player.player.PlayerRoleName = player.player.PlayerRoleName;
            //    player.player.Points = player.player.PlayerScores.Where(ps => ps.PlayerId.Value == player.player.Id).FirstOrDefault().Points.Value;
            //    player.player.Credits = player.player.PlayerScores.Where(ps => ps.PlayerId.Value == player.player.Id).FirstOrDefault().Credits;
            //}
            var players = player.Select(a => new PlayerEntity
            {
                Id = a.player.Id,
                FirstName = a.player.FirstName,
                LastName = a.player.LastName,
                Age = a.player.Age,
                Address = a.player.Address,
                PlayerRoleName = a.player.PlayerRoleName,
                Points = a.player.PlayerScores.Where(ps => ps.PlayerId.Value == a.player.Id).FirstOrDefault().Points.Value,
                Credits = a.player.PlayerScores.Where(ps => ps.PlayerId.Value == a.player.Id).FirstOrDefault().Credits
            });

            return players;
        }
        public int GetMaxPlayerId()
        {
            var playerid = CommanClass.GetConnection().Players.OrderByDescending(u => u.Id).FirstOrDefault();
            return playerid.Id;
        }
    }
}