
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Answering Machine Detection routing config for outbound voice<br/>
    /// agents. AMD classifies the called party's first ~3-15 seconds of<br/>
    /// audio into one of LiveKit's categories (human, uncertain,<br/>
    /// machine-vm, machine-ivr, machine-unavailable) and dispatches per<br/>
    /// category to the configured action. Stored on the agent row;<br/>
    /// flowed onto outbound dispatch metadata under the `amd` key.<br/>
    /// Rationale: see ADR 0008 (docs/adrs/0008-amd-as-session-routing-primitive.md).
    /// </summary>
    public sealed partial class TtsAMDConfig
    {
        /// <summary>
        /// When false, the worker skips AMD entirely. When true, the<br/>
        /// worker runs AMD on the called party's greeting before<br/>
        /// delivering the agent's first message and dispatches per<br/>
        /// result.category. The per-route fields below are still<br/>
        /// required by the schema regardless of `enabled` state so a<br/>
        /// customer flipping `enabled: false → true` ships coherent<br/>
        /// route configuration immediately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Action when AMD returns category=machine-vm.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_voicemail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsAmdConfigOnVoicemail OnVoicemail { get; set; }

        /// <summary>
        /// Action when AMD returns category=machine-ivr.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_ivr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsAmdConfigOnIvr OnIvr { get; set; }

        /// <summary>
        /// Action when AMD returns category=machine-unavailable (mailbox full or disconnected).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_unavailable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsAmdConfigOnUnavailable OnUnavailable { get; set; }

        /// <summary>
        /// Optional overrides for LiveKit's detection thresholds and<br/>
        /// timeouts. Cross-field rule (enforced at the application<br/>
        /// validator): `timeout_seconds` must be greater than or equal<br/>
        /// to `no_speech_threshold_seconds` when both are set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tuning")]
        public global::Speechify.TtsAmdConfigTuning? Tuning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAMDConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// When false, the worker skips AMD entirely. When true, the<br/>
        /// worker runs AMD on the called party's greeting before<br/>
        /// delivering the agent's first message and dispatches per<br/>
        /// result.category. The per-route fields below are still<br/>
        /// required by the schema regardless of `enabled` state so a<br/>
        /// customer flipping `enabled: false → true` ships coherent<br/>
        /// route configuration immediately.
        /// </param>
        /// <param name="onVoicemail">
        /// Action when AMD returns category=machine-vm.
        /// </param>
        /// <param name="onIvr">
        /// Action when AMD returns category=machine-ivr.
        /// </param>
        /// <param name="onUnavailable">
        /// Action when AMD returns category=machine-unavailable (mailbox full or disconnected).
        /// </param>
        /// <param name="tuning">
        /// Optional overrides for LiveKit's detection thresholds and<br/>
        /// timeouts. Cross-field rule (enforced at the application<br/>
        /// validator): `timeout_seconds` must be greater than or equal<br/>
        /// to `no_speech_threshold_seconds` when both are set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAMDConfig(
            bool enabled,
            global::Speechify.TtsAmdConfigOnVoicemail onVoicemail,
            global::Speechify.TtsAmdConfigOnIvr onIvr,
            global::Speechify.TtsAmdConfigOnUnavailable onUnavailable,
            global::Speechify.TtsAmdConfigTuning? tuning)
        {
            this.Enabled = enabled;
            this.OnVoicemail = onVoicemail ?? throw new global::System.ArgumentNullException(nameof(onVoicemail));
            this.OnIvr = onIvr ?? throw new global::System.ArgumentNullException(nameof(onIvr));
            this.OnUnavailable = onUnavailable ?? throw new global::System.ArgumentNullException(nameof(onUnavailable));
            this.Tuning = tuning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAMDConfig" /> class.
        /// </summary>
        public TtsAMDConfig()
        {
        }

    }
}