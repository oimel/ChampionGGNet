using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChampionGG.Models
{
    /// <summary>Contains stats with page control</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StatsPage
    {
        /// <summary>
        /// Current page
        /// </summary>
        [JsonProperty("page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// Current limit
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// Stats
        /// </summary>
        [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Stats> Stats { get; set; }
    }

    /// <summary>Contains stats-container for a champ/role combination</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Stats
    {
        /// <summary>
        /// Champion key
        /// </summary>
        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// Role type
        /// </summary>
        [JsonProperty("role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Role Role { get; set; }

        /// <summary>
        /// Champion key
        /// </summary>
        [JsonProperty("general", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public StatsContainer General { get; set; }
    }

    /// <summary>Contains stats-container for a champ/role combination</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StatsListItem : Stats
    {
        /// <summary>
        /// Champion name
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    /// <summary>Contains a variety of different statistics</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StatsContainer
    {
        /// <summary>
        /// Win percentage
        /// </summary>
        [JsonProperty("winPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WinPercent { get; set; }

        /// <summary>
        /// Play percentage
        /// </summary>
        [JsonProperty("playPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PlayPercent { get; set; }

        /// <summary>
        /// Ban rate
        /// </summary>
        [JsonProperty("banRate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BanRate { get; set; }

        /// <summary>
        /// Average experience
        /// </summary>
        [JsonProperty("experience", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Experience { get; set; }

        /// <summary>
        /// Average kills
        /// </summary>
        [JsonProperty("kills", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Kills { get; set; }

        /// <summary>
        /// Average deaths
        /// </summary>
        [JsonProperty("deaths", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Deaths { get; set; }

        /// <summary>
        /// Average assists
        /// </summary>
        [JsonProperty("assists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Assists { get; set; }

        /// <summary>
        /// Average damage dealt to champions
        /// </summary>
        [JsonProperty("totalDamageDealtToChampions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalDamageDealtToChampions { get; set; }

        /// <summary>
        /// Average total damage taken
        /// </summary>
        [JsonProperty("totalDamageTaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalDamageTaken { get; set; }

        /// <summary>
        /// Average total heal
        /// </summary>
        [JsonProperty("totalHeal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalHeal { get; set; }

        /// <summary>
        /// Average largest killing spree
        /// </summary>
        [JsonProperty("largestKillingSpree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? LargestKillingSpree { get; set; }

        /// <summary>
        /// Average minions killed
        /// </summary>
        [JsonProperty("minionsKilled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? MinionsKilled { get; set; }

        /// <summary>
        /// Average neutral minions killed in own jungle
        /// </summary>
        [JsonProperty("neutralMinionsKilledTeamJungle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NeutralMinionsKilledTeamJungle { get; set; }

        /// <summary>
        /// Average neutral minions killed in enemy jungle
        /// </summary>
        [JsonProperty("neutralMinionsKilledEnemyJungle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NeutralMinionsKilledEnemyJungle { get; set; }

        /// <summary>
        /// Average gold earned
        /// </summary>
        [JsonProperty("goldEarned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? GoldEarned { get; set; }

        /// <summary>
        /// Overall ranking for this champ in this role
        /// </summary>
        [JsonProperty("overallPosition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OverallPosition { get; set; }

        /// <summary>
        /// Overall position change since last patch
        /// </summary>
        [JsonProperty("overallPositionChange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OverallPositionChange { get; set; }
    }

    /// <summary>Aspect in which stats can be viewed</summary>
    public enum StatsAspect
    {
        /// <summary>View starting with most banned</summary>
        MostBanned,
        /// <summary>View starting with least winning</summary>
        LeastWinning,
        /// <summary>View starting with most winning</summary>
        MostWinning,
        /// <summary>View starting with least played</summary>
        LeastPlayed,
        /// <summary>View starting with most played</summary>
        MostPlayed,
        /// <summary>View starting with best rated</summary>
        BestRated,
        /// <summary>View starting with worst rated</summary>
        WorstRated
    }
    /// <summary>Aspect in wich role-stats can be viewed</summary>
    public enum StatsRoleAspect
    {
        /// <summary>View starting with least winning</summary>
        LeastWinning,
        /// <summary>View starting with most winning</summary>
        MostWinning,
        /// <summary>View starting with least improved</summary>
        LeastImproved,
        /// <summary>View starting with most improved</summary>
        MostImproved,
        /// <summary>View starting with worst performing</summary>
        WorstPerformance,
        /// <summary>View starting with best performing</summary>
        BestPerformance
    }
}
