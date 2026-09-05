
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One case's outcome inside one evaluation. An answerable case passes<br/>
    /// when an expected document is in the result set and retrieval did not<br/>
    /// refuse; an unanswerable one passes when retrieval refused or found<br/>
    /// nothing.
    /// </summary>
    public sealed partial class KnowledgeBaseEvaluationResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CaseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_document_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExpectedDocumentIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unanswerable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Unanswerable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// The expected documents that appeared in the result set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("found_document_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FoundDocumentIds { get; set; }

        /// <summary>
        /// 1-based rank of the first expected document, 0 when none appeared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FirstRank { get; set; }

        /// <summary>
        /// The best hit's score, null when nothing was retrieved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_score")]
        public double? TopScore { get; set; }

        /// <summary>
        /// The verdict retrieval gave; absent when the search failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coverage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.RetrievalCoverageJsonConverter))]
        public global::Speechify.RetrievalCoverage? Coverage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_ms")]
        public int? LatencyMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseEvaluationHit> Hits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseEvaluationResult" /> class.
        /// </summary>
        /// <param name="caseId"></param>
        /// <param name="query"></param>
        /// <param name="expectedDocumentIds"></param>
        /// <param name="unanswerable"></param>
        /// <param name="passed"></param>
        /// <param name="foundDocumentIds">
        /// The expected documents that appeared in the result set.
        /// </param>
        /// <param name="firstRank">
        /// 1-based rank of the first expected document, 0 when none appeared.
        /// </param>
        /// <param name="hits"></param>
        /// <param name="createdAt"></param>
        /// <param name="topScore">
        /// The best hit's score, null when nothing was retrieved.
        /// </param>
        /// <param name="coverage">
        /// The verdict retrieval gave; absent when the search failed.
        /// </param>
        /// <param name="latencyMs"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseEvaluationResult(
            string caseId,
            string query,
            global::System.Collections.Generic.IList<string> expectedDocumentIds,
            bool unanswerable,
            bool passed,
            global::System.Collections.Generic.IList<string> foundDocumentIds,
            int firstRank,
            global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseEvaluationHit> hits,
            global::System.DateTime createdAt,
            double? topScore,
            global::Speechify.RetrievalCoverage? coverage,
            int? latencyMs,
            string? error)
        {
            this.CaseId = caseId ?? throw new global::System.ArgumentNullException(nameof(caseId));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.ExpectedDocumentIds = expectedDocumentIds ?? throw new global::System.ArgumentNullException(nameof(expectedDocumentIds));
            this.Unanswerable = unanswerable;
            this.Passed = passed;
            this.FoundDocumentIds = foundDocumentIds ?? throw new global::System.ArgumentNullException(nameof(foundDocumentIds));
            this.FirstRank = firstRank;
            this.TopScore = topScore;
            this.Coverage = coverage;
            this.LatencyMs = latencyMs;
            this.Error = error;
            this.Hits = hits ?? throw new global::System.ArgumentNullException(nameof(hits));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseEvaluationResult" /> class.
        /// </summary>
        public KnowledgeBaseEvaluationResult()
        {
        }

    }
}