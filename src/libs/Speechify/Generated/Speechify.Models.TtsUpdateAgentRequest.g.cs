
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for PATCH /v1/agents/{id}. Every field is optional;<br/>
    /// omitting a field leaves it unchanged. `slug` is intentionally<br/>
    /// not patchable (changing it would break embed URLs).
    /// </summary>
    public sealed partial class TtsUpdateAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// LLM backend. Send an empty string together with<br/>
        /// `llm_model: ""` to clear the pair to the platform default<br/>
        /// (today: Speechify Kimi K2.6). Sending one populated and<br/>
        /// one empty is rejected as a 400. Omit both to leave the<br/>
        /// stored pair unchanged. Switching to a non-`custom` provider<br/>
        /// clears any stored `llm_base_url` / `llm_api_key` /<br/>
        /// `llm_extra_body`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsUpdateAgentRequestLlmProviderJsonConverter))]
        public global::Speechify.TtsUpdateAgentRequestLlmProvider? LlmProvider { get; set; }

        /// <summary>
        /// Chat model slug. Empty string + empty `llm_provider`<br/>
        /// clears the pair to the platform default. For `openai` /<br/>
        /// `speechify` the (provider, model) pair must be in the<br/>
        /// allowed table; for `custom` it is free-form.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// Custom-endpoint base URL. Required when the resulting<br/>
        /// provider is `custom`, rejected otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_base_url")]
        public string? LlmBaseUrl { get; set; }

        /// <summary>
        /// Bearer key for the custom endpoint. Write-only. Omit to<br/>
        /// keep the stored key, send "" to clear it, send a value to<br/>
        /// replace it. Rejected for non-`custom` providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_api_key")]
        public string? LlmApiKey { get; set; }

        /// <summary>
        /// JSON object forwarded to the custom endpoint as<br/>
        /// chat.completions `extra_body`. Omit to leave unchanged;<br/>
        /// a JSON object (including `{}`) replaces it. Valid only<br/>
        /// when the resulting provider is `custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_extra_body")]
        public object? LlmExtraBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
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
        public global::Speechify.TtsWidgetConfig? WidgetConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_origins")]
        public global::System.Collections.Generic.IList<string>? AllowedOrigins { get; set; }

        /// <summary>
        /// When supplied, replaces the stored list. Pass an empty<br/>
        /// array to clear enforcement (public agent is open again).<br/>
        /// Omit the field to leave the existing value unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname_allowlist")]
        public global::System.Collections.Generic.IList<string>? HostnameAllowlist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_enabled")]
        public bool? MemoryEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_retention_days")]
        public int? MemoryRetentionDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Rotate the HMAC secret. Write-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// AMD routing config (PATCH-replace, wholesale). Omit to leave the stored config unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amd")]
        public global::Speechify.TtsAMDConfig? Amd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_audio_recording")]
        public bool? SaveAudioRecording { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("navigator_mode")]
        public bool? NavigatorMode { get; set; }

        /// <summary>
        /// Per-agent kill switch for the IVR-memory cache lookup. nil/omit = unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ivr_memory_enabled")]
        public bool? IvrMemoryEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_speaking_rate")]
        public double? TtsSpeakingRate { get; set; }

        /// <summary>
        /// Two-headed clear: PATCH cannot distinguish "absent" from<br/>
        /// "explicit null" reliably across stacks. Setting this to<br/>
        /// `true` resets `tts_speaking_rate` to the voice default.<br/>
        /// If both are sent, `clear_tts_speaking_rate` wins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_tts_speaking_rate")]
        public bool? ClearTtsSpeakingRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_playback_rate")]
        public double? TtsPlaybackRate { get; set; }

        /// <summary>
        /// Two-headed clear, mirroring `clear_tts_speaking_rate`.<br/>
        /// Setting this to `true` resets `tts_playback_rate` to null<br/>
        /// (no post-process). If both fields are sent,<br/>
        /// `clear_tts_playback_rate` wins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_tts_playback_rate")]
        public bool? ClearTtsPlaybackRate { get; set; }

        /// <summary>
        /// Per-agent silence-wait override (seconds). See the field<br/>
        /// on Agent for semantics. Range 0.0..5.0; null is allowed<br/>
        /// but `clear_response_delay_seconds=true` is the canonical<br/>
        /// way to revert to the stack default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_delay_seconds")]
        public double? ResponseDelaySeconds { get; set; }

        /// <summary>
        /// Two-headed clear, mirroring `clear_tts_playback_rate`.<br/>
        /// Setting this to `true` resets `response_delay_seconds` to<br/>
        /// null (revert to the stack default). If both are sent,<br/>
        /// `clear_response_delay_seconds` wins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_response_delay_seconds")]
        public bool? ClearResponseDelaySeconds { get; set; }

        /// <summary>
        /// Per-agent silence-tolerance override. Send `0` to clear<br/>
        /// the override and fall back to the platform default.<br/>
        /// Negative values are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivity_timeout_seconds")]
        public int? InactivityTimeoutSeconds { get; set; }

        /// <summary>
        /// Pre-mixed ambient bed slug. Send empty string ("") to<br/>
        /// disable the bed, which also clears `background_noise_volume`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsUpdateAgentRequestBackgroundNoisePresetJsonConverter))]
        public global::Speechify.TtsUpdateAgentRequestBackgroundNoisePreset? BackgroundNoisePreset { get; set; }

        /// <summary>
        /// Volume of the background-noise bed (0..1). Ignored when<br/>
        /// the preset is empty; clearing the preset also clears<br/>
        /// this field server-side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise_volume")]
        public double? BackgroundNoiseVolume { get; set; }

        /// <summary>
        /// Streaming-STT stack override. Send an empty string ("") to<br/>
        /// clear the override and fall back to the worker default<br/>
        /// (today: whisper-v3). Any non-empty value must be a known<br/>
        /// stack name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_override")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsUpdateAgentRequestSttOverrideJsonConverter))]
        public global::Speechify.TtsUpdateAgentRequestSttOverride? SttOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateAgentRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="prompt"></param>
        /// <param name="firstMessage"></param>
        /// <param name="language"></param>
        /// <param name="llmProvider">
        /// LLM backend. Send an empty string together with<br/>
        /// `llm_model: ""` to clear the pair to the platform default<br/>
        /// (today: Speechify Kimi K2.6). Sending one populated and<br/>
        /// one empty is rejected as a 400. Omit both to leave the<br/>
        /// stored pair unchanged. Switching to a non-`custom` provider<br/>
        /// clears any stored `llm_base_url` / `llm_api_key` /<br/>
        /// `llm_extra_body`.
        /// </param>
        /// <param name="llmModel">
        /// Chat model slug. Empty string + empty `llm_provider`<br/>
        /// clears the pair to the platform default. For `openai` /<br/>
        /// `speechify` the (provider, model) pair must be in the<br/>
        /// allowed table; for `custom` it is free-form.
        /// </param>
        /// <param name="llmBaseUrl">
        /// Custom-endpoint base URL. Required when the resulting<br/>
        /// provider is `custom`, rejected otherwise.
        /// </param>
        /// <param name="llmApiKey">
        /// Bearer key for the custom endpoint. Write-only. Omit to<br/>
        /// keep the stored key, send "" to clear it, send a value to<br/>
        /// replace it. Rejected for non-`custom` providers.
        /// </param>
        /// <param name="llmExtraBody">
        /// JSON object forwarded to the custom endpoint as<br/>
        /// chat.completions `extra_body`. Omit to leave unchanged;<br/>
        /// a JSON object (including `{}`) replaces it. Valid only<br/>
        /// when the resulting provider is `custom`.
        /// </param>
        /// <param name="voiceId"></param>
        /// <param name="temperature"></param>
        /// <param name="widgetConfig">
        /// Customer-editable appearance + behaviour payload for the<br/>
        /// embedded `&lt;speechify-agent&gt;` pill: button text, avatar style,<br/>
        /// orb colours, terms-and-conditions markdown, transcript display.<br/>
        /// Every field is optional - empty fields fall back to the<br/>
        /// widget's compile-time defaults.
        /// </param>
        /// <param name="isPublic"></param>
        /// <param name="allowedOrigins"></param>
        /// <param name="hostnameAllowlist">
        /// When supplied, replaces the stored list. Pass an empty<br/>
        /// array to clear enforcement (public agent is open again).<br/>
        /// Omit the field to leave the existing value unchanged.
        /// </param>
        /// <param name="memoryEnabled"></param>
        /// <param name="memoryRetentionDays"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookSecret">
        /// Rotate the HMAC secret. Write-only.
        /// </param>
        /// <param name="amd">
        /// AMD routing config (PATCH-replace, wholesale). Omit to leave the stored config unchanged.
        /// </param>
        /// <param name="saveAudioRecording"></param>
        /// <param name="navigatorMode"></param>
        /// <param name="ivrMemoryEnabled">
        /// Per-agent kill switch for the IVR-memory cache lookup. nil/omit = unchanged.
        /// </param>
        /// <param name="ttsSpeakingRate"></param>
        /// <param name="clearTtsSpeakingRate">
        /// Two-headed clear: PATCH cannot distinguish "absent" from<br/>
        /// "explicit null" reliably across stacks. Setting this to<br/>
        /// `true` resets `tts_speaking_rate` to the voice default.<br/>
        /// If both are sent, `clear_tts_speaking_rate` wins.
        /// </param>
        /// <param name="ttsPlaybackRate"></param>
        /// <param name="clearTtsPlaybackRate">
        /// Two-headed clear, mirroring `clear_tts_speaking_rate`.<br/>
        /// Setting this to `true` resets `tts_playback_rate` to null<br/>
        /// (no post-process). If both fields are sent,<br/>
        /// `clear_tts_playback_rate` wins.
        /// </param>
        /// <param name="responseDelaySeconds">
        /// Per-agent silence-wait override (seconds). See the field<br/>
        /// on Agent for semantics. Range 0.0..5.0; null is allowed<br/>
        /// but `clear_response_delay_seconds=true` is the canonical<br/>
        /// way to revert to the stack default.
        /// </param>
        /// <param name="clearResponseDelaySeconds">
        /// Two-headed clear, mirroring `clear_tts_playback_rate`.<br/>
        /// Setting this to `true` resets `response_delay_seconds` to<br/>
        /// null (revert to the stack default). If both are sent,<br/>
        /// `clear_response_delay_seconds` wins.
        /// </param>
        /// <param name="inactivityTimeoutSeconds">
        /// Per-agent silence-tolerance override. Send `0` to clear<br/>
        /// the override and fall back to the platform default.<br/>
        /// Negative values are rejected.
        /// </param>
        /// <param name="backgroundNoisePreset">
        /// Pre-mixed ambient bed slug. Send empty string ("") to<br/>
        /// disable the bed, which also clears `background_noise_volume`.
        /// </param>
        /// <param name="backgroundNoiseVolume">
        /// Volume of the background-noise bed (0..1). Ignored when<br/>
        /// the preset is empty; clearing the preset also clears<br/>
        /// this field server-side.
        /// </param>
        /// <param name="sttOverride">
        /// Streaming-STT stack override. Send an empty string ("") to<br/>
        /// clear the override and fall back to the worker default<br/>
        /// (today: whisper-v3). Any non-empty value must be a known<br/>
        /// stack name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsUpdateAgentRequest(
            string? name,
            string? prompt,
            string? firstMessage,
            string? language,
            global::Speechify.TtsUpdateAgentRequestLlmProvider? llmProvider,
            string? llmModel,
            string? llmBaseUrl,
            string? llmApiKey,
            object? llmExtraBody,
            string? voiceId,
            double? temperature,
            global::Speechify.TtsWidgetConfig? widgetConfig,
            bool? isPublic,
            global::System.Collections.Generic.IList<string>? allowedOrigins,
            global::System.Collections.Generic.IList<string>? hostnameAllowlist,
            bool? memoryEnabled,
            int? memoryRetentionDays,
            string? webhookUrl,
            string? webhookSecret,
            global::Speechify.TtsAMDConfig? amd,
            bool? saveAudioRecording,
            bool? navigatorMode,
            bool? ivrMemoryEnabled,
            double? ttsSpeakingRate,
            bool? clearTtsSpeakingRate,
            double? ttsPlaybackRate,
            bool? clearTtsPlaybackRate,
            double? responseDelaySeconds,
            bool? clearResponseDelaySeconds,
            int? inactivityTimeoutSeconds,
            global::Speechify.TtsUpdateAgentRequestBackgroundNoisePreset? backgroundNoisePreset,
            double? backgroundNoiseVolume,
            global::Speechify.TtsUpdateAgentRequestSttOverride? sttOverride)
        {
            this.Name = name;
            this.Prompt = prompt;
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.LlmProvider = llmProvider;
            this.LlmModel = llmModel;
            this.LlmBaseUrl = llmBaseUrl;
            this.LlmApiKey = llmApiKey;
            this.LlmExtraBody = llmExtraBody;
            this.VoiceId = voiceId;
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
            this.ClearTtsSpeakingRate = clearTtsSpeakingRate;
            this.TtsPlaybackRate = ttsPlaybackRate;
            this.ClearTtsPlaybackRate = clearTtsPlaybackRate;
            this.ResponseDelaySeconds = responseDelaySeconds;
            this.ClearResponseDelaySeconds = clearResponseDelaySeconds;
            this.InactivityTimeoutSeconds = inactivityTimeoutSeconds;
            this.BackgroundNoisePreset = backgroundNoisePreset;
            this.BackgroundNoiseVolume = backgroundNoiseVolume;
            this.SttOverride = sttOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateAgentRequest" /> class.
        /// </summary>
        public TtsUpdateAgentRequest()
        {
        }

    }
}