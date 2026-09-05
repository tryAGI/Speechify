
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Compose a team. The manager and every member must be an agent in the<br/>
    /// caller's workspace. `description` defaults to an empty string and<br/>
    /// `members` to an empty roster.
    /// </summary>
    public sealed partial class CreateTeamRequest
    {
        /// <summary>
        /// The project to create it in. A project-pinned credential creates<br/>
        /// into its own project regardless, and naming a different one is<br/>
        /// refused rather than silently redirected. Omit for no project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

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
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_agent_id")]
        public string? ManagerAgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::Speechify.TeamMemberInput>? Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId">
        /// The project to create it in. A project-pinned credential creates<br/>
        /// into its own project regardless, and naming a different one is<br/>
        /// refused rather than silently redirected. Omit for no project.
        /// </param>
        /// <param name="description"></param>
        /// <param name="managerAgentId"></param>
        /// <param name="members"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTeamRequest(
            string name,
            string? projectId,
            string? description,
            string? managerAgentId,
            global::System.Collections.Generic.IList<global::Speechify.TeamMemberInput>? members)
        {
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ManagerAgentId = managerAgentId;
            this.Members = members;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamRequest" /> class.
        /// </summary>
        public CreateTeamRequest()
        {
        }

    }
}