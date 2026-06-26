
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialConfigViewOauth2Jwt
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
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Issuer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        public string? KeyId { get; set; }

        /// <summary>
        /// Whether a signing key is stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_key_set")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PrivateKeySet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigViewOauth2Jwt" /> class.
        /// </summary>
        /// <param name="tokenUrl"></param>
        /// <param name="issuer"></param>
        /// <param name="audience"></param>
        /// <param name="privateKeySet">
        /// Whether a signing key is stored.
        /// </param>
        /// <param name="subject"></param>
        /// <param name="scopes"></param>
        /// <param name="keyId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialConfigViewOauth2Jwt(
            string tokenUrl,
            string issuer,
            string audience,
            bool privateKeySet,
            string? subject,
            global::System.Collections.Generic.IList<string>? scopes,
            string? keyId)
        {
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            this.Issuer = issuer ?? throw new global::System.ArgumentNullException(nameof(issuer));
            this.Subject = subject;
            this.Audience = audience ?? throw new global::System.ArgumentNullException(nameof(audience));
            this.Scopes = scopes;
            this.KeyId = keyId;
            this.PrivateKeySet = privateKeySet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigViewOauth2Jwt" /> class.
        /// </summary>
        public CredentialConfigViewOauth2Jwt()
        {
        }

    }
}