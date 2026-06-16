
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/outbound-calls`. Requires a Twilio or BYOC<br/>
    /// trunk; LiveKit-native numbers do not support outbound today.
    /// </summary>
    public sealed partial class CreateOutboundCallRequest
    {
        /// <summary>
        /// ID of the agent that handles the answered call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Destination phone number in E.164 format (e.g. `+12025559876`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string To { get; set; }

        /// <summary>
        /// The number shown to the callee as caller ID, in E.164 format.<br/>
        /// Defaults to the first outbound-capable number in the workspace.<br/>
        /// Useful for multi-number campaigns where you want to rotate<br/>
        /// caller IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_id_number")]
        public string? CallerIdNumber { get; set; }

        /// <summary>
        /// DTMF digits dialed automatically after the call is answered,<br/>
        /// before the agent begins speaking. Use this for IVR navigation<br/>
        /// (e.g. `1ww2` presses 1, waits two seconds, presses 2). `w`<br/>
        /// is a half-second pause; `W` is a one-second pause.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dtmf_prefix")]
        public string? DtmfPrefix { get; set; }

        /// <summary>
        /// Per-call variable overrides merged on top of the agent's stored<br/>
        /// defaults. Keys must not use the reserved `system__` prefix.<br/>
        /// Useful for injecting per-call context (customer name, order ID)<br/>
        /// into the agent prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// How long to wait for the callee to answer before abandoning,<br/>
        /// in milliseconds. Defaults to 30000 (30s). Capped at 80000 (80s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ringing_timeout_ms")]
        public int? RingingTimeoutMs { get; set; }

        /// <summary>
        /// Optional per-call override for the AMD routing config. When<br/>
        /// set, wholesale-replaces the agent's stored AMD shape for<br/>
        /// this single call (PATCH-replace, not merge). Unlocks the<br/>
        /// batch-campaign pattern: one agent dialling many recipients<br/>
        /// with per-row tailored voicemail messages via the existing<br/>
        /// dynamic_variables substitution. Validation rules match<br/>
        /// the agent-update boundary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amd")]
        public global::Speechify.AMDConfig? Amd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOutboundCallRequest" /> class.
        /// </summary>
        /// <param name="agentId">
        /// ID of the agent that handles the answered call.
        /// </param>
        /// <param name="to">
        /// Destination phone number in E.164 format (e.g. `+12025559876`).
        /// </param>
        /// <param name="callerIdNumber">
        /// The number shown to the callee as caller ID, in E.164 format.<br/>
        /// Defaults to the first outbound-capable number in the workspace.<br/>
        /// Useful for multi-number campaigns where you want to rotate<br/>
        /// caller IDs.
        /// </param>
        /// <param name="dtmfPrefix">
        /// DTMF digits dialed automatically after the call is answered,<br/>
        /// before the agent begins speaking. Use this for IVR navigation<br/>
        /// (e.g. `1ww2` presses 1, waits two seconds, presses 2). `w`<br/>
        /// is a half-second pause; `W` is a one-second pause.
        /// </param>
        /// <param name="dynamicVariables">
        /// Per-call variable overrides merged on top of the agent's stored<br/>
        /// defaults. Keys must not use the reserved `system__` prefix.<br/>
        /// Useful for injecting per-call context (customer name, order ID)<br/>
        /// into the agent prompt.
        /// </param>
        /// <param name="ringingTimeoutMs">
        /// How long to wait for the callee to answer before abandoning,<br/>
        /// in milliseconds. Defaults to 30000 (30s). Capped at 80000 (80s).
        /// </param>
        /// <param name="amd">
        /// Optional per-call override for the AMD routing config. When<br/>
        /// set, wholesale-replaces the agent's stored AMD shape for<br/>
        /// this single call (PATCH-replace, not merge). Unlocks the<br/>
        /// batch-campaign pattern: one agent dialling many recipients<br/>
        /// with per-row tailored voicemail messages via the existing<br/>
        /// dynamic_variables substitution. Validation rules match<br/>
        /// the agent-update boundary.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOutboundCallRequest(
            string agentId,
            string to,
            string? callerIdNumber,
            string? dtmfPrefix,
            object? dynamicVariables,
            int? ringingTimeoutMs,
            global::Speechify.AMDConfig? amd)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.CallerIdNumber = callerIdNumber;
            this.DtmfPrefix = dtmfPrefix;
            this.DynamicVariables = dynamicVariables;
            this.RingingTimeoutMs = ringingTimeoutMs;
            this.Amd = amd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOutboundCallRequest" /> class.
        /// </summary>
        public CreateOutboundCallRequest()
        {
        }

    }
}