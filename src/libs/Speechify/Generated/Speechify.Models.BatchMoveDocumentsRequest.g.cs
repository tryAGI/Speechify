
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for PATCH /v1/knowledge-bases/{id}/documents/batch/move.<br/>
    /// Capped at 200 ids per call. Pass `folder_id: null` to move to<br/>
    /// root.
    /// </summary>
    public sealed partial class BatchMoveDocumentsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>
        /// Destination folder. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null moves every<br/>
        /// document to the knowledge base root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMoveDocumentsRequest" /> class.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="folderId">
        /// Destination folder. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null moves every<br/>
        /// document to the knowledge base root.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchMoveDocumentsRequest(
            global::System.Collections.Generic.IList<string> ids,
            string? folderId)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.FolderId = folderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMoveDocumentsRequest" /> class.
        /// </summary>
        public BatchMoveDocumentsRequest()
        {
        }

    }
}