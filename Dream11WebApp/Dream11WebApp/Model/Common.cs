using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dream11WebApp.Model
{
    public class Common
    {
        public enum SportType { CRICKET, FOOTBALL, NBA, HOCKEY }
        public enum PlayerType { WK, Bat, Allrounder, Bowler }
        public enum RoleType { WK, BAT, AR, BOWL }

        public enum ToastLevel { Info, Success, Warning, Error }

        List<Player> players = new List<Player>();
        Team team = new Team();
        public List<Player> GetPlayerList(UserTeam userplayers)
        {
            foreach (var player in userplayers.players)
            {
                players.Add(new Player()
                {
                    playerId = player.player.playerId,
                    firstName = player.player.firstName,
                    lastName = player.player.lastName,
                    age = player.player.age,
                    address = player.player.address,
                    playerRoleName = player.player.playerRoleName,
                    teamId = player.player.teamId,
                    team = player.player.team,
                    image = player.player.image,
                    points = player.player.points,
                    credits = player.player.credits,
                    isSelected = player.player.isSelected,
                    isCaptain = player.player.isCaptain,
                    isViceCaptain = player.player.isViceCaptain
                });
            }
            return players.ToList();
        }
        public Player[] GetPlayerArray(UserTeam userplayers)
        {
            foreach (var player in userplayers.players) { 
            players.Add(new Player() { 
                playerId = player.player.playerId,
                firstName = player.player.firstName,
                lastName = player.player.lastName,
                age = player.player.age,
                address = player.player.address,
                playerRoleName = player.player.playerRoleName,
                teamId = player.player.teamId,
                team =player.player.team,
                image = player.player.image,
                points = player.player.points,
                credits= player.player.credits,
                isSelected = player.player.isSelected,
                isCaptain = player.player.isCaptain,
                isViceCaptain = player.player.isViceCaptain
            });
            }

            return players.ToArray();
        }
        public UserTeam localAddPlayer(List<Player> playerList,int matchid)
        {
            UserTeam userTeam = new UserTeam();
            foreach (var player in playerList.Where(p => p.isSelected == true).ToList())
            {
                userTeam.matchid = matchid;
                userTeam.players.Add(new Player2()
                {
                    playerId = player.playerId,
                    player = player,
                    isCaptain = player.isCaptain,
                    isViceCaptain = player.isViceCaptain
                    //point = player.points
                });
            }
            return userTeam;
        }

    }

    public static class BlazorHttpExtensions
    {
        /// <summary>
        /// Sends an HTTP Post request to the specified URI, including the specified <paramref name="content"/>
        /// in JSON-encoded format, and doed NOT parse the response body, just returns a string.
        /// Useful for requesting tokens
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
        /// <param name="method">The HTTP method.</param>
        /// <param name="requestUri">The URI that the request will be sent to.</param>
        /// <param name="content">Content for the request body. This will be JSON-encoded and sent as a string.</param>
        /// <returns>The response as a string (unparsed)</returns>
        public static async Task<string> SendJsonAsyncRawResult(this HttpClient httpClient, HttpMethod httpMethod, string requestUri, object content)
        {
            var requestJson = Json.Serialize(content);
            var response = await httpClient.SendAsync(new HttpRequestMessage(httpMethod, requestUri)
            {
                Content = new StringContent(requestJson, Encoding.UTF8, "application/json")
            });

            return await response.Content.ReadAsStringAsync();

        }

        /// <summary>
        /// Sends a GET request to the specified URI with an Auhtorization bearer in the header, and parses the JSON response body
        /// to create an object of the generic type.
        /// Will throw UnauthorizedAccessException Exception on 401 response.
        /// </summary>
        /// <typeparam name="T">A type into which the response body can be JSON-deserialized.</typeparam>
        /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
        /// <param name="requestUri">The URI that the request will be sent to.</param>
        /// <param name="bearer">Value to be added to the Authorization header as bearer.</param>
        /// <returns>The response parsed as an object of the generic type.</returns>
        public static async Task<T> GetJsonAsync<T>(this HttpClient httpClient, string requestUri, string bearer)
        {
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, requestUri);
            req.Headers.Add("Authorization", $"bearer {bearer}");

            var response = await httpClient.SendAsync(req);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                throw new UnauthorizedAccessException();

            return Json.Deserialize<T>(await response.Content.ReadAsStringAsync());

        }

        /// <summary>
        /// Sends a POST request with the content as json to the specified URI with an Auhtorization bearer in the header, and parses the JSON response body
        /// to create an object of the generic type.
        /// Will throw UnauthorizedAccessException Exception on 401 response.
        /// </summary>
        /// <typeparam name="T">A type into which the response body can be JSON-deserialized.</typeparam>
        /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
        /// <param name="requestUri">The URI that the request will be sent to.</param>
        /// <param name="content">Object to be send with the request, will be json serialized.</param>
        /// <param name="bearer">Value to be added to the Authorization header as bearer.</param>
        /// <returns>The response parsed as an object of the generic type.</returns>
        public static async Task<T> PostJsonAsync<T>(this HttpClient httpClient, string requestUri, object content, string bearer)
        {
            var requestJson = Json.Serialize(content);
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, requestUri);
            req.Headers.Add("Authorization", $"bearer {bearer}");
            req.Content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var response = await httpClient.SendAsync(req);
            Console.WriteLine(response.StatusCode);
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                throw new UnauthorizedAccessException();

            return Json.Deserialize<T>(await response.Content.ReadAsStringAsync());

        }
    }
}
