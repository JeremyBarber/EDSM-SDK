using System.Text.Json.Serialization;

namespace Edsm.Sdk.Model.Edsm.Enums.Planets
{
    [JsonConverter(typeof(StandardEnumConverter<MiningType>))]
    public enum MiningType
    {
        Rocky,
        MetalRich,
        Metallic,
        Icy
    }
}
