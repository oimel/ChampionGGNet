using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ChampionGG.Models
{
    /// <summary>Allows to view data for a specific role</summary>
    public enum Role
    {
        /// <summary>Top-lane</summary>
        [EnumMember(Value = "Top")]
        Top,
        /// <summary>Mid-lane</summary>
        [EnumMember(Value = "Middle")]
        Middle,
        /// <summary>Jungle</summary>
        [EnumMember(Value = "Jungle")]
        Jungle,
        /// <summary>Support/Utility</summary>
        [EnumMember(Value = "Support")]
        Support,
        /// <summary>ADC/Bottom</summary>
        [EnumMember(Value = "ADC")]
        ADC,
    }

    /// <summary>Allows to view data with a certain aspect</summary>
    public enum DataAspect
    {
        /// <summary>Shows most popular</summary>
        MostPopular,
        /// <summary>Shows most winning</summary>
        MostWins,
    }

    /// <summary>Detailed champion model</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Champion
    {
        /// <summary>
        /// Champion database key
        /// </summary>
        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// Role type that this data belongs to
        /// </summary>
        [JsonProperty("role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Role Role { get; set; }

        /// <summary>
        /// Position of the champion according to general ranking
        /// </summary>
        [JsonProperty("overallPosition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ChampionModels.OverallPosition OverallPosition { get; set; }

        /// <summary>
        /// Final build information
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ChampionModels.ItemContainer Items { get; set; }

        /// <summary>
        /// Starting items information
        /// </summary>
        [JsonProperty("firstItems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ChampionModels.ItemContainer FirstItems { get; set; }

        /// <summary>
        /// Numeric data for champion matrix analysis
        /// </summary>
        [JsonProperty("championMatrix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<double> ChampionMatrix { get; set; }

        /// <summary>
        /// Trinkets information
        /// </summary>
        [JsonProperty("trinkets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<ChampionModels.Trinket> Trinkets { get; set; }

        /// <summary>
        /// Information on summoner spells
        /// </summary>
        [JsonProperty("summoners", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ChampionModels.SummonerContainer Summoners { get; set; }

        /// <summary>
        /// Runes information
        /// </summary>
        [JsonProperty("runes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ChampionModels.RuneContainer Runes { get; set; }

        /// <summary>
        /// Experience gaining rate
        /// </summary>
        [JsonProperty("experienceRate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<double> ExperienceRate { get; set; }

        /// <summary>
        /// Experience sampling
        /// </summary>
        [JsonProperty("experienceSample", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<double> ExperienceSample { get; set; }

        /// <summary>
        /// Winrates for last 6 patches
        /// </summary>
        [JsonProperty("patchWin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<double> PatchWin { get; set; }

        /// <summary>
        /// Play rates for last 6 patches
        /// </summary>
        [JsonProperty("patchPlay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<double> PatchPlay { get; set; }

        /// <summary>
        /// Damage composition
        /// </summary>
        [JsonProperty("dmgComposition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ChampionModels.DamageComposition DamageComposition { get; set; }

        /// <summary>
        /// List of matchups information
        /// </summary>
        [JsonProperty("matchups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<ChampionModels.Matchup> Matchups { get; set; }

        /// <summary>
        /// General data on this champ
        /// </summary>
        [JsonProperty("general", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ChampionModels.GeneralContainer General { get; set; }

        /// <summary>
        /// Skill information
        /// </summary>
        [JsonProperty("skills", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ChampionModels.SkillContainer Skills { get; set; }

        /// <summary>
        /// Masteries information
        /// </summary>
        [JsonProperty("masteries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ChampionModels.MasteryContainer Masteries { get; set; }
    }
}

namespace ChampionGG.Models.ChampionModels
{
    // position
    /// <summary>Position in champion ranking</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class OverallPosition
    {
        /// <summary>
        /// Position change since last patch
        /// </summary>
        [JsonProperty("change", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Change { get; set; }

        /// <summary>
        /// Actual position
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Position { get; set; }
    }

    // items
    /// <summary>Contains ItemSets</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemContainer
    {
        /// <summary>
        /// Information on most popular items
        /// </summary>
        [JsonProperty("mostGames", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ItemSet MostGames { get; set; }

        /// <summary>
        /// Information on most winning items
        /// </summary>
        [JsonProperty("highestWinPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ItemSet HighestWinPercent { get; set; }
    }

    // trinkets
    /// <summary>Trinket model</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Trinket
    {
        /// <summary>
        /// Number of games analyzed
        /// </summary>
        [JsonProperty("games", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Games { get; set; }

        /// <summary>
        /// Winning percentage with this trinket
        /// </summary>
        [JsonProperty("winPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WinPercent { get; set; }

        /// <summary>
        /// Trinket item data
        /// </summary>
        public Item Item { get; set; }
    }

    // summoners
    /// <summary>Contains Summonersets</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SummonerContainer
    {
        /// <summary>
        /// Information on most popular summoner spells
        /// </summary>
        [JsonProperty("mostGames", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SummonerSet MostGames { get; set; }

        /// <summary>
        /// Information on most winning summoner spells
        /// </summary>
        [JsonProperty("highestWinPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SummonerSet HighestWinPercent { get; set; }
    }

    // runes
    /// <summary>Contains RuneSets</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class RuneContainer
    {
        /// <summary>
        /// Information on most popular rune page
        /// </summary>
        [JsonProperty("mostGames", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RuneSet MostGames { get; set; }

        /// <summary>
        /// Information on most winning rune page
        /// </summary>
        [JsonProperty("highestWinPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RuneSet HighestWinPercent { get; set; }
    }

    // damage
    /// <summary>Damage split into true-damage, magic-damage and physical-damage</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DamageComposition
    {
        /// <summary>
        /// True damage percentage
        /// </summary>
        [JsonProperty("trueDmg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TrueDamage { get; set; }

        /// <summary>
        /// Magic damage percentage
        /// </summary>
        [JsonProperty("magicDmg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? MagicDamage { get; set; }

        /// <summary>
        /// Physical damage percentage
        /// </summary>
        [JsonProperty("physicalDmg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PhysicalDamage { get; set; }
    }

    // general
    /// <summary>Contains general data</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GeneralContainer
    {
        /// <summary>
        /// Win percent data
        /// </summary>
        [JsonProperty("winPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData WinPercent { get; set; }

        /// <summary>
        /// Play percent data
        /// </summary>
        [JsonProperty("playPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData PlayPercent { get; set; }

        /// <summary>
        /// Ban rate data
        /// </summary>
        [JsonProperty("banRate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData BanRate { get; set; }

        /// <summary>
        /// Experience data
        /// </summary>
        [JsonProperty("experience", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData Experience { get; set; }

        /// <summary>
        /// Gold earned data
        /// </summary>
        [JsonProperty("goldEarned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData GoldEarned { get; set; }

        /// <summary>
        /// Kills data
        /// </summary>
        [JsonProperty("kills", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData Kills { get; set; }

        /// <summary>
        /// Deaths data
        /// </summary>
        [JsonProperty("deaths", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData Deaths { get; set; }

        /// <summary>
        /// ssists data
        /// </summary>
        [JsonProperty("assists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData Assists { get; set; }

        /// <summary>
        /// Total damage dealt to champions data
        /// </summary>
        [JsonProperty("totalDamageDealtToChampions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData TotalDamageDealtToChampions { get; set; }

        /// <summary>
        /// Largest killing spree data
        /// </summary>
        [JsonProperty("largestKillingSpree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData LargestKillingSpree { get; set; }

        /// <summary>
        /// Minions killed data
        /// </summary>
        [JsonProperty("minionsKilled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData MinionsKilled { get; set; }

        //ToDo: Are these only for support????
        /// <summary>
        /// Total heal data
        /// </summary>
        [JsonProperty("totalHeal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData TotalHeal { get; set; }

        /// <summary>
        /// Vision wards bought data
        /// </summary>
        [JsonProperty("visionWardsBoughtInGame", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData VisionWardsBought { get; set; }

        /// <summary>
        /// Wards placed data
        /// </summary>
        [JsonProperty("wardsPlaced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData WardsPlaced { get; set; }

        /// <summary>
        /// Wards killed data
        /// </summary>
        [JsonProperty("wardsKilled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GeneralData WardsKilled { get; set; }
    }

    /// <summary>Model for a general data item</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GeneralData
    {
        /// <summary>
        /// Change since last patch
        /// </summary>
        [JsonProperty("change", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Change { get; set; }

        /// <summary>
        /// Current position
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Position { get; set; }
    }

    // skills
    /// <summary>Contains SkillSets and SkillInfos</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SkillContainer
    {
        /// <summary>
        /// Champion's skills data
        /// </summary>
        [JsonProperty("skillInfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<SkillInfo> SkillInfo { get; set; }

        /// <summary>
        /// Information on most popular skill order
        /// </summary>
        [JsonProperty("mostGames", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SkillSet MostGames { get; set; }

        /// <summary>
        /// Information on most winning skill order
        /// </summary>
        [JsonProperty("highestWinPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SkillSet HighestWinPercent { get; set; }
    }

    // masteries
    /// <summary>Contains MasterySets</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MasteryContainer
    {
        /// <summary>
        /// Most popular masteries
        /// </summary>
        [JsonProperty("mostGames", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MasterySet MostGames { get; set; }

        /// <summary>
        /// Most winning masteries
        /// </summary>
        [JsonProperty("highestWinPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MasterySet HighestWinPercent { get; set; }
    }

    /// <summary>Contains MasteryTrees aswell as their stats</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MasterySet
    {
        /// <summary>
        /// Winning percentage for masteries
        /// </summary>
        [JsonProperty("winPercent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WinPercent { get; set; }

        /// <summary>
        /// Number of games analyzed
        /// </summary>
        [JsonProperty("games", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Games { get; set; }

        /// <summary>
        /// Detailed masteries information
        /// </summary>
        [JsonProperty("masteries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<MasteryTree> MasteryTrees { get; set; }
    }

    /// <summary>Contains masteries</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MasteryTree
    {
        /// <summary>
        /// Tree for these masteries
        /// </summary>
        [JsonProperty("tree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Total points used in this tree
        /// </summary>
        [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// Specific mastery data
        /// </summary>
        [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Mastery> Masteries { get; set; }
    }

    /// <summary>Mastery model</summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Mastery
    {
        /// <summary>
        /// Points used in this mastery
        /// </summary>
        [JsonProperty("points", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Points { get; set; }

        /// <summary>
        /// Mastery id
        /// </summary>
        [JsonProperty("mastery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }
    }
}