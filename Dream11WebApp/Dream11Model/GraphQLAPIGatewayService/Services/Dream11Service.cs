using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Dream11Model.Model;
using Newtonsoft.Json;

namespace GraphQLAPIGatewayService.Services
{
    public  class Dream11MatchService : IDream11MatchService
    {
        public Task<Match> Add(Match match)
        {
            throw new NotImplementedException();
        }

        public Task<List<Match>> GetAll()
        {
            using (var httpClient = new HttpClient())
            {
               
                var response = httpClient.GetStringAsync(new Uri("http://idtp376.synerzipune.local:9015/api/matches")).Result;
                var matches = JsonConvert.DeserializeObject<List<Match>>(response);
                return Task.Factory.StartNew(()=>matches.ToList());
            }
        }

        public Task<Match> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Match> GetRandom()
        {
            throw new NotImplementedException();
        }
    }
}
