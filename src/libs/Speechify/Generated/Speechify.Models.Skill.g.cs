
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A versioned procedure: an instruction block plus the tools and<br/>
    /// knowledge it needs, written once and attached to many agents. The body<br/>
    /// returned is one version's - the latest, or the one `?version=` named.
    /// </summary>
    public sealed partial class Skill
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
        /// The project this skill belongs to; null when it belongs to none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The version this body came from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// The highest version minted. Differs from `version` only when you asked for an older one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LatestVersion { get; set; }

        /// <summary>
        /// The procedure, rendered into the system prompt of every agent attached at this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// Tool definitions this skill contributes to an attached agent's toolbelt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ToolIds { get; set; }

        /// <summary>
        /// Knowledge bases this procedure needs. Unlike tools these are not<br/>
        /// contributed - the agent must already have them attached, and an<br/>
        /// attach naming one it lacks is refused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> KnowledgeBaseIds { get; set; }

        /// <summary>
        /// Defaults for the `{{tokens}}` the instructions reference. They only<br/>
        /// fill keys nothing else set - the agent's own values, the flow's and<br/>
        /// the session's all outrank them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Variables { get; set; }

        /// <summary>
        /// How many agents hold this skill. Zero on list responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attached_agent_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AttachedAgentCount { get; set; }

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
        /// Initializes a new instance of the <see cref="Skill" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="version">
        /// The version this body came from.
        /// </param>
        /// <param name="latestVersion">
        /// The highest version minted. Differs from `version` only when you asked for an older one.
        /// </param>
        /// <param name="instructions">
        /// The procedure, rendered into the system prompt of every agent attached at this version.
        /// </param>
        /// <param name="toolIds">
        /// Tool definitions this skill contributes to an attached agent's toolbelt.
        /// </param>
        /// <param name="knowledgeBaseIds">
        /// Knowledge bases this procedure needs. Unlike tools these are not<br/>
        /// contributed - the agent must already have them attached, and an<br/>
        /// attach naming one it lacks is refused.
        /// </param>
        /// <param name="variables">
        /// Defaults for the `{{tokens}}` the instructions reference. They only<br/>
        /// fill keys nothing else set - the agent's own values, the flow's and<br/>
        /// the session's all outrank them.
        /// </param>
        /// <param name="attachedAgentCount">
        /// How many agents hold this skill. Zero on list responses.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="projectId">
        /// The project this skill belongs to; null when it belongs to none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Skill(
            string id,
            string name,
            string description,
            int version,
            int latestVersion,
            string instructions,
            global::System.Collections.Generic.IList<string> toolIds,
            global::System.Collections.Generic.IList<string> knowledgeBaseIds,
            global::System.Collections.Generic.Dictionary<string, string> variables,
            int attachedAgentCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? projectId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ProjectId = projectId;
            this.Version = version;
            this.LatestVersion = latestVersion;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.ToolIds = toolIds ?? throw new global::System.ArgumentNullException(nameof(toolIds));
            this.KnowledgeBaseIds = knowledgeBaseIds ?? throw new global::System.ArgumentNullException(nameof(knowledgeBaseIds));
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.AttachedAgentCount = attachedAgentCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Skill" /> class.
        /// </summary>
        public Skill()
        {
        }

    }
}