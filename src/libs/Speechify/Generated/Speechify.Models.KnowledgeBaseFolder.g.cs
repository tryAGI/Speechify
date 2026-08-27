
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Folder inside a knowledge base. Root-level folders have<br/>
    /// `parent_folder_id: null`. `document_count` is populated only<br/>
    /// on the list endpoint.
    /// </summary>
    public sealed partial class KnowledgeBaseFolder
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`kb_&lt;26 char Crockford base32&gt;`) of<br/>
        /// the owning knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kb_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KbId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DocumentCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseFolder" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="kbId">
        /// Prefixed wire identifier (`kb_&lt;26 char Crockford base32&gt;`) of<br/>
        /// the owning knowledge base.
        /// </param>
        /// <param name="name"></param>
        /// <param name="documentCount"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="parentFolderId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseFolder(
            string id,
            string kbId,
            string name,
            int documentCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? parentFolderId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.KbId = kbId ?? throw new global::System.ArgumentNullException(nameof(kbId));
            this.ParentFolderId = parentFolderId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DocumentCount = documentCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseFolder" /> class.
        /// </summary>
        public KnowledgeBaseFolder()
        {
        }

    }
}