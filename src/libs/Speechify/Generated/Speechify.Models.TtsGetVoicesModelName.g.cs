
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsGetVoicesModelName
    {
        /// <summary>
        /// 
        /// </summary>
        Simba30,
        /// <summary>
        /// 
        /// </summary>
        SimbaEnglish,
        /// <summary>
        /// 
        /// </summary>
        SimbaMultilingual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsGetVoicesModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsGetVoicesModelName value)
        {
            return value switch
            {
                TtsGetVoicesModelName.Simba30 => "simba-3.0",
                TtsGetVoicesModelName.SimbaEnglish => "simba-english",
                TtsGetVoicesModelName.SimbaMultilingual => "simba-multilingual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsGetVoicesModelName? ToEnum(string value)
        {
            return value switch
            {
                "simba-3.0" => TtsGetVoicesModelName.Simba30,
                "simba-english" => TtsGetVoicesModelName.SimbaEnglish,
                "simba-multilingual" => TtsGetVoicesModelName.SimbaMultilingual,
                _ => null,
            };
        }
    }
}