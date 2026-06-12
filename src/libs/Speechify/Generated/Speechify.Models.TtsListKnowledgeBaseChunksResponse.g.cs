
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Shared pagination metadata composed into every cursor-paginated<br/>
    /// list response via `allOf`. See [ADR 0013](../docs/adrs/0013-list-pagination-conventions.md)<br/>
    /// for the convention and the rationale for shipping `has_more`<br/>
    /// alongside `next_cursor` (defense-in-depth across two equivalent<br/>
    /// end-of-pages signals).
    /// </summary>
    public sealed partial class TtsListKnowledgeBaseChunksResponse
    {
        /// <summary>
        /// Opaque keyset cursor for the next page. Pass back as the<br/>
        /// `cursor` request parameter. `null` when the caller has<br/>
        /// reached the end of the list (`has_more` is also `false`<br/>
        /// in that case).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// True when more rows exist beyond this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseChunk> Chunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListKnowledgeBaseChunksResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// True when more rows exist beyond this page.
        /// </param>
        /// <param name="chunks"></param>
        /// <param name="nextCursor">
        /// Opaque keyset cursor for the next page. Pass back as the<br/>
        /// `cursor` request parameter. `null` when the caller has<br/>
        /// reached the end of the list (`has_more` is also `false`<br/>
        /// in that case).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListKnowledgeBaseChunksResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseChunk> chunks,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListKnowledgeBaseChunksResponse" /> class.
        /// </summary>
        public TtsListKnowledgeBaseChunksResponse()
        {
        }

    }
}