using Edsm.Sdk.Dto;
using Edsm.Sdk.Model.Edsm.Types;

namespace Edsm.Sdk.Model.Edsm.Systems.System
{
    public struct BodiesResponse : IEdsmResponse
    {
        public readonly string name;
        public readonly int id;
        public readonly long id64;
        public readonly string url;
        public readonly int? bodyCount;
        public readonly List<IBody> bodies;

        public BodiesResponse(string name, int id, long id64, string url, int? bodyCount, List<IBody> bodies)
        {
            this.name = name;
            this.id = id;
            this.id64 = id64;
            this.url = url;
            this.bodyCount = bodyCount;
            this.bodies = bodies;
        }
    }
}
