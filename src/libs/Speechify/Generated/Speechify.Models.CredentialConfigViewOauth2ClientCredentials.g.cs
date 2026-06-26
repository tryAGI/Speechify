
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialConfigViewOauth2ClientCredentials(
            string tokenUrl,
            string clientId,
            bool clientSecretSet,
            global::System.Collections.Generic.IList<string>? scopes,
            string? audience)
        {
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.Scopes = scopes;
            this.Audience = audience;
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