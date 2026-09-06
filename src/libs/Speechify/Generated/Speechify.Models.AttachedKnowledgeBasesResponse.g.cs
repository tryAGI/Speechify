
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Cursor-paginated list of the knowledge bases attached to an agent.
    /// </summary>
    public sealed partial class AttachedKnowledgeBasesResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_bases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.KnowledgeBase> KnowledgeBases { get; set; }

        /// <summary>
        /// How the agent's attached knowledge reaches the model, on the<br/>
        /// first page only. `whole` means the entire attached corpus rides<br/>
        /// in the prompt and the agent never searches (`corpus_tokens` is<br/>
        /// its size); otherwise retrieval is on and `pinned_documents`<br/>
        /// counts the documents pinned into every prompt beside it.<br/>
        /// `auto_tokens` is the automatic tier's budget, 0 when off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("injection")]
        public global::Speechify.AttachedKnowledgeBasesResponseInjection? Injection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedKnowledgeBasesResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// True when more rows exist beyond this page.
        /// </param>
        /// <param name="knowledgeBases"></param>
        /// <param name="nextCursor">
        /// Opaque keyset cursor for the next page. Pass back as the<br/>
        /// `cursor` request parameter. `null` when the caller has<br/>
        /// reached the end of the list (`has_more` is also `false`<br/>
        /// in that case).
        /// </param>
        /// <param name="injection">
        /// How the agent's attached knowledge reaches the model, on the<br/>
        /// first page only. `whole` means the entire attached corpus rides<br/>
        /// in the prompt and the agent never searches (`corpus_tokens` is<br/>
        /// its size); otherwise retrieval is on and `pinned_documents`<br/>
        /// counts the documents pinned into every prompt beside it.<br/>
        /// `auto_tokens` is the automatic tier's budget, 0 when off.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachedKnowledgeBasesResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::Speechify.KnowledgeBase> knowledgeBases,
            string? nextCursor,
            global::Speechify.AttachedKnowledgeBasesResponseInjection? injection)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.KnowledgeBases = knowledgeBases ?? throw new global::System.ArgumentNullException(nameof(knowledgeBases));
            this.Injection = injection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedKnowledgeBasesResponse" /> class.
        /// </summary>
        public AttachedKnowledgeBasesResponse()
        {
        }

    }
}