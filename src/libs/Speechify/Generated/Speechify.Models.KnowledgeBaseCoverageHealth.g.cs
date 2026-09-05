
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The strip above the report.
    /// </summary>
    public sealed partial class KnowledgeBaseCoverageHealth
    {
        /// <summary>
        /// Searches in the window whose scope included this knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Searches { get; set; }

        /// <summary>
        /// Distinct conversations those searches came from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Conversations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sufficient")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sufficient { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Partial { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insufficient")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Insufficient { get; set; }

        /// <summary>
        /// Searches recorded before retrieval gave a verdict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unscored")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Unscored { get; set; }

        /// <summary>
        /// Median search time in milliseconds; null until a search in the window recorded it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("median_latency_ms")]
        public int? MedianLatencyMs { get; set; }

        /// <summary>
        /// Ready documents with at least one passage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Documents { get; set; }

        /// <summary>
        /// Those among them a search in the window surfaced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents_retrieved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DocumentsRetrieved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseCoverageHealth" /> class.
        /// </summary>
        /// <param name="searches">
        /// Searches in the window whose scope included this knowledge base.
        /// </param>
        /// <param name="conversations">
        /// Distinct conversations those searches came from.
        /// </param>
        /// <param name="sufficient"></param>
        /// <param name="partial"></param>
        /// <param name="insufficient"></param>
        /// <param name="unscored">
        /// Searches recorded before retrieval gave a verdict.
        /// </param>
        /// <param name="documents">
        /// Ready documents with at least one passage.
        /// </param>
        /// <param name="documentsRetrieved">
        /// Those among them a search in the window surfaced.
        /// </param>
        /// <param name="medianLatencyMs">
        /// Median search time in milliseconds; null until a search in the window recorded it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseCoverageHealth(
            int searches,
            int conversations,
            int sufficient,
            int partial,
            int insufficient,
            int unscored,
            int documents,
            int documentsRetrieved,
            int? medianLatencyMs)
        {
            this.Searches = searches;
            this.Conversations = conversations;
            this.Sufficient = sufficient;
            this.Partial = partial;
            this.Insufficient = insufficient;
            this.Unscored = unscored;
            this.MedianLatencyMs = medianLatencyMs;
            this.Documents = documents;
            this.DocumentsRetrieved = documentsRetrieved;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseCoverageHealth" /> class.
        /// </summary>
        public KnowledgeBaseCoverageHealth()
        {
        }

    }
}