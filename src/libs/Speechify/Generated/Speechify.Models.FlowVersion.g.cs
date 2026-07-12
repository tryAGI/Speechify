
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One published or draft revision of an agent's flow graph.
    /// </summary>
    public sealed partial class FlowVersion
    {
        /// <summary>
        /// Flow version id (prefixed external id, `fver_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Monotonic revision number within the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Parent flow version id (prefixed external id, `fver_...`); null for the first version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_version_id")]
        public string? ParentVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_draft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDraft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        public global::System.DateTime? PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowVersion" /> class.
        /// </summary>
        /// <param name="id">
        /// Flow version id (prefixed external id, `fver_...`).
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="version">
        /// Monotonic revision number within the agent.
        /// </param>
        /// <param name="isActive"></param>
        /// <param name="isDraft"></param>
        /// <param name="parentVersionId">
        /// Parent flow version id (prefixed external id, `fver_...`); null for the first version.
        /// </param>
        /// <param name="name"></param>
        /// <param name="notes"></param>
        /// <param name="publishedAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlowVersion(
            string id,
            string agentId,
            int version,
            bool isActive,
            bool isDraft,
            string? parentVersionId,
            string? name,
            string? notes,
            global::System.DateTime? publishedAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Version = version;
            this.ParentVersionId = parentVersionId;
            this.IsActive = isActive;
            this.IsDraft = isDraft;
            this.Name = name;
            this.Notes = notes;
            this.PublishedAt = publishedAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowVersion" /> class.
        /// </summary>
        public FlowVersion()
        {
        }

    }
}