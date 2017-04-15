using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChampionGG.Models.ChampionModels
{
    /// <summary>Contains runes as well as their stats</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class RuneSet
    {
        /// <summary>
        /// Most popular rune page
        /// </summary>
        [JsonProperty("runes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Rune> Runes { get; set; }

        /// <summary>
        /// Winning percentage for this rune page
        /// </summary>
        [JsonProperty("winPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WinPercent { get; set; }

        /// <summary>
        /// Number of games analyzed
        /// </summary>
        [JsonProperty("games", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Games { get; set; }
    }
}

namespace ChampionGG.Models
{
    /// <summary>Rune model</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Rune
    {
        /// <summary>
        /// Rune id
        /// </summary>
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Quantity of this type of rune
        /// </summary>
        [JsonProperty("number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Number { get; set; }

        /// <summary>
        /// Rune name
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Rune description
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    /// <summary>Contains runes aswell as their stats</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class RuneSet : ChampionModels.RuneSet
    {
        /// <summary>
        /// Role type
        /// </summary>
        [JsonProperty("role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Role Role { get; set; }
    }
}
