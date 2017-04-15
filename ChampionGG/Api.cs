using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ChampionGG.Models;

namespace ChampionGG
{
    /// <summary>API of the League of Legends statistics website champion.gg</summary>
    public sealed class Api
    {
        private HttpClient client = new HttpClient();
        private Uri baseUrl;
        private string apiKey;

        // error messages
        private const string ErrDeserializationFailed = "Response body deserialization failed.";
        private const string ErrUnexpectedHttpStatus = "Unexpected response HTTP status";
        private const string ErrResponse = "Error response";

        // default values
        private const int DefaultLimit = 10;
        private const int DefaultPage = 1;

        /// <summary>Creates new api instance</summary>
        /// <param name="ApiKey">Get an api key at http://api.champion.gg/ </param>
        public Api(string ApiKey)
        {
            this.baseUrl = new Uri("http://api.champion.gg/", UriKind.Absolute);
            this.apiKey = ApiKey;
        }
        /// <summary>Creates new api instance using the default url</summary>
        /// <param name="ApiKey">Get an api key at http://api.champion.gg/ </param>
        /// <param name="BaseUrl">Base path to the web api</param>
        public Api(string ApiKey, Uri BaseUrl)
        {
            this.baseUrl = BaseUrl;
            this.apiKey = ApiKey;
        }

        // basic champion list
        /// <summary>Returns a basic champion list</summary>
        /// <returns>Task to get basic champion list</returns>
        public Task<List<ChampionBasic>> GetBasicChampionList()
        {
            return GetBasicChampionList(CancellationToken.None);
        }
        /// <summary>Returns a basic champion list</summary>
        /// <returns>Task to get basic champion list</returns>
        /// <param name="CancelToken"></param>
        public Task<List<ChampionBasic>> GetBasicChampionList(CancellationToken CancelToken)
        {
            return Get<List<ChampionBasic>>("champion", CancelToken);
        }

        // champion
        /// <summary>Returns data for champion</summary>
        /// <returns>Task to get data for champion</returns>
        /// <param name="ChampionKey"></param>
        public Task<List<Champion>> GetChampion(string ChampionKey)
        {
            return GetChampion(ChampionKey, CancellationToken.None);
        }
        /// <summary>Returns data for champion</summary>
        /// <returns>Task to get data for champion</returns>
        /// <param name="ChampionKey"></param>
        /// <param name="CancelToken"></param>
        public Task<List<Champion>> GetChampion(string ChampionKey, CancellationToken CancelToken)
        {
            return Get<List<Champion>>("champion/" + ChampionKey, CancelToken);
        }

        // matchups
        /// <summary>Returns matchup data for a champion</summary>
        /// <param name="ChampionKey"></param>
        /// <returns>Task to get matchup data for champion</returns>
        public Task<List<Models.ChampionModels.MatchupSet>> GetMatchups(string ChampionKey)
        {
            return GetMatchups(ChampionKey, CancellationToken.None);
        }
        /// <summary>Returns matchup data for a champion</summary>
        /// <param name="ChampionKey"></param>
        /// /// <param name="CancelToken"></param>
        /// <returns>Task to get matchup data</returns>
        public Task<List<Models.ChampionModels.MatchupSet>> GetMatchups(string ChampionKey, CancellationToken CancelToken)
        {
            return Get<List<Models.ChampionModels.MatchupSet>>("champion/" + ChampionKey + "/matchup", CancelToken);
        }
        /// <summary>Returns matchup data for a champion and a specific opponent</summary>
        /// <param name="ChampionKey"></param>
        /// <param name="OpponentKey"></param>
        /// <returns>Task to get matchup data</returns>
        public Task<List<Matchup>> GetMatchup(string ChampionKey, string OpponentKey)
        {
            return GetMatchup(ChampionKey, OpponentKey, CancellationToken.None);
        }
        /// <summary>Returns matchup data for a champion and a specific opponent</summary>
        /// <param name="ChampionKey"></param>
        /// <param name="OpponentKey"></param>
        /// <param name="CancelToken"></param>
        /// <returns>Task to get matchup data</returns>
        public Task<List<Matchup>> GetMatchup(string ChampionKey, string OpponentKey, CancellationToken CancelToken)
        {
            Console.WriteLine("champion/" + ChampionKey + "/matchup/" + OpponentKey);
            return Get<List<Matchup>>("champion/" + ChampionKey + "/matchup/" + OpponentKey, CancelToken);
        }

