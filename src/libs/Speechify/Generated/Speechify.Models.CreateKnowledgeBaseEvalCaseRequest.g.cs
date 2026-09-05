
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateKnowledgeBaseEvalCaseRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Required unless `unanswerable`; every id must belong to this knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_document_ids")]
        public global::System.Collections.Generic.IList<string>? ExpectedDocumentIds { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unanswerable")]
        public bool? Unanswerable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeBaseEvalCaseRequest" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="expectedDocumentIds">
        /// Required unless `unanswerable`; every id must belong to this knowledge base.
        /// </param>
        /// <param name="unanswerable">
        /// Default Value: false
        /// </param>
        /// <param name="note"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKnowledgeBaseEvalCaseRequest(
            string query,
            global::System.Collections.Generic.IList<string>? expectedDocumentIds,
            bool? unanswerable,
            string? note)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.ExpectedDocumentIds = expectedDocumentIds;
            this.Unanswerable = unanswerable;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeBaseEvalCaseRequest" /> class.
        /// </summary>
        public CreateKnowledgeBaseEvalCaseRequest()
        {
        }

    }
}