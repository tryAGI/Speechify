
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH body. Both fields optional; omit to leave unchanged.<br/>
    /// Pass `parent_folder_id: null` to reparent to root.
    /// </summary>
    public sealed partial class TtsUpdateAgentTestFolderRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateAgentTestFolderRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parentFolderId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsUpdateAgentTestFolderRequest(
            string? name,
            string? parentFolderId)
        {
            this.Name = name;
            this.ParentFolderId = parentFolderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateAgentTestFolderRequest" /> class.
        /// </summary>
        public TtsUpdateAgentTestFolderRequest()
        {
        }
    }
}