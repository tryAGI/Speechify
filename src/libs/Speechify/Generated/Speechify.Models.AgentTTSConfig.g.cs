
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Text-to-speech voice and delivery configuration.
    /// </summary>
    public sealed partial class AgentTTSConfig
    {
        /// <summary>
        /// Voice slug (see GET /v1/agents/voices for the recommended set). The server rejects an empty slug, and any voice it cannot synthesize.
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
        /// Pins the Simba model this agent synthesizes on. **Null is the<br/>
        /// default and the recommended setting**: the agent follows the<br/>
        /// model its voice is curated for, so a voice promoted to a newer<br/>
        /// training moves with it and no configuration goes stale.<br/>
        /// Set it to override that choice in either direction - onto an<br/>
        /// experimental training, or back down off one. Call<br/>
        /// GET /v1/agents/tts-models for the catalog, and read the voice's<br/>
        /// `models` and `default_model` on GET /v1/agents/voices for what<br/>
        /// this particular voice can serve on.<br/>
        /// A write is rejected when the agent could not actually be served<br/>
        /// with the model: an English-only model on an agent that resolves<br/>
        /// through the multilingual serving (it declares<br/>
        /// `additional_languages`, or its own `language` is not English),<br/>
        /// or a model the chosen voice is not curated for. The pair is<br/>
        /// re-checked whenever `voice_id`, `language`, or<br/>
        /// `additional_languages` change, so a stored pin cannot be<br/>
        /// orphaned by an edit elsewhere.<br/>
        /// Send `null` (or `""`) to clear it back to automatic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTTSConfig" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Voice slug (see GET /v1/agents/voices for the recommended set). The server rejects an empty slug, and any voice it cannot synthesize.
        /// </param>
        /// <param name="speed">
        /// Post-process, pitch-preserving time-stretch applied to the<br/>
        /// synthesized audio before playback (0.5 = half speed, 2.0 =<br/>
        /// double, 1.0 = unchanged). Null means no time-stretch.
        /// </param>
        /// <param name="model">
        /// Pins the Simba model this agent synthesizes on. **Null is the<br/>
        /// default and the recommended setting**: the agent follows the<br/>
        /// model its voice is curated for, so a voice promoted to a newer<br/>
        /// training moves with it and no configuration goes stale.<br/>
        /// Set it to override that choice in either direction - onto an<br/>
        /// experimental training, or back down off one. Call<br/>
        /// GET /v1/agents/tts-models for the catalog, and read the voice's<br/>
        /// `models` and `default_model` on GET /v1/agents/voices for what<br/>
        /// this particular voice can serve on.<br/>
        /// A write is rejected when the agent could not actually be served<br/>
        /// with the model: an English-only model on an agent that resolves<br/>
        /// through the multilingual serving (it declares<br/>
        /// `additional_languages`, or its own `language` is not English),<br/>
        /// or a model the chosen voice is not curated for. The pair is<br/>
        /// re-checked whenever `voice_id`, `language`, or<br/>
        /// `additional_languages` change, so a stored pin cannot be<br/>
        /// orphaned by an edit elsewhere.<br/>
        /// Send `null` (or `""`) to clear it back to automatic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTTSConfig(
            string voiceId,
            string? speed,
            string? model)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Speed = speed;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTTSConfig" /> class.
        /// </summary>
        public AgentTTSConfig()
        {
        }

    }
}