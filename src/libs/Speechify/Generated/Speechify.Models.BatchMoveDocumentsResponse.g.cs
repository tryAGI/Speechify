
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The documents moved by a batch-move request, each in the same detail<br/>
    /// shape the single-document move<br/>
    /// (`PATCH /v1/agents/knowledge-bases/{kb_id}/documents/{document_id}`)<br/>
    /// returns.
    /// </summary>
    public sealed partial class BatchMoveDocumentsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseDocumentDetail> Documents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMoveDocumentsResponse" /> class.
        /// </summary>
        /// <param name="documents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchMoveDocumentsResponse(
            global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseDocumentDetail> documents)
        {
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMoveDocumentsResponse" /> class.
        /// </summary>
        public BatchMoveDocumentsResponse()
        {
        }

    }
}