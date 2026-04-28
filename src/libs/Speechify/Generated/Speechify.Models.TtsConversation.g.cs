
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsConversation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("room_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoomName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("room_sid")]
        public string? RoomSid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsConversationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsConversationStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsConversationTransportJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsConversationTransport Transport { get; set; }

        /// <summary>
        /// Set when the first user participant joins the realtime<br/>
        /// voice session. Null between CreateConversation and the<br/>
        /// participant-joined event, and stays null if no user ever<br/>
        /// joins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_cents")]
        public int? CostCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_url")]
        public string? RecordingUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsConversation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId"></param>
        /// <param name="roomName"></param>
        /// <param name="status"></param>
        /// <param name="transport"></param>
        /// <param name="roomSid"></param>
        /// <param name="startedAt">
        /// Set when the first user participant joins the realtime<br/>
        /// voice session. Null between CreateConversation and the<br/>
        /// participant-joined event, and stays null if no user ever<br/>
        /// joins.
        /// </param>
        /// <param name="endedAt"></param>
        /// <param name="durationMs"></param>
        /// <param name="costCents"></param>
        /// <param name="recordingUrl"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsConversation(
            string id,
            string agentId,
            string roomName,
            global::Speechify.TtsConversationStatus status,
            global::Speechify.TtsConversationTransport transport,
            string? roomSid,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            int? durationMs,
            int? costCents,
            string? recordingUrl,
            object? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.RoomName = roomName ?? throw new global::System.ArgumentNullException(nameof(roomName));
            this.RoomSid = roomSid;
            this.Status = status;
            this.Transport = transport;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.DurationMs = durationMs;
            this.CostCents = costCents;
            this.RecordingUrl = recordingUrl;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsConversation" /> class.
        /// </summary>
        public TtsConversation()
        {
        }
    }
}