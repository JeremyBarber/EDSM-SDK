using Edsm.Sdk.Dto;

namespace Edsm.Sdk.Model.Edsm.Systems.System
{
    public class CubeSystemsRequest : IEdsmRequest
    {
        public readonly string systemName;
        public readonly float x;
        public readonly float y;
        public readonly float z;
        public readonly int size;
        public readonly int showId;
        public readonly int showCoordinates;
        public readonly int showPermit;
        public readonly int showInformation;
        public readonly int showPrimaryStar;

        public CubeSystemsRequest(
            string systemName = "",
            float x = (float)0.0,
            float y = (float)0.0,
            float z = (float)0.0,
            int size = 0,
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
            this.size = size;
            this.showId = Convert.ToInt32(showId);
            this.showCoordinates = Convert.ToInt32(showCoordinates);
            this.showPermit = Convert.ToInt32(showPermit);
            this.showInformation = Convert.ToInt32(showInformation);
            this.showPrimaryStar = Convert.ToInt32(showPrimaryStar);
        }

        public Uri Path => new(@"https://www.edsm.net/api-v1/cube-systems");

        public Type ResponseType => typeof(CubeSystemsResponse);
    }
}
