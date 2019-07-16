using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dream11WebApp.Model
{
    public interface IplayerData
    {
        Task<Player2[]> GetPlayerInfo(int matchid,int userteamid,Object utoken);
        Task<List<Player2>> GetPlayerData(int matchid,int userTeamId,Object utoken);
    }

    public class PlayerData : IplayerData
    {
        HttpClient httpClient;
        public PlayerData(HttpClient httpclient)
        {
            this.httpClient = httpclient;
        }
        public async Task<Player2[]> GetPlayerInfo(int matchid, int userteamid, Object utoken)
        {
            // var data = await httpClient.GetJsonAsync<Player[]>($"{CommanUrl.url}UserTeam/GetallPlayers/0/{matchid}");
           // var data = await BlazorHttpExtensions.GetJsonAsync<Player[]>(this.httpClient,$"{CommanUrl.url}UserTeam/GetallPlayers/0/{matchid}",utoken.ToString());
            var data = await BlazorHttpExtensions.GetJsonAsync<Player2[]>(this.httpClient,$"{CommanUrl.url}UserTeam/UserTeamPlayers/{userteamid}/{matchid}",utoken.ToString());

            return data;
        }
        public async Task<List<Player2>> GetPlayerData(int matchid,int userTeamId, Object utoken)
        {
            var data = await BlazorHttpExtensions.GetJsonAsync<List<Player2>>(this.httpClient, $"{CommanUrl.url}UserTeam/UserTeamPlayers/{userTeamId}/{matchid}", utoken.ToString());

            return data;
        }
    }
    [Serializable()]
    public class Player
    {
        public int playerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string playerRoleName { get; set; }
        public int teamId { get; set; }
        public Team team { get; set; }
        public string image { get; set; }
        public double points { get; set; }
        public double credits { get; set; }
        public bool isSelected { get; set; }
        public object userTeams { get; set; }
        public bool isCaptain { get; set; }
        public bool isViceCaptain { get; set; }
    }
}
