
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum V1VoicesGetParametersGender
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
    public static class V1VoicesGetParametersGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1VoicesGetParametersGender value)
        {
            return value switch
            {
                V1VoicesGetParametersGender.Female => "female",
                V1VoicesGetParametersGender.Male => "male",
                V1VoicesGetParametersGender.NotSpecified => "not_specified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1VoicesGetParametersGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => V1VoicesGetParametersGender.Female,
                "male" => V1VoicesGetParametersGender.Male,
                "not_specified" => V1VoicesGetParametersGender.NotSpecified,
                _ => null,
            };
        }
    }
}