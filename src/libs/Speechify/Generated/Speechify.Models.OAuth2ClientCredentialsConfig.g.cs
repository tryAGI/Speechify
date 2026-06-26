
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Static client_id + client_secret pair for the OAuth2<br/>
    /// client-credentials flow. The tool runtime mints an access token<br/>
    /// at request time and caches it per credential id.
    /// </summary>
    public sealed partial class OAuth2ClientCredentialsConfig
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
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2ClientCredentialsConfig" /> class.
        /// </summary>
        /// <param name="tokenUrl"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="scopes"></param>
        /// <param name="audience"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuth2ClientCredentialsConfig(
            string tokenUrl,
            string clientId,
            string clientSecret,
            global::System.Collections.Generic.IList<string>? scopes,
            string? audience)
        {
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.Scopes = scopes;
            this.Audience = audience;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2ClientCredentialsConfig" /> class.
        /// </summary>
        public OAuth2ClientCredentialsConfig()
        {
        }

    }
}