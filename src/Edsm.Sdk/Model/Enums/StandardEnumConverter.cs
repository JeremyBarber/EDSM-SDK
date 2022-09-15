using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Edsm.Enums
{
    public class StandardEnumConverter<T> : JsonConverter where T : struct
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            //var indicesOfCapitalLetters = value.ToString().IndexOf((c => char.IsUpper(c))

            writer.WriteValue(value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
           var value = reader?.Value?.ToString()
                ?.Replace(" ", "")
                ?.Replace("-", "")
                ?.Replace("(", "_")
                ?.Replace(")", "_");

            return value == null ? null : Enum.Parse<T>(value, true);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(T) || objectType == typeof(string);
        }
    }
}
