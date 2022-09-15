using Edsm.Sdk.Model.Edsm.Enums.Stars;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edsm.Sdk.Model.Edsm.Enums.Engineering
{
    [JsonConverter(typeof(StandardEnumConverter<RawMaterial>))]
    public enum RawMaterial
    {
        Antimony,
        Arsenic,
        Boron,
        Cadmium,
        Carbon,
        Chromium,
        Germanium,
        Iron,
        Lead,
        Manganese,
        Mercury,
        Molybdenum,
        Nickel,
        Niobium,
        Phosphorus,
        Polonium,
        Rhenium,
        Ruthenium,
        Selenium,
        Sulphur,
        Technetium,
        Tellurium,
        Tin,
        Tungsten,
        Vanadium,
        Yttrium,
        Zinc,
        Zirconium
    }
}
