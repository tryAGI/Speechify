
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The summary over the cases that were searched. Recall, hit rate and<br/>
    /// MRR cover the answerable cases; the gated shares say how often<br/>
    /// retrieval refused an answerable question (a false refusal) and how<br/>
    /// often it refused an unanswerable one (abstention recall).
    /// </summary>
    public sealed partial class KnowledgeBaseEvaluationMetrics
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Cases { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answerable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Answerable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unanswerable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Unanswerable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recall_at_k")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RecallAtK { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hit_rate_at_k")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double HitRateAtK { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mrr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Mrr { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answerable_gated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AnswerableGated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unanswerable_gated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UnanswerableGated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unanswerable_zero_hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UnanswerableZeroHits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duplicate_hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DuplicateHits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseEvaluationMetrics" /> class.
        /// </summary>
        /// <param name="cases"></param>
        /// <param name="answerable"></param>
        /// <param name="unanswerable"></param>
        /// <param name="recallAtK"></param>
        /// <param name="hitRateAtK"></param>
        /// <param name="mrr"></param>
        /// <param name="answerableGated"></param>
        /// <param name="unanswerableGated"></param>
        /// <param name="unanswerableZeroHits"></param>
        /// <param name="duplicateHits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseEvaluationMetrics(
            int cases,
            int answerable,
            int unanswerable,
            double recallAtK,
            double hitRateAtK,
            double mrr,
            double answerableGated,
            double unanswerableGated,
            double unanswerableZeroHits,
            int duplicateHits)
        {
            this.Cases = cases;
            this.Answerable = answerable;
            this.Unanswerable = unanswerable;
            this.RecallAtK = recallAtK;
            this.HitRateAtK = hitRateAtK;
            this.Mrr = mrr;
            this.AnswerableGated = answerableGated;
            this.UnanswerableGated = unanswerableGated;
            this.UnanswerableZeroHits = unanswerableZeroHits;
            this.DuplicateHits = duplicateHits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseEvaluationMetrics" /> class.
        /// </summary>
        public KnowledgeBaseEvaluationMetrics()
        {
        }

    }
}