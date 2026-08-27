
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateFolderRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Parent folder. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null/omitted creates a<br/>
        /// root-level folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolderRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parentFolderId">
        /// Parent folder. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null/omitted creates a<br/>
        /// root-level folder.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFolderRequest(
            string name,
            string? parentFolderId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ParentFolderId = parentFolderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolderRequest" /> class.
        /// </summary>
        public CreateFolderRequest()
        {
        }

    }
}