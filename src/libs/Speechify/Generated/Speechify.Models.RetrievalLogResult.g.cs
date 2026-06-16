
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One ranked chunk inside a retrieval log row. Mirrors<br/>
    /// `RetrievalLogResult` in apps/server/internal/kb/types.go —<br/>
    /// denormalised so deleting a chunk or document after the call<br/>
    /// doesn't render historical logs unreadable.
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
        public required double Score { get; set; }

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
            double score)
        {
            this.ChunkId = chunkId ?? throw new global::System.ArgumentNullException(nameof(chunkId));
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.KbId = kbId ?? throw new global::System.ArgumentNullException(nameof(kbId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ChunkIndex = chunkIndex;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalLogResult" /> class.
        /// </summary>
        public RetrievalLogResult()
        {
        }

    }
}