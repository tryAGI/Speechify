
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH body. All fields optional; omit to leave unchanged. Set<br/>
    /// `parent_folder_id` to reparent into that folder; send<br/>
    /// `clear_parent_folder_id: true` to move the folder to root. The<br/>
    /// clear flag is the explicit signal because JSON `null` is<br/>
    /// indistinguishable from absent for pointer fields in Go's<br/>
    /// encoding/json.
    /// </summary>
    public sealed partial class UpdateFolderRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Folder to reparent under. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        /// When `true`, moves the folder to root (clears<br/>
        /// `parent_folder_id`). Wins over `parent_folder_id` when both<br/>
        /// are sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_parent_folder_id")]
        public bool? ClearParentFolderId { get; set; }

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
        /// Folder to reparent under. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="clearParentFolderId">
        /// When `true`, moves the folder to root (clears<br/>
        /// `parent_folder_id`). Wins over `parent_folder_id` when both<br/>
        /// are sent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFolderRequest(
            string? name,
            string? parentFolderId,
            bool? clearParentFolderId)
        {
            this.Name = name;
            this.ParentFolderId = parentFolderId;
            this.ClearParentFolderId = clearParentFolderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolderRequest" /> class.
        /// </summary>
        public UpdateFolderRequest()
        {
        }

    }
}