
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/batch-calls`. Also accepts `multipart/form-data`<br/>
    /// with a CSV file upload (`csv_file` field) where the `phone` column is<br/>
    /// required and remaining columns become per-recipient `dynamic_vars`.
    /// </summary>
    public sealed partial class TtsCreateBatchCallRequest
    {
        /// <summary>
        /// Human-readable batch name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Agent that handles each call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Caller-ID override. Falls back to the agent's bound number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// Schedule the batch for a future time (RFC 3339). Omit to start immediately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_at")]
        public global::System.DateTime? ScheduledAt { get; set; }

        /// <summary>
        /// Ringing timeout in milliseconds applied to every call in the<br/>
        /// batch (how long each recipient rings before the dial gives<br/>
        /// up). Range 1000-80000 (1-80s). Omit to use the 30s default.<br/>
        /// The console collects this in seconds and converts to<br/>
        /// milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ringing_timeout_ms")]
        public int? RingingTimeoutMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsBatchRecipientRequest> Recipients { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateBatchCallRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable batch name.
        /// </param>
        /// <param name="agentId">
        /// Agent that handles each call.
        /// </param>
        /// <param name="recipients"></param>
        /// <param name="phoneNumberId">
        /// Caller-ID override. Falls back to the agent's bound number.
        /// </param>
        /// <param name="scheduledAt">
        /// Schedule the batch for a future time (RFC 3339). Omit to start immediately.
        /// </param>
        /// <param name="ringingTimeoutMs">
        /// Ringing timeout in milliseconds applied to every call in the<br/>
        /// batch (how long each recipient rings before the dial gives<br/>
        /// up). Range 1000-80000 (1-80s). Omit to use the 30s default.<br/>
        /// The console collects this in seconds and converts to<br/>
        /// milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateBatchCallRequest(
            string name,
            string agentId,
            global::System.Collections.Generic.IList<global::Speechify.TtsBatchRecipientRequest> recipients,
            string? phoneNumberId,
            global::System.DateTime? scheduledAt,
            int? ringingTimeoutMs)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.PhoneNumberId = phoneNumberId;
            this.ScheduledAt = scheduledAt;
            this.RingingTimeoutMs = ringingTimeoutMs;
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateBatchCallRequest" /> class.
        /// </summary>
        public TtsCreateBatchCallRequest()
        {
        }

    }
}