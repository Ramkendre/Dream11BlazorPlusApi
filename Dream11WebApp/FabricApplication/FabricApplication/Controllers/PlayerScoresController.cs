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
    public class PlayerScoresController : ApiController
    {
        private IAllRespository<PlayerScore> iplayerscore;

        public PlayerScoresController()
        {
            this.iplayerscore = new AllRespository<PlayerScore>();
        }

        [Route("api/GetPlayerscoreList")]
        [HttpGet]
        // GET: api/Match
        public IEnumerable<PlayerScore> Get()
        {
            return (iplayerscore.GetModel().ToList());
        }

        [Route("api/GetPlayerscoreList/{id}")]
        [HttpGet]
        // GET: api/Match/5
        public PlayerScore Get(int id)
        {
            var model = iplayerscore.GetById(id);
            return model;
        }
        [Route("api/InsertPlayerscore")]
        [ResponseType(typeof(PlayerScore))]
        [HttpPost]
        // POST: api/Match
        public IHttpActionResult Post(PlayerScore match)
        {
            iplayerscore.InsertModel(match);
            iplayerscore.Save();
            return Ok();
        }

        [Route("api/UpdatePlayerscore/{id}")]
        [ResponseType(typeof(PlayerScore))]
        [HttpPut]
        // PUT: api/Match/5
        public IHttpActionResult Put(int id, PlayerScore match)
        {
            if (id != match.Id)
            {
                return BadRequest();
            }

            iplayerscore.UpdateModel(match);
            iplayerscore.Save();
            return StatusCode(HttpStatusCode.NoContent);
        }

        [Route("api/DeletePlayerscore/{id}")]
        [ResponseType(typeof(PlayerScore))]
        [HttpDelete]
        // DELETE: api/Match/5
        public IHttpActionResult Delete(int id)
        {
            var model = iplayerscore.GetById(id);
            if (model == null)
            {
                return NotFound();
            }
            iplayerscore.DeleteModel(model);
            iplayerscore.Save();
            return Ok(model);
        }
    }
}
