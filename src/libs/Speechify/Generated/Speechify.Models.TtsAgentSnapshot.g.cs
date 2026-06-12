
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Frozen subset of the agent's configuration captured at<br/>
    /// conversation-create time (AIS-2778) so the detail view can<br/>
    /// render historical calls accurately even after the live<br/>
    /// agent's prompt or voice has been edited. Carries its own<br/>
    /// `schema_version` because the snapshot shape evolves<br/>
    /// independently of the live Agent shape.
    /// </summary>
    public sealed partial class TtsAgentSnapshot
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_speaking_rate")]
        public double? TtsSpeakingRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_playback_rate")]
        public double? TtsPlaybackRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_delay_seconds")]
        public double? ResponseDelaySeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAgentSnapshot" /> class.
        /// </summary>
        /// <param name="schemaVersion"></param>
        /// <param name="capturedAt"></param>
        /// <param name="name"></param>
        /// <param name="prompt"></param>
        /// <param name="firstMessage"></param>
        /// <param name="language"></param>
        /// <param name="llmModel"></param>
        /// <param name="voiceId"></param>
        /// <param name="temperature"></param>
        /// <param name="memoryEnabled"></param>
        /// <param name="memoryRetentionDays"></param>
        /// <param name="ttsSpeakingRate"></param>
        /// <param name="ttsPlaybackRate"></param>
        /// <param name="responseDelaySeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAgentSnapshot(
            int? schemaVersion,
            global::System.DateTime? capturedAt,
            string? name,
            string? prompt,
            string? firstMessage,
            string? language,
            string? llmModel,
            string? voiceId,
            double? temperature,
            bool? memoryEnabled,
            int? memoryRetentionDays,
            double? ttsSpeakingRate,
            double? ttsPlaybackRate,
            double? responseDelaySeconds)
        {
            this.SchemaVersion = schemaVersion;
            this.CapturedAt = capturedAt;
            this.Name = name;
            this.Prompt = prompt;
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.LlmModel = llmModel;
            this.VoiceId = voiceId;
            this.Temperature = temperature;
            this.MemoryEnabled = memoryEnabled;
            this.MemoryRetentionDays = memoryRetentionDays;
            this.TtsSpeakingRate = ttsSpeakingRate;
            this.TtsPlaybackRate = ttsPlaybackRate;
            this.ResponseDelaySeconds = responseDelaySeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAgentSnapshot" /> class.
        /// </summary>
        public TtsAgentSnapshot()
        {
        }

    }
}