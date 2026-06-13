
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsConversation
    {
        /// <summary>
        /// Prefixed wire identifier (`conv_&lt;26 char Crockford base32&gt;`).<br/>
        /// ADR 0015 Cluster 2 hard-break: URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404 as of Cluster 2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// for the agent that answers this conversation. ADR 0015<br/>
        /// FK consistency: customer-facing responses emit the prefixed<br/>
        /// form, never raw UUIDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// LiveKit room name. Equals the conversation `id` for `web`<br/>
        /// and `sip_outbound` transports; `sip_inbound` rooms use a<br/>
        /// `sip_&lt;e164&gt;_&lt;random&gt;` name assigned by the SIP dispatch rule.
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
        /// How the caller reached the agent. `web` is the browser /<br/>
        /// SDK realtime path; the `sip_*` and `phone` variants come<br/>
        /// from the telephony stack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsConversationTransportJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsConversationTransport Transport { get; set; }

        /// <summary>
        /// When the conversation row was created (the call was<br/>
        /// initiated). Always present, including for conversations<br/>
        /// that never started — unlike `started_at` — so it is the<br/>
        /// timestamp to display and sort pending calls by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

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
        /// When the recording file actually began capturing audio<br/>
        /// (LiveKit egress file started_at). Anchor transcript message<br/>
        /// offsets on this — not `started_at` — when seeking the<br/>
        /// recording: the file's first frame trails the participant<br/>
        /// join by the egress recorder's spin-up (~1-2s). Null when<br/>
        /// there is no recording or the row pre-dates the field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_started_at")]
        public global::System.DateTime? RecordingStartedAt { get; set; }

        /// <summary>
        /// Coarse termination category. Worker-stamped reasons arrive<br/>
        /// before `terminate_call` fires; `caller_hangup` has two<br/>
        /// emit sites (worker-observed SIP disconnect, plus a<br/>
        /// server-side post-call catch-all).<br/>
        /// * `voicemail_message_left` — AMD machine-vm + we spoke the configured drop-message.<br/>
        /// * `voicemail_hangup` — AMD machine-vm + we terminated silently (action=hangup or empty-message bypass).<br/>
        /// * `ivr_hangup` — AMD machine-ivr + action=hangup.<br/>
        /// * `unavailable_hangup` — AMD machine-unavailable (mailbox full / disconnected).<br/>
        /// * `agent_ended` — LLM-driven end_call builtin.<br/>
        /// * `inactivity_timeout` — worker's inactivity handler fired terminate after the configured silence window.<br/>
        /// * `loop_detected` — worker's runtime loop guard force-ended the call after N consecutive near-identical user turns (typically an IVR replaying its menu while the LLM kept reacting instead of calling end_call).<br/>
        /// * `max_duration_reached` - worker's max-call-duration watchdog force-ended the call at the platform ceiling (a safety bound on runaway calls).<br/>
        /// * `over_capacity` — inbound call refused because the workspace was over its active-call concurrency cap; the busy message played and the call hung up. Stamped server-side and excluded from billing.<br/>
        /// * `caller_hangup` — caller's leg went away. Precise when the worker observed the SIP `participant_disconnected` event (stamped immediately); otherwise stamped server-side ~10s after `room_finished` as a catch-all (web tab close, network blip, worker crash, etc.).<br/>
        /// * `null` — pre-rollout calls only (anything that landed after the rollout completes without a stamp gets `caller_hangup` from the post-call goroutine).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsConversationEndReasonJsonConverter))]
        public global::Speechify.TtsConversationEndReason? EndReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Stable caller key (LiveKit participant identity) persisted<br/>
        /// at session start so the post-call memory extractor can<br/>
        /// pivot memories by `(agent_id, caller_identity)`. Empty<br/>
        /// string for anonymous widget sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_identity")]
        public string? CallerIdentity { get; set; }

        /// <summary>
        /// E.164 of the phone number that placed the call. For<br/>
        /// `sip_outbound` this is the workspace number used as the<br/>
        /// caller ID; for `sip_inbound` it is the external caller's<br/>
        /// number. Null for `web` conversations and for older<br/>
        /// outbound rows, where the dialing caller id was not recorded<br/>
        /// before this field existed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_number")]
        public string? FromNumber { get; set; }

        /// <summary>
        /// E.164 of the phone number that received the call. For<br/>
        /// `sip_outbound` this is the external callee; for<br/>
        /// `sip_inbound` it is the workspace number the caller<br/>
        /// dialed. Null for `web` conversations and for legacy<br/>
        /// inbound rows whose room name did not embed the dialed<br/>
        /// number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_number")]
        public string? ToNumber { get; set; }

        /// <summary>
        /// Frozen snapshot of the agent's configuration at create<br/>
        /// time. Populated only on detail responses; list responses<br/>
        /// intentionally skip the column to keep the row small.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_snapshot")]
        public global::Speechify.TtsAgentSnapshot? AgentSnapshot { get; set; }

        /// <summary>
        /// Customer-facing dynamic variables this call ran with: the<br/>
        /// agent's stored variable defaults overlaid with the<br/>
        /// per-session `dynamic_variables` overrides, resolved to<br/>
        /// their values. Reserved `system__*` keys are excluded —<br/>
        /// they are runtime-derived and not part of the audit<br/>
        /// snapshot. Omitted for SIP inbound calls (which take no<br/>
        /// per-session variables) and for any pre-rollout<br/>
        /// conversation. Populated only on detail responses; the<br/>
        /// list endpoint skips it, mirroring `agent_snapshot`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// Populated only on the list endpoint via a correlated<br/>
        /// subquery. Zero on single-row reads where the join cost<br/>
        /// isn't paid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessageCount { get; set; }

        /// <summary>
        /// AIS-3322 audit pointer at the cached IVR menu the<br/>
        /// navigator consulted on this call. NULL when the navigator<br/>
        /// never engaged OR after the referenced menu was<br/>
        /// invalidated (FK is ON DELETE SET NULL).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ivr_menu_id")]
        public string? IvrMenuId { get; set; }

        /// <summary>
        /// AIS-3322 ordered log of the navigator's per-call presses:<br/>
        /// `[{fingerprint, dtmf, label}, ...]`. Empty array means<br/>
        /// "navigator engaged but pressed nothing" (distinct from<br/>
        /// NULL = "navigator never engaged").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ivr_path_taken")]
        public global::System.Collections.Generic.IList<object>? IvrPathTaken { get; set; }

        /// <summary>
        /// AIS-3322 canonical code the worker emits when the IVR<br/>
        /// navigator gave up. NULL when the navigator completed<br/>
        /// cleanly OR never started a plan.<br/>
        /// * `no_goal` - the goal extractor returned empty.<br/>
        /// * `no_cached_menu` - AMD-time cache miss for the root fingerprint.<br/>
        /// * `below_threshold` - cached menu loaded but confidence &lt; threshold.<br/>
        /// * `fingerprint_mismatch` - in-call prompt diverged from the cached menu fingerprint.<br/>
        /// * `goal_ambiguous` - cached options matched the goal more than once or not at all.<br/>
        /// * `child_cache_miss` - sub-menu fingerprint had no cached row.<br/>
        /// * `dtmf_send_failure` - DTMF press could not be delivered.<br/>
        /// * `matched_option_missing_dtmf` - defensive shape guard.<br/>
        /// * `disabled` - per-agent toggle off OR operator kill switch on.<br/>
        /// * `repeated_prompt_max_retries` - bounded press-retry on the same fingerprint hit its cap of 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ivr_surrender_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsConversationIvrSurrenderReasonJsonConverter))]
        public global::Speechify.TtsConversationIvrSurrenderReason? IvrSurrenderReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsConversation" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`conv_&lt;26 char Crockford base32&gt;`).<br/>
        /// ADR 0015 Cluster 2 hard-break: URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404 as of Cluster 2.
        /// </param>
        /// <param name="agentId">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// for the agent that answers this conversation. ADR 0015<br/>
        /// FK consistency: customer-facing responses emit the prefixed<br/>
        /// form, never raw UUIDs.
        /// </param>
        /// <param name="roomName">
        /// LiveKit room name. Equals the conversation `id` for `web`<br/>
        /// and `sip_outbound` transports; `sip_inbound` rooms use a<br/>
        /// `sip_&lt;e164&gt;_&lt;random&gt;` name assigned by the SIP dispatch rule.
        /// </param>
        /// <param name="status"></param>
        /// <param name="transport">
        /// How the caller reached the agent. `web` is the browser /<br/>
        /// SDK realtime path; the `sip_*` and `phone` variants come<br/>
        /// from the telephony stack.
        /// </param>
        /// <param name="createdAt">
        /// When the conversation row was created (the call was<br/>
        /// initiated). Always present, including for conversations<br/>
        /// that never started — unlike `started_at` — so it is the<br/>
        /// timestamp to display and sort pending calls by.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="messageCount">
        /// Populated only on the list endpoint via a correlated<br/>
        /// subquery. Zero on single-row reads where the join cost<br/>
        /// isn't paid.
        /// </param>
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
        /// <param name="recordingStartedAt">
        /// When the recording file actually began capturing audio<br/>
        /// (LiveKit egress file started_at). Anchor transcript message<br/>
        /// offsets on this — not `started_at` — when seeking the<br/>
        /// recording: the file's first frame trails the participant<br/>
        /// join by the egress recorder's spin-up (~1-2s). Null when<br/>
        /// there is no recording or the row pre-dates the field.
        /// </param>
        /// <param name="endReason">
        /// Coarse termination category. Worker-stamped reasons arrive<br/>
        /// before `terminate_call` fires; `caller_hangup` has two<br/>
        /// emit sites (worker-observed SIP disconnect, plus a<br/>
        /// server-side post-call catch-all).<br/>
        /// * `voicemail_message_left` — AMD machine-vm + we spoke the configured drop-message.<br/>
        /// * `voicemail_hangup` — AMD machine-vm + we terminated silently (action=hangup or empty-message bypass).<br/>
        /// * `ivr_hangup` — AMD machine-ivr + action=hangup.<br/>
        /// * `unavailable_hangup` — AMD machine-unavailable (mailbox full / disconnected).<br/>
        /// * `agent_ended` — LLM-driven end_call builtin.<br/>
        /// * `inactivity_timeout` — worker's inactivity handler fired terminate after the configured silence window.<br/>
        /// * `loop_detected` — worker's runtime loop guard force-ended the call after N consecutive near-identical user turns (typically an IVR replaying its menu while the LLM kept reacting instead of calling end_call).<br/>
        /// * `max_duration_reached` - worker's max-call-duration watchdog force-ended the call at the platform ceiling (a safety bound on runaway calls).<br/>
        /// * `over_capacity` — inbound call refused because the workspace was over its active-call concurrency cap; the busy message played and the call hung up. Stamped server-side and excluded from billing.<br/>
        /// * `caller_hangup` — caller's leg went away. Precise when the worker observed the SIP `participant_disconnected` event (stamped immediately); otherwise stamped server-side ~10s after `room_finished` as a catch-all (web tab close, network blip, worker crash, etc.).<br/>
        /// * `null` — pre-rollout calls only (anything that landed after the rollout completes without a stamp gets `caller_hangup` from the post-call goroutine).
        /// </param>
        /// <param name="callerIdentity">
        /// Stable caller key (LiveKit participant identity) persisted<br/>
        /// at session start so the post-call memory extractor can<br/>
        /// pivot memories by `(agent_id, caller_identity)`. Empty<br/>
        /// string for anonymous widget sessions.
        /// </param>
        /// <param name="fromNumber">
        /// E.164 of the phone number that placed the call. For<br/>
        /// `sip_outbound` this is the workspace number used as the<br/>
        /// caller ID; for `sip_inbound` it is the external caller's<br/>
        /// number. Null for `web` conversations and for older<br/>
        /// outbound rows, where the dialing caller id was not recorded<br/>
        /// before this field existed.
        /// </param>
        /// <param name="toNumber">
        /// E.164 of the phone number that received the call. For<br/>
        /// `sip_outbound` this is the external callee; for<br/>
        /// `sip_inbound` it is the workspace number the caller<br/>
        /// dialed. Null for `web` conversations and for legacy<br/>
        /// inbound rows whose room name did not embed the dialed<br/>
        /// number.
        /// </param>
        /// <param name="agentSnapshot">
        /// Frozen snapshot of the agent's configuration at create<br/>
        /// time. Populated only on detail responses; list responses<br/>
        /// intentionally skip the column to keep the row small.
        /// </param>
        /// <param name="dynamicVariables">
        /// Customer-facing dynamic variables this call ran with: the<br/>
        /// agent's stored variable defaults overlaid with the<br/>
        /// per-session `dynamic_variables` overrides, resolved to<br/>
        /// their values. Reserved `system__*` keys are excluded —<br/>
        /// they are runtime-derived and not part of the audit<br/>
        /// snapshot. Omitted for SIP inbound calls (which take no<br/>
        /// per-session variables) and for any pre-rollout<br/>
        /// conversation. Populated only on detail responses; the<br/>
        /// list endpoint skips it, mirroring `agent_snapshot`.
        /// </param>
        /// <param name="ivrMenuId">
        /// AIS-3322 audit pointer at the cached IVR menu the<br/>
        /// navigator consulted on this call. NULL when the navigator<br/>
        /// never engaged OR after the referenced menu was<br/>
        /// invalidated (FK is ON DELETE SET NULL).
        /// </param>
        /// <param name="ivrPathTaken">
        /// AIS-3322 ordered log of the navigator's per-call presses:<br/>
        /// `[{fingerprint, dtmf, label}, ...]`. Empty array means<br/>
        /// "navigator engaged but pressed nothing" (distinct from<br/>
        /// NULL = "navigator never engaged").
        /// </param>
        /// <param name="ivrSurrenderReason">
        /// AIS-3322 canonical code the worker emits when the IVR<br/>
        /// navigator gave up. NULL when the navigator completed<br/>
        /// cleanly OR never started a plan.<br/>
        /// * `no_goal` - the goal extractor returned empty.<br/>
        /// * `no_cached_menu` - AMD-time cache miss for the root fingerprint.<br/>
        /// * `below_threshold` - cached menu loaded but confidence &lt; threshold.<br/>
        /// * `fingerprint_mismatch` - in-call prompt diverged from the cached menu fingerprint.<br/>
        /// * `goal_ambiguous` - cached options matched the goal more than once or not at all.<br/>
        /// * `child_cache_miss` - sub-menu fingerprint had no cached row.<br/>
        /// * `dtmf_send_failure` - DTMF press could not be delivered.<br/>
        /// * `matched_option_missing_dtmf` - defensive shape guard.<br/>
        /// * `disabled` - per-agent toggle off OR operator kill switch on.<br/>
        /// * `repeated_prompt_max_retries` - bounded press-retry on the same fingerprint hit its cap of 1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsConversation(
            string id,
            string agentId,
            string roomName,
            global::Speechify.TtsConversationStatus status,
            global::Speechify.TtsConversationTransport transport,
            global::System.DateTime createdAt,
            object metadata,
            int messageCount,
            string? roomSid,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            int? durationMs,
            int? costCents,
            string? recordingUrl,
            global::System.DateTime? recordingStartedAt,
            global::Speechify.TtsConversationEndReason? endReason,
            string? callerIdentity,
            string? fromNumber,
            string? toNumber,
            global::Speechify.TtsAgentSnapshot? agentSnapshot,
            object? dynamicVariables,
            string? ivrMenuId,
            global::System.Collections.Generic.IList<object>? ivrPathTaken,
            global::Speechify.TtsConversationIvrSurrenderReason? ivrSurrenderReason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.RoomName = roomName ?? throw new global::System.ArgumentNullException(nameof(roomName));
            this.RoomSid = roomSid;
            this.Status = status;
            this.Transport = transport;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.DurationMs = durationMs;
            this.CostCents = costCents;
            this.RecordingUrl = recordingUrl;
            this.RecordingStartedAt = recordingStartedAt;
            this.EndReason = endReason;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CallerIdentity = callerIdentity;
            this.FromNumber = fromNumber;
            this.ToNumber = toNumber;
            this.AgentSnapshot = agentSnapshot;
            this.DynamicVariables = dynamicVariables;
            this.MessageCount = messageCount;
            this.IvrMenuId = ivrMenuId;
            this.IvrPathTaken = ivrPathTaken;
            this.IvrSurrenderReason = ivrSurrenderReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsConversation" /> class.
        /// </summary>
        public TtsConversation()
        {
        }

    }
}