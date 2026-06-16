
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentVoiceModelName
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
    public static class AgentVoiceModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentVoiceModelName value)
        {
            return value switch
            {
                AgentVoiceModelName.SimbaEnglish => "simba-english",
                AgentVoiceModelName.SimbaMultilingual => "simba-multilingual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentVoiceModelName? ToEnum(string value)
        {
            return value switch
            {
                "simba-english" => AgentVoiceModelName.SimbaEnglish,
                "simba-multilingual" => AgentVoiceModelName.SimbaMultilingual,
                _ => null,
            };
        }
    }
}