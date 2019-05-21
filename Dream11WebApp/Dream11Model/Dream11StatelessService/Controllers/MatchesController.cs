using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dream11Model.EntityFrameworkContext;
using Dream11Model.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dream11StatelessService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private Dream11Context _context;
        public MatchesController(Dream11Context context)
        {
            _context = context;
        }
        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<IEnumerable<MatchPlayerPerforma>> Get(int id)
        //{
        //    return _context.MatchPlayerPerformas.ToList();
        //}

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
        [HttpGet]
        public ActionResult<IEnumerable<Match>> Get()
        {
            List<Match> matches = new List<Match>();
            //using (Dream11Context ctx = new Dream11Context())
            //{
            matches = _context.Matches.Include(m => m.Teams).ToList();
            // }
            return matches;
        }
    }
}
