
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One skill as it is attached to one agent, pinned to a version.
    /// </summary>
    public sealed partial class AgentSkill
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillId { get; set; }

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
        /// The version this agent is pinned to, and the one dispatch renders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// The version the catalog holds now. Higher than `version` means an upgrade is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LatestVersion { get; set; }

        /// <summary>
        /// A disabled skill keeps its pin but is not rendered or dispatched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ToolIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> KnowledgeBaseIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Variables { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attached_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AttachedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentSkill" /> class.
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="version">
        /// The version this agent is pinned to, and the one dispatch renders.
        /// </param>
        /// <param name="latestVersion">
        /// The version the catalog holds now. Higher than `version` means an upgrade is available.
        /// </param>
        /// <param name="enabled">
        /// A disabled skill keeps its pin but is not rendered or dispatched.
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="toolIds"></param>
        /// <param name="knowledgeBaseIds"></param>
        /// <param name="variables"></param>
        /// <param name="attachedAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSkill(
            string skillId,
            string name,
            string description,
            int version,
            int latestVersion,
            bool enabled,
            string instructions,
            global::System.Collections.Generic.IList<string> toolIds,
            global::System.Collections.Generic.IList<string> knowledgeBaseIds,
            global::System.Collections.Generic.Dictionary<string, string> variables,
            global::System.DateTime attachedAt,
            global::System.DateTime updatedAt)
        {
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Version = version;
            this.LatestVersion = latestVersion;
            this.Enabled = enabled;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.ToolIds = toolIds ?? throw new global::System.ArgumentNullException(nameof(toolIds));
            this.KnowledgeBaseIds = knowledgeBaseIds ?? throw new global::System.ArgumentNullException(nameof(knowledgeBaseIds));
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.AttachedAt = attachedAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSkill" /> class.
        /// </summary>
        public AgentSkill()
        {
        }

    }
}