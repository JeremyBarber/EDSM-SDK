using Edsm.Sdk.Dto;

namespace Edsm.Sdk.Model.Edsm.Systems.System
{
    public class BodiesRequest : IEdsmRequest
    {
        public readonly string? systemName;
        public readonly int? systemId;

        public BodiesRequest(
            string? systemName = null,
            int? systemId = null)
        {
            this.systemName = systemName;
            this.systemId = systemId;
        }

        public Uri Path => new(@"https://www.edsm.net/api-system-v1/bodies");

        public Type ResponseType => typeof(BodiesResponse);
    }
}
