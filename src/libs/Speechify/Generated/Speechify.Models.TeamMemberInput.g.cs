
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A member as written on a create/update body. Only `agent_id` is<br/>
    /// required: `role` defaults to `member`, `delegation` is optional, and<br/>
    /// `position` defaults to the member's index in the array.
    /// </summary>
    public sealed partial class TeamMemberInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation")]
        public string? Delegation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberInput" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="role"></param>
        /// <param name="delegation"></param>
        /// <param name="position"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMemberInput(
            string agentId,
            string? role,
            string? delegation,
            int? position)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Role = role;
            this.Delegation = delegation;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberInput" /> class.
        /// </summary>
        public TeamMemberInput()
        {
        }

    }
}