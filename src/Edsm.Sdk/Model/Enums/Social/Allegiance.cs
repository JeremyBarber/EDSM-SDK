using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Edsm.Enums.Social
{
    [JsonConverter(typeof(StandardEnumConverter<Allegiance>))]
    public enum Allegiance
    {
        None,
        Independent,
        Federation,
        Alliance,
        Empire,
        PilotsFederation
    }
}
