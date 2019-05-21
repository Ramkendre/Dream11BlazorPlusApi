using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dream11WebApp.Model
{
    public interface IMatchData
    {
        Task<Match[]> GetMatches();
    }

    public class MatchData : IMatchData
    {
        HttpClient httpClient;
        public MatchData(HttpClient httpclient)
        {
            this.httpClient = httpclient;
        }
        public async Task<Match[]> GetMatches()
        {
            var data = await httpClient.GetJsonAsync<Match[]>($"{CommanUrl.url}matches");
            return data;
        }
    }

    public class Match
    {
        public int matchId { get; set; }
        public string name { get; set; }
        public string seriesName { get; set; }
        public string sport { get; set; }
        public string tImeSlot { get; set; }
        public Team[] teams { get; set; }

    }
    public class Team
    {
        public int teamId { get; set; }
        public string teamName { get; set; }
        public string logo { get; set; }

    }

}
