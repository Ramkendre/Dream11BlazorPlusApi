﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dream11Model.EntityFrameworkContext;
using Dream11Model.Model;
using Microsoft.AspNetCore.Mvc;

namespace PlayerPerfomaStatelessService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerPerfomaController : ControllerBase
    {
        private PlayerPerformaContext _context;
        public PlayerPerfomaController(PlayerPerformaContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<MatchPlayerPerforma>> Get()
        {
            return null;

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
