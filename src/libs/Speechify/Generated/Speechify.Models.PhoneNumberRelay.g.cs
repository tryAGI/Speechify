
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A number's relay binding: the HTTPS endpoint that answers the<br/>
    /// number's traffic, plus how replies are spoken and how failures are<br/>
    /// handled. The signing secret appears exactly once - on the response<br/>
    /// that bound the relay and on rotate-secret - and is otherwise never<br/>
    /// returned.
    /// </summary>
    public sealed partial class PhoneNumberRelay
    {
        /// <summary>
        /// The HTTPS endpoint receiving this number's events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Voice that speaks the relayed replies. When absent, the platform<br/>
        /// default voice is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Per-turn deadline in milliseconds for the endpoint to answer a<br/>
        /// reply-bearing event. Default 5000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_timeout_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReplyTimeoutMs { get; set; }

        /// <summary>
        /// Line spoken to cover a slow or failing endpoint while the<br/>
        /// delivery is retried (e.g. "One moment please").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_line")]
        public string? FallbackLine { get; set; }

        /// <summary>
        /// Line spoken before hanging up when the endpoint stays<br/>
        /// unreachable after the retry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goodbye_line")]
        public string? GoodbyeLine { get; set; }

        /// <summary>
        /// Dated version (`YYYY-MM-DD`) the relay's event payloads are<br/>
        /// rendered at. When absent, deliveries follow the workspace's<br/>
        /// current version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Line spoken when the call is picked up, ahead of the webhook's own<br/>
        /// `call.started` reply (and after any AI-disclosure line). Omitted<br/>
        /// when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("greeting")]
        public string? Greeting { get; set; }

        /// <summary>
        /// Default cold-transfer destination in E.164, used when a reply asks<br/>
        /// to transfer without an explicit target. Omitted when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_number")]
        public string? TransferNumber { get; set; }

        /// <summary>
        /// Auto-hangup silence timeout in seconds. Omitted when unset (no<br/>
        /// silence hangup).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hangup_after_silence_seconds")]
        public int? HangupAfterSilenceSeconds { get; set; }

        /// <summary>
        /// Opt-in AI-disclosure opening line spoken first on `call.started`,<br/>
        /// before the webhook greeting. Omitted when off (the default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_disclosure")]
        public global::Speechify.AIDisclosure? AiDisclosure { get; set; }

        /// <summary>
        /// HMAC signing secret (`whsec_...`) for verifying the<br/>
        /// `Speechify-Signature` header on deliveries. Present ONLY in the<br/>
        /// response that FIRST bound the relay and in the rotate-secret<br/>
        /// response; store it, it cannot be retrieved later. Editing a relay<br/>
        /// setting on an already-bound number never mints a new one, so the<br/>
        /// copy you stored keeps verifying - rotate-secret is the only way<br/>
        /// to replace it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signing_secret")]
        public string? SigningSecret { get; set; }

        /// <summary>
        /// Read-only endpoint health. `unhealthy` after several consecutive<br/>
        /// delivery failures: inbound calls answer with the goodbye line and<br/>
        /// SMS events are parked instead of delivered. Resets to `healthy`<br/>
        /// on the next successful delivery, on rebinding the relay, or on<br/>
        /// rotating the secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.PhoneNumberRelayHealthJsonConverter))]
        public global::Speechify.PhoneNumberRelayHealth? Health { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberRelay" /> class.
        /// </summary>
        /// <param name="url">
        /// The HTTPS endpoint receiving this number's events.
        /// </param>
        /// <param name="replyTimeoutMs">
        /// Per-turn deadline in milliseconds for the endpoint to answer a<br/>
        /// reply-bearing event. Default 5000.
        /// </param>
        /// <param name="voiceId">
        /// Voice that speaks the relayed replies. When absent, the platform<br/>
        /// default voice is used.
        /// </param>
        /// <param name="fallbackLine">
        /// Line spoken to cover a slow or failing endpoint while the<br/>
        /// delivery is retried (e.g. "One moment please").
        /// </param>
        /// <param name="goodbyeLine">
        /// Line spoken before hanging up when the endpoint stays<br/>
        /// unreachable after the retry.
        /// </param>
        /// <param name="apiVersion">
        /// Dated version (`YYYY-MM-DD`) the relay's event payloads are<br/>
        /// rendered at. When absent, deliveries follow the workspace's<br/>
        /// current version.
        /// </param>
        /// <param name="greeting">
        /// Line spoken when the call is picked up, ahead of the webhook's own<br/>
        /// `call.started` reply (and after any AI-disclosure line). Omitted<br/>
        /// when unset.
        /// </param>
        /// <param name="transferNumber">
        /// Default cold-transfer destination in E.164, used when a reply asks<br/>
        /// to transfer without an explicit target. Omitted when unset.
        /// </param>
        /// <param name="hangupAfterSilenceSeconds">
        /// Auto-hangup silence timeout in seconds. Omitted when unset (no<br/>
        /// silence hangup).
        /// </param>
        /// <param name="aiDisclosure">
        /// Opt-in AI-disclosure opening line spoken first on `call.started`,<br/>
        /// before the webhook greeting. Omitted when off (the default).
        /// </param>
        /// <param name="signingSecret">
        /// HMAC signing secret (`whsec_...`) for verifying the<br/>
        /// `Speechify-Signature` header on deliveries. Present ONLY in the<br/>
        /// response that FIRST bound the relay and in the rotate-secret<br/>
        /// response; store it, it cannot be retrieved later. Editing a relay<br/>
        /// setting on an already-bound number never mints a new one, so the<br/>
        /// copy you stored keeps verifying - rotate-secret is the only way<br/>
        /// to replace it.
        /// </param>
        /// <param name="health">
        /// Read-only endpoint health. `unhealthy` after several consecutive<br/>
        /// delivery failures: inbound calls answer with the goodbye line and<br/>
        /// SMS events are parked instead of delivered. Resets to `healthy`<br/>
        /// on the next successful delivery, on rebinding the relay, or on<br/>
        /// rotating the secret.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberRelay(
            string url,
            int replyTimeoutMs,
            string? voiceId,
            string? fallbackLine,
            string? goodbyeLine,
            string? apiVersion,
            string? greeting,
            string? transferNumber,
            int? hangupAfterSilenceSeconds,
            global::Speechify.AIDisclosure? aiDisclosure,
            string? signingSecret,
            global::Speechify.PhoneNumberRelayHealth? health)
        {
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
            this.SigningSecret = signingSecret;
            this.Health = health;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberRelay" /> class.
        /// </summary>
        public PhoneNumberRelay()
        {
        }

    }
}