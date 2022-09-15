using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edsm.Sdk.Dto;

namespace Edsm.Sdk.Model.Edsm.Systems.System
{
    public class SystemRequest : IEdsmRequest
    {
        public readonly string systemName;
        public readonly int showId;
        public readonly int showCoordinates;
        public readonly int showPermit;
        public readonly int showInformation;
        public readonly int showPrimaryStar;
        public readonly int includeHidden;

        public SystemRequest(
            string systemName,
            bool showId = true,
            bool showCoordinates =true,
            bool showPermit = true,
            bool showInformation = true,
            bool showPrimaryStar = true,
            bool includeHidden = false)
        {
            this.systemName = systemName;
            this.showId = Convert.ToInt32(showId);
            this.showCoordinates = Convert.ToInt32(showCoordinates);
            this.showPermit = Convert.ToInt32(showPermit);
            this.showInformation = Convert.ToInt32(showInformation);
            this.showPrimaryStar = Convert.ToInt32(showPrimaryStar);
            this.includeHidden = Convert.ToInt32(includeHidden);
        }

        public Uri Path => new(@"https://www.edsm.net/api-v1/system");

        public Type ResponseType => typeof(SystemResponse);
    }
}
