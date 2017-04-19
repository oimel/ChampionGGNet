using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ChampionGG.Models.ChampionModels
{
    /// <summary>Contains summoners aswell as their stats</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SummonerSet
    {
        /// <summary>
        /// Summoner1 spell data
        /// </summary>
        [JsonProperty("summoner1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Json.Converters.SummonerConverter))]
        public Summoner Summoner1 { get; set; }

        /// <summary>
        /// Summoner2 spell data
        /// </summary>
        [JsonProperty("summoner2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Json.Converters.SummonerConverter))]
        public Summoner Summoner2 { get; set; }

        /// <summary>
        /// Winning percentage with these summoner spells
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
    /// <summary>Summoner spells</summary>
    public enum Summoner
    {
        /// <summary>Summonerspell: Clarity</summary>
        [EnumMember(Value = "Clarity")]
        Clarity,
        /// <summary>Summonerspell: Ghost</summary>
        [EnumMember(Value = "Ghost")]
        Ghost,
        /// <summary>Summonerspell: Heal</summary>
        [EnumMember(Value = "Heal")]
        Heal,
        /// <summary>Summonerspell: Mark</summary>
        [EnumMember(Value = "Mark")]
        Mark,
        /// <summary>Summonerspell: Barrier</summary>
        [EnumMember(Value = "Barrier")]
        Barrier,
        /// <summary>Summonerspell: Exhaust</summary>
        [EnumMember(Value = "Exhaust")]
        Exhaust,
        /// <summary>Summonerspell: Cleanse</summary>
        [EnumMember(Value = "Cleanse")]
        Cleanse,
        /// <summary>Summonerspell: Teleport</summary>
        [EnumMember(Value = "Teleport")]
        Teleport,
        /// <summary>Summonerspell: Flash</summary>
        [EnumMember(Value = "Flash")]
        Flash,
        /// <summary>Summonerspell: Ignite</summary>
        [EnumMember(Value = "Ignite")]
        Ignite,
        /// <summary>Summonerspell: Smite</summary>
        [EnumMember(Value = "Smite")]
        Smite,
    }    

    /// <summary>Contains summoners aswell as their stats</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SummonerSet
    {
        /// <summary>
        /// Summoner1 spell data
        /// </summary>        
        [JsonProperty("summoner1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Summoner Summoner1 { get; set; }

        /// <summary>
        /// Summoner2 spell data
        /// </summary>
        [JsonProperty("summoner2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Summoner Summoner2 { get; set; }

        /// <summary>
        /// Winning percentage with these summoner spells
        /// </summary>
        [JsonProperty("winPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WinPercent { get; set; }

        /// <summary>
        /// Number of games analyzed
        /// </summary>
        [JsonProperty("games", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Games { get; set; }

        /// <summary>
        /// Role type
        /// </summary>
        [JsonProperty("role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Role Type { get; set; }
    }
}
