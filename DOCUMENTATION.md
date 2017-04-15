# ChampionGG

<table>
<tbody>
<tr>
<td><a href="#api">Api</a></td>
<td><a href="#errorresponse">ErrorResponse</a></td>
</tr>
<tr>
<td><a href="#exception">Exception</a></td>
<td><a href="#exception\`1">Exception\`1</a></td>
</tr>
<tr>
<td><a href="#champion">Champion</a></td>
<td><a href="#championbasic">ChampionBasic</a></td>
</tr>
<tr>
<td><a href="#damagecomposition">DamageComposition</a></td>
<td><a href="#generalcontainer">GeneralContainer</a></td>
</tr>
<tr>
<td><a href="#generaldata">GeneralData</a></td>
<td><a href="#itemcontainer">ItemContainer</a></td>
</tr>
<tr>
<td><a href="#itemset">ItemSet</a></td>
<td><a href="#mastery">Mastery</a></td>
</tr>
<tr>
<td><a href="#masterycontainer">MasteryContainer</a></td>
<td><a href="#masteryset">MasterySet</a></td>
</tr>
<tr>
<td><a href="#masterytree">MasteryTree</a></td>
<td><a href="#matchup">Matchup</a></td>
</tr>
<tr>
<td><a href="#matchupset">MatchupSet</a></td>
<td><a href="#overallposition">OverallPosition</a></td>
</tr>
<tr>
<td><a href="#runecontainer">RuneContainer</a></td>
<td><a href="#runeset">RuneSet</a></td>
</tr>
<tr>
<td><a href="#skillcontainer">SkillContainer</a></td>
<td><a href="#skillinfo">SkillInfo</a></td>
</tr>
<tr>
<td><a href="#skillset">SkillSet</a></td>
<td><a href="#summonercontainer">SummonerContainer</a></td>
</tr>
<tr>
<td><a href="#summonerset">SummonerSet</a></td>
<td><a href="#trinket">Trinket</a></td>
</tr>
<tr>
<td><a href="#dataaspect">DataAspect</a></td>
<td><a href="#item">Item</a></td>
</tr>
<tr>
<td><a href="#itemaspect">ItemAspect</a></td>
<td><a href="#itemset">ItemSet</a></td>
</tr>
<tr>
<td><a href="#matchup">Matchup</a></td>
<td><a href="#role">Role</a></td>
</tr>
<tr>
<td><a href="#roleset">RoleSet</a></td>
<td><a href="#rune">Rune</a></td>
</tr>
<tr>
<td><a href="#runeset">RuneSet</a></td>
<td><a href="#skill">Skill</a></td>
</tr>
<tr>
<td><a href="#skillset">SkillSet</a></td>
<td><a href="#stats">Stats</a></td>
</tr>
<tr>
<td><a href="#statsaspect">StatsAspect</a></td>
<td><a href="#statscontainer">StatsContainer</a></td>
</tr>
<tr>
<td><a href="#statslistitem">StatsListItem</a></td>
<td><a href="#statspage">StatsPage</a></td>
</tr>
<tr>
<td><a href="#statsroleaspect">StatsRoleAspect</a></td>
<td><a href="#summoner">Summoner</a></td>
</tr>
<tr>
<td><a href="#summonerset">SummonerSet</a></td>
</tr>
</tbody>
</table>


## Api

API of the League of Legends statistics website champion.gg

### Constructor(ApiKey, BaseUrl)

Creates new api instance using the default url

| Name | Description |
| ---- | ----------- |
| ApiKey | *System.String*<br>Get an api key at http://api.champion.gg/ |
| BaseUrl | *System.Uri*<br>Base path to the web api |

### Constructor(ApiKey)

Creates new api instance

| Name | Description |
| ---- | ----------- |
| ApiKey | *System.String*<br>Get an api key at http://api.champion.gg/ |

### Get\`\`1(BaseExtension, CancelToken, Page, Limit)

Performs http request to the champion.gg api

#### Type Parameters

- T - Type of returning object

| Name | Description |
| ---- | ----------- |
| BaseExtension | *System.String*<br> |
| CancelToken | *System.Threading.CancellationToken*<br> |
| Page | *System.Nullable{System.Int32}*<br> |
| Limit | *System.Nullable{System.Int32}*<br> |

#### Returns

Deserialized http response

*Exception:* ChampionGG.Exception

### GetBasicChampionList

Returns a basic champion list

#### Returns

Task to get basic champion list

### GetBasicChampionList(CancelToken)

Returns a basic champion list

#### Returns

Task to get basic champion list

| Name | Description |
| ---- | ----------- |
| CancelToken | *System.Threading.CancellationToken*<br> |

### GetChampion(ChampionKey, CancelToken)

Returns data for champion

#### Returns

Task to get data for champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| CancelToken | *System.Threading.CancellationToken*<br> |

### GetChampion(ChampionKey)

Returns data for champion

#### Returns

Task to get data for champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |

### GetItems(ChampionKey, DataAspect, ItemAspect, CancelToken)

Returns item data for a champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| DataAspect | *ChampionGG.Models.DataAspect*<br> |
| ItemAspect | *ChampionGG.Models.ItemAspect*<br> |
| CancelToken | *System.Threading.CancellationToken*<br> |

#### Returns

Task to get item data

### GetItems(ChampionKey, DataAspect, ItemAspect)

Returns item data for a champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| DataAspect | *ChampionGG.Models.DataAspect*<br> |
| ItemAspect | *ChampionGG.Models.ItemAspect*<br> |

#### Returns

Task to get item data

### GetMatchup(ChampionKey, OpponentKey, CancelToken)

Returns matchup data for a champion and a specific opponent

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| OpponentKey | *System.String*<br> |
| CancelToken | *System.Threading.CancellationToken*<br> |

#### Returns

Task to get matchup data

### GetMatchup(ChampionKey, OpponentKey)

Returns matchup data for a champion and a specific opponent

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| OpponentKey | *System.String*<br> |

#### Returns

Task to get matchup data

### GetMatchups(ChampionKey, CancelToken)

Returns matchup data for a champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
 ///
| Name | Description |
| ---- | ----------- |
| CancelToken | *System.Threading.CancellationToken*<br> |

#### Returns

Task to get matchup data

### GetMatchups(ChampionKey)

Returns matchup data for a champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |

#### Returns

Task to get matchup data for champion

### GetRunes(ChampionKey, DataAspect, CancelToken)

Returns rune data for a champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| DataAspect | *ChampionGG.Models.DataAspect*<br> |
| CancelToken | *System.Threading.CancellationToken*<br> |

#### Returns

Task to get rune data

### GetRunes(ChampionKey, DataAspect)

Returns rune data for a champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| DataAspect | *ChampionGG.Models.DataAspect*<br> |

#### Returns

Task to get rune data

### GetSkillInfo(ChampionKey, CancelToken)

Returns skill information (names)

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| CancelToken | *System.Threading.CancellationToken*<br> |

#### Returns

Task to get skill information

### GetSkillInfo(ChampionKey)

Returns skill information (names)

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |

#### Returns

Task to get skill information

### GetSkills(ChampionKey, DataAspect, CancelToken)

Returns skill data for a champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| DataAspect | *ChampionGG.Models.DataAspect*<br> |
| CancelToken | *System.Threading.CancellationToken*<br> |

#### Returns

Task to get skill data

### GetSkills(ChampionKey, DataAspect)

Returns skill data for a champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| DataAspect | *ChampionGG.Models.DataAspect*<br> |

#### Returns

Task to get skill data

### GetStats(Role, StatsRoleAspect, Page, Limit)

Returns stats data for specific role by aspect

| Name | Description |
| ---- | ----------- |
| Role | *ChampionGG.Models.Role*<br> |
| StatsRoleAspect | *ChampionGG.Models.StatsRoleAspect*<br> |
| Page | *System.Int32*<br> |
| Limit | *System.Int32*<br> |

#### Returns

Task to get stats data

### GetStats(Role, StatsRoleAspect, CancelToken, Page, Limit)

Returns stats data for specific role by aspect

| Name | Description |
| ---- | ----------- |
| Role | *ChampionGG.Models.Role*<br> |
| StatsRoleAspect | *ChampionGG.Models.StatsRoleAspect*<br> |
| CancelToken | *System.Threading.CancellationToken*<br> |
| Page | *System.Int32*<br> |
| Limit | *System.Int32*<br> |

#### Returns

Task to get stats data

### GetStats(Role, Page, Limit)

Returns stats data for specific role

| Name | Description |
| ---- | ----------- |
| Role | *ChampionGG.Models.Role*<br> |
| Page | *System.Int32*<br> |
| Limit | *System.Int32*<br> |

#### Returns

Task to get stats data

### GetStats(Role, CancelToken, Page, Limit)

Returns stats data for specific role

| Name | Description |
| ---- | ----------- |
| Role | *ChampionGG.Models.Role*<br> |
| CancelToken | *System.Threading.CancellationToken*<br> |
| Page | *System.Int32*<br> |
| Limit | *System.Int32*<br> |

#### Returns

Task to get stats data

### GetStats(StatsAspect, Page, Limit)

Returns stats data for all champions by aspect

| Name | Description |
| ---- | ----------- |
| StatsAspect | *ChampionGG.Models.StatsAspect*<br> |
| Page | *System.Int32*<br> |
| Limit | *System.Int32*<br> |

#### Returns

Task to get stats data

### GetStats(StatsAspect, CancelToken, Page, Limit)

Returns stats data for all champions by aspect

| Name | Description |
| ---- | ----------- |
| StatsAspect | *ChampionGG.Models.StatsAspect*<br> |
| CancelToken | *System.Threading.CancellationToken*<br> |
| Page | *System.Int32*<br> |
| Limit | *System.Int32*<br> |

#### Returns

Task to get stats data

### GetStats(Page, Limit)

Returns stats data for all champions

| Name | Description |
| ---- | ----------- |
| Page | *System.Int32*<br> |
| Limit | *System.Int32*<br> |

#### Returns

Task to get stats data

### GetStats(ChampionKey, Page, Limit)

Returns stats data for specific champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| Page | *System.Int32*<br> |
| Limit | *System.Int32*<br> |

#### Returns

Task to get stats data

### GetStats(ChampionKey, CancelToken, Page, Limit)

Returns stats data for specific champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| CancelToken | *System.Threading.CancellationToken*<br> |
| Page | *System.Int32*<br> |
| Limit | *System.Int32*<br> |

#### Returns

Task to get stats data

### GetStats(CancelToken, Page, Limit)

Returns stats data for all champions

| Name | Description |
| ---- | ----------- |
| CancelToken | *System.Threading.CancellationToken*<br> |
| Page | *System.Int32*<br> |
| Limit | *System.Int32*<br> |

#### Returns

Task to get stats data

### GetSummoners(ChampionKey, DataAspect, CancelToken)

Returns summoner spell data for a champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| DataAspect | *ChampionGG.Models.DataAspect*<br> |
| CancelToken | *System.Threading.CancellationToken*<br> |

#### Returns

Task to get summoner spell data

### GetSummoners(ChampionKey, DataAspect)

Returns summoner spell data for a champion

| Name | Description |
| ---- | ----------- |
| ChampionKey | *System.String*<br> |
| DataAspect | *ChampionGG.Models.DataAspect*<br> |

#### Returns

Task to get summoner spell data


## ErrorResponse

Deserialized server error response

### Message

Server error message


## Exception

Exception of ChampionGG api

### Constructor(message, statusCode, responseData, innerException)

Creates a ChampionGG Exception

| Name | Description |
| ---- | ----------- |
| message | *System.String*<br> |
| statusCode | *System.String*<br> |
| responseData | *System.Byte[]*<br> |
| innerException | *ChampionGG.Exception*<br> |

### ResponseData

Response data

### StatusCode

HTTP status code

### ToString

Converts ChampionGG Exception to string

#### Returns

HTTP Resonse


## Exception\`1

Holds class of T

#### Type Parameters

- T -

### Constructor(message, statusCode, responseData, response, innerException)

Creates a ChampionGG Exception containing exception

| Name | Description |
| ---- | ----------- |
| message | *System.String*<br> |
| statusCode | *System.String*<br> |
| responseData | *System.Byte[]*<br> |
| response | *\`0*<br> |
| innerException | *ChampionGG.Exception*<br> |

### Response

Response


## Champion

Detailed champion model

### ChampionMatrix

Numeric data for champion matrix analysis

### DamageComposition

Damage composition

### ExperienceRate

Experience gaining rate

### ExperienceSample

Experience sampling

### FirstItems

Starting items information

### General

General data on this champ

### Items

Final build information

### Key

Champion database key

### Masteries

Masteries information

### Matchups

List of matchups information

### OverallPosition

Position of the champion according to general ranking

### PatchPlay

Play rates for last 6 patches

### PatchWin

Winrates for last 6 patches

### Role

Role type that this data belongs to

### Runes

Runes information

### Skills

Skill information

### Summoners

Information on summoner spells

### Trinkets

Trinkets information


## ChampionBasic

Basic champion model

### Key

Champion database key

### LastUpdated

Timestamp for last update (in seconds)

### Name

Champion's name

### Roles

Specific data for each role


## DamageComposition

Damage split into true-damage, magic-damage and physical-damage

### MagicDamage

Magic damage percentage

### PhysicalDamage

Physical damage percentage

### TrueDamage

True damage percentage


## GeneralContainer

Contains general data

### Assists

ssists data

### BanRate

Ban rate data

### Deaths

Deaths data

### Experience

Experience data

### GoldEarned

Gold earned data

### Kills

Kills data

### LargestKillingSpree

Largest killing spree data

### MinionsKilled

Minions killed data

### PlayPercent

Play percent data

### TotalDamageDealtToChampions

Total damage dealt to champions data

### TotalHeal

Total heal data

### VisionWardsBought

Vision wards bought data

### WardsKilled

Wards killed data

### WardsPlaced

Wards placed data

### WinPercent

Win percent data


## GeneralData

Model for a general data item

### Change

Change since last patch

### Position

Current position


## ItemContainer

Contains ItemSets

### HighestWinPercent

Information on most winning items

### MostGames

Information on most popular items


## ItemSet

Contains items aswell as their stats

### Games

Number of games analyzed

### Items

List of items

### WinPercent

Win Percentage for these items


## Mastery

Mastery model

### Id

Mastery id

### Points

Points used in this mastery


## MasteryContainer

Contains MasterySets

### HighestWinPercent

Most winning masteries

### MostGames

Most popular masteries


## MasterySet

Contains MasteryTrees aswell as their stats

### Games

Number of games analyzed

### MasteryTrees

Detailed masteries information

### WinPercent

Winning percentage for masteries


## MasteryTree

Contains masteries

### Masteries

Specific mastery data

### Name

Tree for these masteries

### Total

Total points used in this tree


## Matchup

Matchup a champion has to a certain opponent

### Games

Number of matches analyzed

### Key

Enemy champion key

### StatScore

Score for this matchup

### WinRate

Win rate versus this champ

### WinRateChange

Win rate change since last patch


## MatchupSet

Matchups divided by roles

### Matchups

List of matchups

### Role

Human readable role type


## OverallPosition

Position in champion ranking

### Change

Position change since last patch

### Position

Actual position


## RuneContainer

Contains RuneSets

### HighestWinPercent

Information on most winning rune page

### MostGames

Information on most popular rune page


## RuneSet

Contains runes as well as their stats

### Games

Number of games analyzed

### Runes

Most popular rune page

### WinPercent

Winning percentage for this rune page


## SkillContainer

Contains SkillSets and SkillInfos

### HighestWinPercent

Information on most winning skill order

### MostGames

Information on most popular skill order

### SkillInfo

Champion's skills data


## SkillInfo

Contains information about a skill (eg name)

### Key

Default skill key

### Name

Skill name


## SkillSet

Contains skills aswell as their stats

### Games

Number of games analyzed

### Order

Skill order

### WinPercent

Win percentage for this skill order


## SummonerContainer

Contains Summonersets

### HighestWinPercent

Information on most winning summoner spells

### MostGames

Information on most popular summoner spells


## SummonerSet

Contains summoners aswell as their stats

### Games

Number of games analyzed

### Summoner1

Summoner1 spell data

### Summoner2

Summoner2 spell data

### WinPercent

Winning percentage with these summoner spells


## Trinket

Trinket model

### Games

Number of games analyzed

### Item

Trinket item data

### WinPercent

Winning percentage with this trinket


## DataAspect

Allows to view data with a certain aspect

### MostPopular

Shows most popular

### MostWins

Shows most winning


## Item

Item model

### Id

Item id

### Name

Item name


## ItemAspect

Allows to view items with a certain aspect

### Finished

Final build items

### Starters

Starting items (eg. Pots and a Ring)


## ItemSet

Contains the items aswell as their stats

### Games

Number of games analyzed

### Items

List of item ids

### Role

Role this data is bound to

### WinPercent

Win percentage for these items


## Matchup

Matchup a champion has to a certain opponent

### Games

Number of matches analyzed

### StatScore

Score for this matchup

### Type

Role type

### WinRate

Win rate versus this champ


## Role

Allows to view data for a specific role

### ADC

ADC/Bottom

### Jungle

Jungle

### Middle

Mid-lane

### Support

Support/Utility

### Top

Top-lane


## RoleSet

Role of basic champion

### Games

Number of games analyzed for this champ/role combo

### PercentPlayed

Percentage of usage for this champ in this role

### Type

Role type


## Rune

Rune model

### Description

Rune description

### Id

Rune id

### Name

Rune name

### Number

Quantity of this type of rune


## RuneSet

Contains runes aswell as their stats

### Role

Role type


## Skill

Skill model

### Name

Ability name


## SkillSet

Contains skills aswell as their stats

### Type

Role type


## Stats

Contains stats-container for a champ/role combination

### General

Champion key

### Key

Champion key

### Role

Role type


## StatsAspect

Aspect in which stats can be viewed

### BestRated

View starting with best rated

### LeastPlayed

View starting with least played

### LeastWinning

View starting with least winning

### MostBanned

View starting with most banned

### MostPlayed

View starting with most played

### MostWinning

View starting with most winning

### WorstRated

View starting with worst rated


## StatsContainer

Contains a variety of different statistics

### Assists

Average assists

### BanRate

Ban rate

### Deaths

Average deaths

### Experience

Average experience

### GoldEarned

Average gold earned

### Kills

Average kills

### LargestKillingSpree

Average largest killing spree

### MinionsKilled

Average minions killed

### NeutralMinionsKilledEnemyJungle

Average neutral minions killed in enemy jungle

### NeutralMinionsKilledTeamJungle

Average neutral minions killed in own jungle

### OverallPosition

Overall ranking for this champ in this role

### OverallPositionChange

Overall position change since last patch

### PlayPercent

Play percentage

### TotalDamageDealtToChampions

Average damage dealt to champions

### TotalDamageTaken

Average total damage taken

### TotalHeal

Average total heal

### WinPercent

Win percentage


## StatsListItem

Contains stats-container for a champ/role combination

### Name

Champion name


## StatsPage

Contains stats with page control

### Limit

Current limit

### Page

Current page

### Stats

Stats


## StatsRoleAspect

Aspect in wich role-stats can be viewed

### BestPerformance

View starting with best performing

### LeastImproved

View starting with least improved

### LeastWinning

View starting with least winning

### MostImproved

View starting with most improved

### MostWinning

View starting with most winning

### WorstPerformance

View starting with worst performing


## Summoner

Summoner spells

### Barrier

Summonerspell: Barrier

### Clarity

Summonerspell: Clarity

### Cleanse

Summonerspell: Cleanse

### Exhaust

Summonerspell: Exhaust

### Flash

Summonerspell: Flash

### Ghost

Summonerspell: Ghost

### Heal

Summonerspell: Heal

### Ignite

Summonerspell: Ignite

### Mark

Summonerspell: Mark

### Smite

Summonerspell: Smite

### Teleport

Summonerspell: Teleport


## SummonerSet

Contains summoners aswell as their stats

### Type

Role type
