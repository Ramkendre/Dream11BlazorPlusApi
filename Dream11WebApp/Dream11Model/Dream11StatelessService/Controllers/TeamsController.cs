using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dream11Model.EntityFrameworkContext;
using Dream11Model.Model;
using Microsoft.AspNetCore.Mvc;

namespace Dream11StatelessService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        Dream11Context _context;
        public TeamsController(Dream11Context context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5

        [HttpGet("{id}/team")]
        public ActionResult<Team> GetPlayerTeam(int id)
        {
            return _context.Teams.Where(t => t.TeamId == id).FirstOrDefault();
        }
        [HttpGet("{id}")]
        public ActionResult<List<Team>> Get(int id)
        {
            return _context.Teams.Where(t => t.MatchId == id).ToList();
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
