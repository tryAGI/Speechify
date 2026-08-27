
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateDocumentRequest
    {
        /// <summary>
        /// Destination folder. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null moves the<br/>
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
        /// Initializes a new instance of the <see cref="UpdateDocumentRequest" /> class.
        /// </summary>
        /// <param name="folderId">
        /// Destination folder. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null moves the<br/>
        /// document to the knowledge base root.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDocumentRequest(
            string? folderId)
        {
            this.FolderId = folderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentRequest" /> class.
        /// </summary>
        public UpdateDocumentRequest()
        {
        }

    }
}