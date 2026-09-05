
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SkillVersion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// The first line of the body, bounded. Read the full body with `GET /v1/skills/{skill_id}?version=`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillVersion" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="summary">
        /// The first line of the body, bounded. Read the full body with `GET /v1/skills/{skill_id}?version=`.
        /// </param>
        /// <param name="toolIds"></param>
        /// <param name="knowledgeBaseIds"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillVersion(
            int version,
            string summary,
            global::System.Collections.Generic.IList<string> toolIds,
            global::System.Collections.Generic.IList<string> knowledgeBaseIds,
            global::System.DateTime createdAt)
        {
            this.Version = version;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.ToolIds = toolIds ?? throw new global::System.ArgumentNullException(nameof(toolIds));
            this.KnowledgeBaseIds = knowledgeBaseIds ?? throw new global::System.ArgumentNullException(nameof(knowledgeBaseIds));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillVersion" /> class.
        /// </summary>
        public SkillVersion()
        {
        }

    }
}