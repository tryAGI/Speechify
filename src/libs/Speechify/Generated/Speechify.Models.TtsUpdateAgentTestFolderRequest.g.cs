
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH body. All fields optional; omit to leave unchanged. Set<br/>
    /// `parent_folder_id` to a target folder id to reparent into that<br/>
    /// folder; send `clear_parent_folder_id: true` to reparent to<br/>
    /// root. The clear flag is the explicit signal because JSON `null`<br/>
    /// is indistinguishable from absent for pointer fields in Go's<br/>
    /// encoding/json.
    /// </summary>
    public sealed partial class TtsUpdateAgentTestFolderRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`folder_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the folder to reparent this folder under.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        /// When `true`, reparents this folder to root (clears<br/>
        /// `parent_folder_id`). Wins over `parent_folder_id` when<br/>
        /// both are sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_parent_folder_id")]
        public bool? ClearParentFolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateAgentTestFolderRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parentFolderId">
        /// Prefixed wire identifier (`folder_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the folder to reparent this folder under.
        /// </param>
        /// <param name="clearParentFolderId">
        /// When `true`, reparents this folder to root (clears<br/>
        /// `parent_folder_id`). Wins over `parent_folder_id` when<br/>
        /// both are sent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsUpdateAgentTestFolderRequest(
            string? name,
            string? parentFolderId,
            bool? clearParentFolderId)
        {
            this.Name = name;
            this.ParentFolderId = parentFolderId;
            this.ClearParentFolderId = clearParentFolderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateAgentTestFolderRequest" /> class.
        /// </summary>
        public TtsUpdateAgentTestFolderRequest()
        {
        }

    }
}