using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Dream11Model.Model;
using Newtonsoft.Json;

namespace GraphQLAPIGatewayService.Services
{
    public class Dream11TeamService : IDream11TeamService
    {
        public Task<Team> Add(Team team)
        {
            throw new NotImplementedException();
        }

        public Task<List<Team>> Get(int id)
        {
            List<Team> teams = new List<Team>();
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(new Uri(string.Format("http://idtp376.synerzipune.local:9015/api/teams/{0}", id))).Result;
                teams = JsonConvert.DeserializeObject<List<Team>>(response);
            }
            return Task.Run(()=>teams);
        }

        public Task<Team> GetPlayerTeam(int id)
        {
            Team team = new Team();
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(new Uri(string.Format("http://idtp376.synerzipune.local:9015/api/teams/{0}/team", id))).Result;
                team = JsonConvert.DeserializeObject<Team>(response);
            }
            return Task.Factory.StartNew(()=> team);
        }
        public Task<List<Match>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Match> GetRandom()
        {
            throw new NotImplementedException();
        }
    }
}
