using FabricApplication.Models.BAL;
using FabricApplication.Models.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace FabricApplication.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserAPIController : ApiController
    {
        private IAllRespository<User> interfaceobj;
        private IAllRespository<Team> interfaceobjteam;
        private IAllRespository<PlayerScore> interfaceplayerscore;
        private IAllRespository<Match> interfacematch;

        UserRespository userDal = new UserRespository();
        HttpResponseMessage response;
        public UserAPIController()
        {
            this.interfaceobj = new AllRespository<User>();
            this.interfaceobjteam = new AllRespository<Team>();
            this.interfaceplayerscore = new AllRespository<PlayerScore>();
            this.interfacematch = new AllRespository<Match>();
        }

        [Route("api/GetUser/{id}")]
        [HttpGet]
        // GET: api/Match/5
        public Users GetId(int id)
        {
            var model = userDal.GettingUserId(id);
            return model;
        }


        [Route("api/GetContest/{id}")]
        [HttpGet]
        // GET: api/Match/5
        public IEnumerable<Contests> GetContestId(int id)
        {
            var model = userDal.GettingContestId(id);
            return model;
        }

        [Route("api/GetUser")]
        [HttpGet]
        // GET: api/Match/5
        public IEnumerable<User> GetId()
        {
            var model = userDal.GettingUserId();
            return model;
        }

        [HttpPost]
        [Route("api/UserLogin")]
        public Users UserLoginDetails([FromBody]Login login)
        {
            var model = userDal.UserLogin(login);

            System.IO.File.WriteAllText(HttpContext.Current.Server.MapPath("~/AppVirtualPath.txt"), "Log");

            return model;
        }

        [Route("api/GetUserList")]
        [HttpGet]
        // GET: api/UserAPI
        public IEnumerable<User> Get()
        {
            return (interfaceobj.GetModel().ToList());
        }

        [Route("api/GetUserList/{id}")]
        [HttpGet]
        // GET: api/UserAPI/5
        public User Get(int id)
        {
            var model = interfaceobj.GetById(id);
            return model;
        }

        [Route("api/InsertUser")]
        [ResponseType(typeof(Matches))]
        [HttpPost]
        // POST: api/UserAPI
        public HttpResponseMessage Post(HttpRequestMessage request, [FromBody]Matches value)
        {
            //UserRespository userres = new UserRespository();
            //UserMatch userobj = new UserMatch();

            //userobj = userres.CheckUserData(Convert.ToInt32(value.Id),Convert.ToInt32(matchid));

            //if (userobj.Id == null)
            // {
            //interfaceobj.InsertModel(value);
            //interfaceobj.Save();
            // }
            //else
            //{
            //    return request.CreateErrorResponse(HttpStatusCode.OK, "Already User Found");
            //}

            //User user = new User()
            //{
            //    FirstName = value.Firstname,
            //    LastName = value.Lastname,
            //    UserName = value.Username,
            //    EmailAddress = value.Emailaddress,
            //    Age = value.age
            //};
            //interfaceobj.InsertModel(user);
            //interfaceobj.Save();

            //int userid = userDal.GetMaxId();

            //foreach (UserPlayer item in value.UserTeam.UserPlayer)
            //{
            //    lstusermatch.Add(new UserMatch()
            //    {
            //        PlayerId = item.PlayerId,
            //        MatchId = item.MatchId,
            //        UserId = userid
            //    });
            //}

            //Team team = new Team()
            //{
            //    TeamName = value.UserTeam.TeamName,
            //    UserMatches = lstusermatch
            //};
            //interfaceobjteam.InsertModel(team);
            // interfaceobjteam.Save();

            try
            {
                List<UserMatch> lstusermatch = new List<UserMatch>();
                Team team = new Team();
                foreach (FabricApplication.Models.BAL.MatchPlayer item in value.MatchPlayers)
                {
                    if (item.IsSelected == true)
                    {
                        lstusermatch.Add(new UserMatch()
                        {
                            PlayerId = item.PlayerId,
                            UserId = value.UserId,
                            MatchId = item.MatchId
                        });
                        interfaceplayerscore.InsertModel(new PlayerScore()
                        {
                            PlayerId = item.PlayerId,
                            MatchId = item.MatchId,
                            Points = item.Points,
                            Credits = item.Credits
                        });
                    }
                    team.TeamName = value.TeamName;
                    team.UserMatches = lstusermatch;
                }
                interfaceobjteam.InsertModel(team);
                interfaceobjteam.Save();
                interfaceplayerscore.Save();

                //Team mh = new Team()
                //{
                //    TeamName = value.TeamName,
                //};
                //foreach (FabricApplication.Models.BAL.MatchPlayer item in value.MatchPlayers)
                //{
                //    mh.UserMatches.Add(
                //      new UserMatch
                //      {
                //          Team = mh,
                //          //Player = item
                //          PlayerId = item.PlayerId,
                //          MatchId = value.Id,
                //          UserId = value.UserId,
                //          Player = new Player()
                //          {
                //              Id = Convert.ToInt32(item.PlayerId),
                //              FirstName = item.FirstName,
                //              LastName = item.LastName,
                //              Address = item.Address,
                //              Age = item.Age,
                //              PlayerScores = new List<PlayerScore>()
                //                  {
                //                   new PlayerScore()
                //                   {
                //                        Points = item.Points,
                //                       Credits = item.Credits,
                //                       PlayerId = item.PlayerId,
                //                       MatchId = item.MatchId
                //                   }
                //                  }
                //          }
                //      });
                //}
                //interfaceobjteam.InsertModel(mh);
                //interfaceobjteam.Save();

                return request.CreateErrorResponse(HttpStatusCode.OK, "Data Inserted Successfully");
            }

            //value.UserMatches = new List<UserMatch>();
            //value.PlayerScores = new List<PlayerScore>();
            //value.MatchPlayers = new List<FabricApplication.Models.BAL.MatchPlayer>();
            //foreach (FabricApplication.Models.BAL.MatchPlayer item in value.MatchPlayers)
            //{
            //    var result = AutoMapper.Mapper.Map<FabricApplication.Match>(item);

            //    value.UserMatches.Add(new UserMatch()
            //    {
            //        PlayerId = item.PlayerId,
            //        UserId = value.UserId,
            //        MatchId = item.MatchId
            //    });
            //    value.PlayerScores.Add(new PlayerScore()
            //    {
            //        PlayerId = item.PlayerId,
            //        Points = item.Points,
            //        Credits = item.Credits
            //    });
            //    interfacematch.InsertModel(result);
            //}
            //interfacematch.Save();
            // return request.CreateErrorResponse(HttpStatusCode.OK, "Data Inserted Successfully");

            catch (Exception ex)
            {
                return request.CreateResponse(ex.Message);
            }
        }


        [Route("api/TrialInsertUser")]
        [HttpPost]
        // POST: api/UserAPI
        public HttpResponseMessage PostData(HttpRequestMessage request, [FromBody]Matches value)
        {
            try
            {
                return request.CreateErrorResponse(HttpStatusCode.OK, "Data Inserted Successfully");
            }
            catch (Exception ex)
            {

                return request.CreateErrorResponse(HttpStatusCode.OK, "Someting is wrong");
            }
        }

        [Route("api/InsertUserTeam")]
        [ResponseType(typeof(Team))]
        [HttpPost]
        // POST: api/UserAPI
        public HttpResponseMessage Post(HttpRequestMessage request, [FromBody]Team value)
        {
            interfaceobjteam.InsertModel(value);
            interfaceobjteam.Save();
            return request.CreateResponse(value);
        }

        [Route("api/UpdateUser/{id}/{matchid}")]
        [ResponseType(typeof(void))]
        [HttpPut]
        // PUT: api/UserAPI/5
        public HttpResponseMessage Put(HttpRequestMessage request, int id, int matchid, [FromBody]User value)
        {
            // response = Request.CreateResponse<Models.User>(HttpStatusCode.OK, value);
            if (id != value.Id)
            {
                return request.CreateResponse(HttpStatusCode.NotModified, "Unable to update data");
            }

            //interfaceobj.UpdateModel(value);
            //interfaceobj.Save();
            userDal.UpdateUserId(id, matchid, value);
            return request.CreateResponse(HttpStatusCode.OK, "Data updated Successfully");
        }

        [Route("api/UpdateUserMatch/{teamid}")]
        [ResponseType(typeof(void))]
        [HttpPost]
        // PUT: api/UserAPI/5
        public HttpResponseMessage PutUserMatch(HttpRequestMessage request, int teamid, [FromBody]Matches value)
        {
            // response = Request.CreateResponse<Models.User>(HttpStatusCode.OK, value);
            if (teamid != teamid)
            {
                return request.CreateResponse(HttpStatusCode.NotModified, "Unable to update data");
            }

            value = userDal.UpdateUserMatch(teamid,value);
            return request.CreateResponse(HttpStatusCode.OK,value);
        }

        [Route("api/DeleteUser/{id}/{matchid}")]
        [ResponseType(typeof(User))]
        [HttpDelete]
        // DELETE: api/UserAPI/5
        public HttpResponseMessage Delete(int id, int matchid)
        {
            int objvar;
            var model = interfaceobj.GetById(id);
            if (model == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Unavailable data");
            }
            //interfaceobj.DeleteModel(model);
            //interfaceobj.Save();
            objvar = userDal.DeleteUserId(id, matchid);
            if (objvar == 0)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Unavailable data");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Data is deleted Successfully");
            }

        }
    }
}
