using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edsm.Sdk.Dto;

namespace Edsm.Sdk.Model.Edsm.Systems.Systems
{
    public class SystemsRequest : IEdsmRequest
    {
        public readonly List<string> systemName;
        public readonly int showId;
        public readonly int showCoordinates;
        public readonly int showPermit;
        public readonly int showInformation;
        public readonly int showPrimaryStar;
        public readonly DateTime? startDateTime;
        public readonly DateTime? endDateTime;
        public readonly int onlyKnownCoordinates;
        public readonly int onlyUnknownCoordinates;
        public readonly int includeHidden;

        public SystemsRequest(
            List<string> systemName,
            bool showId = true,
            bool showCoordinates = true,
            bool showPermit = true,
            bool showInformation = true,
            bool showPrimaryStar = true,
            DateTime? startDateTime = null,
            DateTime? endDateTime = null,
            bool onlyKnownCoordinates = true,
            bool onlyUnknownCoordinates = false,
            bool includeHidden = false)
        {
            this.systemName = systemName;
            this.showId = Convert.ToInt32(showId);
            this.showCoordinates = Convert.ToInt32(showCoordinates);
            this.showPermit = Convert.ToInt32(showPermit);
            this.showInformation = Convert.ToInt32(showInformation);
            this.showPrimaryStar = Convert.ToInt32(showPrimaryStar);
            this.startDateTime = startDateTime;
            this.endDateTime = endDateTime;
            this.onlyKnownCoordinates = Convert.ToInt32(onlyKnownCoordinates);
            this.onlyUnknownCoordinates = Convert.ToInt32(onlyUnknownCoordinates);
            this.includeHidden = Convert.ToInt32(includeHidden);
        }

        public Uri Path => new(@"https://www.edsm.net/api-v1/systems");

        public Type ResponseType => typeof(SystemsRequest);
    }
}
