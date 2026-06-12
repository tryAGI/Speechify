
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A batch of outbound calls dispatched to a list of recipients.
    /// </summary>
    public sealed partial class TtsBatchCall
    {
        /// <summary>
        /// Prefixed wire identifier (`batch_&lt;26 char Crockford base32&gt;`).<br/>
        /// ADR 0015 Cluster 3 hard-break: URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404 as of Cluster 3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent that will run the batch. ADR 0015 FK consistency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Caller-ID override. When set, prefixed wire identifier<br/>
        /// (`phone_&lt;26 char Crockford base32&gt;`) of the phone number to<br/>
        /// use; falls back to the agent's bound number when null. ADR<br/>
        /// 0015 FK consistency.
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsBatchCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsBatchCallStatus Status { get; set; }

        /// <summary>
        /// Total number of recipients.
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
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsBatchCall" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`batch_&lt;26 char Crockford base32&gt;`).<br/>
        /// ADR 0015 Cluster 3 hard-break: URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404 as of Cluster 3.
        /// </param>
        /// <param name="agentId">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent that will run the batch. ADR 0015 FK consistency.
        /// </param>
        /// <param name="name">
        /// Human-readable batch name.
        /// </param>
        /// <param name="status"></param>
        /// <param name="total">
        /// Total number of recipients.
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
        /// use; falls back to the agent's bound number when null. ADR<br/>
        /// 0015 FK consistency.
        /// </param>
        /// <param name="error">
        /// Populated when the batch itself fails.
        /// </param>
        /// <param name="startedAt">
        /// When the dispatcher started dialing.
        /// </param>
        /// <param name="finishedAt">
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
        public TtsBatchCall(
            string id,
            string agentId,
            string name,
            global::Speechify.TtsBatchCallStatus status,
            int total,
            int completed,
            int failed,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? phoneNumberId,
            string? error,
            global::System.DateTime? startedAt,
            global::System.DateTime? finishedAt,
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
            this.FinishedAt = finishedAt;
            this.ScheduledAt = scheduledAt;
            this.RingingTimeoutMs = ringingTimeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsBatchCall" /> class.
        /// </summary>
        public TtsBatchCall()
        {
        }

    }
}