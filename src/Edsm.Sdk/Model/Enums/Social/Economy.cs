using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Edsm.Enums.Social
{
    [JsonConverter(typeof(StandardEnumConverter<Economy>))]
    public enum Economy
    {
        Agriculture,
        Colony,
        Damaged,
        Extraction,
        HighTech,
        Industrial,
        Military,
        None,
        PrivateEnterprise,
        Refinery,
        Repair,
        Rescue,
        Terraforming,
        Tourism,
        Service
    }
}
