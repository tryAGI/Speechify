
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Discriminates the auth flow a credential carries. The matching<br/>
    /// `config.&lt;kind&gt;` block is the one that must be populated, and the only<br/>
    /// one.<br/>
    /// - `oauth2_client_credentials`: a `client_id` and `client_secret` the<br/>
    ///   platform exchanges at the vendor's `token_url` for a short-lived<br/>
    ///   access token (the OAuth2 client-credentials flow). Backs an `mcp` or<br/>
    ///   `openapi` tool whose `auth.type` is `oauth2_client_credentials`.<br/>
    /// - `bearer`: a static token sent as `Authorization: Bearer &lt;token&gt;`.<br/>
    ///   Backs an `mcp` or `openapi` tool whose `auth.type` is `bearer`, an<br/>
    ///   agent's custom LLM endpoint key, a custom model's key, and a<br/>
    ///   messaging channel's bot token.<br/>
    /// - `shared_secret`: a secret that is never sent anywhere; an inbound<br/>
    ///   callback's signature is verified against it, such as a messaging<br/>
    ///   channel's signing secret.<br/>
    /// - `oauth2_jwt`: a signing key for the JWT-bearer flow (RFC 7523).<br/>
    /// - `basic`: a username and password.<br/>
    /// - `custom_headers`: a set of header names and values.<br/>
    /// The vault stores `oauth2_jwt`, `basic` and `custom_headers`, but no<br/>
    /// tool auth type references them yet: an `mcp` or `openapi` tool<br/>
    /// authenticates with `bearer` or `oauth2_client_credentials` only.
    /// </summary>
    public enum CredentialKind
    {
        /// <summary>
        /// a username and password.
        /// </summary>
        Basic,
        /// <summary>
        /// a static token sent as `Authorization: Bearer &lt;token&gt;`.
        /// </summary>
        Bearer,
        /// <summary>
        /// a set of header names and values.
        /// </summary>
        CustomHeaders,
        /// <summary>
        /// a `client_id` and `client_secret` the
        /// </summary>
        Oauth2ClientCredentials,
        /// <summary>
        /// a signing key for the JWT-bearer flow (RFC 7523).
        /// </summary>
        Oauth2Jwt,
        /// <summary>
        /// a secret that is never sent anywhere; an inbound
        /// </summary>
        SharedSecret,
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
                CredentialKind.SharedSecret => "shared_secret",
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
                "shared_secret" => CredentialKind.SharedSecret,
                _ => null,
            };
        }
    }
}