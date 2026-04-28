
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One entry in a batch-run request. Omit `agent_id` to fan out to<br/>
    /// every agent the test is attached to.
    /// </summary>
    public sealed partial class TtsBatchRunEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsBatchRunEntry" /> class.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="agentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsBatchRunEntry(
            string testId,
            string? agentId)
        {
            this.TestId = testId ?? throw new global::System.ArgumentNullException(nameof(testId));
            this.AgentId = agentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsBatchRunEntry" /> class.
        /// </summary>
        public TtsBatchRunEntry()
        {
        }
    }
}