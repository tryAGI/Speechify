
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The verdict breakdown over the cases evaluated so far, apart from the processing counts.
    /// </summary>
    public sealed partial class KnowledgeBaseEvaluationResults
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Passed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseEvaluationResults" /> class.
        /// </summary>
        /// <param name="passed"></param>
        /// <param name="failed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseEvaluationResults(
            int passed,
            int failed)
        {
            this.Passed = passed;
            this.Failed = failed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseEvaluationResults" /> class.
        /// </summary>
        public KnowledgeBaseEvaluationResults()
        {
        }

    }
}