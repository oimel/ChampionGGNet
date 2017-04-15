using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ChampionGG.Models.ChampionModels
{
    /// <summary>Matchups divided by roles</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MatchupSet
    {
        /// <summary>
        /// Human readable role type
        /// </summary>
        [JsonProperty("role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Role Role { get; set; }

        /// <summary>
        /// List of matchups
        /// </summary>
        [JsonProperty("matchups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Matchup> Matchups { get; set; }

    }
    /// <summary>Matchup a champion has to a certain opponent</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Matchup
    {
        /// <summary>
        /// Number of matches analyzed
        /// </summary>
        [JsonProperty("games", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Games { get; set; }

        /// <summary>
        /// Score for this matchup
        /// </summary>
        [JsonProperty("statScore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? StatScore { get; set; }

        /// <summary>
        /// Win rate versus this champ
        /// </summary>
        [JsonProperty("winRate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WinRate { get; set; }

        /// <summary>
        /// Win rate change since last patch
        /// </summary>
        [JsonProperty("winRateChange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WinRateChange { get; set; }

        /// <summary>
        /// Enemy champion key
        /// </summary>
        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }
    }
}
namespace ChampionGG.Models
{
    /// <summary>Matchup a champion has to a certain opponent</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Matchup
    {
        /// <summary>
        /// Number of matches analyzed
        /// </summary>
        [JsonProperty("games", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Games { get; set; }

        /// <summary>
        /// Score for this matchup
        /// </summary>
        [JsonProperty("statScore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? StatScore { get; set; }

        /// <summary>
        /// Win rate versus this champ
        /// </summary>
        [JsonProperty("winRate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WinRate { get; set; }

        /// <summary>
        /// Role type
        /// </summary>
        [JsonProperty("role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Role Type { get; set; }
    }
}
