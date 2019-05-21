using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dream11Model.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Data;
using Microsoft.ServiceFabric.Data.Collections;

namespace RulesStatefulApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RulesController : ControllerBase
    {

        private IReliableStateManager _stateManager;
        public RulesController(IReliableStateManager reliableStateManager)
        {
            _stateManager = reliableStateManager;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            CancellationToken ct = new CancellationToken();
            IReliableDictionary<int, int> playerDictionary =  await this._stateManager.GetOrAddAsync<IReliableDictionary<int, int>>("PlayerMatchStatisticsDictionary");


            using (ITransaction tx = this._stateManager.CreateTransaction())
            {
                Microsoft.ServiceFabric.Data.IAsyncEnumerable<KeyValuePair<int, int>> playerList = await playerDictionary.CreateEnumerableAsync(tx);

                Microsoft.ServiceFabric.Data.IAsyncEnumerator<KeyValuePair<int, int>> enumerator = playerList.GetAsyncEnumerator();


                var stats = new List<UserTeamPlayers>();

                while (await enumerator.MoveNextAsync(ct))
                {
                    stats.Add(new UserTeamPlayers { PlayerId = enumerator.Current.Key,  Point= enumerator.Current.Value });
                }

                return new JsonResult(stats);
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
