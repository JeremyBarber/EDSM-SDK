using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Edsm.Enums.Stars
{
    [JsonConverter(typeof(StandardEnumConverter<LuminosityClass>))]
    public enum LuminosityClass
    {
        I,
        Ia,
        Iab,
        Ib,
        II,
        IIa,
        IIab,
        IIb,
        III,
        IIIa,
        IIIab,
        IIIb,
        IV,
        IVa,
        IVab,
        IVb,
        V,
        Va,
        Vab,
        Vb,
        Vz,
        VI,
        VIa,
        VIab,
        VIb,
        VII,
        VIIa,
        VIIab,
        VIIb
    }
}
