
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateHostedApiRequestAuthMode
    {
        /// <summary>
        ///
        /// </summary>
        ConsumerKey,
        /// <summary>
        ///
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateHostedApiRequestAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateHostedApiRequestAuthMode value)
        {
            return value switch
            {
                UpdateHostedApiRequestAuthMode.ConsumerKey => "consumer_key",
                UpdateHostedApiRequestAuthMode.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateHostedApiRequestAuthMode? ToEnum(string value)
        {
            return value switch
            {
                "consumer_key" => UpdateHostedApiRequestAuthMode.ConsumerKey,
                "public" => UpdateHostedApiRequestAuthMode.Public,
                _ => null,
            };
        }
    }
}