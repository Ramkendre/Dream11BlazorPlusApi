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
