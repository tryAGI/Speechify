
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsCreatedVoiceGender
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
    public static class TtsCreatedVoiceGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsCreatedVoiceGender value)
        {
            return value switch
            {
                TtsCreatedVoiceGender.Female => "female",
                TtsCreatedVoiceGender.Male => "male",
                TtsCreatedVoiceGender.NotSpecified => "notSpecified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsCreatedVoiceGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => TtsCreatedVoiceGender.Female,
                "male" => TtsCreatedVoiceGender.Male,
                "notSpecified" => TtsCreatedVoiceGender.NotSpecified,
                _ => null,
            };
        }
    }
}