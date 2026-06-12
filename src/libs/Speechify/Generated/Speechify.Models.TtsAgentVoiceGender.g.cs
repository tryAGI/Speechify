
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Speaker gender as classified by VMS. `notSpecified` is used<br/>
    /// when the source dataset didn't carry the metadata; the<br/>
    /// console treats it as a neutral display label rather than a<br/>
    /// filter gap.
    /// </summary>
    public enum TtsAgentVoiceGender
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
    public static class TtsAgentVoiceGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsAgentVoiceGender value)
        {
            return value switch
            {
                TtsAgentVoiceGender.Female => "female",
                TtsAgentVoiceGender.Male => "male",
                TtsAgentVoiceGender.NotSpecified => "notSpecified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsAgentVoiceGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => TtsAgentVoiceGender.Female,
                "male" => TtsAgentVoiceGender.Male,
                "notSpecified" => TtsAgentVoiceGender.NotSpecified,
                _ => null,
            };
        }
    }
}