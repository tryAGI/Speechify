
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunTestRequest
    {
        /// <summary>
        /// Run the test against this agent instead of the test's default agent.
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
        /// Run the test against this agent instead of the test's default agent.
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