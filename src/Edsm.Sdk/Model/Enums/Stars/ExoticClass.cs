using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Edsm.Sdk.Model.Edsm.Enums.Stars
{
    [JsonConverter(typeof(StandardEnumConverter<ExoticClass>))]
    public enum ExoticClass
    {
        TTauri,
        HerbigAeBe,
        W,
        WN,
        WNC,
        WC,
        WO,
        Neutron,
        BlackHole,
        C,
        CV,
        CN,
        CJ,
        D,
        DA,
        DAB,
        DAV,
        DAZ,
        DB,
        DBV,
        DBZ,
        DC,
        DCV,
        DQ,
        None
    }
}
