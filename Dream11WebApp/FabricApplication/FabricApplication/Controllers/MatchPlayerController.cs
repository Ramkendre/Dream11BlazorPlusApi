using FabricApplication.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace FabricApplication.Controllers
{
    public class MatchPlayerController : ApiController
    {
        private IAllRespository<MatchPlayer> imatchpalyer;

        public MatchPlayerController()
        {
            this.imatchpalyer = new AllRespository<MatchPlayer>();
        }

        [Route("api/GetMatchplayerList")]
        [HttpGet]
        // GET: api/Match
        public IEnumerable<MatchPlayer> Get()
        {
            return (imatchpalyer.GetModel().ToList());
        }

        [Route("api/GetMatchplayerList/{id}")]
        [HttpGet]
        // GET: api/Match/5
        public MatchPlayer Get(int id)
        {
            var model = imatchpalyer.GetById(id);
            return model;
        }
        [Route("api/InsertMatchplayer")]
        [ResponseType(typeof(MatchPlayer))]
        [HttpPost]
        // POST: api/Match
        public IHttpActionResult Post(MatchPlayer match)
        {
            imatchpalyer.InsertModel(match);
            imatchpalyer.Save();
            return Ok();
        }

        [Route("api/UpdateMatchplayer/{id}")]
        [ResponseType(typeof(PlayerScore))]
        [HttpPut]
        // PUT: api/Match/5
        public IHttpActionResult Put(int id, MatchPlayer match)
        {
            if (id != match.Id)
            {
                return BadRequest();
            }

            imatchpalyer.UpdateModel(match);
            imatchpalyer.Save();
            return StatusCode(HttpStatusCode.NoContent);
        }

        [Route("api/DeleteMatchplayer/{id}")]
        [ResponseType(typeof(MatchPlayer))]
        [HttpDelete]
        // DELETE: api/Match/5
        public IHttpActionResult Delete(int id)
        {
            var model = imatchpalyer.GetById(id);
            if (model == null)
            {
                return NotFound();
            }
            imatchpalyer.DeleteModel(model);
            imatchpalyer.Save();
            return Ok(model);
        }
    }
}
