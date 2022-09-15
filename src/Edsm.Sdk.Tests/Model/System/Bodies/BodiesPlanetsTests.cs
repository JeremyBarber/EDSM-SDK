using Edsm.Sdk.Model.Edsm.Enums.Planets;
using Edsm.Sdk.Model.Edsm.Enums.Stars;
using Edsm.Sdk.Model.Edsm.Systems.System;
using Edsm.Sdk.Model.Types.Planets;

namespace Edsm.Sdk.Tests.Model.System.Bodies
{
    // Luminosity
    // Terraform
    // Planet Types


    [TestFixture]
    public class PlanetsTests
    {
        public static IEdsmClient Client = new EdsmClient(new HttpClient());

        [TestCase("Sol", "Mars", VolcanismSeverity.Standard, VolcanismType.Novolcanism, TestName = "Volcanism_NoVolcanism")]
        [TestCase("Sol", "Europa", VolcanismSeverity.Major, VolcanismType.WaterMagma, TestName = "Volcanism_WaterMagma")]
        [TestCase("Toolfa", "Toolfa A 10 a", VolcanismSeverity.Minor, VolcanismType.AmmoniaMagma, TestName = "Volcanism_AmmoniaMagma")]
        [TestCase("Sol", "Pluto", VolcanismSeverity.Minor, VolcanismType.MethaneMagma, TestName = "Volcanism_MethaneMagma")]
        [TestCase("Luhman 16", "Luhman 16 A 6", VolcanismSeverity.Minor, VolcanismType.NitrogenMagma, TestName = "Volcanism_NitrogenMagma")]
        [TestCase("Sol", "Earth", VolcanismSeverity.Standard, VolcanismType.RockyMagma, TestName = "Volcanism_RockyMagma")]
        [TestCase("Alpha Centauri", "Eden", VolcanismSeverity.Minor, VolcanismType.MetallicMagma, TestName = "Volcanism_MetallicMagma")]
        [TestCase("Sol", "Tethys", VolcanismSeverity.Major, VolcanismType.WaterGeysers, TestName = "Volcanism_WaterGeysers")]
        [TestCase("Ross 248", "Ross 248 A 5", VolcanismSeverity.Minor, VolcanismType.CarbonDioxideGeysers, TestName = "Volcanism_CarbonDioxideGeysers")]
        [TestCase("Epsilon Indi", "New Africa", VolcanismSeverity.Minor, VolcanismType.SilicateVapourGeysers, TestName = "Volcanism_SilicateVapourGeysers")]
        public async Task System_Body_Volcanism_Success(string systemName, string bodyName, VolcanismSeverity severity, VolcanismType type)
        {
            var request = new BodiesRequest(systemName);

            var response = await Client.SendRequest<BodiesResponse>(request);

            var body = (Planet) response.bodies.Where(b => b.name == bodyName).Single();

            Assert.That(body.volcanismType.type, Is.EqualTo(type));
            Assert.That(body.volcanismType.severity, Is.EqualTo(severity));
        }

