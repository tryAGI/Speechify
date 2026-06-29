
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Speaker gender classification for the voice. `not_specified` is<br/>
    /// used when the source dataset didn't carry the metadata; treat it<br/>
    /// as a neutral display label rather than a filter gap.
    /// </summary>
    public enum AgentVoiceGender
    {
        /// <summary>
        /// 
        /// </summary>
        Female,
        /// <summary>
        /// 
        /// </summary>
        Male,
        /// <summary>
        /// 
        /// </summary>
        NotSpecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentVoiceGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentVoiceGender value)
        {
            return value switch
            {
                AgentVoiceGender.Female => "female",
                AgentVoiceGender.Male => "male",
                AgentVoiceGender.NotSpecified => "not_specified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentVoiceGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => AgentVoiceGender.Female,
                "male" => AgentVoiceGender.Male,
                "not_specified" => AgentVoiceGender.NotSpecified,
                _ => null,
            };
        }
    }
}