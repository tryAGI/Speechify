
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The workspace's contact-resolver configuration: the endpoint asked to<br/>
    /// identify an inbound caller at session start.
    /// </summary>
    public sealed partial class ContactResolver
    {
        /// <summary>
        /// The HTTPS endpoint Speechify POSTs the identifier to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// When true the endpoint is kept but never called, which is how you<br/>
        /// park an integration without losing its secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Disabled { get; set; }

        /// <summary>
        /// The HMAC signing key, present ONLY in the response that mints it<br/>
        /// (first configuration, or a rotation). Verify<br/>
        /// `Speechify-Signature` with it exactly as you would a webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactResolver" /> class.
        /// </summary>
        /// <param name="url">
        /// The HTTPS endpoint Speechify POSTs the identifier to.
        /// </param>
        /// <param name="disabled">
        /// When true the endpoint is kept but never called, which is how you<br/>
        /// park an integration without losing its secret.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="secret">
        /// The HMAC signing key, present ONLY in the response that mints it<br/>
        /// (first configuration, or a rotation). Verify<br/>
        /// `Speechify-Signature` with it exactly as you would a webhook.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactResolver(
            string url,
            bool disabled,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? secret)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Disabled = disabled;
            this.Secret = secret;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactResolver" /> class.
        /// </summary>
        public ContactResolver()
        {
        }

    }
}