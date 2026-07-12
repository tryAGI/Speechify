
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH body (JSON merge-patch). All fields optional; omit a field<br/>
    /// to leave it unchanged. Set `parent_folder_id` to reparent into<br/>
    /// that folder, or send `parent_folder_id: null` to move the folder<br/>
    /// to the knowledge base root.
    /// </summary>
    public sealed partial class UpdateFolderRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Folder to reparent under (prefixed wire identifier<br/>
        /// `kfolder_&lt;26 char Crockford base32&gt;`), or `null` to move the<br/>
        /// folder to the knowledge base root. Omit to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolderRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parentFolderId">
        /// Folder to reparent under (prefixed wire identifier<br/>
        /// `kfolder_&lt;26 char Crockford base32&gt;`), or `null` to move the<br/>
        /// folder to the knowledge base root. Omit to leave unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFolderRequest(
            string? name,
            string? parentFolderId)
        {
            this.Name = name;
            this.ParentFolderId = parentFolderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolderRequest" /> class.
        /// </summary>
        public UpdateFolderRequest()
        {
        }

    }
}