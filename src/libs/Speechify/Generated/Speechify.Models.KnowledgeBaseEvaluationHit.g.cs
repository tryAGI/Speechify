
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KnowledgeBaseEvaluationHit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChunkIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heading_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> HeadingPath { get; set; }

        /// <summary>
        /// The first 300 characters of the passage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerpt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Excerpt { get; set; }

        /// <summary>
        /// A fingerprint of the whole passage, so two hits can be told apart past the excerpt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseEvaluationHit" /> class.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="filename"></param>
        /// <param name="chunkIndex"></param>
        /// <param name="score"></param>
        /// <param name="headingPath"></param>
        /// <param name="excerpt">
        /// The first 300 characters of the passage.
        /// </param>
        /// <param name="contentHash">
        /// A fingerprint of the whole passage, so two hits can be told apart past the excerpt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseEvaluationHit(
            string documentId,
            string filename,
            int chunkIndex,
            double score,
            global::System.Collections.Generic.IList<string> headingPath,
            string excerpt,
            string contentHash)
        {
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ChunkIndex = chunkIndex;
            this.Score = score;
            this.HeadingPath = headingPath ?? throw new global::System.ArgumentNullException(nameof(headingPath));
            this.Excerpt = excerpt ?? throw new global::System.ArgumentNullException(nameof(excerpt));
            this.ContentHash = contentHash ?? throw new global::System.ArgumentNullException(nameof(contentHash));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseEvaluationHit" /> class.
        /// </summary>
        public KnowledgeBaseEvaluationHit()
        {
        }

    }
}