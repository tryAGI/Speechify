
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One agent the manager delegates to, with an optional natural-language<br/>
    /// hand-off note and a canvas ordering position.
    /// </summary>
    public sealed partial class TeamMember
    {
        /// <summary>
        /// The member agent (prefixed external id, `agent_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The member's role within the team. Defaults to `member`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// Natural-language note for when the manager should hand work to this<br/>
        /// member (for example "refunds over $100"). Empty when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delegation { get; set; }

        /// <summary>
        /// The member's ordering position on the composition canvas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMember" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The member agent (prefixed external id, `agent_...`).
        /// </param>
        /// <param name="role">
        /// The member's role within the team. Defaults to `member`.
        /// </param>
        /// <param name="delegation">
        /// Natural-language note for when the manager should hand work to this<br/>
        /// member (for example "refunds over $100"). Empty when unset.
        /// </param>
        /// <param name="position">
        /// The member's ordering position on the composition canvas.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMember(
            string agentId,
            string role,
            string delegation,
            int position)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Delegation = delegation ?? throw new global::System.ArgumentNullException(nameof(delegation));
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMember" /> class.
        /// </summary>
        public TeamMember()
        {
        }

    }
}