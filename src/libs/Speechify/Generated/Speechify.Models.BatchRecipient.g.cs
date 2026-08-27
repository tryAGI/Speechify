
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One recipient row in a batch call.
    /// </summary>
    public sealed partial class BatchRecipient
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`batch_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the parent batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BatchId { get; set; }

        /// <summary>
        /// Recipient phone number in E.164 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Phone { get; set; }

        /// <summary>
        /// Per-recipient variable overrides injected into the agent prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// `cancelled` marks a recipient the batch cancel spared before it<br/>
        /// was dialed - distinct from `failed` (a dial that was attempted<br/>
        /// and failed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.BatchRecipientStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.BatchRecipientStatus Status { get; set; }

        /// <summary>
        /// Set once the call is placed. Prefixed wire identifier<br/>
        /// (`conv_&lt;26 char Crockford base32&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Client-supplied correlation key echoed back from the create<br/>
        /// request, so results can be reconciled to the caller's own<br/>
        /// identifier. Absent when the recipient carried none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// Populated when this recipient fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempted_at")]
        public global::System.DateTime? AttemptedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRecipient" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="batchId">
        /// Prefixed wire identifier (`batch_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the parent batch.
        /// </param>
        /// <param name="phone">
        /// Recipient phone number in E.164 format.
        /// </param>
        /// <param name="status">
        /// `cancelled` marks a recipient the batch cancel spared before it<br/>
        /// was dialed - distinct from `failed` (a dial that was attempted<br/>
        /// and failed).
        /// </param>
        /// <param name="dynamicVariables">
        /// Per-recipient variable overrides injected into the agent prompt.
        /// </param>
        /// <param name="conversationId">
        /// Set once the call is placed. Prefixed wire identifier<br/>
        /// (`conv_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="customId">
        /// Client-supplied correlation key echoed back from the create<br/>
        /// request, so results can be reconciled to the caller's own<br/>
        /// identifier. Absent when the recipient carried none.
        /// </param>
        /// <param name="error">
        /// Populated when this recipient fails.
        /// </param>
        /// <param name="attemptedAt"></param>
        /// <param name="endedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRecipient(
            string id,
            string batchId,
            string phone,
            global::Speechify.BatchRecipientStatus status,
            object? dynamicVariables,
            string? conversationId,
            string? customId,
            string? error,
            global::System.DateTime? attemptedAt,
            global::System.DateTime? endedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BatchId = batchId ?? throw new global::System.ArgumentNullException(nameof(batchId));
            this.Phone = phone ?? throw new global::System.ArgumentNullException(nameof(phone));
            this.DynamicVariables = dynamicVariables;
            this.Status = status;
            this.ConversationId = conversationId;
            this.CustomId = customId;
            this.Error = error;
            this.AttemptedAt = attemptedAt;
            this.EndedAt = endedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRecipient" /> class.
        /// </summary>
        public BatchRecipient()
        {
        }

    }
}