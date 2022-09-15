using Edsm.Sdk.Model.Edsm.Enums.Stars;
using Edsm.Sdk.Model.Edsm.Systems.System;

namespace Edsm.Sdk.Tests.Model.Systems
{
    [TestFixture]
    public class SystemTests
    {
        public static IEdsmClient Client = new EdsmClient(new HttpClient());

        [TestCase("HIP 83003", true, ColorClass.BlueWhite, MassClass.Unspecified, ExoticClass.None, SpectralClass.O, TestName = "OStar")]
        [TestCase("Glesting", true, ColorClass.BlueWhite, MassClass.Unspecified, ExoticClass.None, SpectralClass.B, TestName = "BStar")]
        [TestCase("c Car", true, ColorClass.BlueWhite, MassClass.Supergiant, ExoticClass.None, SpectralClass.B, TestName = "BSupergiantStar")]
        [TestCase("Sirius", true, ColorClass.BlueWhite, MassClass.Unspecified, ExoticClass.None, SpectralClass.A, TestName = "AStar")]
        [TestCase("Sigma Serpentis", true, ColorClass.BlueWhite, MassClass.Supergiant, ExoticClass.None, SpectralClass.A, TestName = "ASupergiantStar")]
        [TestCase("Procyon", true, ColorClass.White, MassClass.Unspecified, ExoticClass.None, SpectralClass.F, TestName = "FStar")]
        [TestCase("Gamma Indi", false, ColorClass.White, MassClass.Supergiant, ExoticClass.None, SpectralClass.F, TestName = "FSupergiantStar")]
        [TestCase("Sol", true, ColorClass.WhiteYellow, MassClass.Unspecified, ExoticClass.None, SpectralClass.G, TestName = "GStar")]
        [TestCase("Rho Puppis", false, ColorClass.WhiteYellow, MassClass.Supergiant, ExoticClass.None, SpectralClass.G, TestName = "GSupergiantStar")]
        [TestCase("Lung", true, ColorClass.YellowOrange, MassClass.Unspecified, ExoticClass.None, SpectralClass.K, TestName = "KStar")]
        [TestCase("Rana", true, ColorClass.YellowOrange, MassClass.Giant, ExoticClass.None, SpectralClass.K, TestName = "KGiantStar")]
        [TestCase("Wolf 359", true, ColorClass.Red, MassClass.Dwarf, ExoticClass.None, SpectralClass.M, TestName = "MDwarfStar")]
        [TestCase("Gacrux", true, ColorClass.Red, MassClass.Giant, ExoticClass.None, SpectralClass.M, TestName = "MGiantStar")]
        [TestCase("Betelgeuse", true, ColorClass.Red, MassClass.Supergiant, ExoticClass.None, SpectralClass.M, TestName = "MSupergiantStar")]
        [TestCase("Ushornt TU-G d10-1", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.None, SpectralClass.MS, TestName = "MSStar")]
        [TestCase("BD Camelopardalis", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.None, SpectralClass.S, TestName = "SStar")]
        [TestCase("Kushen", false, ColorClass.Brown, MassClass.Dwarf, ExoticClass.None, SpectralClass.L, TestName = "LStar")]
        [TestCase("Ministry", false, ColorClass.Brown, MassClass.Dwarf, ExoticClass.None, SpectralClass.T, TestName = "TStar")]
        [TestCase("WISE 0855-0714", false, ColorClass.Brown, MassClass.Dwarf, ExoticClass.None, SpectralClass.Y, TestName = "YStar")]
        [TestCase("Seediansi", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.TTauri, SpectralClass.Unknown, TestName = "TTauriStar")]
        [TestCase("Wregoe LS-T e3-1", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.HerbigAeBe, SpectralClass.Unknown, TestName = "HerbigAeBeStar")]
        [TestCase("HIP 89535", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.W, SpectralClass.WolfRayet, TestName = "WolfRayetStar")]
        [TestCase("Csi+46-20087", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.WN, SpectralClass.WolfRayet, TestName = "WolfRayetNStar")]
        [TestCase("Bleae Thaa AA-A h0", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.WNC, SpectralClass.WolfRayet, TestName = "WolfRayetNCStar")]
        [TestCase("KN Muscae", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.WC, SpectralClass.WolfRayet, TestName = "WolfRayetCStar")]
        [TestCase("Smojoo AA-A h1", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.WO, SpectralClass.WolfRayet, TestName = "WolfRayetOStar")]
        [TestCase("HD 115977", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.C, SpectralClass.C, TestName = "CStar")]
        [TestCase("Nidge MJ-F d12-0", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.CN, SpectralClass.C, TestName = "CNStar")]
        [TestCase("Bleia Dryiae DB-X d1-5", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.CJ, SpectralClass.C, " A", TestName = "CJStar")]
        [TestCase("LP 658-2", false, ColorClass.White, MassClass.Dwarf, ExoticClass.D, SpectralClass.D, TestName = "WhiteDwarfDStar")]
        [TestCase("LAWD 96", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DA, SpectralClass.D, TestName = "WhiteDwarfDAStar")]
        [TestCase("Synuefai EA-A d0", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DAB, SpectralClass.D, TestName = "WhiteDwarfDABStar")]
        [TestCase("LHS 235", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DAZ, SpectralClass.D, TestName = "WhiteDwarfDAZStar")]
        [TestCase("Swoilz AF-H d10-2", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DAV, SpectralClass.D, TestName = "WhiteDwarfDAVStar")]
        [TestCase("Prua Dryoae QK-F d11-1", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DB, SpectralClass.D, TestName = "WhiteDwarfDBStar")]
        [TestCase("Swoiwns VQ-D d12-2", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DBZ, SpectralClass.D, TestName = "WhiteDwarfDBZStar")]
        [TestCase("Pru Euq QL-J d10-0", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DBV, SpectralClass.D, TestName = "WhiteDwarfDBVStar")]
        [TestCase("LFT 65", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DQ, SpectralClass.D, TestName = "WhiteDwarfDQStar")]
        [TestCase("LFT 1", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DC, SpectralClass.D, TestName = "WhiteDwarfDCStar")]
        [TestCase("Bleae Thua MY-Y d1-0", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DCV, SpectralClass.D, TestName = "WhiteDwarfDCVStar")]
        [TestCase("PSR J2144-3933", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.Neutron, SpectralClass.D, TestName = "NeutronStar")]
        [TestCase("Praea Euq MR-W e1-5", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.BlackHole, SpectralClass.D, TestName = "BlackHole")]
        public async Task System_PrimaryStar_Success(string name, bool isScoopable, ColorClass colorClass, MassClass massClass, ExoticClass exoticClass, SpectralClass spectralClass, string starSuffix = "")
        {
            var request = new SystemRequest(name);

            var response = await Client.SendRequest<SystemResponse>(request);

            Assert.That(response.primaryStar.isScoopable, Is.EqualTo(isScoopable));
            Assert.That(response.primaryStar.name, Is.EqualTo(name + starSuffix));
            Assert.That(response.primaryStar.type.colorClass, Is.EqualTo(colorClass));
            Assert.That(response.primaryStar.type.massClass, Is.EqualTo(massClass));
            Assert.That(response.primaryStar.type.spectralClass.spectralClass, Is.EqualTo(spectralClass));
            Assert.That(response.primaryStar.type.spectralClass.spectralSubClass, Is.Null);
            Assert.That(response.primaryStar.type.spectralClass.exoticClass, Is.EqualTo(exoticClass));
        }
    }
}
