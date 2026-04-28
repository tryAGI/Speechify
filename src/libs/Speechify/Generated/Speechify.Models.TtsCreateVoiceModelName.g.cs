
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
        SimbaBase,
        /// <summary>
        /// 
        /// </summary>
        SimbaEnglish,
        /// <summary>
        /// 
        /// </summary>
        SimbaMultilingual,
        /// <summary>
        /// 
        /// </summary>
        SimbaTurbo,
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
                TtsCreateVoiceModelName.SimbaBase => "simba-base",
                TtsCreateVoiceModelName.SimbaEnglish => "simba-english",
                TtsCreateVoiceModelName.SimbaMultilingual => "simba-multilingual",
                TtsCreateVoiceModelName.SimbaTurbo => "simba-turbo",
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
                "simba-base" => TtsCreateVoiceModelName.SimbaBase,
                "simba-english" => TtsCreateVoiceModelName.SimbaEnglish,
                "simba-multilingual" => TtsCreateVoiceModelName.SimbaMultilingual,
                "simba-turbo" => TtsCreateVoiceModelName.SimbaTurbo,
                _ => null,
            };
        }
    }
}