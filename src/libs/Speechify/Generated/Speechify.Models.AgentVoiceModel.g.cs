
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One Simba model version the voice can be synthesised through, and<br/>
    /// therefore one an agent on this voice may pin with `tts.model`.<br/>
    /// Every agent voice supports `simba-3.0`. English-only upgrade tiers<br/>
    /// (`simba-3.5-turbo`, `simba-3.2`) are listed when this voice can<br/>
    /// select them: a tier with `requires_voice_curation` only where the<br/>
    /// voice is curated for it, a tier without it on any voice we speak<br/>
    /// ourselves EXCEPT one built for a curated roster, whose speaker<br/>
    /// embedding is valid for that training alone. A partner voice lists no<br/>
    /// tier at all - Simba model selection does not apply to it.<br/>
    /// So read this array rather than inferring membership from<br/>
    /// `requires_voice_curation`: a voice can be absent from a model that<br/>
    /// needs no curation. It is the per-voice answer for every model, and a<br/>
    /// pin outside it is a 400. Which of these `tts.model: null`<br/>
    /// actually resolves to is `default_model`, not the order here.<br/>
    /// Like `default_model`, the tiers listed here are the ENGLISH answer,<br/>
    /// and they are a fact about the voice rather than about any one agent.<br/>
    /// An agent that resolves through the multilingual serving (it declares<br/>
    /// `additional_languages`, or its own `language` is not English) can<br/>
    /// select none of them, whatever this array says - no upgrade tier has a<br/>
    /// multilingual deployment. That is `english_only` on<br/>
    /// GET /v1/agents/tts-models, and a picker has to apply it as well as<br/>
    /// this array. The voice's own `locale` is not what decides: the bucket<br/>
    /// follows the AGENT's language, so an English agent may pin an<br/>
    /// English-only tier on a voice of any locale.<br/>
    /// The English-vs-multilingual split is otherwise an internal routing<br/>
    /// detail the worker resolves per call, not a selectable model.<br/>
    /// Treat this as an open set - new model versions are added here as<br/>
    /// they ship, so branch on the ones you know and fall through for<br/>
    /// the rest.
    /// </summary>
    public sealed partial class AgentVoiceModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentVoiceModelNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentVoiceModelName Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.AgentVoiceLanguage> Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVoiceModel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="languages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVoiceModel(
            global::Speechify.AgentVoiceModelName name,
            global::System.Collections.Generic.IList<global::Speechify.AgentVoiceLanguage> languages)
        {
            this.Name = name;
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVoiceModel" /> class.
        /// </summary>
        public AgentVoiceModel()
        {
        }

    }
}