        // items
        /// <summary>Returns item data for a champion</summary>
        /// <param name="ChampionKey"></param>
        /// <param name="DataAspect"></param>
        /// <param name="ItemAspect"></param>
        /// <returns>Task to get item data</returns>
        public Task<List<ItemSet>> GetItems(string ChampionKey, DataAspect DataAspect, ItemAspect ItemAspect)
        {
            return GetItems(ChampionKey, DataAspect, ItemAspect, CancellationToken.None);
        }
        /// <summary>Returns item data for a champion</summary>
        /// <param name="ChampionKey"></param>
        /// <param name="DataAspect"></param>
        /// <param name="ItemAspect"></param>
        /// <param name="CancelToken"></param>
        /// <returns>Task to get item data</returns>
        public Task<List<ItemSet>> GetItems(string ChampionKey, DataAspect DataAspect, ItemAspect ItemAspect, CancellationToken CancelToken)
        {
            return Get<List<ItemSet>>("champion/" + ChampionKey + "/items/" + ItemAspect + "/" + DataAspect, CancelToken);
        }

        // skills
        /// <summary>Returns skill data for a champion</summary>
        /// <param name="ChampionKey"></param>
        /// <param name="DataAspect"></param>
        /// <returns>Task to get skill data</returns>
        public Task<List<SkillSet>> GetSkills(string ChampionKey, DataAspect DataAspect)
        {
            return GetSkills(ChampionKey, DataAspect, CancellationToken.None);
        }
        /// <summary>Returns skill data for a champion</summary>
        /// <param name="ChampionKey"></param>
        /// <param name="DataAspect"></param>
        /// <param name="CancelToken"></param>
        /// <returns>Task to get skill data</returns>
        public Task<List<SkillSet>> GetSkills(string ChampionKey, DataAspect DataAspect, CancellationToken CancelToken)
        {
            return Get<List<SkillSet>>("champion/" + ChampionKey + "/skills/" + DataAspect, CancelToken);
        }
        /// <summary>Returns skill information (names)</summary>
        /// <param name="ChampionKey"></param>
        /// <returns>Task to get skill information</returns>
        public Task<Dictionary<string, Skill>> GetSkillInfo(string ChampionKey)
        {
            return GetSkillInfo(ChampionKey, CancellationToken.None);
        }
        /// <summary>Returns skill information (names)</summary>
        /// <param name="ChampionKey"></param>
        /// <param name="CancelToken"></param>
        /// <returns>Task to get skill information</returns>
        public Task<Dictionary<string, Skill>> GetSkillInfo(string ChampionKey, CancellationToken CancelToken)
        {
            return Get<Dictionary<string, Skill>>("champion/" + ChampionKey + "/skills", CancelToken);
        }

        // summoner spells
        /// <summary>Returns summoner spell data for a champion</summary>
        /// <param name="ChampionKey"></param>
        /// <param name="DataAspect"></param>
        /// <returns>Task to get summoner spell data</returns>
         public Task<List<SummonerSet>> GetSummoners(string ChampionKey, DataAspect DataAspect)
        {
            return GetSummoners(ChampionKey, DataAspect, CancellationToken.None);
        }
        /// <summary>Returns summoner spell data for a champion</summary>
        /// <param name="ChampionKey"></param>
        /// <param name="DataAspect"></param>
        /// <param name="CancelToken"></param>
        /// <returns>Task to get summoner spell data</returns>
        public Task<List<SummonerSet>> GetSummoners(string ChampionKey, DataAspect DataAspect, CancellationToken CancelToken)
        {
            return Get<List<SummonerSet>>("champion/" + ChampionKey + "/summoners/" + DataAspect, CancelToken);
        }

