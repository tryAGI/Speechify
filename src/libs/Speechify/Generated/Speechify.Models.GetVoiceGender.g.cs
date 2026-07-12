
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetVoiceGender
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
    public static class GetVoiceGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVoiceGender value)
        {
            return value switch
            {
                GetVoiceGender.Female => "female",
                GetVoiceGender.Male => "male",
                GetVoiceGender.NotSpecified => "not_specified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVoiceGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => GetVoiceGender.Female,
                "male" => GetVoiceGender.Male,
                "not_specified" => GetVoiceGender.NotSpecified,
                _ => null,
            };
        }
    }
}