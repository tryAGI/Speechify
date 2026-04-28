
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsEvaluationConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsEvaluationCriterion> Criteria { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsDataCollectionField> DataCollection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsEvaluationConfig" /> class.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="dataCollection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsEvaluationConfig(
            global::System.Collections.Generic.IList<global::Speechify.TtsEvaluationCriterion> criteria,
            global::System.Collections.Generic.IList<global::Speechify.TtsDataCollectionField> dataCollection)
        {
            this.Criteria = criteria ?? throw new global::System.ArgumentNullException(nameof(criteria));
            this.DataCollection = dataCollection ?? throw new global::System.ArgumentNullException(nameof(dataCollection));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsEvaluationConfig" /> class.
        /// </summary>
        public TtsEvaluationConfig()
        {
        }
    }
}