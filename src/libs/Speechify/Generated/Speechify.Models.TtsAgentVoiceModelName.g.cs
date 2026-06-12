
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsAgentVoiceModelName
    {
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
    public static class TtsAgentVoiceModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsAgentVoiceModelName value)
        {
            return value switch
            {
                TtsAgentVoiceModelName.SimbaEnglish => "simba-english",
                TtsAgentVoiceModelName.SimbaMultilingual => "simba-multilingual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsAgentVoiceModelName? ToEnum(string value)
        {
            return value switch
            {
                "simba-english" => TtsAgentVoiceModelName.SimbaEnglish,
                "simba-multilingual" => TtsAgentVoiceModelName.SimbaMultilingual,
                _ => null,
            };
        }
    }
}