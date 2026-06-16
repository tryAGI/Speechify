
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatedVoiceGender
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
    public static class CreatedVoiceGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatedVoiceGender value)
        {
            return value switch
            {
                CreatedVoiceGender.Female => "female",
                CreatedVoiceGender.Male => "male",
                CreatedVoiceGender.NotSpecified => "notSpecified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatedVoiceGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => CreatedVoiceGender.Female,
                "male" => CreatedVoiceGender.Male,
                "notSpecified" => CreatedVoiceGender.NotSpecified,
                _ => null,
            };
        }
    }
}