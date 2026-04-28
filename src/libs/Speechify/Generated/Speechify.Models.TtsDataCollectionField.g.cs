
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A structured value the post-call evaluator should extract from the<br/>
    /// transcript. `int` is distinct from `number` so downstream consumers<br/>
    /// receive whole integers without a synthetic decimal.
    /// </summary>
    public sealed partial class TtsDataCollectionField
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsDataCollectionFieldTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsDataCollectionFieldType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsDataCollectionField" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsDataCollectionField(
            string key,
            string description,
            global::Speechify.TtsDataCollectionFieldType type)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsDataCollectionField" /> class.
        /// </summary>
        public TtsDataCollectionField()
        {
        }
    }
}