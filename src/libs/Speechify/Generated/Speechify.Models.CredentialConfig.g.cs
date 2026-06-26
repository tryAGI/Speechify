
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Kind-specific credential payload. Exactly one block is<br/>
    /// populated — the one named by the credential's `kind`. The<br/>
    /// block IS the secret; it is echoed back decrypted on reads.
    /// </summary>
    public sealed partial class CredentialConfig
    {
        /// <summary>
        /// Static client_id + client_secret pair for the OAuth2<br/>
        /// client-credentials flow. The tool runtime mints an access token<br/>
        /// at request time and caches it per credential id.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfig" /> class.
        /// </summary>
        /// <param name="oauth2ClientCredentials">
        /// Static client_id + client_secret pair for the OAuth2<br/>
        /// client-credentials flow. The tool runtime mints an access token<br/>
        /// at request time and caches it per credential id.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialConfig(
            global::Speechify.OAuth2ClientCredentialsConfig? oauth2ClientCredentials,
            global::Speechify.OAuth2JWTConfig? oauth2Jwt,
            global::Speechify.BasicAuthConfig? basic,
            global::Speechify.BearerAuthConfig? bearer,
            global::Speechify.CustomHeadersConfig? customHeaders)
        {
            this.Oauth2ClientCredentials = oauth2ClientCredentials;
            this.Oauth2Jwt = oauth2Jwt;
            this.Basic = basic;
            this.Bearer = bearer;
            this.CustomHeaders = customHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfig" /> class.
        /// </summary>
        public CredentialConfig()
        {
        }

    }
}