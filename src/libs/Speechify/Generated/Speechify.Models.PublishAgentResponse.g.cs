
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The outcome of publishing a task agent's current configuration.
    /// </summary>
    public sealed partial class PublishAgentResponse
    {
        /// <summary>
        /// The agent that was published.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Identifies the exact configuration this decision covers. A run is<br/>
        /// admitted only against a fingerprint carrying a passing (or overridden)<br/>
        /// decision, so any edit that changes the agent's behavior produces a new<br/>
        /// fingerprint and requires publishing again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_fingerprint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigFingerprint { get; set; }

        /// <summary>
        /// When the configuration was published.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishedAt { get; set; }

        /// <summary>
        /// The gate outcome. Absent when the workspace is not gated, in which case<br/>
        /// nothing was scored and runs are admitted without a gate check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gate")]
        public global::Speechify.PublishGateResult? Gate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishAgentResponse" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The agent that was published.
        /// </param>
        /// <param name="configFingerprint">
        /// Identifies the exact configuration this decision covers. A run is<br/>
        /// admitted only against a fingerprint carrying a passing (or overridden)<br/>
        /// decision, so any edit that changes the agent's behavior produces a new<br/>
        /// fingerprint and requires publishing again.
        /// </param>
        /// <param name="publishedAt">
        /// When the configuration was published.
        /// </param>
        /// <param name="gate">
        /// The gate outcome. Absent when the workspace is not gated, in which case<br/>
        /// nothing was scored and runs are admitted without a gate check.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishAgentResponse(
            string agentId,
            string configFingerprint,
            global::System.DateTime publishedAt,
            global::Speechify.PublishGateResult? gate)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ConfigFingerprint = configFingerprint ?? throw new global::System.ArgumentNullException(nameof(configFingerprint));
            this.PublishedAt = publishedAt;
            this.Gate = gate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishAgentResponse" /> class.
        /// </summary>
        public PublishAgentResponse()
        {
        }

    }
}