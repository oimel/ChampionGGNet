using System;
using Newtonsoft.Json;

#pragma warning disable 1591, 1587
/// <exclude>MicrosecondEpochConverter</exclude>
namespace ChampionGG.Json.Converters
{    
    public class MicrosecondEpochConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
    {
        private static readonly DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(((DateTime)value - _epoch).TotalMilliseconds + "000");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) { return null; }
            return _epoch.AddMilliseconds((long)reader.Value / 1000d);
        }
    }
}
