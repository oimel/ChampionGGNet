using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChampionGG.Models;

namespace Example
{
    public class Program
    {
        private static ManualResetEvent resetEvent = new ManualResetEvent(false);
        private static ChampionGG.Api ChampionGG;

        private static void Main(string[] args)
        {
            ChampionGG = new ChampionGG.Api("YOUR API KEY HERE");
            Show();
            resetEvent.WaitOne();
            Console.ReadLine();
        }
        private async static void Show()
        {
            try
            {
                // Getting a list of all champions with basic information
                var championList = await ChampionGG.GetBasicChampionList();
                foreach (var champion in championList)
                {
                    string roles = "";
                    foreach (var role in champion.Roles)
                        roles += role.Type.ToString() + " ";
                    Console.WriteLine("{0}  Name: \"{1}\", Updated: {2}, Roles: {3}", champion.Key, champion.Name, champion.LastUpdated.ToString("yyyy-MM-dd HH:mm:ss"), roles);
                }

                // Getting detailed information about a specific champion
                var championRoles = await ChampionGG.GetChampion("Taric");
                foreach(var role in championRoles)                
                    Console.WriteLine("Taric " + role.Role);                

                // Getting all matchups for Ashe
                var matchupSets = await ChampionGG.GetMatchups("Ashe");
                foreach (var matchupSet in matchupSets)
                {
                    Console.WriteLine(matchupSet.Role);
                    foreach (var matchup in matchupSet.Matchups)
                        Console.WriteLine("{0} Games: {1}, WinRate: {2}%", matchup.Key, matchup.Games, matchup.WinRate);
                }

                // Getting details on the specific matchup Orianna vs. Xerath
                var specificMatchups = await ChampionGG.GetMatchup("Orianna", "Xerath");
                foreach (var m in specificMatchups)                
                    Console.WriteLine("{0} Games: {1}, WinRate: {2}%", "Orianna vs. Xerath", m.Games, m.WinRate);
                

                // Getting the most winning final item build for Urgot
                var itemSets = await ChampionGG.GetItems("Urgot", DataAspect.MostWins, ItemAspect.Finished);
                foreach (var itemSet in itemSets)
                {
                    Console.WriteLine("Urgot " + itemSet.Role.ToString());
                    foreach (var item in itemSet.Items)
                        Console.WriteLine(item);

                }

                // Getting the most popular skill order for Lux
                var skillSets = await ChampionGG.GetSkills("Lux", DataAspect.MostPopular);
                foreach (var skillSet in skillSets)
                {
                    Console.WriteLine("Order:");
                    foreach (var skill in skillSet.Order)
                        Console.WriteLine(skill);
                }

                // Getting the names of the skills of Lux
                var skillInfo = await ChampionGG.GetSkillInfo("Lux");
                foreach (var skillKey in new List<string> { "Q", "W", "E", "R" })
                    Console.WriteLine(skillInfo[skillKey].Name);

                // Getting the most winning summoner spells for Sion
                var summonerSets = await ChampionGG.GetSummoners("Sion", DataAspect.MostWins);
                foreach (var summonerSet in summonerSets)
                    Console.WriteLine("{0} and {1}: {2} {3}%", summonerSet.Summoner1, summonerSet.Summoner2, summonerSet.Games, summonerSet.WinPercent);

                // Getting the most popular rune page for Morgana
                var runeSets = await ChampionGG.GetRunes("Morgana", DataAspect.MostPopular);
                foreach (var runeSet in runeSets)
                {
                    Console.WriteLine(runeSet.Role);
                    foreach (var rune in runeSet.Runes)
                        Console.WriteLine("{0}x {1}", rune.Number, rune.Name);
                }

                // Getting stats of every champion
                var stats = await ChampionGG.GetStats();
                foreach (var champ in stats)
                    Console.WriteLine("{0} {1}: {2} Kills", champ.Name, champ.Role, champ.General.Kills);

                // Getting stats of Maokai
                var stats2 = await ChampionGG.GetStats("Maokai");
                foreach (var role in stats2)
                    Console.WriteLine("Maokai {0}: {1} Deaths", role.Role, role.General.Deaths);

                // Getting stats of all mid-lane champions
                var stats3 = await ChampionGG.GetStats(Role.Middle);
                foreach (var champ in stats3.Stats)
                    Console.WriteLine("{0} {1}: {2} Gold", champ.Key, champ.Role, champ.General.GoldEarned);

                // Getting stats of all jungle champions, starting with the worst performing
                var stats4 = await ChampionGG.GetStats(Role.Jungle, StatsRoleAspect.WorstPerformance);
                foreach (var champ in stats4.Stats)
                    Console.WriteLine("{0} {1}: {2}% Wins", champ.Key, champ.Role, champ.General.WinPercent);

                // Gettings all champions, starting with the most banned one
                var stats5 = await ChampionGG.GetStats(StatsAspect.MostBanned);
                foreach (var champ in stats5.Stats)
                    Console.WriteLine("{0} {1}: {2}% Banrate", champ.Key, champ.Role, champ.General.BanRate);
            }
            catch (ChampionGG.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            resetEvent.Set();
        }
    }
}
