
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A durable document + asset store. Runs write to it through<br/>
    /// their store tools; hosted-API routes serve it; your own code reads and<br/>
    /// writes it directly. Document bodies live in object storage, so a<br/>
    /// growing dataset costs nothing on the database.
    /// </summary>
    public sealed partial class Store
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The project this store belongs to; null when it belongs to none.
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
        /// Bytes the store holds across its documents and files, kept in step with every write.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UsedBytes { get; set; }

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
        /// Initializes a new instance of the <see cref="Store" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="usedBytes">
        /// Bytes the store holds across its documents and files, kept in step with every write.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="projectId">
        /// The project this store belongs to; null when it belongs to none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Store(
            string id,
            string name,
            string description,
            global::System.DateTime createdAt,
            long usedBytes,
            global::System.DateTime updatedAt,
            string? projectId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ProjectId = projectId;
            this.CreatedAt = createdAt;
            this.UsedBytes = usedBytes;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Store" /> class.
        /// </summary>
        public Store()
        {
        }

    }
}