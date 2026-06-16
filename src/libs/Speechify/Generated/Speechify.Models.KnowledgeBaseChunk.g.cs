
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentId { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`kb_&lt;26 char Crockford base32&gt;`) of<br/>
        /// the knowledge base the chunk belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kb_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KbId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseChunk" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="documentId"></param>
        /// <param name="kbId">
        /// Prefixed wire identifier (`kb_&lt;26 char Crockford base32&gt;`) of<br/>
        /// the knowledge base the chunk belongs to.
        /// </param>
        /// <param name="chunkIndex"></param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseChunk(
            string id,
            string documentId,
            string kbId,
            int chunkIndex,
            string content)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.KbId = kbId ?? throw new global::System.ArgumentNullException(nameof(kbId));
            this.ChunkIndex = chunkIndex;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseChunk" /> class.
        /// </summary>
        public KnowledgeBaseChunk()
        {
        }

    }
}