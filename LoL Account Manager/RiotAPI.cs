using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LoL_Account_Manager
{
    class RiotAPI
    {
        private static string apiKey = "?api_key=RGAPI-88047fda-a42c-447d-b467-5ac925290c83";

        public static APIAccount GetAccountFromUrl<APIAccount>(string server, string name) where APIAccount : new()
        {
            using (var w = new WebClient())
            {
                var account = string.Empty;
                try
                {
                    string url = "https://" + server + ".api.riotgames.com/lol/summoner/v4/summoners/by-name/" + name + apiKey;
                    account = w.DownloadString(url);
                }
                catch (Exception) { }
                return !string.IsNullOrEmpty(account) ? JsonConvert.DeserializeObject<APIAccount>(account) : new APIAccount();
            }
        }

        public static APIRank GetRankFromUrl<APIRank>(string server, string summonerId) where APIRank : new()
        {
            using (var w = new WebClient())
            {
                var rank = string.Empty;
                try
                {
                    string url = "https://" + server + ".api.riotgames.com/lol/league/v4/entries/by-summoner/" + summonerId + apiKey;
                    rank = w.DownloadString(url);
                }
                catch (Exception) { }
                APIRank final = JsonConvert.DeserializeObject<List<APIRank>>(rank)[0];
                return !string.IsNullOrEmpty(rank) ? final : new APIRank();
            }
        }
    }
}
