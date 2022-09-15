using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Edsm.Enums.Planets
{
    [JsonConverter(typeof(StandardEnumConverter<VolcanismType>))]
    public enum VolcanismType
    {
        Novolcanism,
        WaterMagma,
        SulphurDioxideMagma,
        AmmoniaMagma,
        MethaneMagma,
        NitrogenMagma,
        RockyMagma,
        MetallicMagma,
        WaterGeysers,
        CarbonDioxideGeysers,
        AmmoniaGeysers,
        MethaneGeysers,
        NitrogenGeysers,
        HeliumGeysers,
        SilicateVapourGeysers
    }
}
