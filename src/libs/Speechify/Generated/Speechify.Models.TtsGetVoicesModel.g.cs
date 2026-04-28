
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsGetVoicesModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsGetVoiceLanguage> Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsGetVoicesModelNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsGetVoicesModelName Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetVoicesModel" /> class.
        /// </summary>
        /// <param name="languages"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsGetVoicesModel(
            global::System.Collections.Generic.IList<global::Speechify.TtsGetVoiceLanguage> languages,
            global::Speechify.TtsGetVoicesModelName name)
        {
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetVoicesModel" /> class.
        /// </summary>
        public TtsGetVoicesModel()
        {
        }
    }
}