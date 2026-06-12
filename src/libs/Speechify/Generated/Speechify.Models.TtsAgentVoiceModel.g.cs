
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One TTS engine the voice can be synthesised through. Each<br/>
    /// agent voice exposes a multilingual model, plus an<br/>
    /// english-specific model for voices whose locale starts with<br/>
    /// `en`.
    /// </summary>
    public sealed partial class TtsAgentVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsAgentVoiceModelNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsAgentVoiceModelName Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsAgentVoiceLanguage> Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAgentVoiceModel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="languages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAgentVoiceModel(
            global::Speechify.TtsAgentVoiceModelName name,
            global::System.Collections.Generic.IList<global::Speechify.TtsAgentVoiceLanguage> languages)
        {
            this.Name = name;
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAgentVoiceModel" /> class.
        /// </summary>
        public TtsAgentVoiceModel()
        {
        }

    }
}