
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Discriminates the auth flow a credential carries. The matching<br/>
    /// `config.&lt;kind&gt;` block is the one that must be populated.
    /// </summary>
    public enum CredentialKind
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
        /// <summary>
        /// 
        /// </summary>
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        CustomHeaders,
        /// <summary>
        /// 
        /// </summary>
        Oauth2ClientCredentials,
        /// <summary>
        /// 
        /// </summary>
        Oauth2Jwt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CredentialKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CredentialKind value)
        {
            return value switch
            {
                CredentialKind.Basic => "basic",
                CredentialKind.Bearer => "bearer",
                CredentialKind.CustomHeaders => "custom_headers",
                CredentialKind.Oauth2ClientCredentials => "oauth2_client_credentials",
                CredentialKind.Oauth2Jwt => "oauth2_jwt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CredentialKind? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CredentialKind.Basic,
                "bearer" => CredentialKind.Bearer,
                "custom_headers" => CredentialKind.CustomHeaders,
                "oauth2_client_credentials" => CredentialKind.Oauth2ClientCredentials,
                "oauth2_jwt" => CredentialKind.Oauth2Jwt,
                _ => null,
            };
        }
    }
}