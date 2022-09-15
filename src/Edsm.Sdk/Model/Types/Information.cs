using Edsm.Sdk.Model.Edsm.Enums.Planets;
using Edsm.Sdk.Model.Edsm.Enums.Social;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edsm.Sdk.Model.Edsm.Types
{
    public struct Information
    {
        public readonly Allegiance? allegiance;
        public readonly Government? government;
        public readonly string faction;
        public readonly FactionState? factionState;
        public readonly long population;
        public readonly Security? security;
        public readonly Economy? economy;
        public readonly Economy? secondEconomy;
        public readonly Reserve? reserve;

        public Information(
            Allegiance? allegiance,
            Government? government,
            string faction,
            FactionState? factionState,
            long population,
            Security? security,
            Economy? economy,
            Economy? secondEconomy,
            Reserve? reserve)
        {
            this.allegiance = allegiance;
            this.government = government;
            this.faction = faction;
            this.factionState = factionState;
            this.population = population;
            this.security = security;
            this.economy = economy;
            this.secondEconomy = secondEconomy;
            this.reserve = reserve;
        }
    }
}
