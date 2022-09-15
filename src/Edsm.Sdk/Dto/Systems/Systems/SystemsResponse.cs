using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edsm.Sdk.Dto;

namespace Edsm.Sdk.Model.Edsm.Systems.System
{
    public class SystemsResponse : IEdsmResponse
    {
        public readonly List<SystemResponse> systems;

        public SystemsResponse(List<SystemResponse> systems)
        {
            this.systems = systems;
        }
    }
}
