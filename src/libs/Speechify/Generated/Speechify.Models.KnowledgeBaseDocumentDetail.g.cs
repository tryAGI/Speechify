
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload of GET /v1/agents/knowledge-bases/documents/{document_id}. Extends<br/>
    /// the list-view document with a bounded content preview, the<br/>
    /// list of dependent agents, and (for url-sourced docs) the<br/>
    /// auto-refresh state.
    /// </summary>
    public sealed partial class KnowledgeBaseDocumentDetail
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`kb_&lt;26 char Crockford base32&gt;`) of<br/>
        /// the knowledge base the document belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kb_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KbId { get; set; }

        /// <summary>
        /// How the document entered the KB. `file` is the upload path,<br/>
        /// `text` is inline pasted content, `url` is fetched via<br/>
        /// Firecrawl. Sitemap and crawl imports also produce `url` rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.KnowledgeBaseDocumentSourceKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.KnowledgeBaseDocumentSourceKind SourceKind { get; set; }

        /// <summary>
        /// Source URL for url-sourced documents (and the sitemap /<br/>
        /// crawl imports that produce them). Empty string for file<br/>
        /// and text rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Folder this document lives in. Null for root-level<br/>
        /// (unfiled) documents. Mutated via the move endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

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
        /// `always` places the document in every prompt of the agents its<br/>
        /// knowledge base is attached to; `on_demand` (the default) leaves it<br/>
        /// on retrieval. A knowledge base small enough to fit the automatic<br/>
        /// budget is placed in the prompt whole regardless of this setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("injection_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.KnowledgeBaseDocumentDetailInjectionModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.KnowledgeBaseDocumentDetailInjectionMode InjectionMode { get; set; }

        /// <summary>
        /// Document lifecycle. `fetching` is the pre-scrape state used<br/>
        /// only by url-sourced rows; file and text docs skip straight<br/>
        /// to `embedding` because their content is available<br/>
        /// synchronously. Terminal states are `ready` and `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.KnowledgeBaseDocumentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.KnowledgeBaseDocumentStatus Status { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_preview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentPreview { get; set; }

        /// <summary>
        /// The document's size in prompt tokens, the number the prompt budget counts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TokenCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PreviewTruncated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependent_agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.DependentAgent> DependentAgents { get; set; }

        /// <summary>
        /// Per-document auto-refresh state. Only populated<br/>
        /// for url-sourced documents; file and text rows omit this and<br/>
        /// clients hide auto-refresh affordances accordingly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh")]
        public global::Speechify.RefreshConfig? Refresh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseDocumentDetail" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="kbId">
        /// Prefixed wire identifier (`kb_&lt;26 char Crockford base32&gt;`) of<br/>
        /// the knowledge base the document belongs to.
        /// </param>
        /// <param name="sourceKind">
        /// How the document entered the KB. `file` is the upload path,<br/>
        /// `text` is inline pasted content, `url` is fetched via<br/>
        /// Firecrawl. Sitemap and crawl imports also produce `url` rows.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="contentType"></param>
        /// <param name="byteSize"></param>
        /// <param name="charCount"></param>
        /// <param name="chunkCount"></param>
        /// <param name="injectionMode">
        /// `always` places the document in every prompt of the agents its<br/>
        /// knowledge base is attached to; `on_demand` (the default) leaves it<br/>
        /// on retrieval. A knowledge base small enough to fit the automatic<br/>
        /// budget is placed in the prompt whole regardless of this setting.
        /// </param>
        /// <param name="status">
        /// Document lifecycle. `fetching` is the pre-scrape state used<br/>
        /// only by url-sourced rows; file and text docs skip straight<br/>
        /// to `embedding` because their content is available<br/>
        /// synchronously. Terminal states are `ready` and `failed`.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="contentPreview"></param>
        /// <param name="tokenCount">
        /// The document's size in prompt tokens, the number the prompt budget counts.
        /// </param>
        /// <param name="previewTruncated"></param>
        /// <param name="dependentAgents"></param>
        /// <param name="sourceUrl">
        /// Source URL for url-sourced documents (and the sitemap /<br/>
        /// crawl imports that produce them). Empty string for file<br/>
        /// and text rows.
        /// </param>
        /// <param name="folderId">
        /// Folder this document lives in. Null for root-level<br/>
        /// (unfiled) documents. Mutated via the move endpoint.
        /// </param>
        /// <param name="error">
        /// Populated when status is failed.
        /// </param>
        /// <param name="refresh">
        /// Per-document auto-refresh state. Only populated<br/>
        /// for url-sourced documents; file and text rows omit this and<br/>
        /// clients hide auto-refresh affordances accordingly.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseDocumentDetail(
            string id,
            string kbId,
            global::Speechify.KnowledgeBaseDocumentSourceKind sourceKind,
            string filename,
            string contentType,
            long byteSize,
            int charCount,
            int chunkCount,
            global::Speechify.KnowledgeBaseDocumentDetailInjectionMode injectionMode,
            global::Speechify.KnowledgeBaseDocumentStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string contentPreview,
            int tokenCount,
            bool previewTruncated,
            global::System.Collections.Generic.IList<global::Speechify.DependentAgent> dependentAgents,
            string? sourceUrl,
            string? folderId,
            string? error,
            global::Speechify.RefreshConfig? refresh)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.KbId = kbId ?? throw new global::System.ArgumentNullException(nameof(kbId));
            this.SourceKind = sourceKind;
            this.SourceUrl = sourceUrl;
            this.FolderId = folderId;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.ByteSize = byteSize;
            this.CharCount = charCount;
            this.ChunkCount = chunkCount;
            this.InjectionMode = injectionMode;
            this.Status = status;
            this.Error = error;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ContentPreview = contentPreview ?? throw new global::System.ArgumentNullException(nameof(contentPreview));
            this.TokenCount = tokenCount;
            this.PreviewTruncated = previewTruncated;
            this.DependentAgents = dependentAgents ?? throw new global::System.ArgumentNullException(nameof(dependentAgents));
            this.Refresh = refresh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseDocumentDetail" /> class.
        /// </summary>
        public KnowledgeBaseDocumentDetail()
        {
        }

    }
}