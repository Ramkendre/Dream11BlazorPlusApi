using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Dream11Model.Model;
using Newtonsoft.Json;

namespace GraphQLAPIGatewayService.Services
{
    public class Dream11PlayerService : IDream11PlayerService
    {
        public Task<Player> Add(Player player)
        {
            throw new NotImplementedException();
        }

        public Task<List<Player>> Get(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(new Uri(string.Format("http://idtp376.synerzipune.local:9015/api/players/{0}", id))).Result;
                var players = JsonConvert.DeserializeObject<List<Player>>(response);
                return Task.Factory.StartNew(() => players.ToList());
            }
        }

        public Task<List<Player>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Player> GetRandom()
        {
            throw new NotImplementedException();
        }
    }
}
