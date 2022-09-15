using Edsm.Sdk.Model.Edsm.Enums.Stars;
using Edsm.Sdk.Model.Edsm.Types;

namespace Edsm.Sdk.Model.Types.Stars
{
    public class Star : IBody
    {
        public StarType subType;
        public bool isScoopable;
        public bool? isMainStar;
        public int? age;
        public MorganKeenanSpectralClass? spectralClass;
        public int? spectralSubClass;
        public LuminosityClass? luminosity;
        public double? absoluteMagnitude;
        public double? solarMasses;
        public double? solarRadius;
        //public List<MineableRegion> belts;
    }

    public class StarShort
    {
        public string name;
        public StarType type;
        public bool isScoopable;
    }
}
