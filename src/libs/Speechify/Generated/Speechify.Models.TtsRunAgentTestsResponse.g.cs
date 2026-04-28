
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Response from `POST /v1/agents/{id}/tests/runs`. Contains every<br/>
    /// newly-queued run so the client can poll each for completion.<br/>
    /// Capped at 50 runs per call.
    /// </summary>
    public sealed partial class TtsRunAgentTestsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestRun> Runs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRunAgentTestsResponse" /> class.
        /// </summary>
        /// <param name="runs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsRunAgentTestsResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestRun> runs)
        {
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRunAgentTestsResponse" /> class.
        /// </summary>
        public TtsRunAgentTestsResponse()
        {
        }
    }
}