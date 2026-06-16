
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for POST /v1/knowledge-bases/{id}/documents/text.
    /// </summary>
    public sealed partial class CreateTextDocumentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Folder to drop the document into. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null/omitted = root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextDocumentRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="folderId">
        /// Folder to drop the document into. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null/omitted = root.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextDocumentRequest(
            string name,
            string content,
            string? folderId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.FolderId = folderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextDocumentRequest" /> class.
        /// </summary>
        public CreateTextDocumentRequest()
        {
        }

    }
}