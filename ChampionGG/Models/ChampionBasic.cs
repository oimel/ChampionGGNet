using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChampionGG.Models
{
    /// <summary>Basic champion model</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ChampionBasic
    {
        /// <summary>
        /// Champion database key
        /// </summary>
        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// Timestamp for last update (in seconds)
        /// </summary>
        [JsonProperty("lastUpdated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ChampionGG.Json.Converters.MicrosecondEpochConverter))]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Champion's name
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Specific data for each role
        /// </summary>
        [JsonProperty("roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<RoleSet> Roles { get; set; }
    }

    /// <summary>Role of basic champion</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class RoleSet
    {
        /// <summary>
        /// Number of games analyzed for this champ/role combo
        /// </summary>
        [JsonProperty("games", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Games { get; set; }

        /// <summary>
        /// Percentage of usage for this champ in this role
        /// </summary>
        [JsonProperty("percentPlayed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PercentPlayed { get; set; }

        /// <summary>
        /// Role type
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Role Type { get; set; }
    }
}
