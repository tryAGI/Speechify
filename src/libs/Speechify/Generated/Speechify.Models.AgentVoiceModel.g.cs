
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One Simba model version the voice can be synthesised through.<br/>
    /// Every agent voice supports `simba-3.0`; voices curated for<br/>
    /// Simba 3.2 additionally expose `simba-3.2` (streaming-native,<br/>
    /// English only). The English-vs-multilingual split is an internal<br/>
    /// routing detail the worker resolves per call, not a selectable<br/>
    /// model.
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