using Edsm.Sdk.Dto;

namespace Edsm.Sdk.Model.Edsm.Systems.System
{
    public class SphereSystemsRequest : IEdsmRequest
    {
        public readonly string systemName;
        public readonly float x;
        public readonly float y;
        public readonly float z;
        public readonly int minRadius;
        public readonly int radius;
        public readonly int showId;
        public readonly int showCoordinates;
        public readonly int showPermit;
        public readonly int showInformation;
        public readonly int showPrimaryStar;

        public SphereSystemsRequest(
            string systemName = "",
            float x = (float)0.0,
            float y = (float)0.0,
            float z = (float)0.0,
            int minRadius = 0,
            int radius = 50,
            bool showId = true,
            bool showCoordinates = true,
            bool showPermit = true,
            bool showInformation = true,
            bool showPrimaryStar = true)
        {
            this.systemName = systemName;
            this.x = x;
            this.y = y;
            this.z = z;
            this.minRadius = minRadius;
            this.radius = radius;
            this.showId = Convert.ToInt32(showId);
            this.showCoordinates = Convert.ToInt32(showCoordinates);
            this.showPermit = Convert.ToInt32(showPermit);
            this.showInformation = Convert.ToInt32(showInformation);
            this.showPrimaryStar = Convert.ToInt32(showPrimaryStar);
        }

        public Uri Path => new(@"https://www.edsm.net/api-v1/sphere-systems");

        public Type ResponseType => typeof(SphereSystemsResponse);
    }
}
