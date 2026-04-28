
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsKnowledgeBaseDocument
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
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byte_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ByteSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("char_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChunkCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsKnowledgeBaseDocumentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsKnowledgeBaseDocumentStatus Status { get; set; }

        /// <summary>
        /// Populated when status is failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsKnowledgeBaseDocument" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="kbId"></param>
        /// <param name="filename"></param>
        /// <param name="contentType"></param>
        /// <param name="byteSize"></param>
        /// <param name="charCount"></param>
        /// <param name="chunkCount"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="error">
        /// Populated when status is failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsKnowledgeBaseDocument(
            string id,
            string kbId,
            string filename,
            string contentType,
            long byteSize,
            int charCount,
            int chunkCount,
            global::Speechify.TtsKnowledgeBaseDocumentStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.KbId = kbId ?? throw new global::System.ArgumentNullException(nameof(kbId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.ByteSize = byteSize;
            this.CharCount = charCount;
            this.ChunkCount = chunkCount;
            this.Status = status;
            this.Error = error;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsKnowledgeBaseDocument" /> class.
        /// </summary>
        public TtsKnowledgeBaseDocument()
        {
        }
    }
}