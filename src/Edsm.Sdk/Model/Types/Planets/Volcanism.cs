using Edsm.Sdk.Model.Edsm.Enums.Planets;
using Edsm.Sdk.Model.Types.Stars;
using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Types.Planets
{
    public class VolcanismConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader?.Value?.ToString()
                ?.Replace(" ", "");

            var severity = VolcanismSeverity.Standard;

            if (value.StartsWith("Major"))
            {
                value = value.Replace("Major", "");
                severity = VolcanismSeverity.Major;
            }
            else if (value.StartsWith("Minor"))
            {
                value = value.Replace("Minor", "");
                severity = VolcanismSeverity.Minor;
            }

            var type = Enum.Parse<VolcanismType>(value);

            return new Volcanism(type, severity);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(StarType) || objectType == typeof(string);
        }
    }

    [JsonConverter(typeof(VolcanismConverter))]
    public class Volcanism
    {
        public readonly VolcanismType type;
        public readonly VolcanismSeverity severity;

        public Volcanism(VolcanismType type, VolcanismSeverity severity)
        {
            this.type = type;
            this.severity = severity;
        }
    }
}
