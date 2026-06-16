
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::Speechify.CreateVoiceLanguage>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.CreateVoiceModelNameJsonConverter))]
        public global::Speechify.CreateVoiceModelName? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceModel" /> class.
        /// </summary>
        /// <param name="languages"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoiceModel(
            global::System.Collections.Generic.IList<global::Speechify.CreateVoiceLanguage>? languages,
            global::Speechify.CreateVoiceModelName? name)
        {
            this.Languages = languages;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceModel" /> class.
        /// </summary>
        public CreateVoiceModel()
        {
        }

    }
}