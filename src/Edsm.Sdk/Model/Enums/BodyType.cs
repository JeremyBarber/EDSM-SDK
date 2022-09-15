using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Edsm.Enums
{
    [JsonConverter(typeof(StandardEnumConverter<BodyType>))]
    public enum BodyType
    {
        Star,
        Planet
    }
}
