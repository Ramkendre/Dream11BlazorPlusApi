using FabricApplication.Models.BAL;
using FabricApplication.Models.DAL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace FabricApplication.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MatchAPIController : ApiController
    {

        private IAllRespository<Match> imatch;
        //private CommanClass commanclass = new CommanClass();
        MatchRespository matchDal = new MatchRespository();
        public MatchAPIController()
        {
            this.imatch = new AllRespository<Match>();
        }

        [Route("api/GetMatch/{id}")]
        [HttpGet]
        // GET: api/Match/5
        public Matches GetId(int id)
        {
            var model = matchDal.GettingMatchId(id);
            return model;
        }

        [Route("api/GetMatch")]
        [HttpGet]
        // GET: api/Match/5
        public IEnumerable<Matchs> GetId()
        {
            var model = matchDal.GettingMatchId();
            
            return model;
        }

        [Route("api/GetMatchList")]
        [HttpGet]
        // GET: api/Match
        public IEnumerable<Match> Get()
        {
            return (imatch.GetModel().ToList());
        }

        [Route("api/GetMatchList/{id}")]
        [HttpGet]
        // GET: api/Match/5
        public Match Get(int id)
        {
            var model = imatch.GetById(id);
            return model;
        }

        [Route("api/InsertMatch")]
        [ResponseType(typeof(Match))]
        [HttpPost]
        // POST: api/Match
        public HttpResponseMessage Post(HttpRequestMessage request, Match match)
        {
            imatch.InsertModel(match);
            imatch.Save();

            //Match mch = objmatch.match;
            //var plyers = objmatch.Players;
            //CommanClass.GetConnection().Matches.Add(mch);
            //CommanClass.GetConnection().SaveChanges();

            //int matchid = matchDal.GetMaxMatchId();
            //List<MatchPlayer> lstmatchplayer = new List<MatchPlayer>();

            //foreach (Player item in plyers)
            //{
            //    CommanClass.GetConnection().Players.Add(item);
            //    CommanClass.GetConnection().SaveChanges();

            //    int playerid = new PlayerRespository().GetMaxPlayerId();

            //    lstmatchplayer.Add(new MatchPlayer()
            //    {
            //        PlayerId = playerid,
            //        MatchId = matchid
            //    });
            //}
            //foreach (MatchPlayer item in lstmatchplayer)
            //{
            //    CommanClass.GetConnection().MatchPlayers.Add(item);
            //}
            //CommanClass.GetConnection().SaveChanges();

            ///////////////Upload Multiple player list for one match //////////////
            //Match mh = new Match()
            //{
            //    Name = "Test",
            //    SeriesName = "Test",
            //    Location = "Rajkot",
            //    Date = DateTime.Now,
            //    TimeSlot = "154h 54m 2s"
            //};
            //List<Player> listpl = new List<Player>();
            //Player pl = new Player()
            //{
            //    FirstName = "Sachin",
            //    LastName = "Tendulkar",
            //    Age = 37,
            //    Address = "Mumbai",
            //    Location = "Mumbai",
            //    RoleId = 1
            //};
            //Player pl1 = new Player()
            //{
            //    FirstName = "virendra",
            //    LastName = "sehwag",
            //    Age = 37,
            //    Address = "Mumbai",
            //    Location = "Mumbai",
            //    RoleId = 1
            //};
            //Player pl2 = new Player()
            //{
            //    FirstName = "Rahul",
            //    LastName = "dravid ",
            //    Age = 37,
            //    Address = "Mumbai",
            //    Location = "Mumbai",
            //    RoleId = 1
            //};
            //Player pl3 = new Player()
            //{
            //    FirstName = "vvs",
            //    LastName = "laxman",
            //    Age = 37,
            //    Address = "Mumbai",
            //    Location = "Mumbai",
            //    RoleId = 1
            //};
            //listpl.Add(pl);
            //listpl.Add(pl1);
            //listpl.Add(pl2);
            //listpl.Add(pl3);
            //mh.MatchPlayers = new List<MatchPlayer>();
            //mh.PlayerScores = new List<PlayerScore>();
            //foreach (Player item in listpl)
            //{
            //    mh.MatchPlayers.Add(
            //      new MatchPlayer
            //      {
            //          Match = mh,
            //          Player = item
            //          //PlayerId = item.Id
            //      });
            //}
            //imatch.InsertModel(mh);
            //imatch.Save();


            return request.CreateResponse(HttpStatusCode.OK, "Data Inserted Successfully");
        }

        [Route("api/UpdateMatch/{id}")]
        [ResponseType(typeof(Player))]
        [HttpPut]
        // PUT: api/Match/5
        public HttpResponseMessage Put(HttpRequestMessage request, int id, Match match)
        {
            if (id != match.Id)
            {
                return request.CreateResponse(HttpStatusCode.NotModified, "Unable to update data");
            }

            imatch.UpdateModel(match);
            imatch.Save();
            return request.CreateResponse(HttpStatusCode.OK, "Data Updated Successfully");
        }

        [Route("api/DeleteMatch/{id}")]
        [ResponseType(typeof(Player))]
        [HttpDelete]
        // DELETE: api/Match/5
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            var model = imatch.GetById(id);
            if (model == null)
            {
                return request.CreateResponse(HttpStatusCode.NotFound, "Data not found on these id");
            }
            imatch.DeleteModel(model);
            imatch.Save();
            return request.CreateResponse(HttpStatusCode.OK, "Data is deleted Successfully");
        }
    }
}
