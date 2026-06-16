
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional. Server derives slug from name with a random suffix when omitted; if you supply your own, a collision returns 400 'slug already taken'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Greeting spoken verbatim at session start when included in the agent's flow graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstMessage { get; set; }

        /// <summary>
        /// ISO 639-1 code. Defaults to 'en' when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// LLM backend. Leave empty (or omit both `llm_provider` and<br/>
        /// `llm_model`) to use the platform default (today: Speechify<br/>
        /// Kimi K2.6, resolved server-side at dispatch). When set,<br/>
        /// must be paired with a non-empty `llm_model`; mixing a<br/>
        /// populated provider with an empty model is rejected as a<br/>
        /// 400. `custom` additionally requires `llm_base_url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.CreateAgentRequestLlmProviderJsonConverter))]
        public global::Speechify.CreateAgentRequestLlmProvider? LlmProvider { get; set; }

        /// <summary>
        /// Chat model slug. Leave empty to use the platform default.<br/>
        /// For `openai` / `speechify` the (provider, model) pair must<br/>
        /// be in the allowed table; for `custom` it is free-form.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// Custom OpenAI/vLLM-compatible endpoint base URL. Required<br/>
        /// when `llm_provider` is `custom`, rejected otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_base_url")]
        public string? LlmBaseUrl { get; set; }

        /// <summary>
        /// Bearer key for the custom endpoint. Write-only - stored<br/>
        /// encrypted, never returned (GET exposes `llm_api_key_set`).<br/>
        /// Optional even for `custom` (keyless endpoints); rejected<br/>
        /// for any other provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_api_key")]
        public string? LlmApiKey { get; set; }

        /// <summary>
        /// Optional JSON object forwarded verbatim to the custom<br/>
        /// endpoint as the chat.completions `extra_body` (reasoning /<br/>
        /// sampling knobs). Valid only when `llm_provider` is<br/>
        /// `custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_extra_body")]
        public object? LlmExtraBody { get; set; }

        /// <summary>
        /// Voice slug from the VMS catalog (see GET /v1/voices). Required — the server rejects writes with an unknown or empty slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Sampling temperature in the range 0.0–1.0. Defaults to 0.5 when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

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
        /// Defaults to false when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_origins")]
        public global::System.Collections.Generic.IList<string>? AllowedOrigins { get; set; }

        /// <summary>
        /// Optional per-agent hostname allowlist (see Agent schema).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname_allowlist")]
        public global::System.Collections.Generic.IList<string>? HostnameAllowlist { get; set; }

        /// <summary>
        /// Defaults to false when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_enabled")]
        public bool? MemoryEnabled { get; set; }

        /// <summary>
        /// Defaults to 90 when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_retention_days")]
        public int? MemoryRetentionDays { get; set; }

        /// <summary>
        /// Customer-facing post-call webhook URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// HMAC-SHA256 secret seed. Write-only — never echoed back on<br/>
        /// reads; clients see `webhook_secret_set: true` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// AMD routing config. Optional on create; omitted means AMD off. See AMDConfig schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amd")]
        public global::Speechify.AMDConfig? Amd { get; set; }

        /// <summary>
        /// When set, opts the agent into per-conversation audio recording. Defaults to false when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_audio_recording")]
        public bool? SaveAudioRecording { get; set; }

        /// <summary>
        /// When set, opts the agent into IVR-tuned turn handling. Defaults to false when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("navigator_mode")]
        public bool? NavigatorMode { get; set; }

        /// <summary>
        /// When omitted, defaults to true. Set to false to opt-out of the IVR-memory cache lookup for this agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ivr_memory_enabled")]
        public bool? IvrMemoryEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_speaking_rate")]
        public double? TtsSpeakingRate { get; set; }

        /// <summary>
        /// Post-process pitch-preserving time-stretch on the synthesized<br/>
        /// audio. See the field on Agent for semantics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_playback_rate")]
        public double? TtsPlaybackRate { get; set; }

        /// <summary>
        /// Per-agent override for the worker's endpointing min_delay on<br/>
        /// the VAD path (seconds). See the field on Agent for semantics.<br/>
        /// Range 0.0..5.0; null means use the stack default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_delay_seconds")]
        public double? ResponseDelaySeconds { get; set; }

        /// <summary>
        /// Per-agent silence-tolerance override in seconds. Send `0`<br/>
        /// to clear the override and fall back to the platform<br/>
        /// default. Negative values are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivity_timeout_seconds")]
        public int? InactivityTimeoutSeconds { get; set; }

        /// <summary>
        /// Pre-mixed ambient bed slug. Send empty string ("") to<br/>
        /// disable the bed, which also clears `background_noise_volume`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.CreateAgentRequestBackgroundNoisePresetJsonConverter))]
        public global::Speechify.CreateAgentRequestBackgroundNoisePreset? BackgroundNoisePreset { get; set; }

        /// <summary>
        /// Volume of the background-noise bed (0..1). Ignored when<br/>
        /// `background_noise_preset` is empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise_volume")]
        public double? BackgroundNoiseVolume { get; set; }

        /// <summary>
        /// Optional non-default streaming-STT stack for this agent.<br/>
        /// Omit to use the worker's default stack (today: whisper-v3).<br/>
        /// See the Agent schema for the full option semantics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_override")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.CreateAgentRequestSttOverrideJsonConverter))]
        public global::Speechify.CreateAgentRequestSttOverride? SttOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="prompt"></param>
        /// <param name="firstMessage">
        /// Greeting spoken verbatim at session start when included in the agent's flow graph.
        /// </param>
        /// <param name="voiceId">
        /// Voice slug from the VMS catalog (see GET /v1/voices). Required — the server rejects writes with an unknown or empty slug.
        /// </param>
        /// <param name="slug">
        /// Optional. Server derives slug from name with a random suffix when omitted; if you supply your own, a collision returns 400 'slug already taken'.
        /// </param>
        /// <param name="language">
        /// ISO 639-1 code. Defaults to 'en' when omitted.
        /// </param>
        /// <param name="llmProvider">
        /// LLM backend. Leave empty (or omit both `llm_provider` and<br/>
        /// `llm_model`) to use the platform default (today: Speechify<br/>
        /// Kimi K2.6, resolved server-side at dispatch). When set,<br/>
        /// must be paired with a non-empty `llm_model`; mixing a<br/>
        /// populated provider with an empty model is rejected as a<br/>
        /// 400. `custom` additionally requires `llm_base_url`.
        /// </param>
        /// <param name="llmModel">
        /// Chat model slug. Leave empty to use the platform default.<br/>
        /// For `openai` / `speechify` the (provider, model) pair must<br/>
        /// be in the allowed table; for `custom` it is free-form.
        /// </param>
        /// <param name="llmBaseUrl">
        /// Custom OpenAI/vLLM-compatible endpoint base URL. Required<br/>
        /// when `llm_provider` is `custom`, rejected otherwise.
        /// </param>
        /// <param name="llmApiKey">
        /// Bearer key for the custom endpoint. Write-only - stored<br/>
        /// encrypted, never returned (GET exposes `llm_api_key_set`).<br/>
        /// Optional even for `custom` (keyless endpoints); rejected<br/>
        /// for any other provider.
        /// </param>
        /// <param name="llmExtraBody">
        /// Optional JSON object forwarded verbatim to the custom<br/>
        /// endpoint as the chat.completions `extra_body` (reasoning /<br/>
        /// sampling knobs). Valid only when `llm_provider` is<br/>
        /// `custom`.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature in the range 0.0–1.0. Defaults to 0.5 when omitted.
        /// </param>
        /// <param name="widgetConfig">
        /// Customer-editable appearance + behaviour payload for the<br/>
        /// embedded `&lt;speechify-agent&gt;` pill: button text, avatar style,<br/>
        /// orb colours, terms-and-conditions markdown, transcript display.<br/>
        /// Every field is optional - empty fields fall back to the<br/>
        /// widget's compile-time defaults.
        /// </param>
        /// <param name="isPublic">
        /// Defaults to false when omitted.
        /// </param>
        /// <param name="allowedOrigins"></param>
        /// <param name="hostnameAllowlist">
        /// Optional per-agent hostname allowlist (see Agent schema).
        /// </param>
        /// <param name="memoryEnabled">
        /// Defaults to false when omitted.
        /// </param>
        /// <param name="memoryRetentionDays">
        /// Defaults to 90 when omitted.
        /// </param>
        /// <param name="webhookUrl">
        /// Customer-facing post-call webhook URL.
        /// </param>
        /// <param name="webhookSecret">
        /// HMAC-SHA256 secret seed. Write-only — never echoed back on<br/>
        /// reads; clients see `webhook_secret_set: true` instead.
        /// </param>
        /// <param name="amd">
        /// AMD routing config. Optional on create; omitted means AMD off. See AMDConfig schema.
        /// </param>
        /// <param name="saveAudioRecording">
        /// When set, opts the agent into per-conversation audio recording. Defaults to false when omitted.
        /// </param>
        /// <param name="navigatorMode">
        /// When set, opts the agent into IVR-tuned turn handling. Defaults to false when omitted.
        /// </param>
        /// <param name="ivrMemoryEnabled">
        /// When omitted, defaults to true. Set to false to opt-out of the IVR-memory cache lookup for this agent.
        /// </param>
        /// <param name="ttsSpeakingRate"></param>
        /// <param name="ttsPlaybackRate">
        /// Post-process pitch-preserving time-stretch on the synthesized<br/>
        /// audio. See the field on Agent for semantics.
        /// </param>
        /// <param name="responseDelaySeconds">
        /// Per-agent override for the worker's endpointing min_delay on<br/>
        /// the VAD path (seconds). See the field on Agent for semantics.<br/>
        /// Range 0.0..5.0; null means use the stack default.
        /// </param>
        /// <param name="inactivityTimeoutSeconds">
        /// Per-agent silence-tolerance override in seconds. Send `0`<br/>
        /// to clear the override and fall back to the platform<br/>
        /// default. Negative values are rejected.
        /// </param>
        /// <param name="backgroundNoisePreset">
        /// Pre-mixed ambient bed slug. Send empty string ("") to<br/>
        /// disable the bed, which also clears `background_noise_volume`.
        /// </param>
        /// <param name="backgroundNoiseVolume">
        /// Volume of the background-noise bed (0..1). Ignored when<br/>
        /// `background_noise_preset` is empty.
        /// </param>
        /// <param name="sttOverride">
        /// Optional non-default streaming-STT stack for this agent.<br/>
        /// Omit to use the worker's default stack (today: whisper-v3).<br/>
        /// See the Agent schema for the full option semantics.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRequest(
            string name,
            string prompt,
            string firstMessage,
            string voiceId,
            string? slug,
            string? language,
            global::Speechify.CreateAgentRequestLlmProvider? llmProvider,
            string? llmModel,
            string? llmBaseUrl,
            string? llmApiKey,
            object? llmExtraBody,
            double? temperature,
            global::Speechify.WidgetConfig? widgetConfig,
            bool? isPublic,
            global::System.Collections.Generic.IList<string>? allowedOrigins,
            global::System.Collections.Generic.IList<string>? hostnameAllowlist,
            bool? memoryEnabled,
            int? memoryRetentionDays,
            string? webhookUrl,
            string? webhookSecret,
            global::Speechify.AMDConfig? amd,
            bool? saveAudioRecording,
            bool? navigatorMode,
            bool? ivrMemoryEnabled,
            double? ttsSpeakingRate,
            double? ttsPlaybackRate,
            double? responseDelaySeconds,
            int? inactivityTimeoutSeconds,
            global::Speechify.CreateAgentRequestBackgroundNoisePreset? backgroundNoisePreset,
            double? backgroundNoiseVolume,
            global::Speechify.CreateAgentRequestSttOverride? sttOverride)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.FirstMessage = firstMessage ?? throw new global::System.ArgumentNullException(nameof(firstMessage));
            this.Language = language;
            this.LlmProvider = llmProvider;
            this.LlmModel = llmModel;
            this.LlmBaseUrl = llmBaseUrl;
            this.LlmApiKey = llmApiKey;
            this.LlmExtraBody = llmExtraBody;
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Temperature = temperature;
            this.WidgetConfig = widgetConfig;
            this.IsPublic = isPublic;
            this.AllowedOrigins = allowedOrigins;
            this.HostnameAllowlist = hostnameAllowlist;
            this.MemoryEnabled = memoryEnabled;
            this.MemoryRetentionDays = memoryRetentionDays;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
            this.Amd = amd;
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
        /// </summary>
        public CreateAgentRequest()
        {
        }

    }
}