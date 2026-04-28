
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsGetVoiceGender
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
    public static class TtsGetVoiceGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsGetVoiceGender value)
        {
            return value switch
            {
                TtsGetVoiceGender.Female => "female",
                TtsGetVoiceGender.Male => "male",
                TtsGetVoiceGender.NotSpecified => "notSpecified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsGetVoiceGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => TtsGetVoiceGender.Female,
                "male" => TtsGetVoiceGender.Male,
                "notSpecified" => TtsGetVoiceGender.NotSpecified,
                _ => null,
            };
        }
    }
}