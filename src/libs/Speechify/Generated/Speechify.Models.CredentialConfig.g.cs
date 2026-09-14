
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Kind-specific credential payload, used on WRITES only (create and<br/>
    /// rotate). Exactly one block is populated — the one named by the<br/>
    /// credential's `kind`. The secret fields are write-only: they are<br/>
    /// accepted here but are NEVER returned on reads — a read returns the<br/>
    /// masked `CredentialConfigView` instead.
    /// </summary>
    public sealed partial class CredentialConfig
    {
        /// <summary>
        /// A `client_id` and `client_secret` for the OAuth2 client-credentials<br/>
        /// flow. When a call needs a token, the platform POSTs<br/>
        /// `grant_type=client_credentials` to `token_url`, with `scope` and<br/>
        /// `audience` when they are set, authenticating the way<br/>
        /// `token_endpoint_auth_method` says. It sends the access token that<br/>
        /// comes back as `Authorization: Bearer &lt;token&gt;` and reuses it until it<br/>
        /// nears expiry; rotating the secret mints a fresh one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2_client_credentials")]
        public global::Speechify.OAuth2ClientCredentialsConfig? Oauth2ClientCredentials { get; set; }

        /// <summary>
        /// Issuer, audience, and signing key for the JWT-bearer flow<br/>
        /// (RFC 7523) — e.g. Google service accounts that exchange a<br/>
        /// signed JWT for an access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2_jwt")]
        public global::Speechify.OAuth2JWTConfig? Oauth2Jwt { get; set; }

        /// <summary>
        /// HTTP Basic auth — username + password.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basic")]
        public global::Speechify.BasicAuthConfig? Basic { get; set; }

        /// <summary>
        /// A static bearer token sent as `Authorization: Bearer …`. For<br/>
        /// rotating tokens prefer one of the oauth2 kinds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bearer")]
        public global::Speechify.BearerAuthConfig? Bearer { get; set; }

        /// <summary>
        /// An arbitrary set of headers sent on every outbound tool<br/>
        /// request. Useful for vendor signature schemes that don't fit<br/>
        /// Basic / Bearer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_headers")]
        public global::Speechify.CustomHeadersConfig? CustomHeaders { get; set; }

        /// <summary>
        /// One pre-shared secret. Unlike every other credential kind it is never<br/>
        /// placed on an outbound request: it is the key an INBOUND callback's<br/>
        /// signature is verified against, which is how a messaging provider<br/>
        /// authenticates itself to a channel front door.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_secret")]
        public global::Speechify.SharedSecretConfig? SharedSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfig" /> class.
        /// </summary>
        /// <param name="oauth2ClientCredentials">
        /// A `client_id` and `client_secret` for the OAuth2 client-credentials<br/>
        /// flow. When a call needs a token, the platform POSTs<br/>
        /// `grant_type=client_credentials` to `token_url`, with `scope` and<br/>
        /// `audience` when they are set, authenticating the way<br/>
        /// `token_endpoint_auth_method` says. It sends the access token that<br/>
        /// comes back as `Authorization: Bearer &lt;token&gt;` and reuses it until it<br/>
        /// nears expiry; rotating the secret mints a fresh one.
        /// </param>
        /// <param name="oauth2Jwt">
        /// Issuer, audience, and signing key for the JWT-bearer flow<br/>
        /// (RFC 7523) — e.g. Google service accounts that exchange a<br/>
        /// signed JWT for an access token.
        /// </param>
        /// <param name="basic">
        /// HTTP Basic auth — username + password.
        /// </param>
        /// <param name="bearer">
        /// A static bearer token sent as `Authorization: Bearer …`. For<br/>
        /// rotating tokens prefer one of the oauth2 kinds.
        /// </param>
        /// <param name="customHeaders">
        /// An arbitrary set of headers sent on every outbound tool<br/>
        /// request. Useful for vendor signature schemes that don't fit<br/>
        /// Basic / Bearer.
        /// </param>
        /// <param name="sharedSecret">
        /// One pre-shared secret. Unlike every other credential kind it is never<br/>
        /// placed on an outbound request: it is the key an INBOUND callback's<br/>
        /// signature is verified against, which is how a messaging provider<br/>
        /// authenticates itself to a channel front door.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialConfig(
            global::Speechify.OAuth2ClientCredentialsConfig? oauth2ClientCredentials,
            global::Speechify.OAuth2JWTConfig? oauth2Jwt,
            global::Speechify.BasicAuthConfig? basic,
            global::Speechify.BearerAuthConfig? bearer,
            global::Speechify.CustomHeadersConfig? customHeaders,
            global::Speechify.SharedSecretConfig? sharedSecret)
        {
            this.Oauth2ClientCredentials = oauth2ClientCredentials;
            this.Oauth2Jwt = oauth2Jwt;
            this.Basic = basic;
            this.Bearer = bearer;
            this.CustomHeaders = customHeaders;
            this.SharedSecret = sharedSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfig" /> class.
        /// </summary>
        public CredentialConfig()
        {
        }

    }
}