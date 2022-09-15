using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Edsm.Sdk.Model.Edsm.Enums.Stars
{
    [JsonConverter(typeof(StandardEnumConverter<ColorClass>))]
    public enum ColorClass
    {
        BlueWhite,
        White,
        WhiteYellow,
        YellowOrange,
        Red,
        Brown,
        Unspecified
    }
}
