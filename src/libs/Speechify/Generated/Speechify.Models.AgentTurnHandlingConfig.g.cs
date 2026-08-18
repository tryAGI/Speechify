
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Turn-handling and silence-timeout configuration.
    /// </summary>
    public sealed partial class AgentTurnHandlingConfig
    {
        /// <summary>
        /// Minimum silence, in seconds, the agent waits for after the<br/>
        /// caller stops talking before it starts replying. Applies to<br/>
        /// every turn on the call. Raise it when the agent talks over a<br/>
        /// caller who pauses mid-sentence, or over an IVR menu that<br/>
        /// breaks between options. It is a floor on listening rather<br/>
        /// than a pause before speaking, so it adds to the time every<br/>
        /// reply takes to arrive. Null lets turn detection decide, which<br/>
        /// waits 0.3s when it is confident the caller finished and up to<br/>
        /// 1.2s when it is not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_delay_seconds")]
        public string? ResponseDelaySeconds { get; set; }

        /// <summary>
        /// How easily the caller takes the floor from a speaking agent,<br/>
        /// and how patiently the agent waits before treating a pause as<br/>
        /// the end of the caller's turn. Null follows the platform and<br/>
        /// behaves identically to `medium`.<br/>
        /// `low` makes the agent hard to interrupt: background noise,<br/>
        /// hold music, and one- or two-word sounds no longer stop it<br/>
        /// mid-sentence (it needs 1.5s of speech and at least 3 words),<br/>
        /// and it waits 0.4s longer before taking a pause as the end of<br/>
        /// a turn. Use it for noisy lines and for callers who pause<br/>
        /// mid-thought. `high` is the opposite: the agent yields after<br/>
        /// 0.4s of caller speech and takes the turn sooner.<br/>
        /// Neither setting changes ordinary turn-taking - a one-word<br/>
        /// answer still replies normally when the agent is silent; the<br/>
        /// word threshold only applies to interrupting speech already in<br/>
        /// progress. Two limits worth knowing: the word threshold needs<br/>
        /// transcription, so it does not apply to agents running the<br/>
        /// realtime audio model, and setting `response_delay_seconds`<br/>
        /// takes over the silence window entirely - the level no longer<br/>
        /// lengthens or shortens how long the agent waits, though it still<br/>
        /// governs how easily the caller interrupts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_sensitivity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentTurnHandlingConfigInterruptionSensitivityJsonConverter))]
        public global::Speechify.AgentTurnHandlingConfigInterruptionSensitivity? InterruptionSensitivity { get; set; }

        /// <summary>
        /// How long the agent tolerates silence before ending the call,<br/>
        /// in seconds. Null uses the platform default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivity_timeout_seconds")]
        public int? InactivityTimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnHandlingConfig" /> class.
        /// </summary>
        /// <param name="responseDelaySeconds">
        /// Minimum silence, in seconds, the agent waits for after the<br/>
        /// caller stops talking before it starts replying. Applies to<br/>
        /// every turn on the call. Raise it when the agent talks over a<br/>
        /// caller who pauses mid-sentence, or over an IVR menu that<br/>
        /// breaks between options. It is a floor on listening rather<br/>
        /// than a pause before speaking, so it adds to the time every<br/>
        /// reply takes to arrive. Null lets turn detection decide, which<br/>
        /// waits 0.3s when it is confident the caller finished and up to<br/>
        /// 1.2s when it is not.
        /// </param>
        /// <param name="interruptionSensitivity">
        /// How easily the caller takes the floor from a speaking agent,<br/>
        /// and how patiently the agent waits before treating a pause as<br/>
        /// the end of the caller's turn. Null follows the platform and<br/>
        /// behaves identically to `medium`.<br/>
        /// `low` makes the agent hard to interrupt: background noise,<br/>
        /// hold music, and one- or two-word sounds no longer stop it<br/>
        /// mid-sentence (it needs 1.5s of speech and at least 3 words),<br/>
        /// and it waits 0.4s longer before taking a pause as the end of<br/>
        /// a turn. Use it for noisy lines and for callers who pause<br/>
        /// mid-thought. `high` is the opposite: the agent yields after<br/>
        /// 0.4s of caller speech and takes the turn sooner.<br/>
        /// Neither setting changes ordinary turn-taking - a one-word<br/>
        /// answer still replies normally when the agent is silent; the<br/>
        /// word threshold only applies to interrupting speech already in<br/>
        /// progress. Two limits worth knowing: the word threshold needs<br/>
        /// transcription, so it does not apply to agents running the<br/>
        /// realtime audio model, and setting `response_delay_seconds`<br/>
        /// takes over the silence window entirely - the level no longer<br/>
        /// lengthens or shortens how long the agent waits, though it still<br/>
        /// governs how easily the caller interrupts.
        /// </param>
        /// <param name="inactivityTimeoutSeconds">
        /// How long the agent tolerates silence before ending the call,<br/>
        /// in seconds. Null uses the platform default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTurnHandlingConfig(
            string? responseDelaySeconds,
            global::Speechify.AgentTurnHandlingConfigInterruptionSensitivity? interruptionSensitivity,
            int? inactivityTimeoutSeconds)
        {
            this.ResponseDelaySeconds = responseDelaySeconds;
            this.InterruptionSensitivity = interruptionSensitivity;
            this.InactivityTimeoutSeconds = inactivityTimeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTurnHandlingConfig" /> class.
        /// </summary>
        public AgentTurnHandlingConfig()
        {
        }

    }
}