
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Text-to-speech voice and delivery configuration.
    /// </summary>
    public sealed partial class AgentTTSConfig
    {
        /// <summary>
        /// Voice slug from the catalog (see GET /v1/agents/voices). The server rejects an unknown or empty slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Post-process, pitch-preserving time-stretch applied to the<br/>
        /// synthesized audio before playback (0.5 = half speed, 2.0 =<br/>
        /// double, 1.0 = unchanged). Null means no time-stretch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public string? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTTSConfig" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Voice slug from the catalog (see GET /v1/agents/voices). The server rejects an unknown or empty slug.
        /// </param>
        /// <param name="speed">
        /// Post-process, pitch-preserving time-stretch applied to the<br/>
        /// synthesized audio before playback (0.5 = half speed, 2.0 =<br/>
        /// double, 1.0 = unchanged). Null means no time-stretch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTTSConfig(
            string voiceId,
            string? speed)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTTSConfig" /> class.
        /// </summary>
        public AgentTTSConfig()
        {
        }

    }
}