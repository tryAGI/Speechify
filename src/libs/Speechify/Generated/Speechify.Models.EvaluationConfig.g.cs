
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluationConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.EvaluationCriterion> Criteria { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.DataCollectionField> DataCollection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationConfig" /> class.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="dataCollection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationConfig(
            global::System.Collections.Generic.IList<global::Speechify.EvaluationCriterion> criteria,
            global::System.Collections.Generic.IList<global::Speechify.DataCollectionField> dataCollection)
        {
            this.Criteria = criteria ?? throw new global::System.ArgumentNullException(nameof(criteria));
            this.DataCollection = dataCollection ?? throw new global::System.ArgumentNullException(nameof(dataCollection));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationConfig" /> class.
        /// </summary>
        public EvaluationConfig()
        {
        }

    }
}