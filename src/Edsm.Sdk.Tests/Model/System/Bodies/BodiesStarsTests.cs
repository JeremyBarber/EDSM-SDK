using Edsm.Sdk.Model.Edsm.Enums.Planets;
using Edsm.Sdk.Model.Edsm.Enums.Stars;
using Edsm.Sdk.Model.Edsm.Systems.System;
using Edsm.Sdk.Model.Types.Planets;
using Edsm.Sdk.Model.Types.Stars;
using System;

namespace Edsm.Sdk.Tests.Model.System.Bodies
{
    // Luminosity
    // Terraform
    // Planet Types


    [TestFixture]
    public class StarsTests
    {
        public static IEdsmClient Client = new EdsmClient(new HttpClient());

        [TestCase("HIP 83003", true, ColorClass.BlueWhite, MassClass.Unspecified, ExoticClass.None, SpectralClass.O, TestName = "OStar_StarType")]
        [TestCase("Glesting", true, ColorClass.BlueWhite, MassClass.Unspecified, ExoticClass.None, SpectralClass.B, TestName = "BStar_StarType")]
        [TestCase("41 Tauri", true, ColorClass.BlueWhite, MassClass.Supergiant, ExoticClass.None, SpectralClass.B, TestName = "BSupergiantStar_StarType")]
        [TestCase("Sirius", true, ColorClass.BlueWhite, MassClass.Unspecified, ExoticClass.None, SpectralClass.A, TestName = "AStar_StarType")]
        [TestCase("Sigma Serpentis", true, ColorClass.BlueWhite, MassClass.Supergiant, ExoticClass.None, SpectralClass.A, TestName = "ASupergiantStar_StarType")]
        [TestCase("Procyon", true, ColorClass.White, MassClass.Unspecified, ExoticClass.None, SpectralClass.F, TestName = "FStar_StarType")]
        [TestCase("Gamma Indi", false, ColorClass.White, MassClass.Supergiant, ExoticClass.None, SpectralClass.F, TestName = "FSupergiantStar_StarType")]
        [TestCase("Sol", true, ColorClass.WhiteYellow, MassClass.Unspecified, ExoticClass.None, SpectralClass.G, TestName = "GStar_StarType")]
        [TestCase("Rho Puppis", false, ColorClass.WhiteYellow, MassClass.Supergiant, ExoticClass.None, SpectralClass.G, TestName = "GSupergiantStar_StarType")]
        [TestCase("Lung", true, ColorClass.YellowOrange, MassClass.Unspecified, ExoticClass.None, SpectralClass.K, TestName = "KStar_StarType")]
        [TestCase("Rana", true, ColorClass.YellowOrange, MassClass.Giant, ExoticClass.None, SpectralClass.K, TestName = "KGiantStar_StarType")]
        [TestCase("Wolf 359", true, ColorClass.Red, MassClass.Dwarf, ExoticClass.None, SpectralClass.M, TestName = "MDwarfStar_StarType")]
        [TestCase("Gacrux", true, ColorClass.Red, MassClass.Giant, ExoticClass.None, SpectralClass.M, TestName = "MGiantStar_StarType")]
        [TestCase("Betelgeuse", true, ColorClass.Red, MassClass.Supergiant, ExoticClass.None, SpectralClass.M, TestName = "MSupergiantStar_StarType")]
        [TestCase("Ushornt TU-G d10-1", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.None, SpectralClass.MS, TestName = "MSStar_StarType")]
        [TestCase("BD Camelopardalis", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.None, SpectralClass.S, TestName = "SStar_StarType")]
        [TestCase("Kushen", false, ColorClass.Brown, MassClass.Dwarf, ExoticClass.None, SpectralClass.L, TestName = "LStar_StarType")]
        [TestCase("Ministry", false, ColorClass.Brown, MassClass.Dwarf, ExoticClass.None, SpectralClass.T, TestName = "TStar_StarType")]
        [TestCase("WISE 0855-0714", false, ColorClass.Brown, MassClass.Dwarf, ExoticClass.None, SpectralClass.Y, TestName = "YStar_StarType")]
        [TestCase("Seediansi", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.TTauri, SpectralClass.Unknown, TestName = "TTauriStar_StarType")]
        [TestCase("Wregoe LS-T e3-1", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.HerbigAeBe, SpectralClass.Unknown, TestName = "HerbigAeBeStar_StarType")]
        [TestCase("HIP 89535", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.W, SpectralClass.WolfRayet, TestName = "WolfRayetStar_StarType")]
        [TestCase("Csi+46-20087", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.WN, SpectralClass.WolfRayet, TestName = "WolfRayetNStar_StarType")]
        [TestCase("Bleae Thaa AA-A h0", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.WNC, SpectralClass.WolfRayet, TestName = "WolfRayetNCStar_StarType")]
        [TestCase("KN Muscae", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.WC, SpectralClass.WolfRayet, TestName = "WolfRayetCStar_StarType")]
        [TestCase("Smojoo AA-A h1", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.WO, SpectralClass.WolfRayet, TestName = "WolfRayetOStar_StarType")]
        [TestCase("HD 115977", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.C, SpectralClass.C, TestName = "CStar_StarType")]
        [TestCase("Nidge MJ-F d12-0", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.CN, SpectralClass.C, TestName = "CNStar_StarType")]
        [TestCase("Bleia Dryiae DB-X d1-5", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.CJ, SpectralClass.C, " A", TestName = "CJStar_StarType")]
        [TestCase("LP 658-2", false, ColorClass.White, MassClass.Dwarf, ExoticClass.D, SpectralClass.D, TestName = "WhiteDwarfDStar_StarType")]
        [TestCase("LAWD 96", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DA, SpectralClass.D, TestName = "WhiteDwarfDAStar_StarType")]
        [TestCase("Synuefai EA-A d0", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DAB, SpectralClass.D, TestName = "WhiteDwarfDABStar_StarType")]
        [TestCase("LHS 235", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DAZ, SpectralClass.D, TestName = "WhiteDwarfDAZStar_StarType")]
        [TestCase("Swoilz AF-H d10-2", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DAV, SpectralClass.D, TestName = "WhiteDwarfDAVStar_StarType")]
        [TestCase("Prua Dryoae QK-F d11-1", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DB, SpectralClass.D, TestName = "WhiteDwarfDBStar_StarType")]
        [TestCase("Swoiwns VQ-D d12-2", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DBZ, SpectralClass.D, TestName = "WhiteDwarfDBZStar_StarType")]
        [TestCase("Pru Euq QL-J d10-0", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DBV, SpectralClass.D, TestName = "WhiteDwarfDBVStar_StarType")]
        [TestCase("LFT 65", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DQ, SpectralClass.D, TestName = "WhiteDwarfDQStar_StarType")]
        [TestCase("LFT 1", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DC, SpectralClass.D, TestName = "WhiteDwarfDCStar_StarType")]
        [TestCase("Bleae Thua MY-Y d1-0", false, ColorClass.White, MassClass.Dwarf, ExoticClass.DCV, SpectralClass.D, TestName = "WhiteDwarfDCVStar_StarType")]
        [TestCase("PSR J2144-3933", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.Neutron, SpectralClass.D, TestName = "NeutronStar_StarType")]
        [TestCase("Praea Euq MR-W e1-5", false, ColorClass.Unspecified, MassClass.Unspecified, ExoticClass.BlackHole, SpectralClass.D, TestName = "BlackHole_StarType")]
        public async Task System_Body_StarType_Success(string name, bool isScoopable, ColorClass colorClass, MassClass massClass, ExoticClass exoticClass, SpectralClass spectralClass, string starSuffix = "")
        {
            var request = new BodiesRequest(name);

            var response = await Client.SendRequest<BodiesResponse>(request);

            var body = (Star)response.bodies.Where(b => b.name == (name + starSuffix)).Single();

            Assert.That(body.isScoopable, Is.EqualTo(isScoopable));
            Assert.That(body.name, Is.EqualTo(name + starSuffix));
            Assert.That(body.subType.colorClass, Is.EqualTo(colorClass));
            Assert.That(body.subType.massClass, Is.EqualTo(massClass));
            Assert.That(body.subType.spectralClass.spectralClass, Is.EqualTo(spectralClass));
            Assert.That(body.subType.spectralClass.spectralSubClass, Is.Null);
        }

