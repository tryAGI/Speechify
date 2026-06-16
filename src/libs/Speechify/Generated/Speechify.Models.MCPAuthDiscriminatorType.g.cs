
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum MCPAuthDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Oauth2ClientCredentials,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPAuthDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPAuthDiscriminatorType value)
        {
            return value switch
            {
                MCPAuthDiscriminatorType.Bearer => "bearer",
                MCPAuthDiscriminatorType.None => "none",
                MCPAuthDiscriminatorType.Oauth2ClientCredentials => "oauth2_client_credentials",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPAuthDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => MCPAuthDiscriminatorType.Bearer,
                "none" => MCPAuthDiscriminatorType.None,
                "oauth2_client_credentials" => MCPAuthDiscriminatorType.Oauth2ClientCredentials,
                _ => null,
            };
        }
    }
}