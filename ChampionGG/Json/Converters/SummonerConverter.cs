using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ChampionGG.Models;

#pragma warning disable 1591, 1587
/// <exclude>MicrosecondEpochConverter</exclude>
namespace ChampionGG.Json.Converters
{
    public class SummonerConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            Console.WriteLine((objectType == typeof(Summoner)).ToString());
            return (objectType == typeof(Summoner));
        }
        public override bool CanRead
        {
            get { return true; }
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            string enumString = (string)jo["name"];
            return Enum.Parse(typeof(Summoner), enumString, true);
        }
        public override bool CanWrite
        {
            get { return false; }
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