        // There's a weird thing with these tests where a bunch of star types dont return full spectral class info
        // For example, all B Supergiants return a spectralClass of null
        // So, for now, that's what the tests are set up to expect
        [TestCase("HIP 83003", ExoticClass.None, SpectralClass.O, 0, TestName = "OStar_SpectralClass")]
        [TestCase("Glesting", ExoticClass.None, SpectralClass.B, 2, TestName = "BStar_SpectralClass")]
        [TestCase("41 Tauri", null, null, null, TestName = "BSupergiantStar_SpectralClass")]
        [TestCase("Sirius", ExoticClass.None, SpectralClass.A, 1, TestName = "AStar_SpectralClass")]
        [TestCase("Sigma Serpentis", ExoticClass.None, SpectralClass.A, null, TestName = "ASupergiantStar_SpectralClass")]
        [TestCase("Procyon", ExoticClass.None, SpectralClass.F, 6, TestName = "FStar_SpectralClass")]
        [TestCase("Gamma Indi", ExoticClass.None, SpectralClass.F, 9, TestName = "FSupergiantStar_SpectralClass")]
        [TestCase("Sol", ExoticClass.None, SpectralClass.G, 2, TestName = "GStar_SpectralClass")]
        [TestCase("Rho Puppis", ExoticClass.None, SpectralClass.G, 3, TestName = "GSupergiantStar_SpectralClass")]
        [TestCase("Lung", ExoticClass.None, SpectralClass.K, 0, TestName = "KStar_SpectralClass")]
        [TestCase("Rana", ExoticClass.None, SpectralClass.K, 7, TestName = "KGiantStar_SpectralClass")]
        [TestCase("Wolf 359", ExoticClass.None, SpectralClass.M, 6, TestName = "MDwarfStar_SpectralClass")]
        [TestCase("Gacrux", ExoticClass.None, SpectralClass.M, 6, TestName = "MGiantStar_SpectralClass")]
        [TestCase("Betelgeuse", ExoticClass.None, SpectralClass.M, 7, TestName = "MSupergiantStar_SpectralClass")]
        [TestCase("Ushornt TU-G d10-1", null, null, null, TestName = "MSStar_SpectralClass")]
        [TestCase("BD Camelopardalis", null, null, null, TestName = "SStar_SpectralClass")]
        [TestCase("Kushen", ExoticClass.None, SpectralClass.L, 5, TestName = "LStar_SpectralClass")]
        [TestCase("Ministry", ExoticClass.None, SpectralClass.T, 5, TestName = "TStar_SpectralClass")]
        [TestCase("WISE 0855-0714", ExoticClass.None, SpectralClass.Y, 4, TestName = "YStar_SpectralClass")]
        [TestCase("Seediansi", ExoticClass.TTauri, SpectralClass.Unknown, 7, TestName = "TTauriStar_SpectralClass")]
        [TestCase("Wregoe LS-T e3-1", ExoticClass.HerbigAeBe, SpectralClass.Unknown, 9, TestName = "HerbigAeBeStar_SpectralClass")]
        [TestCase("HIP 89535", null, null, null, TestName = "WolfRayetStar_SpectralClass")]
        [TestCase("Csi+46-20087", null, null, null, TestName = "WolfRayetNStar_SpectralClass")]
        [TestCase("Bleae Thaa AA-A h0", null, null, null, TestName = "WolfRayetNCStar_SpectralClass")]
        [TestCase("KN Muscae", null, null, null, TestName = "WolfRayetCStar_SpectralClass")]
        [TestCase("Smojoo AA-A h1", null, null, null, TestName = "WolfRayetOStar_SpectralClass")]
        [TestCase("HD 115977", null, null, null, TestName = "CStar_SpectralClass")]
        [TestCase("Nidge MJ-F d12-0", null, null, null, TestName = "CNStar_SpectralClass")]
        [TestCase("Bleia Dryiae DB-X d1-5", null, null, null, " A", TestName = "CJStar_SpectralClass")]
        [TestCase("LP 658-2", null, null, null, TestName = "WhiteDwarfDStar_SpectralClass")]
        [TestCase("LAWD 96", null, null, null, TestName = "WhiteDwarfDAStar_SpectralClass")]
        [TestCase("Synuefai EA-A d0", null, null, null, TestName = "WhiteDwarfDABStar_SpectralClass")]
        [TestCase("LHS 235", null, null, null, TestName = "WhiteDwarfDAZStar_SpectralClass")]
        [TestCase("Swoilz AF-H d10-2", null, null, null, TestName = "WhiteDwarfDAVStar_SpectralClass")]
        [TestCase("Prua Dryoae QK-F d11-1", null, null, null, TestName = "WhiteDwarfDBStar_SpectralClass")]
        [TestCase("Swoiwns VQ-D d12-2", null, null, null, TestName = "WhiteDwarfDBZStar_SpectralClass")]
        [TestCase("Pru Euq QL-J d10-0", null, null, null, TestName = "WhiteDwarfDBVStar_SpectralClass")]
        [TestCase("LFT 65", null, null, null, TestName = "WhiteDwarfDQStar_SpectralClass")]
        [TestCase("LFT 1", null, null, null, TestName = "WhiteDwarfDCStar_SpectralClass")]
        [TestCase("Bleae Thua MY-Y d1-0", null, null, null, TestName = "WhiteDwarfDCVStar_SpectralClass")]
        [TestCase("PSR J2144-3933", null, null, null, TestName = "NeutronStar_SpectralClass")]
        [TestCase("Praea Euq MR-W e1-5", null, null, null, TestName = "BlackHole_SpectralClass")]
        public async Task System_Body_SpectralClass_Success(string name, ExoticClass? exoticClass, SpectralClass? detailedSpectralClass, int? spectralSubClass, string starSuffix = "")
        {
            var request = new BodiesRequest(name);

            var response = await Client.SendRequest<BodiesResponse>(request);

            var body = (Star)response.bodies.Where(b => b.name == (name + starSuffix)).Single();

            Assert.That(body.name, Is.EqualTo(name + starSuffix));
            Assert.That(body.spectralClass?.spectralClass, Is.EqualTo(detailedSpectralClass));
            Assert.That(body.spectralClass?.spectralSubClass, Is.EqualTo(spectralSubClass));
            Assert.That(body.spectralClass?.exoticClass, Is.EqualTo(exoticClass));
        }
    }
}
