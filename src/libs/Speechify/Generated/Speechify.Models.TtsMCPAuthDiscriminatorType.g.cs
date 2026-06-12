
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsMCPAuthDiscriminatorType
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
    public static class TtsMCPAuthDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsMCPAuthDiscriminatorType value)
        {
            return value switch
            {
                TtsMCPAuthDiscriminatorType.Bearer => "bearer",
                TtsMCPAuthDiscriminatorType.None => "none",
                TtsMCPAuthDiscriminatorType.Oauth2ClientCredentials => "oauth2_client_credentials",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsMCPAuthDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => TtsMCPAuthDiscriminatorType.Bearer,
                "none" => TtsMCPAuthDiscriminatorType.None,
                "oauth2_client_credentials" => TtsMCPAuthDiscriminatorType.Oauth2ClientCredentials,
                _ => null,
            };
        }
    }
}