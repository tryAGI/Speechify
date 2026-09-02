
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The agent's most recent publish-gate decision.
    /// </summary>
    public sealed partial class LatestPublishGateRunResponse
    {
        /// <summary>
        /// Null when the agent has never been gated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gate_run")]
        public global::Speechify.PublishGateRun? GateRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LatestPublishGateRunResponse" /> class.
        /// </summary>
        /// <param name="gateRun">
        /// Null when the agent has never been gated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LatestPublishGateRunResponse(
            global::Speechify.PublishGateRun? gateRun)
        {
            this.GateRun = gateRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatestPublishGateRunResponse" /> class.
        /// </summary>
        public LatestPublishGateRunResponse()
        {
        }

    }
}