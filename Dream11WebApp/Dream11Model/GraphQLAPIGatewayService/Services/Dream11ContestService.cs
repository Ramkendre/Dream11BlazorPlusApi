using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Dream11Model.Model;
using Newtonsoft.Json;

namespace GraphQLAPIGatewayService.Services
{
    public class Dream11ContestService : IDream11ContestService
    {
        public Task<Contest> Add(Player player)
        {
            throw new NotImplementedException();
        }

        public Task<List<Contest>> Get(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(new Uri(string.Format("http://idtp376.synerzipune.local:9015/api/contests/{0}", id))).Result;
                var contests = JsonConvert.DeserializeObject<List<Contest>>(response);
                return Task.Factory.StartNew(() => contests.ToList());
            }
        }

        public Task<List<Contest>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Contest> GetRandom()
        {
            throw new NotImplementedException();
        }
    }
}
