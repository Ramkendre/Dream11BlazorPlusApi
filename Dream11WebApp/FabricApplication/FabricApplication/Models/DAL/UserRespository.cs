using FabricApplication.Models.BAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FabricApplication.Models.DAL
{
    public class UserRespository
    {
        public UserMatch CheckUserData(int id, int matchid)
        {
            UserMatch objuser = new UserMatch();
            try
            {
                objuser = CommanClass.GetConnection().UserMatches.Where(a => a.UserId == id).Where(b => b.MatchId == matchid).FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return objuser;
        }

        public int GetMaxId()
        {
            var userid = CommanClass.GetConnection().Users.OrderByDescending(u => u.Id).FirstOrDefault();
            return userid.Id;
        }

        public Users GettingUserId(int id)
        {
            //var teams = dbcontext.Users.Where(a => a.Id == id)
            //                .Select(t => new user
            //                {
            //                    Id = t.Id,
            //                    Firstname = t.FirstName,
            //                    Lastname = t.LastName,
            //                    age = t.Age,
            //                    Username = t.UserName
            //                    //,
            //                    //Emailid = t.EmailAddress
            //                    //,
            //                    //Userplayers = t.UsersPlayers.Select(p => new FabricApplication.Models.DAL.Userplayer
            //                    //{
            //                    //    Id = p.Id,
            //                    //    //Playerid = p.PlayerId,
            //                    //    //Userid = p.UserId,
            //                    //    //PlayerName = p.Player.FirstName,
            //                    //    //UserTeamid = p.UserTeamId,
            //                    //    UserTeamName = p.UserTeam.TeamName
            //                    //})
            //                }).ToList();

            //  var Users = AutoMapper.Mapper.Map<List<user>>(CommanClass.GetConnection().Users.Where(a => a.Id == id).ToList());

            var Users = CommanClass.GetConnection().Users.Where(a => a.Id == id)
                        .Select(t => new Users
                        {
                            userid = t.Id,
                            firstname = t.FirstName,
                            lastname = t.LastName,
                            username = t.UserName,
                            emailaddress = t.EmailAddress,
                            age = t.Age,
                            Password = t.Password,
                            RemeberMe = true,
                            userMatches = t.UserMatches.Where(m => m.UserId == id).Select(p => new UserMatchs
                            {
                                matchId = p.MatchId,
                                matchName = p.Match.Name,
                                matchTeams = t.UserMatches.Select(q => new MatchTeams
                                {
                                    teamId = q.Team.Id,
                                    teamName = q.Team.TeamName,
                                    players = t.UserMatches.Where(pq => pq.UserId == id && pq.MatchId == p.MatchId && pq.TeamId == q.TeamId).Select(pl => new FabricApplication.Models.BAL.players
                                    {
                                        playerid = pl.Player.Id,
                                        firstName = pl.Player.FirstName,
                                        lastName = pl.Player.LastName,
                                        age = pl.Player.Age,
                                        address = pl.Player.Address,
                                        playerRoleName = pl.Player.PlayerRole.Name
                                    }).ToList(),
                                }).GroupBy(n => new { n.teamId, n.teamName })
                                           .Select(g => g.FirstOrDefault()).ToList()
                            }).GroupBy(n => new { n.matchId, n.matchName })
                                           .Select(g => g.FirstOrDefault()).ToList()
                            //  Points = pl.Player.PlayerScores.Where(x => x.PlayerId.Value == pl.PlayerId).FirstOrDefault().Points.Value,
                            // Credits = pl.Player.PlayerScores.Where(x => x.PlayerId.Value == pl.PlayerId).FirstOrDefault().Credits
                        }).FirstOrDefault();

            return Users;
        }

        public IEnumerable<Contests> GettingContestId(int id)
        {
            //List<Contests> listcontest = new List<Contests>();

            //var contests = CommanClass.GetConnection().ContestUsers.Where(a => a.Id == id).ToList();

            //foreach (var item in contests[0].Contest.ContestUsers)
            //{
            var contest = CommanClass.GetConnection().ContestUsers.Where(a => a.ContestId == id) // && a.UserId == item.UserId)
                    .Select(t => new Contests
                    {
                        //username = t.User.FirstName + " " + t.User.LastName,
                        //teamname = t.Team.TeamName,
                        //players = t.Team.UserMatches.Where(b => b.TeamId == t.TeamId && b.UserId == t.UserId).Select(a => new PlayerEntity() //Where(b => b.TeamId == item.TeamId && b.UserId == item.UserId).Select(a => new PlayerEntity()
                        //    {
                        //    Id = a.Player.Id,
                        //    FirstName = a.Player.FirstName,
                        //    LastName = a.Player.LastName,
                        //    Age = a.Player.Age,
                        //    Address = a.Player.Address,
                        //    PlayerRoleName = a.Player.PlayerRole.Name,
                        //    playerimage = a.Player.ImagePath,
                        //    Points = a.Player.PlayerScores.Where(x => x.PlayerId.Value == a.PlayerId).FirstOrDefault().Points.Value,
                        //    Credits = a.Player.PlayerScores.Where(x => x.PlayerId.Value == a.PlayerId).FirstOrDefault().Credits
                        //})
                    }).ToList();
            return contest;
            //    listcontest.Add(contest);
            //}
            //return listcontest.ToList();
        }

        public Users UserLogin(Login login)
        {
            //var objuser = AutoMapper.Mapper.Map<Login>(CommanClass.GetConnection().Users.Where(a => a.UserName == login.UserName && a.Password == login.Password).FirstOrDefault());
            //return objuser;
            var Users = CommanClass.GetConnection().Users.Where(a => a.UserName == login.UserName && a.Password == login.Password)
                        .Select(t => new Users
                        {
                            userid = t.Id,
                            firstname = t.FirstName,
                            lastname = t.LastName,
                            username = t.UserName,
                            emailaddress = t.EmailAddress,
                            age = t.Age,
                            Password = t.Password,
                            RemeberMe = true,
                            usercontests = t.ContestUsers.Where(uc => uc.UserId == t.Id).Select(cu => new UserContest()
                            {
                                contestid = cu.ContestId,
                                Name = cu.Contest.Name
                            }).ToList(),
                            userMatches = t.UserMatches.Select(p => new UserMatchs
                            {
                                matchId = p.MatchId,
                                matchName = p.Match.Name,
                                matchTeams = t.UserMatches.Select(q => new MatchTeams
                                {
                                    teamId = q.Team.Id,
                                    teamName = q.Team.TeamName,
                                    players = t.UserMatches.Where(pq => pq.UserId == t.Id && pq.MatchId == p.MatchId && pq.TeamId == q.TeamId).Select(pl => new FabricApplication.Models.BAL.players
                                    {
                                        playerid = pl.Player.Id,
                                        firstName = pl.Player.FirstName,
                                        lastName = pl.Player.LastName,
                                        age = pl.Player.Age,
                                        address = pl.Player.Address,
                                        playerRoleName = pl.Player.PlayerRole.Name,
                                        playerimage =pl.Player.ImagePath,
                                        Points = pl.Player.PlayerScores.Where(x => x.PlayerId.Value == pl.PlayerId).FirstOrDefault().Points.Value,
                                        Credits = pl.Player.PlayerScores.Where(x => x.PlayerId.Value == pl.PlayerId).FirstOrDefault().Credits
                                    }).ToList(),
                                }).GroupBy(n => new { n.teamId, n.teamName })
                                           .Select(g => g.FirstOrDefault()).ToList()
                            }).GroupBy(n => new { n.matchId, n.matchName })
                                           .Select(g => g.FirstOrDefault()).ToList()
                            //  Points = pl.Player.PlayerScores.Where(x => x.PlayerId.Value == pl.PlayerId).FirstOrDefault().Points.Value,
                            // Credits = pl.Player.PlayerScores.Where(x => x.PlayerId.Value == pl.PlayerId).FirstOrDefault().Credits
                        }).FirstOrDefault();

            return Users;

        }

        public IEnumerable<User> GettingUserId()
        {
            var Users = AutoMapper.Mapper.Map<List<User>>(CommanClass.GetConnection().Users.ToList());
            return Users;
        }

        public User UpdateUserId(int userid, int matchid, User val)
        {
            var objuser = CommanClass.GetConnection().Users.Where(a => a.Id == userid).FirstOrDefault();
            if (objuser == null)
            {
                CommanClass.GetConnection().Users.Add(val);
            }
            else
            {
                foreach (UserMatch item in val.UserMatches)
                {
                    var usermatch = CommanClass.GetConnection().UserMatches.Where(a => a.UserId == userid && a.MatchId == matchid).FirstOrDefault();
                    if (usermatch == null)
                    {
                        //  dbcontext.Users.Add(objuser);
                    }
                    else
                    {
                        CommanClass.GetConnection().UserMatches.Remove(usermatch);
                        CommanClass.GetConnection().SaveChanges();
                    }
                }
                CommanClass.GetConnection().Users.Remove(objuser);
                CommanClass.GetConnection().SaveChanges();
                CommanClass.GetConnection().Users.Add(val);
            }
            CommanClass.GetConnection().SaveChanges();

            return objuser;
        }
        public Matches UpdateUserMatch(int teamid, Matches val)
        {
            var objuser = CommanClass.GetConnection().UserMatches.Where(a => a.MatchId == val.Id && a.TeamId == teamid && a.UserId == val.UserId).FirstOrDefault();
            if (objuser == null)
            {
                //  CommanClass.GetConnection().Users.Add(val);
            }
            else
            {
                foreach (FabricApplication.Models.BAL.MatchPlayer item in val.MatchPlayers)
                {
                    var userPlayerPoints = CommanClass.GetConnection().UserMatches.Where(a => a.PlayerId == item.PlayerId && a.MatchId == item.MatchId).FirstOrDefault();
                    if (objuser == null && userPlayerPoints == null)
                    {
                        //  dbcontext.Users.Add(objuser);
                    }
                    else
                    {
                        using (var db = CommanClass.GetConnection())
                        {
                            if (item.IsSelected == true)
                            {
                                UserMatch usermatch = new UserMatch()
                                {
                                    Id = item.Id,
                                    UserId = val.UserId,
                                    MatchId = item.MatchId,
                                    PlayerId = item.PlayerId,
                                    TeamId = teamid
                                };
                                db.UserMatches.Attach(usermatch);
                                var usermatchs = db.Entry(usermatch);
                                usermatchs.Property(x => x.MatchId).IsModified = true;
                                usermatchs.Property(x => x.UserId).IsModified = true;
                                usermatchs.Property(x => x.PlayerId).IsModified = true;
                                usermatchs.Property(x => x.TeamId).IsModified = true;

                                var PlayerscoreId = db.PlayerScores.AsNoTracking().Where(a => a.PlayerId == item.PlayerId && a.MatchId == item.MatchId).FirstOrDefault();
                                PlayerScore playerscore = new PlayerScore()
                                {
                                    PlayerId = item.PlayerId,
                                    MatchId = item.MatchId,
                                    Id = PlayerscoreId.Id,
                                    Points = item.Points,
                                    Credits = item.Credits
                                };
                                db.PlayerScores.Attach(playerscore);
                                var playerscores = db.Entry(playerscore);
                                playerscores.Property(x => x.PlayerId).IsModified = true;
                                playerscores.Property(x => x.MatchId).IsModified = true;
                                playerscores.Property(x => x.Points).IsModified = true;
                                playerscores.Property(x => x.Credits).IsModified = true;
                                db.SaveChanges();
                            }
                        }
                    }
                }
            }
            return val;
        }

        public int DeleteUserId(int userid, int matchid)
        {
            var objuser = CommanClass.GetConnection().Users.Where(a => a.Id == userid).FirstOrDefault();
            if (objuser == null)
            {
                //dbcontext.Users.Add(val);
                return 0;
            }
            else
            {
                for (int i = 0; i <= 11; i++)
                {
                    var usermatch = CommanClass.GetConnection().UserMatches.Where(a => a.UserId == userid && a.MatchId == matchid).FirstOrDefault();
                    if (usermatch == null)
                    {
                        //  dbcontext.Users.Add(objuser);
                    }
                    else
                    {
                        CommanClass.GetConnection().UserMatches.Remove(usermatch);
                        CommanClass.GetConnection().SaveChanges();
                    }
                }
                CommanClass.GetConnection().Users.Remove(objuser);
                CommanClass.GetConnection().SaveChanges();
                // dbcontext.Users.Add(val);
            }

            return 1;
        }
    }
}