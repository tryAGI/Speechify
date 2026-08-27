
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Binds a number's traffic to your own HTTPS endpoint. The endpoint<br/>
    /// must be `https://` and publicly resolvable - private-network and<br/>
    /// literal-IP targets in reserved ranges are rejected. Binding a relay<br/>
    /// atomically clears any agent binding on the number.
    /// </summary>
    public sealed partial class RelayBinding
    {
        /// <summary>
        /// Acknowledges that this bind takes the number away from a hosted<br/>
        /// agent that is still answering on it. Without it, binding a relay to<br/>
        /// an agent-bound number is refused with `409 relay_displaces_agent`<br/>
        /// naming the agent, so the displacement is never a surprise.<br/>
        /// Re-binding a relay over an existing relay does not need it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_agent_binding")]
        public bool? ReplaceAgentBinding { get; set; }

        /// <summary>
        /// The HTTPS endpoint to deliver this number's events to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Optional voice that speaks the relayed replies. Defaults to the<br/>
        /// platform default voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Optional per-turn deadline in milliseconds. Defaults to 5000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_timeout_ms")]
        public int? ReplyTimeoutMs { get; set; }

        /// <summary>
        /// Optional line spoken to cover a slow or failing endpoint while<br/>
        /// the delivery is retried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_line")]
        public string? FallbackLine { get; set; }

        /// <summary>
        /// Optional line spoken before hanging up when the endpoint stays<br/>
        /// unreachable after the retry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goodbye_line")]
        public string? GoodbyeLine { get; set; }

        /// <summary>
        /// Optional dated version (`YYYY-MM-DD`) to pin the relay's event<br/>
        /// payloads to. Defaults to the workspace's current version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Optional line spoken when the call is picked up, ahead of the<br/>
        /// webhook's own `call.started` reply (and after any AI-disclosure<br/>
        /// line).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("greeting")]
        public string? Greeting { get; set; }

        /// <summary>
        /// Optional default cold-transfer destination in E.164, used when a<br/>
        /// reply asks to transfer without an explicit target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_number")]
        public string? TransferNumber { get; set; }

        /// <summary>
        /// Optional auto-hangup silence timeout in seconds. Omit for no<br/>
        /// silence hangup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hangup_after_silence_seconds")]
        public int? HangupAfterSilenceSeconds { get; set; }

        /// <summary>
        /// Optional opt-in AI-disclosure opening line spoken first on<br/>
        /// `call.started`, before the webhook greeting. Off by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_disclosure")]
        public global::Speechify.AIDisclosure? AiDisclosure { get; set; }

        /// <summary>
        /// Optional workspace-level intended-use declaration recorded with<br/>
        /// the bind (replaces any earlier declaration). May be required by<br/>
        /// the workspace trust policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intended_use")]
        public global::Speechify.IntendedUse? IntendedUse { get; set; }

        /// <summary>
        /// Set true to record the ToS/consent attestation for this<br/>
        /// workspace. Recorded once - a re-bind never moves the original<br/>
        /// attestation's actor or timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tos_accepted")]
        public bool? TosAccepted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayBinding" /> class.
        /// </summary>
        /// <param name="url">
        /// The HTTPS endpoint to deliver this number's events to.
        /// </param>
        /// <param name="replaceAgentBinding">
        /// Acknowledges that this bind takes the number away from a hosted<br/>
        /// agent that is still answering on it. Without it, binding a relay to<br/>
        /// an agent-bound number is refused with `409 relay_displaces_agent`<br/>
        /// naming the agent, so the displacement is never a surprise.<br/>
        /// Re-binding a relay over an existing relay does not need it.
        /// </param>
        /// <param name="voiceId">
        /// Optional voice that speaks the relayed replies. Defaults to the<br/>
        /// platform default voice.
        /// </param>
        /// <param name="replyTimeoutMs">
        /// Optional per-turn deadline in milliseconds. Defaults to 5000.
        /// </param>
        /// <param name="fallbackLine">
        /// Optional line spoken to cover a slow or failing endpoint while<br/>
        /// the delivery is retried.
        /// </param>
        /// <param name="goodbyeLine">
        /// Optional line spoken before hanging up when the endpoint stays<br/>
        /// unreachable after the retry.
        /// </param>
        /// <param name="apiVersion">
        /// Optional dated version (`YYYY-MM-DD`) to pin the relay's event<br/>
        /// payloads to. Defaults to the workspace's current version.
        /// </param>
        /// <param name="greeting">
        /// Optional line spoken when the call is picked up, ahead of the<br/>
        /// webhook's own `call.started` reply (and after any AI-disclosure<br/>
        /// line).
        /// </param>
        /// <param name="transferNumber">
        /// Optional default cold-transfer destination in E.164, used when a<br/>
        /// reply asks to transfer without an explicit target.
        /// </param>
        /// <param name="hangupAfterSilenceSeconds">
        /// Optional auto-hangup silence timeout in seconds. Omit for no<br/>
        /// silence hangup.
        /// </param>
        /// <param name="aiDisclosure">
        /// Optional opt-in AI-disclosure opening line spoken first on<br/>
        /// `call.started`, before the webhook greeting. Off by default.
        /// </param>
        /// <param name="intendedUse">
        /// Optional workspace-level intended-use declaration recorded with<br/>
        /// the bind (replaces any earlier declaration). May be required by<br/>
        /// the workspace trust policy.
        /// </param>
        /// <param name="tosAccepted">
        /// Set true to record the ToS/consent attestation for this<br/>
        /// workspace. Recorded once - a re-bind never moves the original<br/>
        /// attestation's actor or timestamp.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RelayBinding(
            string url,
            bool? replaceAgentBinding,
            string? voiceId,
            int? replyTimeoutMs,
            string? fallbackLine,
            string? goodbyeLine,
            string? apiVersion,
            string? greeting,
            string? transferNumber,
            int? hangupAfterSilenceSeconds,
            global::Speechify.AIDisclosure? aiDisclosure,
            global::Speechify.IntendedUse? intendedUse,
            bool? tosAccepted)
        {
            this.ReplaceAgentBinding = replaceAgentBinding;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.VoiceId = voiceId;
            this.ReplyTimeoutMs = replyTimeoutMs;
            this.FallbackLine = fallbackLine;
            this.GoodbyeLine = goodbyeLine;
            this.ApiVersion = apiVersion;
            this.Greeting = greeting;
            this.TransferNumber = transferNumber;
            this.HangupAfterSilenceSeconds = hangupAfterSilenceSeconds;
            this.AiDisclosure = aiDisclosure;
            this.IntendedUse = intendedUse;
            this.TosAccepted = tosAccepted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayBinding" /> class.
        /// </summary>
        public RelayBinding()
        {
        }

    }
}