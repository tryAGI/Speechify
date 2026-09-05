
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A document as the coverage report lists it.
    /// </summary>
    public sealed partial class KnowledgeBaseCoverageDocument
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
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChunkCount { get; set; }

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
        /// Initializes a new instance of the <see cref="KnowledgeBaseCoverageDocument" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filename"></param>
        /// <param name="sourceKind">
        /// How the document entered the KB. `file` is the upload path,<br/>
        /// `text` is inline pasted content, `url` is fetched via<br/>
        /// Firecrawl. Sitemap and crawl imports also produce `url` rows.
        /// </param>
        /// <param name="chunkCount"></param>
        /// <param name="createdAt"></param>
        /// <param name="sourceUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseCoverageDocument(
            string id,
            string filename,
            global::Speechify.KnowledgeBaseDocumentSourceKind sourceKind,
            int chunkCount,
            global::System.DateTime createdAt,
            string? sourceUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.SourceKind = sourceKind;
            this.SourceUrl = sourceUrl;
            this.ChunkCount = chunkCount;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseCoverageDocument" /> class.
        /// </summary>
        public KnowledgeBaseCoverageDocument()
        {
        }

    }
}