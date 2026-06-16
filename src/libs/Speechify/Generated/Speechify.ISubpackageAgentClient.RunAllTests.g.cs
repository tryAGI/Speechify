#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// Run All Agent Tests<br/>
        /// Enqueue runs for every test on the agent concurrently. Up to 50<br/>
        /// tests are dispatched in one call. Each returned run starts in<br/>
        /// `queued` status; poll `GET /v1/agents/tests/runs/{id}` for the terminal<br/>
        /// result.<br/>
        /// An optional request body runs the whole suite against<br/>
        /// a proposed config: a `config_override` (prompt / model / tools)<br/>
        /// applied to every test without editing the tests, and/or a<br/>
        /// `flow_version_id` to target a specific flow version instead of<br/>
        /// the agent's active flow. Omit the body to run against the<br/>
        /// agent's live config and active flow.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RunAgentTestsResponse> RunAllTestsAsync(
            string id,

            global::Speechify.RunAllTestsRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run All Agent Tests<br/>
        /// Enqueue runs for every test on the agent concurrently. Up to 50<br/>
        /// tests are dispatched in one call. Each returned run starts in<br/>
        /// `queued` status; poll `GET /v1/agents/tests/runs/{id}` for the terminal<br/>
        /// result.<br/>
        /// An optional request body runs the whole suite against<br/>
        /// a proposed config: a `config_override` (prompt / model / tools)<br/>
        /// applied to every test without editing the tests, and/or a<br/>
        /// `flow_version_id` to target a specific flow version instead of<br/>
        /// the agent's active flow. Omit the body to run against the<br/>
        /// agent's live config and active flow.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.RunAgentTestsResponse>> RunAllTestsAsResponseAsync(
            string id,

            global::Speechify.RunAllTestsRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run All Agent Tests<br/>
        /// Enqueue runs for every test on the agent concurrently. Up to 50<br/>
        /// tests are dispatched in one call. Each returned run starts in<br/>
        /// `queued` status; poll `GET /v1/agents/tests/runs/{id}` for the terminal<br/>
        /// result.<br/>
        /// An optional request body runs the whole suite against<br/>
        /// a proposed config: a `config_override` (prompt / model / tools)<br/>
        /// applied to every test without editing the tests, and/or a<br/>
        /// `flow_version_id` to target a specific flow version instead of<br/>
        /// the agent's active flow. Omit the body to run against the<br/>
        /// agent's live config and active flow.
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RunAgentTestsResponse> RunAllTestsAsync(
            string id,
            global::Speechify.TestRunConfigOverride? configOverride = default,
            string? flowVersionId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}