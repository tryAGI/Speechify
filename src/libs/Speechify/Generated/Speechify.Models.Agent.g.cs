
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Agent
    {
        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`).<br/>
        /// This is the sole customer-facing<br/>
        /// identifier. URL paths accept only this prefixed form; legacy<br/>
        /// UUID path parameters are rejected with 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Spoken verbatim at session start when present in the customer's flow graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstMessage { get; set; }

        /// <summary>
        /// ISO 639-1 code, e.g. 'en'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// LLM backend the worker constructs for this agent. Null<br/>
        /// means "use the platform default" (resolved server-side at<br/>
        /// dispatch; today: Speechify Kimi K2.6). `openai` and<br/>
        /// `speechify` pair with a model from the allowed (provider,<br/>
        /// model) table. `custom` points the worker at any OpenAI /<br/>
        /// vLLM-compatible endpoint - see `llm_base_url`,<br/>
        /// `llm_api_key`, `llm_extra_body`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentLlmProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentLlmProvider LlmProvider { get; set; }

        /// <summary>
        /// Chat model slug. Null means "use the platform default"<br/>
        /// (resolved server-side at dispatch; today: Speechify Kimi<br/>
        /// K2.6). For `openai` / `speechify` it must be a slug from<br/>
        /// the allowed table; for `custom` it is free-form (the<br/>
        /// customer's endpoint owns the namespace).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// Custom OpenAI/vLLM-compatible endpoint base URL. Non-null<br/>
        /// only when `llm_provider` is `custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_base_url")]
        public string? LlmBaseUrl { get; set; }

        /// <summary>
        /// Whether a bearer key is stored for the custom endpoint.<br/>
        /// The key itself is write-only and never returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_api_key_set")]
        public bool? LlmApiKeySet { get; set; }

        /// <summary>
        /// JSON object forwarded verbatim to the custom endpoint as<br/>
        /// the chat.completions `extra_body` (reasoning / sampling<br/>
        /// knobs). Non-null only when `llm_provider` is `custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_extra_body")]
        public object? LlmExtraBody { get; set; }

        /// <summary>
        /// Speechify voice slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Temperature { get; set; }

        /// <summary>
        /// Customer-editable appearance + behaviour payload for the<br/>
        /// embedded `&lt;speechify-agent&gt;` pill: button text, avatar style,<br/>
        /// orb colours, terms-and-conditions markdown, transcript display.<br/>
        /// Every field is optional - empty fields fall back to the<br/>
        /// widget's compile-time defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget_config")]
        public global::Speechify.WidgetConfig? WidgetConfig { get; set; }

        /// <summary>
        /// When true, the `&lt;speechify-agent&gt;` web component can start a<br/>
        /// session against this agent without an API key, subject to<br/>
        /// the `allowed_origins` allowlist. When false (default), only<br/>
        /// authenticated callers can start sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPublic { get; set; }

        /// <summary>
        /// Exact `Origin` header values (e.g. `https://example.com`)<br/>
        /// that are allowed to start public sessions. Empty array<br/>
        /// with `is_public = true` means any origin is accepted —<br/>
        /// intended for open demos. No subdomain wildcards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_origins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedOrigins { get; set; }

        /// <summary>
        /// Optional per-agent hostname allowlist enforced at<br/>
        /// session-creation time. When set and non-empty, the<br/>
        /// `Origin` header's hostname must be an exact member.<br/>
        /// Bare hostnames only — no scheme, port, or path. Up to<br/>
        /// 10 entries. Omit (null) or leave empty for no<br/>
        /// enforcement (public agents accept any hostname).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname_allowlist")]
        public global::System.Collections.Generic.IList<string>? HostnameAllowlist { get; set; }

        /// <summary>
        /// When true, the post-call extractor writes durable facts about<br/>
        /// each caller; at conversation-start the retriever injects the<br/>
        /// top matches into the system prompt via the `{{memory}}`<br/>
        /// template variable. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MemoryEnabled { get; set; }

        /// <summary>
        /// Maximum age (in days) of memories kept and surfaced to the<br/>
        /// retriever. 0 disables the cap. Defaults to 90.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_retention_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoryRetentionDays { get; set; }

        /// <summary>
        /// Customer-facing post-call webhook target. When non-empty,<br/>
        /// the control plane POSTs a signed payload (transcript +<br/>
        /// evals + extractors + recording URL) once the conversation<br/>
        /// completes. Empty disables the fire path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// True when an HMAC-SHA256 webhook secret is configured. The<br/>
        /// secret itself is write-only — supplied on PATCH and never<br/>
        /// echoed back on reads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret_set")]
        public bool? WebhookSecretSet { get; set; }

        /// <summary>
        /// Answering Machine Detection routing config for outbound voice<br/>
        /// agents. AMD classifies the called party's first ~3-15 seconds of<br/>
        /// audio into one of LiveKit's categories (human, uncertain,<br/>
        /// machine-vm, machine-ivr, machine-unavailable) and dispatches per<br/>
        /// category to the configured action. Stored on the agent row;<br/>
        /// flowed onto outbound dispatch metadata under the `amd` key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AMDConfig Amd { get; set; }

        /// <summary>
        /// When true, every conversation produces a room-composite<br/>
        /// OGG egress uploaded to the recordings bucket. Defaults<br/>
        /// FALSE for new agents (privacy by default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_audio_recording")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SaveAudioRecording { get; set; }

        /// <summary>
        /// Tunes worker turn handling for autonomous outbound IVR<br/>
        /// navigation - longer endpointing and no barge-in. The goal<br/>
        /// itself lives in the agent's prompt; this flag is the<br/>
        /// behaviour switch only. Defaults FALSE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("navigator_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool NavigatorMode { get; set; }

        /// <summary>
        /// Per-agent kill switch for the IVR-memory cache lookup<br/>
        /// performed at AMD time. Defaults TRUE so existing navigator<br/>
        /// agents keep their always-on behaviour. Set to false to skip<br/>
        /// the cache and force every outbound dial on this agent to<br/>
        /// start cold (LLM-driven navigation only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ivr_memory_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IvrMemoryEnabled { get; set; }

        /// <summary>
        /// Per-agent override for the voice's default speaking rate<br/>
        /// (0.5 = half speed, 2.0 = double, 1.0 = neutral). Null<br/>
        /// means "use the voice's default rate".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_speaking_rate")]
        public double? TtsSpeakingRate { get; set; }

        /// <summary>
        /// Per-agent post-process pitch-preserving time-stretch applied<br/>
        /// to the synthesized audio in the worker before publishing.<br/>
        /// Distinct from tts_speaking_rate: speaking_rate biases the<br/>
        /// model's generation prosody (clipped syllables, pauses<br/>
        /// preserved); playback_rate uniformly stretches the rendered<br/>
        /// waveform (every sample, every pause, every breath). Range<br/>
        /// 0.5..3.0; null means no post-process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_playback_rate")]
        public double? TtsPlaybackRate { get; set; }

        /// <summary>
        /// How long the agent waits after the caller stops talking<br/>
        /// before generating a reply (the worker's endpointing<br/>
        /// min_delay on the VAD path). Range 0.0..5.0. Null means<br/>
        /// "use the stack default" — Deepgram VAD: 0.5s, or 0.75s<br/>
        /// when `navigator_mode=true`. Ignored on Flux + Whisper<br/>
        /// STT, which use semantic turn detection instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_delay_seconds")]
        public double? ResponseDelaySeconds { get; set; }

        /// <summary>
        /// Optional override for the per-agent silence-tolerance<br/>
        /// before the worker tears the call down. Null means use<br/>
        /// the platform default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivity_timeout_seconds")]
        public int? InactivityTimeoutSeconds { get; set; }

        /// <summary>
        /// Optional pre-mixed ambient bed. Null disables background<br/>
        /// noise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentBackgroundNoisePresetJsonConverter))]
        public global::Speechify.AgentBackgroundNoisePreset? BackgroundNoisePreset { get; set; }

        /// <summary>
        /// Volume of the background-noise bed. Null disables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise_volume")]
        public double? BackgroundNoiseVolume { get; set; }

        /// <summary>
        /// Optional override for the streaming-STT stack this agent<br/>
        /// dispatches with. Null means use the worker's default<br/>
        /// stack (today: whisper-v3, Baseten Whisper Large V3). Pick<br/>
        /// `whisper-v3` to pin Whisper Large V3 explicitly, `flux` to<br/>
        /// opt into Deepgram Flux's semantic end-of-turn detection, or<br/>
        /// `gpt-realtime-whisper` for OpenAI's streaming Whisper-class<br/>
        /// STT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_override")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentSttOverrideJsonConverter))]
        public global::Speechify.AgentSttOverride? SttOverride { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`).<br/>
        /// This is the sole customer-facing<br/>
        /// identifier. URL paths accept only this prefixed form; legacy<br/>
        /// UUID path parameters are rejected with 404.
        /// </param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="prompt"></param>
        /// <param name="firstMessage">
        /// Spoken verbatim at session start when present in the customer's flow graph.
        /// </param>
        /// <param name="language">
        /// ISO 639-1 code, e.g. 'en'.
        /// </param>
        /// <param name="llmProvider">
        /// LLM backend the worker constructs for this agent. Null<br/>
        /// means "use the platform default" (resolved server-side at<br/>
        /// dispatch; today: Speechify Kimi K2.6). `openai` and<br/>
        /// `speechify` pair with a model from the allowed (provider,<br/>
        /// model) table. `custom` points the worker at any OpenAI /<br/>
        /// vLLM-compatible endpoint - see `llm_base_url`,<br/>
        /// `llm_api_key`, `llm_extra_body`.
        /// </param>
        /// <param name="voiceId">
        /// Speechify voice slug.
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="isPublic">
        /// When true, the `&lt;speechify-agent&gt;` web component can start a<br/>
        /// session against this agent without an API key, subject to<br/>
        /// the `allowed_origins` allowlist. When false (default), only<br/>
        /// authenticated callers can start sessions.
        /// </param>
        /// <param name="allowedOrigins">
        /// Exact `Origin` header values (e.g. `https://example.com`)<br/>
        /// that are allowed to start public sessions. Empty array<br/>
        /// with `is_public = true` means any origin is accepted —<br/>
        /// intended for open demos. No subdomain wildcards.
        /// </param>
        /// <param name="memoryEnabled">
        /// When true, the post-call extractor writes durable facts about<br/>
        /// each caller; at conversation-start the retriever injects the<br/>
        /// top matches into the system prompt via the `{{memory}}`<br/>
        /// template variable. Defaults to false.
        /// </param>
        /// <param name="memoryRetentionDays">
        /// Maximum age (in days) of memories kept and surfaced to the<br/>
        /// retriever. 0 disables the cap. Defaults to 90.
        /// </param>
        /// <param name="amd">
        /// Answering Machine Detection routing config for outbound voice<br/>
        /// agents. AMD classifies the called party's first ~3-15 seconds of<br/>
        /// audio into one of LiveKit's categories (human, uncertain,<br/>
        /// machine-vm, machine-ivr, machine-unavailable) and dispatches per<br/>
        /// category to the configured action. Stored on the agent row;<br/>
        /// flowed onto outbound dispatch metadata under the `amd` key.
        /// </param>
        /// <param name="saveAudioRecording">
        /// When true, every conversation produces a room-composite<br/>
        /// OGG egress uploaded to the recordings bucket. Defaults<br/>
        /// FALSE for new agents (privacy by default).
        /// </param>
        /// <param name="navigatorMode">
        /// Tunes worker turn handling for autonomous outbound IVR<br/>
        /// navigation - longer endpointing and no barge-in. The goal<br/>
        /// itself lives in the agent's prompt; this flag is the<br/>
        /// behaviour switch only. Defaults FALSE.
        /// </param>
        /// <param name="ivrMemoryEnabled">
        /// Per-agent kill switch for the IVR-memory cache lookup<br/>
        /// performed at AMD time. Defaults TRUE so existing navigator<br/>
        /// agents keep their always-on behaviour. Set to false to skip<br/>
        /// the cache and force every outbound dial on this agent to<br/>
        /// start cold (LLM-driven navigation only).
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="llmModel">
        /// Chat model slug. Null means "use the platform default"<br/>
        /// (resolved server-side at dispatch; today: Speechify Kimi<br/>
        /// K2.6). For `openai` / `speechify` it must be a slug from<br/>
        /// the allowed table; for `custom` it is free-form (the<br/>
        /// customer's endpoint owns the namespace).
        /// </param>
        /// <param name="llmBaseUrl">
        /// Custom OpenAI/vLLM-compatible endpoint base URL. Non-null<br/>
        /// only when `llm_provider` is `custom`.
        /// </param>
        /// <param name="llmApiKeySet">
        /// Whether a bearer key is stored for the custom endpoint.<br/>
        /// The key itself is write-only and never returned.
        /// </param>
        /// <param name="llmExtraBody">
        /// JSON object forwarded verbatim to the custom endpoint as<br/>
        /// the chat.completions `extra_body` (reasoning / sampling<br/>
        /// knobs). Non-null only when `llm_provider` is `custom`.
        /// </param>
        /// <param name="widgetConfig">
        /// Customer-editable appearance + behaviour payload for the<br/>
        /// embedded `&lt;speechify-agent&gt;` pill: button text, avatar style,<br/>
        /// orb colours, terms-and-conditions markdown, transcript display.<br/>
        /// Every field is optional - empty fields fall back to the<br/>
        /// widget's compile-time defaults.
        /// </param>
        /// <param name="hostnameAllowlist">
        /// Optional per-agent hostname allowlist enforced at<br/>
        /// session-creation time. When set and non-empty, the<br/>
        /// `Origin` header's hostname must be an exact member.<br/>
        /// Bare hostnames only — no scheme, port, or path. Up to<br/>
        /// 10 entries. Omit (null) or leave empty for no<br/>
        /// enforcement (public agents accept any hostname).
        /// </param>
        /// <param name="webhookUrl">
        /// Customer-facing post-call webhook target. When non-empty,<br/>
        /// the control plane POSTs a signed payload (transcript +<br/>
        /// evals + extractors + recording URL) once the conversation<br/>
        /// completes. Empty disables the fire path.
        /// </param>
        /// <param name="webhookSecretSet">
        /// True when an HMAC-SHA256 webhook secret is configured. The<br/>
        /// secret itself is write-only — supplied on PATCH and never<br/>
        /// echoed back on reads.
        /// </param>
        /// <param name="ttsSpeakingRate">
        /// Per-agent override for the voice's default speaking rate<br/>
        /// (0.5 = half speed, 2.0 = double, 1.0 = neutral). Null<br/>
        /// means "use the voice's default rate".
        /// </param>
        /// <param name="ttsPlaybackRate">
        /// Per-agent post-process pitch-preserving time-stretch applied<br/>
        /// to the synthesized audio in the worker before publishing.<br/>
        /// Distinct from tts_speaking_rate: speaking_rate biases the<br/>
        /// model's generation prosody (clipped syllables, pauses<br/>
        /// preserved); playback_rate uniformly stretches the rendered<br/>
        /// waveform (every sample, every pause, every breath). Range<br/>
        /// 0.5..3.0; null means no post-process.
        /// </param>
        /// <param name="responseDelaySeconds">
        /// How long the agent waits after the caller stops talking<br/>
        /// before generating a reply (the worker's endpointing<br/>
        /// min_delay on the VAD path). Range 0.0..5.0. Null means<br/>
        /// "use the stack default" — Deepgram VAD: 0.5s, or 0.75s<br/>
        /// when `navigator_mode=true`. Ignored on Flux + Whisper<br/>
        /// STT, which use semantic turn detection instead.
        /// </param>
        /// <param name="inactivityTimeoutSeconds">
        /// Optional override for the per-agent silence-tolerance<br/>
        /// before the worker tears the call down. Null means use<br/>
        /// the platform default.
        /// </param>
        /// <param name="backgroundNoisePreset">
        /// Optional pre-mixed ambient bed. Null disables background<br/>
        /// noise.
        /// </param>
        /// <param name="backgroundNoiseVolume">
        /// Volume of the background-noise bed. Null disables.
        /// </param>
        /// <param name="sttOverride">
        /// Optional override for the streaming-STT stack this agent<br/>
        /// dispatches with. Null means use the worker's default<br/>
        /// stack (today: whisper-v3, Baseten Whisper Large V3). Pick<br/>
        /// `whisper-v3` to pin Whisper Large V3 explicitly, `flux` to<br/>
        /// opt into Deepgram Flux's semantic end-of-turn detection, or<br/>
        /// `gpt-realtime-whisper` for OpenAI's streaming Whisper-class<br/>
        /// STT.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Agent(
            string id,
            string name,
            string slug,
            string prompt,
            string firstMessage,
            string language,
            global::Speechify.AgentLlmProvider llmProvider,
            string voiceId,
            double temperature,
            bool isPublic,
            global::System.Collections.Generic.IList<string> allowedOrigins,
            bool memoryEnabled,
            int memoryRetentionDays,
            global::Speechify.AMDConfig amd,
            bool saveAudioRecording,
            bool navigatorMode,
            bool ivrMemoryEnabled,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? llmModel,
            string? llmBaseUrl,
            bool? llmApiKeySet,
            object? llmExtraBody,
            global::Speechify.WidgetConfig? widgetConfig,
            global::System.Collections.Generic.IList<string>? hostnameAllowlist,
            string? webhookUrl,
            bool? webhookSecretSet,
            double? ttsSpeakingRate,
            double? ttsPlaybackRate,
            double? responseDelaySeconds,
            int? inactivityTimeoutSeconds,
            global::Speechify.AgentBackgroundNoisePreset? backgroundNoisePreset,
            double? backgroundNoiseVolume,
            global::Speechify.AgentSttOverride? sttOverride)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.FirstMessage = firstMessage ?? throw new global::System.ArgumentNullException(nameof(firstMessage));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.LlmProvider = llmProvider;
            this.LlmModel = llmModel;
            this.LlmBaseUrl = llmBaseUrl;
            this.LlmApiKeySet = llmApiKeySet;
            this.LlmExtraBody = llmExtraBody;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Temperature = temperature;
            this.WidgetConfig = widgetConfig;
            this.IsPublic = isPublic;
            this.AllowedOrigins = allowedOrigins ?? throw new global::System.ArgumentNullException(nameof(allowedOrigins));
            this.HostnameAllowlist = hostnameAllowlist;
            this.MemoryEnabled = memoryEnabled;
            this.MemoryRetentionDays = memoryRetentionDays;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecretSet = webhookSecretSet;
            this.Amd = amd ?? throw new global::System.ArgumentNullException(nameof(amd));
            this.SaveAudioRecording = saveAudioRecording;
            this.NavigatorMode = navigatorMode;
            this.IvrMemoryEnabled = ivrMemoryEnabled;
            this.TtsSpeakingRate = ttsSpeakingRate;
            this.TtsPlaybackRate = ttsPlaybackRate;
            this.ResponseDelaySeconds = responseDelaySeconds;
            this.InactivityTimeoutSeconds = inactivityTimeoutSeconds;
            this.BackgroundNoisePreset = backgroundNoisePreset;
            this.BackgroundNoiseVolume = backgroundNoiseVolume;
            this.SttOverride = sttOverride;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        public Agent()
        {
        }

    }
}