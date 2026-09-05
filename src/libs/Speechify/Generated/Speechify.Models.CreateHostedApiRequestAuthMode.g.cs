
#nullable enable

namespace Speechify
{
    /// <summary>
    /// consumer_key when omitted.
    /// </summary>
    public enum CreateHostedApiRequestAuthMode
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
    public static class CreateHostedApiRequestAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateHostedApiRequestAuthMode value)
        {
            return value switch
            {
                CreateHostedApiRequestAuthMode.ConsumerKey => "consumer_key",
                CreateHostedApiRequestAuthMode.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateHostedApiRequestAuthMode? ToEnum(string value)
        {
            return value switch
            {
                "consumer_key" => CreateHostedApiRequestAuthMode.ConsumerKey,
                "public" => CreateHostedApiRequestAuthMode.Public,
                _ => null,
            };
        }
    }
}