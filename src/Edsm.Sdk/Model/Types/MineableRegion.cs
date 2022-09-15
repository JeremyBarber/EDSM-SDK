using Edsm.Sdk.Model.Edsm.Enums.Planets;

namespace Edsm.Sdk.Model.Edsm.Types
{
    public struct MineableRegion
    {
        public readonly string name;
        public readonly MiningType type;
        public readonly long mass;
        public readonly long innerRadius;
        public readonly long outerRadius;

        public MineableRegion(string name, MiningType type, long mass, long innerRadius, long outerRadius)
        {
            this.name = name;
            this.type = type;
            this.mass = mass;
            this.innerRadius = innerRadius;
            this.outerRadius = outerRadius;
        }
    }
}
