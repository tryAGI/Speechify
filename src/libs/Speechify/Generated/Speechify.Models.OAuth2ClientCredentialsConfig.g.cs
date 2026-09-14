
#nullable enable

namespace Speechify
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
    public sealed partial class OAuth2ClientCredentialsConfig
    {
        /// <summary>
        /// The vendor's OAuth2 token endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenUrl { get; set; }

        /// <summary>
        /// The client id the vendor issued.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// The client secret the vendor issued. Accepted on create and rotate,<br/>
        /// never returned: a read shows `client_secret_set` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// The scopes to request, sent space-separated as the token request's<br/>
        /// `scope`. Omit when the vendor grants a fixed set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// The API the token is for, sent as the token request's `audience`,<br/>
        /// for vendors that require one. Omit otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

        /// <summary>
        /// How a client-credentials credential authenticates to its `token_url`<br/>
        /// when an access token is minted. `client_secret_post` sends `client_id`<br/>
        /// and `client_secret` as form parameters in the request body, and is what<br/>
        /// a credential that omits this field uses. `client_secret_basic` sends<br/>
        /// them in an HTTP Basic `Authorization` header instead (each value<br/>
        /// form-urlencoded first, as RFC 6749 section 2.3.1 specifies) and neither<br/>
        /// in the body. Most providers accept either; choose `client_secret_basic`<br/>
        /// when the provider's documentation says so.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.OAuth2TokenEndpointAuthMethodJsonConverter))]
        public global::Speechify.OAuth2TokenEndpointAuthMethod? TokenEndpointAuthMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2ClientCredentialsConfig" /> class.
        /// </summary>
        /// <param name="tokenUrl">
        /// The vendor's OAuth2 token endpoint.
        /// </param>
        /// <param name="clientId">
        /// The client id the vendor issued.
        /// </param>
        /// <param name="clientSecret">
        /// The client secret the vendor issued. Accepted on create and rotate,<br/>
        /// never returned: a read shows `client_secret_set` instead.
        /// </param>
        /// <param name="scopes">
        /// The scopes to request, sent space-separated as the token request's<br/>
        /// `scope`. Omit when the vendor grants a fixed set.
        /// </param>
        /// <param name="audience">
        /// The API the token is for, sent as the token request's `audience`,<br/>
        /// for vendors that require one. Omit otherwise.
        /// </param>
        /// <param name="tokenEndpointAuthMethod">
        /// How a client-credentials credential authenticates to its `token_url`<br/>
        /// when an access token is minted. `client_secret_post` sends `client_id`<br/>
        /// and `client_secret` as form parameters in the request body, and is what<br/>
        /// a credential that omits this field uses. `client_secret_basic` sends<br/>
        /// them in an HTTP Basic `Authorization` header instead (each value<br/>
        /// form-urlencoded first, as RFC 6749 section 2.3.1 specifies) and neither<br/>
        /// in the body. Most providers accept either; choose `client_secret_basic`<br/>
        /// when the provider's documentation says so.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuth2ClientCredentialsConfig(
            string tokenUrl,
            string clientId,
            string clientSecret,
            global::System.Collections.Generic.IList<string>? scopes,
            string? audience,
            global::Speechify.OAuth2TokenEndpointAuthMethod? tokenEndpointAuthMethod)
        {
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.Scopes = scopes;
            this.Audience = audience;
            this.TokenEndpointAuthMethod = tokenEndpointAuthMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2ClientCredentialsConfig" /> class.
        /// </summary>
        public OAuth2ClientCredentialsConfig()
        {
        }

    }
}