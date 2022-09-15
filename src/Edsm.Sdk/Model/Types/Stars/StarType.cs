using Edsm.Sdk.Model.Edsm.Enums.Stars;
using Newtonsoft.Json;

namespace Edsm.Sdk.Model.Types.Stars
{
    public class StarTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader?.Value?.ToString()
                ?.Replace(" Star", "")
                ?.Replace("type", "")
                ?.Replace("(", "")
                ?.Replace(")", "")
                ?.Replace("-", "")
                ?.Replace("super giant", "supergiant")
                ?.Split(' ');

            if (value == null || value.Length == 0)
            {
                throw new Exception();
            }

            if (!StarTypeParser.IsExoticObject(value))
            {
                return StarTypeParser.ParseNonExoticObject(value);
            }
            else
            {
                return StarTypeParser.ParseExoticObject(value);
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(StarType) || objectType == typeof(string);
        }
    }

    public static class StarTypeParser
    {
        private static readonly IReadOnlyList<string> NonExoticClasses = new List<string> { "O", "B", "A", "F", "G", "K", "M", "MS", "S", "L", "T", "Y" }.AsReadOnly();

        public static bool IsExoticObject(string[] description)
        {
            var spectralClass = description[0];

            // T Tauri looks like a T class, but it actually isn't so we have some special handling
            if (description.Length > 1 && description[1] == "Tauri")
            {
                return true;
            }

            return !NonExoticClasses.Contains(spectralClass);
        }

        public static StarType ParseNonExoticObject(string[] description)
        {
            SpectralClass spectralClass;
            var colorClass = ColorClass.Unspecified;
            var massClass = MassClass.Unspecified;

            var spectralClassParseSuccess = Enum.TryParse(description[0], true, out spectralClass);

            if (!spectralClassParseSuccess)
            {
                throw new Exception();
            }

            foreach (var component in description.Skip(1))
            {
                var colorClassParseSuccess = Enum.TryParse<ColorClass>(component, true, out var colorClassTemp);

                if (colorClassParseSuccess)
                {
                    colorClass = colorClassTemp;
                    continue;
                }

                var massClassParseSuccess = Enum.TryParse<MassClass>(component, true, out var massClassTemp);

                if (massClassParseSuccess)
                {
                    massClass = massClassTemp;
                    continue;
                }

                throw new Exception();
            }

            var fullSpectralClass = new MorganKeenanSpectralClass
            {
                spectralClass = spectralClass,
                exoticClass = ExoticClass.None
            };

            return new StarType(fullSpectralClass, massClass, colorClass);
        }

        public static StarType ParseExoticObject(string[] description)
        {
            SpectralClass spectralClass;
            ExoticClass exoticClass;

            var colorClass = ColorClass.Unspecified;
            var massClass = MassClass.Unspecified;

            if (description[0].StartsWith('C'))
            {
                spectralClass = SpectralClass.C;
                exoticClass = Enum.Parse<ExoticClass>(description[0], true);
            }
            else
            {
                switch (description[0])
                {
                    case "T":
                        spectralClass = SpectralClass.Unknown;
                        exoticClass = ExoticClass.TTauri;
                        break;
                    case "Herbig":
                        spectralClass = SpectralClass.Unknown;
                        exoticClass = ExoticClass.HerbigAeBe;
                        break;
                    case "WolfRayet":
                        spectralClass = SpectralClass.WolfRayet;
                        exoticClass = Enum.Parse<ExoticClass>($"W{(description.Length > 1 ? description[1] : string.Empty)}", true);
                        break;
                    case "White":
                        spectralClass = SpectralClass.D;
                        colorClass = ColorClass.White;
                        massClass = MassClass.Dwarf;
                        exoticClass = Enum.Parse<ExoticClass>(description[2], true);
                        break;
                    case "Neutron":
                        spectralClass = SpectralClass.D;
                        exoticClass = ExoticClass.Neutron;
                        break;
                    case "Black":
                        spectralClass = SpectralClass.D;
                        exoticClass = ExoticClass.BlackHole;
                        break;
                    default:
                        throw new Exception();
                }
            }

            var fullSpectralClass = new MorganKeenanSpectralClass
            {
                spectralClass = spectralClass,
                exoticClass = exoticClass
            };

            return new StarType(fullSpectralClass, massClass, colorClass);
        }
    }

    [JsonConverter(typeof(StarTypeConverter))]
    public class StarType
    {
        public readonly MorganKeenanSpectralClass spectralClass;
        public readonly MassClass massClass;
        public readonly ColorClass colorClass;

        public StarType(MorganKeenanSpectralClass spectralClass, MassClass massClass, ColorClass colorClass)
        {
            this.spectralClass = spectralClass;
            this.massClass = massClass;
            this.colorClass = colorClass;
        }
    }
}
