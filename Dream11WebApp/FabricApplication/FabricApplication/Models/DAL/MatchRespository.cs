using FabricApplication.Models.BAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace FabricApplication.Models.DAL
{
    public class MatchRespository
    {
        //private readonly ServiceFabricEntities7 dbcontext;

        //public MatchRespository()
        //{
        //    dbcontext = new ServiceFabricEntities7();
        //}

        public Matches GettingMatchId(int id)
        {
            //var model = (from match in dbcontext.Matches
            //             join matchPlayers in dbcontext.MatchPlayers on match.Id equals matchPlayers.MatchId
            //             join player in dbcontext.Players on matchPlayers.PlayerId equals player.Id
            //             join playerScores in dbcontext.PlayerScores on player.Id equals playerScores.PlayerId
            //             join playerRole in dbcontext.PlayerRoles on player.RoleId equals playerRole.Id
            //             where match.Id == id
            //             select new Matches
            //             {
            //                 Id = match.Id,
            //                 MatchName = match.Name,
            //                 Location = match.Location,
            //                 Date = match.Date,
            //                 PlayerId = player.Id,
            //                 FirstName = player.FirstName,
            //                 LastName = player.LastName,
            //                 Age = player.Age,
            //                 Address = player.Address,
            //                 Points = playerScores.Points,
            //                 PlayerRoleName = playerRole.Name
            //             }).ToList();


            //var teams = dbcontext.Matches.Where(a => a.Id == id)
            //            .Select(t => new Matches
            //            {
            //                MatchId = t.Id,
            //                MatchName = t.Name,
            //                Location = t.Location,
            //                Date = t.Date,
            //                MatchPlayers = t.MatchPlayers.Select(p => new FabricApplication.Models.DAL.MatchPlayer
            //                {
            //                    Id = p.Id,
            //                    PlayerId = p.PlayerId,
            //                    MatchId = p.MatchId,
            //                    PlayerFirstName = p.Player.FirstName,
            //                    PlayerLastName = p.Player.LastName
            //                }),
            //                PlayerScores = t.PlayerScores.Select(ps => new FabricApplication.Models.DAL.PlayerScore
            //                {
            //                    Id = ps.Id,
            //                    MatchId = ps.PlayerId,
            //                    PlayerId = ps.PlayerId,
            //                    Points = ps.Points
            //                })
            //            }).ToList();


            var matches = CommanClass.GetConnection().Matches.Where(a => a.Id == id)
                        .Select(t => new Matches
                        {
                            Id = t.Id,
                            Name = t.Name,
                            Location = t.Location,
                            Date = t.Date,
                            MatchPlayers = t.MatchPlayers.Select(p => new FabricApplication.Models.BAL.MatchPlayer
                            {
                                Id = p.Id,
                                PlayerId = p.PlayerId,
                                MatchId = p.MatchId,
                                MatchName = p.Match.Name,
                                FirstName = p.Player.FirstName,
                                LastName = p.Player.LastName,
                                PlayerImage = p.Player.ImagePath,
                                Age = p.Player.Age,
                                Address = p.Player.Address,
                                PlayerRoleName = p.Player.PlayerRole.Name,
                                IsSelected = false,
                                Points = t.PlayerScores.Where(x => x.PlayerId.Value == p.PlayerId).FirstOrDefault().Points.Value,
                                Credits = t.PlayerScores.Where(x => x.PlayerId.Value == p.PlayerId).FirstOrDefault().Credits.Value
                            })
                        }).FirstOrDefault();

            //var matches = AutoMapper.Mapper.Map<List<MatchEntity>>(CommanClass.GetConnection().Matches.Where(a => a.Id == id).ToList());
            //foreach (var player in matches[0].MatchPlayers)
            //{
            //    player.player.Points = player.player.PlayerScores.Where(x => x.PlayerId.Value == player.player.Id).FirstOrDefault().Points.Value;
            //    player.player.Credit = player.player.PlayerScores.Where(x => x.PlayerId.Value == player.player.Id).FirstOrDefault().Credits;
            //}
            //foreach (var MatchPlayers in matches[0].MatchPlayers)
            //{
            //    MatchPlayers.MatchId = MatchPlayers.MatchId;
            //    MatchPlayers.MatchName = MatchPlayers.MatchName;
            //    MatchPlayers.PlayerId = MatchPlayers.player.Id;
            //    MatchPlayers.FirstName = MatchPlayers.player.FirstName;
            //    MatchPlayers.LastName = MatchPlayers.player.LastName;
            //    MatchPlayers.Address = MatchPlayers.player.Address;
            //    MatchPlayers.Age = MatchPlayers.player.Age;
            //    MatchPlayers.PlayerRoleName = MatchPlayers.player.PlayerRoleName;
            //    MatchPlayers.Points = MatchPlayers.player.PlayerScores.Where(x => x.PlayerId.Value == MatchPlayers.player.Id).FirstOrDefault().Points.Value;
            //    MatchPlayers.Credit = MatchPlayers.player.PlayerScores.Where(x => x.PlayerId.Value == MatchPlayers.player.Id).FirstOrDefault().Credits;
            //}
            return matches;
        }

        public IEnumerable<Matchs> GettingMatchId()
        {

            var matches = AutoMapper.Mapper.Map<List<Matchs>>(CommanClass.GetConnection().Matches.ToList());

            return matches;
        }

        public int GetMaxMatchId()
        {
            var matchid = CommanClass.GetConnection().Matches.OrderByDescending(u => u.Id).FirstOrDefault();
            return matchid.Id;
        }
    }
}