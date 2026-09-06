
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One ranked chunk inside a retrieval log row. Denormalised so<br/>
    /// deleting a chunk or document after the call doesn't render<br/>
    /// historical logs unreadable.
    /// </summary>
    public sealed partial class RetrievalLogResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChunkId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentId { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`kb_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the knowledge base the matched chunk lives in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kb_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KbId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Score { get; set; }

        /// <summary>
        /// The headings the passage sat under when it was retrieved, outermost first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heading_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> HeadingPath { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// The component scores behind the position at the time of the search; absent when only the cosine ranked the hit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranking")]
        public global::Speechify.SearchHitRanking? Ranking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalLogResult" /> class.
        /// </summary>
        /// <param name="chunkId"></param>
        /// <param name="documentId"></param>
        /// <param name="kbId">
        /// Prefixed wire identifier (`kb_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the knowledge base the matched chunk lives in.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="chunkIndex"></param>
        /// <param name="content"></param>
        /// <param name="score"></param>
        /// <param name="headingPath">
        /// The headings the passage sat under when it was retrieved, outermost first.
        /// </param>
        /// <param name="sourceUrl"></param>
        /// <param name="ranking">
        /// The component scores behind the position at the time of the search; absent when only the cosine ranked the hit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrievalLogResult(
            string chunkId,
            string documentId,
            string kbId,
            string filename,
            int chunkIndex,
            string content,
            string score,
            global::System.Collections.Generic.IList<string> headingPath,
            string? sourceUrl,
            global::Speechify.SearchHitRanking? ranking)
        {
            this.ChunkId = chunkId ?? throw new global::System.ArgumentNullException(nameof(chunkId));
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.KbId = kbId ?? throw new global::System.ArgumentNullException(nameof(kbId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ChunkIndex = chunkIndex;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Score = score ?? throw new global::System.ArgumentNullException(nameof(score));
            this.HeadingPath = headingPath ?? throw new global::System.ArgumentNullException(nameof(headingPath));
            this.SourceUrl = sourceUrl;
            this.Ranking = ranking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalLogResult" /> class.
        /// </summary>
        public RetrievalLogResult()
        {
        }

    }
}