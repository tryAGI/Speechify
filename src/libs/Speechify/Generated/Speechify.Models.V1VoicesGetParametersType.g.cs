
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum V1VoicesGetParametersType
    {
        /// <summary>
        ///
        /// </summary>
        Personal,
        /// <summary>
        ///
        /// </summary>
        Shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1VoicesGetParametersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1VoicesGetParametersType value)
        {
            return value switch
            {
                V1VoicesGetParametersType.Personal => "personal",
                V1VoicesGetParametersType.Shared => "shared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1VoicesGetParametersType? ToEnum(string value)
        {
            return value switch
            {
                "personal" => V1VoicesGetParametersType.Personal,
                "shared" => V1VoicesGetParametersType.Shared,
                _ => null,
            };
        }
    }
}