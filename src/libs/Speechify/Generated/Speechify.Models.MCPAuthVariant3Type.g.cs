
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Discriminator value: oauth2_client_credentials
    /// </summary>
    public enum MCPAuthVariant3Type
    {
        /// <summary>
        /// oauth2_client_credentials
        /// </summary>
        Oauth2ClientCredentials,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPAuthVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPAuthVariant3Type value)
        {
            return value switch
            {
                MCPAuthVariant3Type.Oauth2ClientCredentials => "oauth2_client_credentials",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPAuthVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "oauth2_client_credentials" => MCPAuthVariant3Type.Oauth2ClientCredentials,
                _ => null,
            };
        }
    }
}