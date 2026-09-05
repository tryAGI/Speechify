
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HostedAPIKey
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The masked secret shown on every read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_hint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyHint { get; set; }

        /// <summary>
        /// Requests per minute this key may make; 0 is unlimited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_per_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RatePerMinute { get; set; }

        /// <summary>
        /// The plaintext key, present on the create response only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked_at")]
        public global::System.DateTime? RevokedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIKey" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apiId"></param>
        /// <param name="name"></param>
        /// <param name="keyHint">
        /// The masked secret shown on every read.
        /// </param>
        /// <param name="ratePerMinute">
        /// Requests per minute this key may make; 0 is unlimited.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="secret">
        /// The plaintext key, present on the create response only.
        /// </param>
        /// <param name="revokedAt"></param>
        /// <param name="lastUsedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedAPIKey(
            string id,
            string apiId,
            string name,
            string keyHint,
            int ratePerMinute,
            global::System.DateTime createdAt,
            string? secret,
            global::System.DateTime? revokedAt,
            global::System.DateTime? lastUsedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApiId = apiId ?? throw new global::System.ArgumentNullException(nameof(apiId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.KeyHint = keyHint ?? throw new global::System.ArgumentNullException(nameof(keyHint));
            this.RatePerMinute = ratePerMinute;
            this.Secret = secret;
            this.RevokedAt = revokedAt;
            this.LastUsedAt = lastUsedAt;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIKey" /> class.
        /// </summary>
        public HostedAPIKey()
        {
        }

    }
}