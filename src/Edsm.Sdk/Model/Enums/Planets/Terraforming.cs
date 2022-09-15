using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Edsm.Enums.Planets
{
    [JsonConverter(typeof(StandardEnumConverter<Terraforming>))]
    public enum Terraforming
    {
        NotTerraformable,
        CandidateForTerraforming,
        Terraformed,
        Terraforming
    }
}
