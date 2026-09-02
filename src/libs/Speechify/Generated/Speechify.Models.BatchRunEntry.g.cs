
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One entry in a batch-run request. Omit `agent_id` to run the test<br/>
    /// against the agent it was authored against; a test with no authoring<br/>
    /// agent requires an explicit `agent_id`.
    /// </summary>
    public sealed partial class BatchRunEntry
    {
        /// <summary>
        /// Prefixed wire identifier (`test_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the test to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestId { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent to run the test against (any agent in the<br/>
        /// workspace; the run target is bound here at run time). Omit to<br/>
        /// run against the agent the test was authored against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRunEntry" /> class.
        /// </summary>
        /// <param name="testId">
        /// Prefixed wire identifier (`test_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the test to run.
        /// </param>
        /// <param name="agentId">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent to run the test against (any agent in the<br/>
        /// workspace; the run target is bound here at run time). Omit to<br/>
        /// run against the agent the test was authored against.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRunEntry(
            string testId,
            string? agentId)
        {
            this.TestId = testId ?? throw new global::System.ArgumentNullException(nameof(testId));
            this.AgentId = agentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRunEntry" /> class.
        /// </summary>
        public BatchRunEntry()
        {
        }

    }
}