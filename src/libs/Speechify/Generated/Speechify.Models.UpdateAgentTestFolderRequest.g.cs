
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH body (JSON merge-patch). All fields optional; omit a field<br/>
    /// to leave it unchanged. Set `parent_folder_id` to a target folder<br/>
    /// id to reparent into that folder, or send `parent_folder_id: null`<br/>
    /// to reparent this folder to root.
    /// </summary>
    public sealed partial class UpdateAgentTestFolderRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`folder_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the folder to reparent this folder under, or `null` to<br/>
        /// reparent it to root. Omit to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentTestFolderRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parentFolderId">
        /// Prefixed wire identifier (`folder_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the folder to reparent this folder under, or `null` to<br/>
        /// reparent it to root. Omit to leave unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentTestFolderRequest(
            string? name,
            string? parentFolderId)
        {
            this.Name = name;
            this.ParentFolderId = parentFolderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentTestFolderRequest" /> class.
        /// </summary>
        public UpdateAgentTestFolderRequest()
        {
        }

    }
}