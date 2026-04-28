
#nullable enable

namespace Speechify
{
    /// <summary>
    /// in: body
    /// </summary>
    public enum TtsCreateAccessTokenRequestGrantType
    {
        /// <summary>
        /// 
        /// </summary>
        ClientCredentials,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsCreateAccessTokenRequestGrantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsCreateAccessTokenRequestGrantType value)
        {
            return value switch
            {
                TtsCreateAccessTokenRequestGrantType.ClientCredentials => "client_credentials",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsCreateAccessTokenRequestGrantType? ToEnum(string value)
        {
            return value switch
            {
                "client_credentials" => TtsCreateAccessTokenRequestGrantType.ClientCredentials,
                _ => null,
            };
        }
    }
}