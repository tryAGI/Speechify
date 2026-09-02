
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentRunInputDelegationTargetsItems
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunInputDelegationTargetsItems" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="role"></param>
        /// <param name="delegation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunInputDelegationTargetsItems(
            string? agentId,
            string? role,
            string? delegation)
        {
            this.AgentId = agentId;
            this.Role = role;
            this.Delegation = delegation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunInputDelegationTargetsItems" /> class.
        /// </summary>
        public AgentRunInputDelegationTargetsItems()
        {
        }

    }
}