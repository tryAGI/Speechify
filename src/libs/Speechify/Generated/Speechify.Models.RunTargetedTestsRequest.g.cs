
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Run a chosen set of tests against a target agent, bound at run<br/>
    /// time. The tests are not attached to the agent, so the same set can<br/>
    /// run against another agent in a second call (A/B), and against a<br/>
    /// pinned agent version once versioning ships (version-pinned<br/>
    /// regression). Total runs are capped at 100 per call.
    /// </summary>
    public sealed partial class RunTargetedTestsRequest
    {
        /// <summary>
        /// Prefixed `test_&lt;crockford&gt;` ids to run. De-duplicated, so a<br/>
        /// repeated id runs once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TestIds { get; set; }

        /// <summary>
        /// The agent a targeted run binds to at run time. `agent_id` is<br/>
        /// required. `version` and `tag` pin a specific agent version once<br/>
        /// agent versioning ships; supplying either today returns 400, so<br/>
        /// agent-id targeting works now and version/tag light up later without<br/>
        /// a wire change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.RunTarget Target { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunTargetedTestsRequest" /> class.
        /// </summary>
        /// <param name="testIds">
        /// Prefixed `test_&lt;crockford&gt;` ids to run. De-duplicated, so a<br/>
        /// repeated id runs once.
        /// </param>
        /// <param name="target">
        /// The agent a targeted run binds to at run time. `agent_id` is<br/>
        /// required. `version` and `tag` pin a specific agent version once<br/>
        /// agent versioning ships; supplying either today returns 400, so<br/>
        /// agent-id targeting works now and version/tag light up later without<br/>
        /// a wire change.
        /// </param>
        /// <param name="configOverride">
        /// A run-level config override applied to every test in a Run All.<br/>
        /// Layered on top of the agent's stored config for the duration of<br/>
        /// the suite run, so the whole suite can be validated against a<br/>
        /// proposed prompt / model / toolbelt without editing any test. An<br/>
        /// absent field leaves the agent's value untouched; a run-level<br/>
        /// override wins over a deprecated per-test `system_prompt_override`<br/>
        /// / `model_override`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunTargetedTestsRequest(
            global::System.Collections.Generic.IList<string> testIds,
            global::Speechify.RunTarget target,
            global::Speechify.TestRunConfigOverride? configOverride)
        {
            this.TestIds = testIds ?? throw new global::System.ArgumentNullException(nameof(testIds));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.ConfigOverride = configOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunTargetedTestsRequest" /> class.
        /// </summary>
        public RunTargetedTestsRequest()
        {
        }

    }
}