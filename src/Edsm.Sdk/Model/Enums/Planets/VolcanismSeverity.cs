using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Edsm.Enums.Planets
{
    [JsonConverter(typeof(StandardEnumConverter<VolcanismSeverity>))]
    public enum VolcanismSeverity
    {
        Minor,
        Standard,
        Major
    }
}
