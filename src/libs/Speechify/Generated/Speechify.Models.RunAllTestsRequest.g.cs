
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional body of `POST /v1/agents/{agent_id}/tests/runs`. Omit it<br/>
    /// entirely to run every test against the agent's live config and<br/>
    /// active flow.
    /// </summary>
    public sealed partial class RunAllTestsRequest
    {
        /// <summary>
        /// A run-level config override applied to every test in a Run All.<br/>
        /// Layered on top of the agent's stored config for the duration of<br/>
        /// the suite run, so the whole suite can be validated against a<br/>
        /// proposed prompt / model / toolbelt without editing any test. An<br/>
        /// absent field leaves the agent's value untouched; a run-level<br/>
        /// override wins over a deprecated per-test `system_prompt_override`<br/>
        /// / `model_override`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_override")]
        public global::Speechify.TestRunConfigOverride? ConfigOverride { get; set; }

        /// <summary>
        /// Targets a specific flow version (an `agent_versions` row)<br/>
        /// instead of the agent's active flow — version-targeted<br/>
        /// regression. Must be a flow version of the agent under test.<br/>
        /// Raw UUID; flow versions carry no prefixed wire id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flow_version_id")]
        public string? FlowVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAllTestsRequest" /> class.
        /// </summary>
        /// <param name="configOverride">
        /// A run-level config override applied to every test in a Run All.<br/>
        /// Layered on top of the agent's stored config for the duration of<br/>
        /// the suite run, so the whole suite can be validated against a<br/>
        /// proposed prompt / model / toolbelt without editing any test. An<br/>
        /// absent field leaves the agent's value untouched; a run-level<br/>
        /// override wins over a deprecated per-test `system_prompt_override`<br/>
        /// / `model_override`.
        /// </param>
        /// <param name="flowVersionId">
        /// Targets a specific flow version (an `agent_versions` row)<br/>
        /// instead of the agent's active flow — version-targeted<br/>
        /// regression. Must be a flow version of the agent under test.<br/>
        /// Raw UUID; flow versions carry no prefixed wire id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunAllTestsRequest(
            global::Speechify.TestRunConfigOverride? configOverride,
            string? flowVersionId)
        {
            this.ConfigOverride = configOverride;
            this.FlowVersionId = flowVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAllTestsRequest" /> class.
        /// </summary>
        public RunAllTestsRequest()
        {
        }

    }
}