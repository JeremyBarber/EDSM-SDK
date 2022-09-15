using System.Text.Json.Serialization;

namespace Edsm.Sdk.Model.Edsm.Enums.Stars
{
    [JsonConverter(typeof(StandardEnumConverter<SpectralClass>))]
    public enum SpectralClass
    {
        O,
        B,
        A,
        F,
        G,
        K,
        M,
        MS,
        S,
        L,
        T,
        Y,
        C,
        D,
        WolfRayet,
        Unknown
    }
}
