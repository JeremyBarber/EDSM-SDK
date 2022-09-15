using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Edsm.Enums.Planets
{
    [JsonConverter(typeof(StandardEnumConverter<AtmosphereType>))]
    public enum AtmosphereType
    {
        NoAtmosphere,
        Ammonia,
        AmmoniaRich,
        AmmoniaAndOxygen,
        Helium,
        CarbonDioxide,
        CarbonDioxideRich,
        SilicateVapour,
        SulphurDioxide,
        ArgonRich,
        Oxygen,
        MetallicVapour,
        Methane,
        MethaneRich,
        NeonRich,
        Neon,
        Nitrogen,
        Water,
        WaterRich,
        Argon,
        SuitableForWaterBasedLife
    }
}
