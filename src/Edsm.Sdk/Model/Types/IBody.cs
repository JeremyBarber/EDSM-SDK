using Edsm.Sdk.Model.Edsm.Enums;
using Edsm.Sdk.Model.Types.Planets;
using Edsm.Sdk.Model.Types.Stars;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Edsm.Sdk.Model.Edsm.Types
{
    public class IBodyConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            //var indicesOfCapitalLetters = value.ToString().IndexOf((c => char.IsUpper(c))

            writer.WriteValue(value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject obj = JObject.Load(reader);

            var bt = obj["type"].ToObject<BodyType>(serializer);

            var output = default(IBody);
            switch (bt)
            {
                case BodyType.Star:

                    output = new Star();

                    break;
                case BodyType.Planet:
                    output = new Planet();
                    break;
                default:
                    throw new Exception($"Cannot figure out type {bt}");
            }
            serializer.Populate(obj.CreateReader(), output);
            return output;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(StarType) || objectType == typeof(string);
        }
    }

    [JsonConverter(typeof(IBodyConverter))]
    public abstract class IBody
    {
        public string name { get; set; }

        public BodyType type { get; set; }

        public int? bodyId { get; set; }

        public int? id { get; set; }

        public long? id64 { get; set; }

        public Discovery? discovery { get; set; }

        public List<KeyValuePair<string, int>>? parents { get; set; }

        public int? distanceToArrival { get; set; }

        public int? surfaceTemperature { get; set; }

        public double? orbitalPeriod { get; set; }

        public double? semiMajorAxis { get; set; }

        public double? orbitalEccentricity { get; set; }

        public double? orbitalInclination { get; set; }

        public double? argOfPeriapsis { get; set; }

        public double? rotationalPeriod { get; set; }

        public bool? rotationalPeriodTidallyLocked { get; set; }

        public float? axialTilt { get; set; }

        public DateTime? updateTime { get; set; }
    }
}