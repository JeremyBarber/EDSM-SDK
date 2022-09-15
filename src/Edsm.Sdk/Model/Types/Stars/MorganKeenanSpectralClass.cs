using Edsm.Sdk.Model.Edsm.Enums;
using Edsm.Sdk.Model.Edsm.Enums.Stars;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edsm.Sdk.Model.Types.Stars
{
    public class MorganKeenanSpectralClassConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader?.Value?.ToString();

            if (value == null || value.Length == 0)
            {
                return null;
            }

            var spectralClass = SpectralClass.Unknown;
            var exoticClass = ExoticClass.None;

            var classString = "";
            if (char.IsDigit(value.Last()))
            {
                classString = new string(value.Take(value.Length - 1).ToArray());
            }
            else
            {
                classString = value;
            }

            var spectralClassSuccess = Enum.TryParse<SpectralClass>(classString, out spectralClass);

            if (!spectralClassSuccess)
            {
                switch (classString)
                {
                    case "TTS":
                        spectralClass = SpectralClass.Unknown;
                        exoticClass = ExoticClass.TTauri;
                        break;
                    case "AeBe":
                        spectralClass = SpectralClass.Unknown;
                        exoticClass = ExoticClass.HerbigAeBe;
                        break;
                    default:
                        throw new Exception();
                }
            }

            int? subClass = null;
            if (value.Length > 1)
            {
                subClass = int.Parse(value.Last().ToString());
            }

            return new MorganKeenanSpectralClass
            {
                spectralClass = spectralClass,
                exoticClass = exoticClass,
                spectralSubClass = subClass
            };
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(StarType) || objectType == typeof(string);
        }
    }

    [JsonConverter(typeof(MorganKeenanSpectralClassConverter))]
    public class MorganKeenanSpectralClass
    {
        public SpectralClass spectralClass;
        public ExoticClass exoticClass;
        public int? spectralSubClass;
    }
}
