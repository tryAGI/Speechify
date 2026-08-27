
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-verdict breakdown among the `completed` child runs.
    /// </summary>
    public sealed partial class AgentTestSuiteRunResults
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Passed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSuiteRunResults" /> class.
        /// </summary>
        /// <param name="passed"></param>
        /// <param name="failed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestSuiteRunResults(
            int passed,
            int failed)
        {
            this.Passed = passed;
            this.Failed = failed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSuiteRunResults" /> class.
        /// </summary>
        public AgentTestSuiteRunResults()
        {
        }

    }
}