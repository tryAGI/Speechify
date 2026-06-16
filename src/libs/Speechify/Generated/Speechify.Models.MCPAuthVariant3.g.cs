
#nullable enable

namespace Speechify
{
    /// <summary>
    /// oauth2_client_credentials variant
    /// </summary>
    public sealed partial class MCPAuthVariant3
    {
        /// <summary>
        /// Discriminator value: oauth2_client_credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.MCPAuthVariant3TypeJsonConverter))]
        public global::Speechify.MCPAuthVariant3Type Type { get; set; }

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
        /// OAuth2 client_secret. Write-only — never echoed back on reads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// True when a client_secret is configured. Read-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret_set")]
        public bool? ClientSecretSet { get; set; }

        /// <summary>
        /// Optional scope claim sent on the token request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPAuthVariant3" /> class.
        /// </summary>
        /// <param name="tokenUrl"></param>
        /// <param name="clientId"></param>
        /// <param name="type">
        /// Discriminator value: oauth2_client_credentials
        /// </param>
        /// <param name="clientSecret">
        /// OAuth2 client_secret. Write-only — never echoed back on reads.
        /// </param>
        /// <param name="clientSecretSet">
        /// True when a client_secret is configured. Read-only.
        /// </param>
        /// <param name="scope">
        /// Optional scope claim sent on the token request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPAuthVariant3(
            string tokenUrl,
            string clientId,
            global::Speechify.MCPAuthVariant3Type type,
            string? clientSecret,
            bool? clientSecretSet,
            string? scope)
        {
            this.Type = type;
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret;
            this.ClientSecretSet = clientSecretSet;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPAuthVariant3" /> class.
        /// </summary>
        public MCPAuthVariant3()
        {
        }

    }
}