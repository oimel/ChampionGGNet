using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChampionGG.Models.ChampionModels
{
    /// <summary>Contains information about a skill (eg name)</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SkillInfo
    {
        /// <summary>
        /// Skill name
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Default skill key
        /// </summary>
        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }
    }

    /// <summary>Contains skills aswell as their stats</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SkillSet
    {
        /// <summary>
        /// Skill order
        /// </summary>
        [JsonProperty("order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<char> Order { get; set; }

        /// <summary>
        /// Win percentage for this skill order
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
    /// <summary>Contains skills aswell as their stats</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SkillSet : ChampionModels.SkillSet
    {
        /// <summary>
        /// Role type
        /// </summary>
        [JsonProperty("role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Role Type { get; set; }
    }

    /// <summary>Skill model</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Skill
    {
        /// <summary>
        /// Ability name
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}
