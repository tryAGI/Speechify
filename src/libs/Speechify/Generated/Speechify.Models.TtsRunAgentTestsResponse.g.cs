
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Response from `POST /v1/agents/{id}/tests/runs` and the suite-run<br/>
    /// resubmit endpoint. Contains every newly-queued run so the client<br/>
    /// can poll each for completion, plus the `suite_run` that groups<br/>
    /// them. `suite_run` is null only when a Run All found no tests.
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
        /// The suite run grouping the queued runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suite_run")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsAgentTestSuiteRun, object>))]
        public global::Speechify.OneOf<global::Speechify.TtsAgentTestSuiteRun, object>? SuiteRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRunAgentTestsResponse" /> class.
        /// </summary>
        /// <param name="runs"></param>
        /// <param name="suiteRun">
        /// The suite run grouping the queued runs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsRunAgentTestsResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestRun> runs,
            global::Speechify.OneOf<global::Speechify.TtsAgentTestSuiteRun, object>? suiteRun)
        {
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
            this.SuiteRun = suiteRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRunAgentTestsResponse" /> class.
        /// </summary>
        public TtsRunAgentTestsResponse()
        {
        }

    }
}