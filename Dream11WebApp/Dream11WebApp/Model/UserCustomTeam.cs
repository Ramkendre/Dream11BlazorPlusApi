using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dream11WebApp.Model
{
    public interface IUserCustomTeam
    {
        Task SaveTeam(UserTeam players,Object utoken);
        Task<int> UserTeams(int matchid, Object utoken);
        Task<UserTeams[]> GetUserTeams(int matchid, Object utoken);
    }
    public class UserCustomTeam : IUserCustomTeam
    {
        HttpClient _httpClient;
        public UserCustomTeam(HttpClient httpClient){
            _httpClient = httpClient;
            }
        public async Task SaveTeam(UserTeam players,Object utoken)
        {
            try
            {
                await BlazorHttpExtensions.PostJsonAsync<UserTeam>(_httpClient, $"{CommanUrl.url}UserTeam", players, utoken.ToString());
                Console.WriteLine("Ok");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task<int> UserTeams(int matchid, Object utoken)
        {
            try
            {
                var data = await BlazorHttpExtensions.GetJsonAsync<int>(this._httpClient, $"{CommanUrl.url}UserTeam/userTeamCount/{matchid}", utoken.ToString());

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }


        public async Task<UserTeams[]> GetUserTeams(int matchid, Object utoken)
        {
            try
            {
                var data = await BlazorHttpExtensions.GetJsonAsync<UserTeams[]>(this._httpClient, $"{CommanUrl.url}UserTeam/matchUserTeam/{matchid}", utoken.ToString());

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }


    public class Player2
    {
        public int userTeamPlayersId { get; set; }
        public int userTeamId { get; set; }
        public int playerId { get; set; }
        public Player player { get; set; }
        public bool isCaptain { get; set; }
        public bool isViceCaptain { get; set; }
        public int point { get; set; }
    }

    public class UserTeam
    {
        public int matchid { get; set; }
        public List<Player2> players  = new List<Player2>();
        public string userTeamName { get; set; } = "Team";
    }
}
