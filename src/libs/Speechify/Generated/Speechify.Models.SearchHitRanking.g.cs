
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The component scores behind a hit's position, for a caller that<br/>
    /// wants to see why a passage ranked where it did. Each field is absent<br/>
    /// when the stage that produces it did not run. `score` on the hit keeps<br/>
    /// its cosine meaning regardless.
    /// </summary>
    public sealed partial class SearchHitRanking
    {
        /// <summary>
        /// Reciprocal-rank fusion score across the semantic and lexical lanes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fused_score")]
        public string? FusedScore { get; set; }

        /// <summary>
        /// Distinct query terms the passage holds, plus its full-text density; set when the lexical lane matched it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lexical_rank")]
        public string? LexicalRank { get; set; }

        /// <summary>
        /// The cross-encoder's relevance of the passage to the query, when a reranker ran.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank_score")]
        public string? RerankScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchHitRanking" /> class.
        /// </summary>
        /// <param name="fusedScore">
        /// Reciprocal-rank fusion score across the semantic and lexical lanes.
        /// </param>
        /// <param name="lexicalRank">
        /// Distinct query terms the passage holds, plus its full-text density; set when the lexical lane matched it.
        /// </param>
        /// <param name="rerankScore">
        /// The cross-encoder's relevance of the passage to the query, when a reranker ran.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchHitRanking(
            string? fusedScore,
            string? lexicalRank,
            string? rerankScore)
        {
            this.FusedScore = fusedScore;
            this.LexicalRank = lexicalRank;
            this.RerankScore = rerankScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchHitRanking" /> class.
        /// </summary>
        public SearchHitRanking()
        {
        }

    }
}