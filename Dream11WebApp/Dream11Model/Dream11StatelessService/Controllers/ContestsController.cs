using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dream11Model.EntityFrameworkContext;
using Dream11Model.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dream11StatelessService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContestsController : ControllerBase
    {
        Dream11Context _context;
        public ContestsController(Dream11Context context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Contest>> Get()
        {
            return _context.Contests.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Contest>> Get(int id)
        {
            return _context.Contests.Where(c => c.Match.MatchId == id).ToList();
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
