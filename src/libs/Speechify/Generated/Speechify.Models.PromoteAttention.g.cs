
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One thing the promote could not finish on its own.
    /// </summary>
    public sealed partial class PromoteAttention
    {
        /// <summary>
        /// The kind of resource the entry names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.PromoteAttentionKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.PromoteAttentionKind Kind { get; set; }

        /// <summary>
        /// The resource's prefixed external id; a target id except for `audio_asset_not_copied`, which names the source asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Stable code a client can branch on. `credential_not_attached`: the<br/>
        /// source referenced a vault credential, which never travels.<br/>
        /// `webhook_secret_reminted`: a fresh signing secret was minted; rotate<br/>
        /// to read it. `webhook_secret_not_copied`: the agent's customer-set<br/>
        /// post-call secret was cleared. `renamed`: the copy took a suffixed<br/>
        /// name. `phone_number_not_copied`: the source agent had numbers bound.<br/>
        /// `documents_not_copied`: the knowledge base held uploaded or pasted<br/>
        /// documents. `import_not_requeued`: URL sources could not be queued.<br/>
        /// `audio_asset_not_copied`: no asset storage is configured here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.PromoteAttentionReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.PromoteAttentionReason Reason { get; set; }

        /// <summary>
        /// Human-readable detail for the entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteAttention" /> class.
        /// </summary>
        /// <param name="kind">
        /// The kind of resource the entry names.
        /// </param>
        /// <param name="id">
        /// The resource's prefixed external id; a target id except for `audio_asset_not_copied`, which names the source asset.
        /// </param>
        /// <param name="reason">
        /// Stable code a client can branch on. `credential_not_attached`: the<br/>
        /// source referenced a vault credential, which never travels.<br/>
        /// `webhook_secret_reminted`: a fresh signing secret was minted; rotate<br/>
        /// to read it. `webhook_secret_not_copied`: the agent's customer-set<br/>
        /// post-call secret was cleared. `renamed`: the copy took a suffixed<br/>
        /// name. `phone_number_not_copied`: the source agent had numbers bound.<br/>
        /// `documents_not_copied`: the knowledge base held uploaded or pasted<br/>
        /// documents. `import_not_requeued`: URL sources could not be queued.<br/>
        /// `audio_asset_not_copied`: no asset storage is configured here.
        /// </param>
        /// <param name="message">
        /// Human-readable detail for the entry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromoteAttention(
            global::Speechify.PromoteAttentionKind kind,
            string id,
            global::Speechify.PromoteAttentionReason reason,
            string message)
        {
            this.Kind = kind;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Reason = reason;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteAttention" /> class.
        /// </summary>
        public PromoteAttention()
        {
        }

    }
}