
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StartKnowledgeBaseEvaluationRequest
    {
        /// <summary>
        /// How many passages each search returns; the metrics are computed at this depth.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartKnowledgeBaseEvaluationRequest" /> class.
        /// </summary>
        /// <param name="topK">
        /// How many passages each search returns; the metrics are computed at this depth.<br/>
        /// Default Value: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartKnowledgeBaseEvaluationRequest(
            int? topK)
        {
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartKnowledgeBaseEvaluationRequest" /> class.
        /// </summary>
        public StartKnowledgeBaseEvaluationRequest()
        {
        }

    }
}