using Edsm.Sdk.Model.Edsm.Enums;
using Edsm.Sdk.Model.Edsm.Enums.Engineering;
using Edsm.Sdk.Model.Edsm.Enums.Planets;
using Edsm.Sdk.Model.Edsm.Types;
using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Types.Planets
{
    public class CustomDictionaryConverter<TKey, TValue> : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(Dictionary<TKey, TValue>);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            => serializer.Serialize(writer, ((Dictionary<TKey, TValue>)value).ToList());

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return null;
            }

            return serializer.Deserialize<KeyValuePair<TKey, TValue>[]>(reader).ToDictionary(kv => kv.Key, kv => kv.Value);
        }
    }

    public sealed class Planet : IBody
    {
        public string subType;
        public bool isLandable;
        //public double gravity;
        //public double earthMasses;
        //public double radius;
        //public double? surfacePressure;
        public Volcanism volcanismType;
        public Atmosphere atmosphereType;
        //[JsonConverter(typeof(CustomDictionaryConverter<AtmosphereConstituent, float>))]
        //public Dictionary<AtmosphereConstituent, float>? atmosphereComposition;
        //public Dictionary<SurfaceConstituent, float> solidComposition;
        public Terraforming? terraformingState;
        //public Dictionary<RawMaterial, float> materials;
        //public List<MineableRegion> rings;
        //public Reserve? reserveLevel;
    }
}
