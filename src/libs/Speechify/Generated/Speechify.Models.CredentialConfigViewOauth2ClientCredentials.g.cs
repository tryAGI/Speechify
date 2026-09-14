
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CredentialConfigViewOauth2ClientCredentials
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        ///
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
        /// Whether a client secret is stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret_set")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ClientSecretSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigViewOauth2ClientCredentials" /> class.
        /// </summary>
        /// <param name="tokenUrl"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecretSet">
        /// Whether a client secret is stored.
        /// </param>
        /// <param name="scopes"></param>
        /// <param name="audience"></param>
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
        public CredentialConfigViewOauth2ClientCredentials(
            string tokenUrl,
            string clientId,
            bool clientSecretSet,
            global::System.Collections.Generic.IList<string>? scopes,
            string? audience,
            global::Speechify.OAuth2TokenEndpointAuthMethod? tokenEndpointAuthMethod)
        {
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.Scopes = scopes;
            this.Audience = audience;
            this.TokenEndpointAuthMethod = tokenEndpointAuthMethod;
            this.ClientSecretSet = clientSecretSet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigViewOauth2ClientCredentials" /> class.
        /// </summary>
        public CredentialConfigViewOauth2ClientCredentials()
        {
        }

    }
}