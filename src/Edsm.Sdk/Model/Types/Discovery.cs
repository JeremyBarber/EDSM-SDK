using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edsm.Sdk.Model.Edsm.Types
{
    public struct Discovery
    {
        public readonly string commander;
        public readonly DateTime date;

        public Discovery(string commander, DateTime date)
        {
            this.commander = commander;
            this.date = date;
        }
    }
}
