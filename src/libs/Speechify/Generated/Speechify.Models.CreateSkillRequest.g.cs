
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSkillRequest
    {
        /// <summary>
        /// 1-128 characters of letters, digits, spaces, or `. _ -`; unique per workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The procedure. Bounded because it rides on every dispatched turn of<br/>
        /// every agent that attaches it, so the limit is a per-turn token bill<br/>
        /// rather than a storage bound.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_ids")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_ids")]
        public global::System.Collections.Generic.IList<string>? KnowledgeBaseIds { get; set; }

        /// <summary>
        /// Default token values. Keys in the reserved `system__` namespace are refused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? Variables { get; set; }

        /// <summary>
        /// The project to create the skill in; omit for the caller's default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// 1-128 characters of letters, digits, spaces, or `. _ -`; unique per workspace.
        /// </param>
        /// <param name="instructions">
        /// The procedure. Bounded because it rides on every dispatched turn of<br/>
        /// every agent that attaches it, so the limit is a per-turn token bill<br/>
        /// rather than a storage bound.
        /// </param>
        /// <param name="description"></param>
        /// <param name="toolIds"></param>
        /// <param name="knowledgeBaseIds"></param>
        /// <param name="variables">
        /// Default token values. Keys in the reserved `system__` namespace are refused.
        /// </param>
        /// <param name="projectId">
        /// The project to create the skill in; omit for the caller's default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSkillRequest(
            string name,
            string instructions,
            string? description,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::System.Collections.Generic.IList<string>? knowledgeBaseIds,
            global::System.Collections.Generic.Dictionary<string, string>? variables,
            string? projectId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.ToolIds = toolIds;
            this.KnowledgeBaseIds = knowledgeBaseIds;
            this.Variables = variables;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillRequest" /> class.
        /// </summary>
        public CreateSkillRequest()
        {
        }

    }
}