
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsCreateVoiceModelName
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
    public static class TtsCreateVoiceModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsCreateVoiceModelName value)
        {
            return value switch
            {
                TtsCreateVoiceModelName.Simba30 => "simba-3.0",
                TtsCreateVoiceModelName.SimbaEnglish => "simba-english",
                TtsCreateVoiceModelName.SimbaMultilingual => "simba-multilingual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsCreateVoiceModelName? ToEnum(string value)
        {
            return value switch
            {
                "simba-3.0" => TtsCreateVoiceModelName.Simba30,
                "simba-english" => TtsCreateVoiceModelName.SimbaEnglish,
                "simba-multilingual" => TtsCreateVoiceModelName.SimbaMultilingual,
                _ => null,
            };
        }
    }
}