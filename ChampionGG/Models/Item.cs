using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChampionGG.Models.ChampionModels
{
    /// <summary>Contains items aswell as their stats</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemSet
    {
        /// <summary>
        /// List of items
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }

        /// <summary>
        /// Win Percentage for these items
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
    /// <summary>Allows to view items with a certain aspect</summary>
    public enum ItemAspect
    {
        /// <summary>Starting items (eg. Pots and a Ring)</summary>
        Starters,
        /// <summary>Final build items</summary>
        Finished
    }

    /// <summary>Contains the items aswell as their stats</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemSet
    {
        /// <summary>
        /// Number of games analyzed
        /// </summary>
        [JsonProperty("games", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Games { get; set; }

        /// <summary>
        /// Win percentage for these items
        /// </summary>
        [JsonProperty("winPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WinPercent { get; set; }

        /// <summary>
        /// List of item ids
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<int> Items { get; set; }

        /// <summary>
        /// Role this data is bound to
        /// </summary>
        [JsonProperty("role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Role Role { get; set; }
    }

    /// <summary>Item model</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Item
    {
        /// <summary>
        /// Item id
        /// </summary>
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Item name
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}
