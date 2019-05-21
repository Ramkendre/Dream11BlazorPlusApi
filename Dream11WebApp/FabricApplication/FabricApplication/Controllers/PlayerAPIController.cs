using FabricApplication.Models.BAL;
using FabricApplication.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
//using System.Web.Http.Description;


namespace FabricApplication.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PlayerAPIController : ApiController
    {
        private IAllRespository<Player> iplayer;
        // private CommanClass commanclass = new CommanClass();
        PlayerRespository playerDal = new PlayerRespository();
        public PlayerAPIController()
        {
            this.iplayer = new AllRespository<Player>();
        }

        [Route("api/GetPlayer/{id}")]
        [HttpGet]
        // GET: api/Match/5
        public Players GetId(int id)
        {
            var model = playerDal.GettingPlayerId(id);
            return model;
        }


        [Route("api/GetPlayer")]
        [HttpGet]
        // GET: api/Match/5
        public IEnumerable<Players> GetId()
        {
            var model = playerDal.GettingPlayerId();
            return model;
        }
        [HttpGet]
        [Route("api/GetUserPlayer/{userid}/{matchid}/{teamid}")]
        public IEnumerable<PlayerEntity> GetPlayer(int userid, int matchid, int teamid) //userplayer
        {
            var model = playerDal.GettingPlayerBasedOnTeamId(userid, matchid, teamid);
            return model;
        }


        [Route("api/GetPlayerList")]
        [HttpGet]
        // GET: api/PlayerAPI
        public IEnumerable<Player> Get()
        {
            return (iplayer.GetModel().Where(a => a.RoleId != null).ToList());

            // return listObjects;
        }

        [Route("api/GetPlayerList/{id}")]
        [HttpGet]
        // GET: api/PlayerAPI/5
        public Player Get(int id)
        {
            var model = iplayer.GetById(id);
            return model;
        }

        [Route("api/InsertPlayer")]
        [HttpPost]
        // POST: api/PlayerAPI
        public HttpResponseMessage Post(HttpRequestMessage request, [FromBody]Player value)
        {
            iplayer.InsertModel(value);
            iplayer.Save();
            return request.CreateResponse(HttpStatusCode.OK, "Data Inserted Successfully");
        }

        [Route("api/UpdatePlayer/{id}")]
        [HttpPut]
        // PUT: api/PlayerAPI/5
        public HttpResponseMessage Put(HttpRequestMessage request, int id, [FromBody]Player value)
        {
            if (id != value.Id)
            {
                return request.CreateResponse(HttpStatusCode.NotModified, "Unable to update data");
            }

            iplayer.UpdateModel(value);
            iplayer.Save();
            return request.CreateResponse(HttpStatusCode.OK, "Data Updated Successfully");
        }

        [Route("api/DeletePlayer/{id}")]
        [HttpDelete]
        // DELETE: api/PlayerAPI/5
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            var model = iplayer.GetById(id);
            if (model == null)
            {
                return request.CreateResponse(HttpStatusCode.NotFound, "Data is Not found");
            }
            iplayer.DeleteModel(model);
            iplayer.Save();
            return request.CreateResponse(HttpStatusCode.OK, "Data is deleted Successfully");
        }


    }
}
