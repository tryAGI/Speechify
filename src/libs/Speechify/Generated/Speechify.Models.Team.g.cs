
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A workspace-owned composition of agents: a `manager_agent_id` that<br/>
    /// orchestrates plus the `members` it delegates to. Persists the<br/>
    /// composition; the delegation runtime that runs a team is a later<br/>
    /// addition.
    /// </summary>
    public sealed partial class Team
    {
        /// <summary>
        /// The project this team belongs to; null when it belongs to none.<br/>
        /// Its agents live in the same project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`team_&lt;26 char Crockford base32&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable label, unique within the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional longer description. Empty string when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The orchestrator agent, or `null` while a draft has no manager<br/>
        /// picked yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_agent_id")]
        public string? ManagerAgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TeamMember> Members { get; set; }

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
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`team_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="name">
        /// Human-readable label, unique within the workspace.
        /// </param>
        /// <param name="description">
        /// Optional longer description. Empty string when unset.
        /// </param>
        /// <param name="members"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="projectId">
        /// The project this team belongs to; null when it belongs to none.<br/>
        /// Its agents live in the same project.
        /// </param>
        /// <param name="managerAgentId">
        /// The orchestrator agent, or `null` while a draft has no manager<br/>
        /// picked yet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Team(
            string id,
            string name,
            string description,
            global::System.Collections.Generic.IList<global::Speechify.TeamMember> members,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? projectId,
            string? managerAgentId)
        {
            this.ProjectId = projectId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ManagerAgentId = managerAgentId;
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        public Team()
        {
        }

    }
}