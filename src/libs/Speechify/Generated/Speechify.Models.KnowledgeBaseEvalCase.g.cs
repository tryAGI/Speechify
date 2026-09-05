
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A labelled question for one knowledge base: the documents that<br/>
    /// answer it, or `unanswerable` when nothing should.
    /// </summary>
    public sealed partial class KnowledgeBaseEvalCase
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
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The documents whose passages answer the question. Empty for an unanswerable case.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_document_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExpectedDocumentIds { get; set; }

        /// <summary>
        /// Nothing in the knowledge base should answer this; retrieval is expected to say so.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unanswerable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Unanswerable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Note { get; set; }

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
        /// Initializes a new instance of the <see cref="KnowledgeBaseEvalCase" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="kbId"></param>
        /// <param name="query"></param>
        /// <param name="expectedDocumentIds">
        /// The documents whose passages answer the question. Empty for an unanswerable case.
        /// </param>
        /// <param name="unanswerable">
        /// Nothing in the knowledge base should answer this; retrieval is expected to say so.
        /// </param>
        /// <param name="note"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseEvalCase(
            string id,
            string kbId,
            string query,
            global::System.Collections.Generic.IList<string> expectedDocumentIds,
            bool unanswerable,
            string note,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.KbId = kbId ?? throw new global::System.ArgumentNullException(nameof(kbId));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.ExpectedDocumentIds = expectedDocumentIds ?? throw new global::System.ArgumentNullException(nameof(expectedDocumentIds));
            this.Unanswerable = unanswerable;
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseEvalCase" /> class.
        /// </summary>
        public KnowledgeBaseEvalCase()
        {
        }

    }
}