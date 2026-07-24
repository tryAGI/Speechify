
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One extra language an agent serves beyond its default `language`.<br/>
    /// Without `voice_id` the agent's own voice speaks the language<br/>
    /// (voice continuity through a mid-call switch); with `voice_id`<br/>
    /// the language is served by that voice instead, e.g. a native<br/>
    /// speaker of the language. `first_message` overrides the greeting<br/>
    /// only when a session starts in this language.
    /// </summary>
    public sealed partial class AgentAdditionalLanguage
    {
        /// <summary>
        /// BCP-47 language tag, e.g. 'es' or 'pt-BR'. Supported primary<br/>
        /// subtags today: en, de, es, fr, it, pt. Must be unique per<br/>
        /// agent and different from the default `language`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Optional per-language voice slug from the catalog (see GET<br/>
        /// /v1/agents/voices). Null or omitted serves the language with<br/>
        /// the agent's default voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Optional greeting used when a session starts in this<br/>
        /// language. Null or omitted falls back to the agent's default<br/>
        /// `first_message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAdditionalLanguage" /> class.
        /// </summary>
        /// <param name="language">
        /// BCP-47 language tag, e.g. 'es' or 'pt-BR'. Supported primary<br/>
        /// subtags today: en, de, es, fr, it, pt. Must be unique per<br/>
        /// agent and different from the default `language`.
        /// </param>
        /// <param name="voiceId">
        /// Optional per-language voice slug from the catalog (see GET<br/>
        /// /v1/agents/voices). Null or omitted serves the language with<br/>
        /// the agent's default voice.
        /// </param>
        /// <param name="firstMessage">
        /// Optional greeting used when a session starts in this<br/>
        /// language. Null or omitted falls back to the agent's default<br/>
        /// `first_message`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAdditionalLanguage(
            string language,
            string? voiceId,
            string? firstMessage)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.VoiceId = voiceId;
            this.FirstMessage = firstMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAdditionalLanguage" /> class.
        /// </summary>
        public AgentAdditionalLanguage()
        {
        }

    }
}