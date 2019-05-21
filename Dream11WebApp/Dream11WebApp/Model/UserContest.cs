using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dream11WebApp.Model
{
    public interface IContestData
    {
        Task JoinContest(UserContest contests, Object utoken);
    }

   
    public class ContestData : IContestData
    {
        HttpClient httpClient;
        public ContestData(HttpClient httpclient)
        {
            this.httpClient = httpclient;
        }
        public async Task JoinContest(UserContest contests,Object utoken)
        {
            try
            {
                await BlazorHttpExtensions.PostJsonAsync<UserContest>(httpClient, $"{CommanUrl.url}UserTeam", contests, utoken.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class UserContest
    {
        //public bool dialogBox { get; set; } = false;
        public int ContestUserTeamsId { get; set; }
        public int contestId { get; set; } 
        public int userTeamId { get; set; } 
    }
}
