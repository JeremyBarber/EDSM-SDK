using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Edsm.Enums.Planets
{
    [JsonConverter(typeof(StandardEnumConverter<AtmosphereDescriptor>))]
    public enum AtmosphereDescriptor
    {
        Hot,
        Thick,
        Thin
    }
}