        /// <summary>Returns rune data for a champion</summary>
        /// <param name="ChampionKey"></param>
        /// <param name="DataAspect"></param>
        /// <returns>Task to get rune data</returns>
        public Task<List<RuneSet>> GetRunes(string ChampionKey, DataAspect DataAspect)
        {
            return GetRunes(ChampionKey, DataAspect, CancellationToken.None);
        }
        /// <summary>Returns rune data for a champion</summary>
        /// <param name="ChampionKey"></param>
        /// <param name="DataAspect"></param>
        /// <param name="CancelToken"></param>
        /// <returns>Task to get rune data</returns>
        public Task<List<RuneSet>> GetRunes(string ChampionKey, DataAspect DataAspect, CancellationToken CancelToken)
        {
            return Get<List<RuneSet>>("champion/" + ChampionKey + "/runes/" + DataAspect, CancelToken);
        }

        //stats
        /// <summary>Returns stats data for all champions</summary>
        /// <param name="Page"></param>
        /// <param name="Limit"></param>
        /// <returns>Task to get stats data</returns>
        public Task<List<StatsListItem>> GetStats(int Page = DefaultPage, int Limit = DefaultLimit)
        {
            return GetStats(CancellationToken.None, Page, Limit);
        }
        /// <summary>Returns stats data for all champions</summary>
        /// <param name="CancelToken"></param>
        /// <param name="Page"></param>
        /// <param name="Limit"></param>
        /// <returns>Task to get stats data</returns>
        public Task<List<StatsListItem>> GetStats(CancellationToken CancelToken, int Page = DefaultPage, int Limit = DefaultLimit)
        {
            return Get<List<StatsListItem>>("stats/", CancelToken, Page, Limit);
        }
        /// <summary>Returns stats data for all champions by aspect</summary>
        /// <param name="StatsAspect"></param>
        /// <param name="Page"></param>
        /// <param name="Limit"></param>
        /// <returns>Task to get stats data</returns>
        public Task<StatsPage> GetStats(StatsAspect StatsAspect, int Page = DefaultPage, int Limit = DefaultLimit)
        {
            return GetStats(StatsAspect, CancellationToken.None, Page, Limit);
        }
        /// <summary>Returns stats data for all champions by aspect</summary>
        /// <param name="StatsAspect"></param>
        /// <param name="CancelToken"></param>
        /// <param name="Page"></param>
        /// <param name="Limit"></param>
        /// <returns>Task to get stats data</returns>
        public Task<StatsPage> GetStats(StatsAspect StatsAspect, CancellationToken CancelToken, int Page = DefaultPage, int Limit = DefaultLimit)
        {
            return Get<StatsPage>("stats/champs/" + StatsAspect, CancelToken, Page, Limit);
        }
        /// <summary>Returns stats data for specific champion</summary>
        /// <param name="ChampionKey"></param>
        /// <param name="Page"></param>
        /// <param name="Limit"></param>
        /// <returns>Task to get stats data</returns>
        public Task<List<Stats>> GetStats(string ChampionKey, int Page = DefaultPage, int Limit = DefaultLimit)
        {
            return GetStats(ChampionKey, CancellationToken.None, Page, Limit);
        }
        /// <summary>Returns stats data for specific champion</summary>
        /// <param name="ChampionKey"></param>
        /// <param name="CancelToken"></param>
        /// <param name="Page"></param>
        /// <param name="Limit"></param>
        /// <returns>Task to get stats data</returns>
        public Task<List<Stats>> GetStats(string ChampionKey, CancellationToken CancelToken, int Page = DefaultPage, int Limit = DefaultLimit)
        {
            return Get<List<Stats>>("stats/champs/" + ChampionKey, CancelToken, Page, Limit);
        }
        /// <summary>Returns stats data for specific role</summary>
        /// <param name="Role"></param>
        /// <param name="Page"></param>
        /// <param name="Limit"></param>
        /// <returns>Task to get stats data</returns>
        public Task<StatsPage> GetStats(Role Role, int Page = DefaultPage, int Limit = DefaultLimit)
        {
            return GetStats(Role, CancellationToken.None, Page, Limit);
        }
        /// <summary>Returns stats data for specific role</summary>
        /// <param name="Role"></param>
        /// <param name="CancelToken"></param>
        /// <param name="Page"></param>
        /// <param name="Limit"></param>
        /// <returns>Task to get stats data</returns>
        public Task<StatsPage> GetStats(Role Role, CancellationToken CancelToken, int Page = DefaultPage, int Limit = DefaultLimit)
        {
            return Get<StatsPage>("stats/role/" + Role.ToString(), CancelToken, Page, Limit);
        }
        /// <summary>Returns stats data for specific role by aspect</summary>
        /// <param name="Role"></param>
        /// <param name="StatsRoleAspect"></param>
        /// <param name="Page"></param>
        /// <param name="Limit"></param>
        /// <returns>Task to get stats data</returns>
        public Task<StatsPage> GetStats(Role Role, StatsRoleAspect StatsRoleAspect, int Page = DefaultPage, int Limit = DefaultLimit)
        {
            return GetStats(Role, StatsRoleAspect, CancellationToken.None, Page, Limit);
        }
        /// <summary>Returns stats data for specific role by aspect</summary>
        /// <param name="Role"></param>
        /// <param name="StatsRoleAspect"></param>
        /// <param name="CancelToken"></param>
        /// <param name="Page"></param>
        /// <param name="Limit"></param>
        /// <returns>Task to get stats data</returns>
        public Task<StatsPage> GetStats(Role Role, StatsRoleAspect StatsRoleAspect, CancellationToken CancelToken, int Page = DefaultPage, int Limit = DefaultLimit)
        {
            return Get<StatsPage>("stats/role/" + Role.ToString() + "/" + StatsRoleAspect.ToString(), CancelToken, Page, Limit);
        }

