
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/{agent_id}/share-links`. Every field is<br/>
    /// optional and falls back to a bounded default.
    /// </summary>
    public sealed partial class CreateShareLinkRequest
    {
        /// <summary>
        /// An optional note so several links can be told apart.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// How long the link stays usable. A duration rather than a<br/>
        /// timestamp, so a client with a skewed clock cannot mint a link<br/>
        /// that is already expired. Defaults to 7 days, maximum 30.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in_seconds")]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Total conversation time the link may authorise, across all its<br/>
        /// calls. This is the control that bounds what a leaked link can<br/>
        /// cost. Defaults to 1 hour, maximum 4.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_seconds")]
        public int? BudgetSeconds { get; set; }

        /// <summary>
        /// Ceiling on a single call. Defaults to 5 minutes, maximum 30, and<br/>
        /// is clamped again to the agent's own limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_call_duration_seconds")]
        public int? MaxCallDurationSeconds { get; set; }

        /// <summary>
        /// Simultaneous calls allowed on this link. Defaults to 3, maximum 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent")]
        public int? MaxConcurrent { get; set; }

        /// <summary>
        /// Tools to opt this link into, by id — the same `tool_…` ids<br/>
        /// `listAgentTools` returns. Omit for the default posture (call<br/>
        /// controls and knowledge search only). Opting a webhook or MCP<br/>
        /// tool in lets a stranger drive it, so it is an explicit act<br/>
        /// rather than something inherited from the agent. Every id must<br/>
        /// name a tool attached to this agent; anything else is a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tool_ids")]
        public global::System.Collections.Generic.IList<string>? AllowedToolIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShareLinkRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// An optional note so several links can be told apart.
        /// </param>
        /// <param name="expiresInSeconds">
        /// How long the link stays usable. A duration rather than a<br/>
        /// timestamp, so a client with a skewed clock cannot mint a link<br/>
        /// that is already expired. Defaults to 7 days, maximum 30.
        /// </param>
        /// <param name="budgetSeconds">
        /// Total conversation time the link may authorise, across all its<br/>
        /// calls. This is the control that bounds what a leaked link can<br/>
        /// cost. Defaults to 1 hour, maximum 4.
        /// </param>
        /// <param name="maxCallDurationSeconds">
        /// Ceiling on a single call. Defaults to 5 minutes, maximum 30, and<br/>
        /// is clamped again to the agent's own limit.
        /// </param>
        /// <param name="maxConcurrent">
        /// Simultaneous calls allowed on this link. Defaults to 3, maximum 10.
        /// </param>
        /// <param name="allowedToolIds">
        /// Tools to opt this link into, by id — the same `tool_…` ids<br/>
        /// `listAgentTools` returns. Omit for the default posture (call<br/>
        /// controls and knowledge search only). Opting a webhook or MCP<br/>
        /// tool in lets a stranger drive it, so it is an explicit act<br/>
        /// rather than something inherited from the agent. Every id must<br/>
        /// name a tool attached to this agent; anything else is a 400.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateShareLinkRequest(
            string? label,
            int? expiresInSeconds,
            int? budgetSeconds,
            int? maxCallDurationSeconds,
            int? maxConcurrent,
            global::System.Collections.Generic.IList<string>? allowedToolIds)
        {
            this.Label = label;
            this.ExpiresInSeconds = expiresInSeconds;
            this.BudgetSeconds = budgetSeconds;
            this.MaxCallDurationSeconds = maxCallDurationSeconds;
            this.MaxConcurrent = maxConcurrent;
            this.AllowedToolIds = allowedToolIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShareLinkRequest" /> class.
        /// </summary>
        public CreateShareLinkRequest()
        {
        }

    }
}