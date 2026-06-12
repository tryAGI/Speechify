
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One (test, agent) pair. Poll the `attached_agent_ids` field on `AgentTestWithLastRun` or hit `/v1/agents/tests/{id}/attachments` for the authoritative set.
    /// </summary>
    public sealed partial class TtsAgentTestAttachment
    {
        /// <summary>
        /// Prefixed wire identifier (`test_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the attached test. ADR 0015 FK consistency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestId { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the attached agent. ADR 0015 FK consistency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAgentTestAttachment" /> class.
        /// </summary>
        /// <param name="testId">
        /// Prefixed wire identifier (`test_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the attached test. ADR 0015 FK consistency.
        /// </param>
        /// <param name="agentId">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the attached agent. ADR 0015 FK consistency.
        /// </param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAgentTestAttachment(
            string testId,
            string agentId,
            global::System.DateTime createdAt)
        {
            this.TestId = testId ?? throw new global::System.ArgumentNullException(nameof(testId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAgentTestAttachment" /> class.
        /// </summary>
        public TtsAgentTestAttachment()
        {
        }

    }
}