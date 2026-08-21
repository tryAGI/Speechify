
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVoicesModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.GetVoiceLanguage> Languages { get; set; }

        /// <summary>
        /// A model this voice can be synthesized with. The set is filtered to<br/>
        /// what YOUR workspace's API version can select, so a voice never<br/>
        /// advertises a model your own synthesis request would reject. The<br/>
        /// legacy `simba-english` / `simba-multilingual` values appear only for<br/>
        /// a workspace pinned before API version `2026-09-21`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.GetVoicesModelNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.GetVoicesModelName Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesModel" /> class.
        /// </summary>
        /// <param name="languages"></param>
        /// <param name="name">
        /// A model this voice can be synthesized with. The set is filtered to<br/>
        /// what YOUR workspace's API version can select, so a voice never<br/>
        /// advertises a model your own synthesis request would reject. The<br/>
        /// legacy `simba-english` / `simba-multilingual` values appear only for<br/>
        /// a workspace pinned before API version `2026-09-21`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVoicesModel(
            global::System.Collections.Generic.IList<global::Speechify.GetVoiceLanguage> languages,
            global::Speechify.GetVoicesModelName name)
        {
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesModel" /> class.
        /// </summary>
        public GetVoicesModel()
        {
        }

    }
}