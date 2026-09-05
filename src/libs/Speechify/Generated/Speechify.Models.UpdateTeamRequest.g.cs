
#nullable enable

namespace Speechify
{
    /// <summary>
    /// All fields optional (merge-patch): an omitted field is left unchanged,<br/>
    /// `manager_agent_id: null` clears the manager, and a `members` array<br/>
    /// replaces the whole roster.
    /// </summary>
    public sealed partial class UpdateTeamRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateTeamRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="managerAgentId"></param>
        /// <param name="members"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTeamRequest(
            string? name,
            string? description,
            string? managerAgentId,
            global::System.Collections.Generic.IList<global::Speechify.TeamMemberInput>? members)
        {
            this.Name = name;
            this.Description = description;
            this.ManagerAgentId = managerAgentId;
            this.Members = members;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamRequest" /> class.
        /// </summary>
        public UpdateTeamRequest()
        {
        }

    }
}