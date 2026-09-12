
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunTestRequest
    {
        /// <summary>
        /// Bind the run to this agent (any agent in the workspace).<br/>
        /// Omit to run against the agent the test was authored<br/>
        /// against; required when the test has no authoring agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunTestRequest" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Bind the run to this agent (any agent in the workspace).<br/>
        /// Omit to run against the agent the test was authored<br/>
        /// against; required when the test has no authoring agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunTestRequest(
            string? agentId)
        {
            this.AgentId = agentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunTestRequest" /> class.
        /// </summary>
        public RunTestRequest()
        {
        }

    }
}