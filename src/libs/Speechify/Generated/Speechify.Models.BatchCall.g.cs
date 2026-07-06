
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A batch of outbound calls dispatched to a list of recipients. This<br/>
    /// summary object (counts + status, no recipients) is the payload of the<br/>
    /// `batch_call.completed` / `batch_call.failed` webhook events. Per-recipient<br/>
    /// results - including each recipient's `custom_id` and `conversation_id` -<br/>
    /// are reconciled by polling<br/>
    /// `GET /v1/agents/batch-calls/{batch_call_id}/recipients`, not through the<br/>
    /// webhook.
    /// </summary>
    public sealed partial class BatchCall
    {
        /// <summary>
        /// Prefixed wire identifier (`batch_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent that will run the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Caller-ID override. When set, prefixed wire identifier<br/>
        /// (`phone_&lt;26 char Crockford base32&gt;`) of the phone number to<br/>
        /// use; falls back to the agent's bound number when null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// Human-readable batch name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Lifecycle status. A batch deferred to a future time is<br/>
        /// `pending` with a non-null `scheduled_at`; it moves to `running`<br/>
        /// once the scheduled time arrives and the dispatcher starts<br/>
        /// dialing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.JobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.JobStatus Status { get; set; }

        /// <summary>
        /// Total number of recipients (the progress denominator).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Recipients successfully dialed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Completed { get; set; }

        /// <summary>
        /// Recipients that failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// Populated when the batch itself fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

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
        /// When the dispatcher started dialing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the last recipient was resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// If set, the batch waits until this time before dialing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_at")]
        public global::System.DateTime? ScheduledAt { get; set; }

        /// <summary>
        /// Per-call ringing timeout in milliseconds applied to every<br/>
        /// recipient in the batch. Null when the batch uses the 30s<br/>
        /// default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ringing_timeout_ms")]
        public int? RingingTimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCall" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`batch_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </param>
        /// <param name="agentId">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent that will run the batch.
        /// </param>
        /// <param name="name">
        /// Human-readable batch name.
        /// </param>
        /// <param name="status">
        /// Lifecycle status. A batch deferred to a future time is<br/>
        /// `pending` with a non-null `scheduled_at`; it moves to `running`<br/>
        /// once the scheduled time arrives and the dispatcher starts<br/>
        /// dialing.
        /// </param>
        /// <param name="total">
        /// Total number of recipients (the progress denominator).
        /// </param>
        /// <param name="completed">
        /// Recipients successfully dialed.
        /// </param>
        /// <param name="failed">
        /// Recipients that failed.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="phoneNumberId">
        /// Caller-ID override. When set, prefixed wire identifier<br/>
        /// (`phone_&lt;26 char Crockford base32&gt;`) of the phone number to<br/>
        /// use; falls back to the agent's bound number when null.
        /// </param>
        /// <param name="error">
        /// Populated when the batch itself fails.
        /// </param>
        /// <param name="startedAt">
        /// When the dispatcher started dialing.
        /// </param>
        /// <param name="endedAt">
        /// When the last recipient was resolved.
        /// </param>
        /// <param name="scheduledAt">
        /// If set, the batch waits until this time before dialing.
        /// </param>
        /// <param name="ringingTimeoutMs">
        /// Per-call ringing timeout in milliseconds applied to every<br/>
        /// recipient in the batch. Null when the batch uses the 30s<br/>
        /// default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchCall(
            string id,
            string agentId,
            string name,
            global::Speechify.JobStatus status,
            int total,
            int completed,
            int failed,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? phoneNumberId,
            string? error,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            global::System.DateTime? scheduledAt,
            int? ringingTimeoutMs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.PhoneNumberId = phoneNumberId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Total = total;
            this.Completed = completed;
            this.Failed = failed;
            this.Error = error;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.ScheduledAt = scheduledAt;
            this.RingingTimeoutMs = ringingTimeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCall" /> class.
        /// </summary>
        public BatchCall()
        {
        }

    }
}