        // request handling
        /// <summary>Performs http request to the champion.gg api</summary>
        /// <typeparam name="T">Type of returning object</typeparam>
        /// <param name="BaseExtension"></param>
        /// <param name="CancelToken"></param>
        /// <param name="Page"></param>
        /// <param name="Limit"></param>
        /// <returns>Deserialized http response</returns>
        /// <exception cref="Exception">ChampionGG.Exception</exception>
        private async Task<T> Get<T>(string BaseExtension, CancellationToken CancelToken, int? Page = default(int), int? Limit = default(int))
        {
            // request
            var request = new HttpRequestMessage();
            request.Method = new HttpMethod("GET");

            // url
            string urlExtension = BaseExtension + "?api_key=" + apiKey;
            if (Page.HasValue) urlExtension += "&page=" + Page.Value;
            if (Limit.HasValue) urlExtension += "&limit=" + Limit.Value;
            request.RequestUri = new Uri(baseUrl, urlExtension);

            // response
            var response = await client.SendAsync(request, HttpCompletionOption.ResponseContentRead, CancelToken).ConfigureAwait(false);
            var data = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);

            // result
            int status = (int)response.StatusCode;
            if (status == 200)
            {
                var result = default(T);
                try
                {
                    if (data.Length > 0)
                        result = JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(data, 0, data.Length));
                    return result;
                }
                catch (Exception ex)
                {
                    throw new ChampionGG.Exception(ErrDeserializationFailed, status.ToString(), data, ex);
                }
            }
            else
            {
                var result = default(ErrorResponse);
                try
                {
                    if (data.Length > 0)
                        result = JsonConvert.DeserializeObject<ErrorResponse>(Encoding.UTF8.GetString(data, 0, data.Length));
                }
                catch (Exception ex)
                {
                    throw new ChampionGG.Exception(ErrDeserializationFailed, status.ToString(), data, ex);
                }
                throw new ChampionGG.Exception<ErrorResponse>(ErrResponse, status.ToString(), data, result, null);
            }
            throw new ChampionGG.Exception(ErrUnexpectedHttpStatus + " (" + (int)response.StatusCode + ").", status.ToString(), data, null);
        }
        
    }
}