        [TestCase("Sol", "Jupiter", "", AtmosphereType.NoAtmosphere, TestName = "Atmosphere_NoAtmosphere")] // Yep, Jupiter has no atmosphere. You heard it here first.
        [TestCase("Sol", "Earth", "", AtmosphereType.SuitableForWaterBasedLife, TestName = "Atmosphere_SuitableForWaterBasedLife")]
        [TestCase("Kruger 60", "Kruger 60 A 1", "Thick", AtmosphereType.AmmoniaAndOxygen, TestName = "Atmosphere_AmmoniaAndOxygen")]
        [TestCase("Zhi", "Zhi 6", "Thin", AtmosphereType.Ammonia, TestName = "Atmosphere_Ammonia")]
        [TestCase("Alpha Centauri", "Eden", "Hot,Thick", AtmosphereType.Water, TestName = "Atmosphere_Water")]
        [TestCase("Sol", "Venus", "Hot,Thick", AtmosphereType.CarbonDioxide, TestName = "Atmosphere_CarbonDioxide")]
        [TestCase("Sol", "Io", "", AtmosphereType.SulphurDioxide, TestName = "Atmosphere_SulphurDioxide")]
        [TestCase("SPF-LF 1", "SPF-LF 1 1", "Thick", AtmosphereType.Nitrogen, TestName = "Atmosphere_Nitrogen")]
        [TestCase("Guangul", "Guangul 3", "Thick", AtmosphereType.WaterRich, TestName = "Atmosphere_WaterRich")]
        [TestCase("Sol", "Titan", "Thick", AtmosphereType.MethaneRich, TestName = "Atmosphere_MethaneRich")]
        [TestCase("Duamta", "Duamta 6", "Thick", AtmosphereType.AmmoniaRich, TestName = "Atmosphere_AmmoniaRich")]
        [TestCase("G 99-49", "G 99-49 2 a", "Thick", AtmosphereType.CarbonDioxideRich, TestName = "Atmosphere_CarbonDioxideRich")]
        [TestCase("Sol", "Pluto", "Thin", AtmosphereType.Methane, TestName = "Atmosphere_Methane")]
        [TestCase("Luhman 16", "Luhman 16 AB 1", "", AtmosphereType.Helium, TestName = "Atmosphere_Helium")]
        [TestCase("LAWD 26", "LAWD 26 B 1", "Hot,Thick", AtmosphereType.SilicateVapour, TestName = "Atmosphere_SilicateVapour")]
        [TestCase("WD 1207-032", "WD 1207-032 C 1", "Hot,Thick", AtmosphereType.MetallicVapour, TestName = "Atmosphere_MetallicVapour")]
        [TestCase("Ross 248", "Ross 248 A 3", "Thin", AtmosphereType.NeonRich, TestName = "Atmosphere_NeonRich")]
        [TestCase("SPF-LF 1", "SPF-LF 1 2", "", AtmosphereType.ArgonRich, TestName = "Atmosphere_ArgonRich")]
        [TestCase("Ross 248", "Ross 248 B 6", "Thin", AtmosphereType.Neon, TestName = "Atmosphere_Neon")]
        [TestCase("Luhman 16", "Luhman 16 B 3", "Thin", AtmosphereType.Argon, TestName = "Atmosphere_Argon")]
        [TestCase("LHS 200", "LHS 200 1 a", "Thin", AtmosphereType.Oxygen, TestName = "Atmosphere_Oxygen")]
        public async Task System_Body_Atmosphere_Success(string systemName, string bodyName, string description, AtmosphereType type)
        {
            var request = new BodiesRequest(systemName);

            var response = await Client.SendRequest<BodiesResponse>(request);

            var body = (Planet)response.bodies.Where(b => b.name == bodyName).Single();

            var expectedDescription = new List<AtmosphereDescriptor>();

            if (!string.IsNullOrWhiteSpace(description))
            {
                foreach (var descriptor in description.Split(","))
                {
                    expectedDescription.Add(Enum.Parse<AtmosphereDescriptor>(descriptor));
                }
            }

            Assert.That(body.atmosphereType.type, Is.EqualTo(type));
            Assert.That(body.atmosphereType.description, Is.EquivalentTo(expectedDescription));
        }

        [TestCase("Sol", "Neptune", Terraforming.NotTerraformable, TestName = "Terraforming_NotTerraformable")]
        [TestCase("Gliese 868", "Gliese 868 7", Terraforming.CandidateForTerraforming, TestName = "Terraforming_CandidateForTerraforming")]
        [TestCase("Agastani", "Agastani A 5", Terraforming.Terraforming, TestName = "Terraforming_Terraforming")]
        [TestCase("Sol", "Mars", Terraforming.Terraformed, TestName = "Terraforming_Terraformed")]
        public async Task System_Body_Volcanism_Success(string systemName, string bodyName, Terraforming terraforming)
        {
            var request = new BodiesRequest(systemName);

            var response = await Client.SendRequest<BodiesResponse>(request);

            var body = (Planet)response.bodies.Where(b => b.name == bodyName).Single();

            Assert.That(body.terraformingState, Is.EqualTo(terraforming));
        }

        //[TestCase("Sol", "Saturn", "D Ring", MiningType.Icy, 58071, 74500, 140180, Reserve.Common, TestName = "Common Ring")]
        //public async Task System_Body_Rings_Success(string systemName, string bodyName, string ringName, MiningType ringType, int mass, int minRadius, int maxRadius, Reserve reserves)
        //{
        //    var request = new BodiesRequest(systemName);

        //    var response = await Client.SendRequest<BodiesResponse>(request);

        //    var body = (Planet)response.bodies.Where(b => b.name == bodyName).Single();

        //    Assert.That(body.rings.Single().name, Is.EqualTo(ringName));
        //    Assert.That(body.rings.Single().type, Is.EqualTo(ringType));
        //    Assert.That(body.rings.Single().mass, Is.EqualTo(mass));
        //    Assert.That(body.rings.Single().innerRadius, Is.EqualTo(minRadius));
        //    Assert.That(body.rings.Single().outerRadius, Is.EqualTo(maxRadius));
        //    Assert.That(body.reserveLevel, Is.EqualTo(reserves));
        //}
    }
}
