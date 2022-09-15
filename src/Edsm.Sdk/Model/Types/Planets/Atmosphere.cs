using Edsm.Sdk.Model.Edsm.Enums.Planets;
using Edsm.Sdk.Model.Types.Stars;
using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Types.Planets
{
    public class AtmosphereConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader?.Value?.ToString()
                ?.Split(" ").ToList();

            var description = new List<AtmosphereDescriptor>();

            while (value.Count > 0)
            {
                if (Enum.TryParse<AtmosphereDescriptor>(value[0], true, out var descriptor))
                {
                    description.Add(descriptor);
                    value.RemoveAt(0);
                }
                else
                {
                    break;
                }
            }

            var typeString = string.Join("", value).Replace("-", "");

            var type = Enum.Parse<AtmosphereType>(typeString, true);

            return new Atmosphere(description, type);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(StarType) || objectType == typeof(string);
        }
    }

    [JsonConverter(typeof(AtmosphereConverter))]
    public class Atmosphere
    {
        public readonly List<AtmosphereDescriptor> description;
        public readonly AtmosphereType type;

        public Atmosphere(List<AtmosphereDescriptor> description, AtmosphereType type)
        {
            this.description = description;
            this.type = type;
        }
    }
}
