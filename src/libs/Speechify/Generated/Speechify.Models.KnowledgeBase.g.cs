
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A bundle of documents that can be attached to one or more voice<br/>
    /// agents. Chunks across every document in the knowledge base are<br/>
    /// embedded and searched together.
    /// </summary>
    public sealed partial class KnowledgeBase
    {
        /// <summary>
        /// Prefixed wire identifier (`kb_&lt;26 char Crockford base32&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable label for the knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Number of ingested documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DocumentCount { get; set; }

        /// <summary>
        /// Workspace project this resource lives in (prefixed external<br/>
        /// id). Null means the implicit Default project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

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
        /// Initializes a new instance of the <see cref="KnowledgeBase" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`kb_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="name">
        /// Human-readable label for the knowledge base.
        /// </param>
        /// <param name="description">
        /// Optional description.
        /// </param>
        /// <param name="documentCount">
        /// Number of ingested documents.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="projectId">
        /// Workspace project this resource lives in (prefixed external<br/>
        /// id). Null means the implicit Default project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBase(
            string id,
            string name,
            string description,
            int documentCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? projectId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.DocumentCount = documentCount;
            this.ProjectId = projectId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBase" /> class.
        /// </summary>
        public KnowledgeBase()
        {
        }

    }
}