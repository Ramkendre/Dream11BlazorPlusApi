using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Data;
using Microsoft.ServiceFabric.Data.Collections;

namespace UserStatefulService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private IReliableStateManager _stateManager;

        public UserController(IReliableStateManager reliableStateManager)
        {
            _stateManager = reliableStateManager;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            CancellationToken ct = new CancellationToken();
            IReliableDictionary<string, long> playerDictionary = await this._stateManager.GetOrAddAsync<IReliableDictionary<string, long>>("rulesDictionary");


            using (ITransaction tx = this._stateManager.CreateTransaction())
            {
                Microsoft.ServiceFabric.Data.IAsyncEnumerable<KeyValuePair<string, long>> playerList = await playerDictionary.CreateEnumerableAsync(tx);

                Microsoft.ServiceFabric.Data.IAsyncEnumerator<KeyValuePair<string, long>> enumerator = playerList.GetAsyncEnumerator();

                List<KeyValuePair<string, long>> result = new List<KeyValuePair<string, long>>();

                while (await enumerator.MoveNextAsync(ct))
                {
                    result.Add(enumerator.Current);
                }

                return new JsonResult(result);
            }
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
