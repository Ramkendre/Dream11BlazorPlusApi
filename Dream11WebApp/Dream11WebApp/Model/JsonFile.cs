using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dream11WebApp.Model
{
    public interface IJsonFile
    {
        bool WriteJsonFile(List<Player> players);
        Task<IList<Player>> ReadJsonFile();
        void ClearJsonFile();
    }
    public class JsonFile : IJsonFile
    {
       HttpClient httpClient;
        private string jsonxml = @"F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Json\userteam.xml";
        private string jsonFile = @"F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Json\userteam.json";

        public JsonFile()
        {
            //this.jsonFile = @"F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Json\userteam.json";
        }

        public bool WriteJsonFile(List<Player> players)
        {
            //string json = File.ReadAllText(jsonFile);
            //if (json == null || json == "")
            //{
            // File.WriteAllText(jsonFile, JsonConvert.SerializeObject(players));
            try
            {
                Console.WriteLine(players[0].firstName);
                string JSONresult = JsonConvert.SerializeObject(players.ToArray());
                Console.WriteLine(JSONresult);
                File.WriteAllText(jsonFile, JSONresult);

                System.Xml.Serialization.XmlSerializer serialiser = new System.Xml.Serialization.XmlSerializer(typeof(List<Player>));
                TextWriter filestream = new StreamWriter(jsonxml);
                Console.WriteLine(filestream);
                serialiser.Serialize(filestream, players);
                filestream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;

            //}
            //else
            //    return false;
        }

        public async Task<IList<Player>> ReadJsonFile()
        {
            try
            {
                Console.WriteLine(jsonFile);
                var data = await httpClient.GetJsonAsync<List<Player>>(jsonFile);
                return data;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IList<Player> data = null;
                return data;
            }

            //string json = File.ReadAllText(jsonFile);
            //var players = JsonConvert.DeserializeObject<List<Player>>(json);
            //return players.ToList();
        }

        public void ClearJsonFile()
        {
            File.WriteAllText(jsonFile, JsonConvert.SerializeObject(null));
        }
    }
}
