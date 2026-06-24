
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Frozen copy of the agent's behavioral configuration captured at<br/>
    /// conversation-create time so the detail view can<br/>
    /// render historical calls accurately even after the live agent<br/>
    /// has been edited. Carries its own `schema_version` because the<br/>
    /// snapshot shape evolves independently of the live Agent shape.<br/>
    /// Field-presence contract: new snapshots emit every field<br/>
    /// (explicit null when unset). A key that is ABSENT from a stored<br/>
    /// snapshot means the snapshot pre-dates that field's capture;<br/>
    /// readers hide the value instead of guessing a default.
    /// </summary>
    public sealed partial class AgentSnapshot
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_version")]
        public int? SchemaVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("captured_at")]
        public global::System.DateTime? CapturedAt { get; set; }

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
        /// Resolved provider that actually ran (a "Platform default"<br/>
        /// agent freezes the concrete platform pair at call time).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_provider")]
        public string? LlmProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// Custom-provider endpoint base URL; null for managed providers. The bearer key is never captured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_base_url")]
        public string? LlmBaseUrl { get; set; }

        /// <summary>
        /// Extra chat.completions body forwarded verbatim for custom-provider agents; null otherwise.
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
        /// Post-process time-stretch at call time; null = no time-stretch (1x).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_playback_rate")]
        public double? TtsPlaybackRate { get; set; }

        /// <summary>
        /// Silence-wait override at call time; null = stack default endpointing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_delay_seconds")]
        public double? ResponseDelaySeconds { get; set; }

        /// <summary>
        /// Streaming-STT stack the call dispatched with; null = the worker's platform default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_override")]
        public string? SttOverride { get; set; }

        /// <summary>
        /// Answering Machine Detection routing config for outbound voice<br/>
        /// agents. AMD classifies the called party's first ~3-15 seconds of<br/>
        /// audio into one of LiveKit's categories (human, uncertain,<br/>
        /// machine-vm, machine-ivr, machine-unavailable) and dispatches per<br/>
        /// category to the configured action. Stored on the agent row;<br/>
        /// flowed onto outbound dispatch metadata under the `amd` key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amd")]
        public global::Speechify.AMDConfig? Amd { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ivr_memory_enabled")]
        public bool? IvrMemoryEnabled { get; set; }

        /// <summary>
        /// Silence-tolerance override at call time; null = platform default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivity_timeout_seconds")]
        public int? InactivityTimeoutSeconds { get; set; }

        /// <summary>
        /// Ambient-bed preset at call time; null = no background noise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentSnapshotBackgroundNoisePresetJsonConverter))]
        public global::Speechify.AgentSnapshotBackgroundNoisePreset? BackgroundNoisePreset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_noise_volume")]
        public double? BackgroundNoiseVolume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSnapshot" /> class.
        /// </summary>
        /// <param name="schemaVersion"></param>
        /// <param name="capturedAt"></param>
        /// <param name="name"></param>
        /// <param name="prompt"></param>
        /// <param name="firstMessage"></param>
        /// <param name="language"></param>
        /// <param name="llmProvider">
        /// Resolved provider that actually ran (a "Platform default"<br/>
        /// agent freezes the concrete platform pair at call time).
        /// </param>
        /// <param name="llmModel"></param>
        /// <param name="llmBaseUrl">
        /// Custom-provider endpoint base URL; null for managed providers. The bearer key is never captured.
        /// </param>
        /// <param name="llmExtraBody">
        /// Extra chat.completions body forwarded verbatim for custom-provider agents; null otherwise.
        /// </param>
        /// <param name="voiceId"></param>
        /// <param name="temperature"></param>
        /// <param name="memoryEnabled"></param>
        /// <param name="memoryRetentionDays"></param>
        /// <param name="ttsPlaybackRate">
        /// Post-process time-stretch at call time; null = no time-stretch (1x).
        /// </param>
        /// <param name="responseDelaySeconds">
        /// Silence-wait override at call time; null = stack default endpointing.
        /// </param>
        /// <param name="sttOverride">
        /// Streaming-STT stack the call dispatched with; null = the worker's platform default.
        /// </param>
        /// <param name="amd">
        /// Answering Machine Detection routing config for outbound voice<br/>
        /// agents. AMD classifies the called party's first ~3-15 seconds of<br/>
        /// audio into one of LiveKit's categories (human, uncertain,<br/>
        /// machine-vm, machine-ivr, machine-unavailable) and dispatches per<br/>
        /// category to the configured action. Stored on the agent row;<br/>
        /// flowed onto outbound dispatch metadata under the `amd` key.
        /// </param>
        /// <param name="saveAudioRecording"></param>
        /// <param name="navigatorMode"></param>
        /// <param name="ivrMemoryEnabled"></param>
        /// <param name="inactivityTimeoutSeconds">
        /// Silence-tolerance override at call time; null = platform default.
        /// </param>
        /// <param name="backgroundNoisePreset">
        /// Ambient-bed preset at call time; null = no background noise.
        /// </param>
        /// <param name="backgroundNoiseVolume"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSnapshot(
            int? schemaVersion,
            global::System.DateTime? capturedAt,
            string? name,
            string? prompt,
            string? firstMessage,
            string? language,
            string? llmProvider,
            string? llmModel,
            string? llmBaseUrl,
            object? llmExtraBody,
            string? voiceId,
            double? temperature,
            bool? memoryEnabled,
            int? memoryRetentionDays,
            double? ttsPlaybackRate,
            double? responseDelaySeconds,
            string? sttOverride,
            global::Speechify.AMDConfig? amd,
            bool? saveAudioRecording,
            bool? navigatorMode,
            bool? ivrMemoryEnabled,
            int? inactivityTimeoutSeconds,
            global::Speechify.AgentSnapshotBackgroundNoisePreset? backgroundNoisePreset,
            double? backgroundNoiseVolume)
        {
            this.SchemaVersion = schemaVersion;
            this.CapturedAt = capturedAt;
            this.Name = name;
            this.Prompt = prompt;
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.LlmProvider = llmProvider;
            this.LlmModel = llmModel;
            this.LlmBaseUrl = llmBaseUrl;
            this.LlmExtraBody = llmExtraBody;
            this.VoiceId = voiceId;
            this.Temperature = temperature;
            this.MemoryEnabled = memoryEnabled;
            this.MemoryRetentionDays = memoryRetentionDays;
            this.TtsPlaybackRate = ttsPlaybackRate;
            this.ResponseDelaySeconds = responseDelaySeconds;
            this.SttOverride = sttOverride;
            this.Amd = amd;
            this.SaveAudioRecording = saveAudioRecording;
            this.NavigatorMode = navigatorMode;
            this.IvrMemoryEnabled = ivrMemoryEnabled;
            this.InactivityTimeoutSeconds = inactivityTimeoutSeconds;
            this.BackgroundNoisePreset = backgroundNoisePreset;
            this.BackgroundNoiseVolume = backgroundNoiseVolume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSnapshot" /> class.
        /// </summary>
        public AgentSnapshot()
        {
        }

    }
}