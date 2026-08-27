
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateKnowledgeBaseRequest
    {
        /// <summary>
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Human-readable label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeBaseRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable label.
        /// </param>
        /// <param name="projectId">
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </param>
        /// <param name="description">
        /// Optional description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKnowledgeBaseRequest(
            string name,
            string? projectId,
            string? description)
        {
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeBaseRequest" /> class.
        /// </summary>
        public CreateKnowledgeBaseRequest()
        {
        }

    }
}