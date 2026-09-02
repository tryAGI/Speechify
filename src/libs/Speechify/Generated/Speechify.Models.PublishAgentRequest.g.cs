
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional body for POST /v1/agents/{agent_id}/publish.
    /// </summary>
    public sealed partial class PublishAgentRequest
    {
        /// <summary>
        /// On a gated workspace, a non-empty justification publishes past failing<br/>
        /// checks. The suite still runs and its verdict is recorded with this<br/>
        /// reason - an override bypasses blocking, not measurement. Must be at<br/>
        /// least 10 characters after trimming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gate_override_reason")]
        public string? GateOverrideReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishAgentRequest" /> class.
        /// </summary>
        /// <param name="gateOverrideReason">
        /// On a gated workspace, a non-empty justification publishes past failing<br/>
        /// checks. The suite still runs and its verdict is recorded with this<br/>
        /// reason - an override bypasses blocking, not measurement. Must be at<br/>
        /// least 10 characters after trimming.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishAgentRequest(
            string? gateOverrideReason)
        {
            this.GateOverrideReason = gateOverrideReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishAgentRequest" /> class.
        /// </summary>
        public PublishAgentRequest()
        {
        }

    }
}