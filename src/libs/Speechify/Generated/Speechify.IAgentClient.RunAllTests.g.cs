#nullable enable

namespace Speechify
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Run All Agent Tests<br/>
        /// Enqueue runs for every test on the agent concurrently. Up to 50<br/>
        /// tests are dispatched in one call. Each returned run starts in<br/>
        /// `pending` status; poll `GET /v1/agents/tests/runs/{test_run_id}` for the terminal<br/>
        /// result (`completed` / `failed` / `cancelled`, with the pass/fail<br/>
        /// judgment in the separate `verdict` field).<br/>
        /// An optional request body runs the whole suite against<br/>
        /// a proposed config: a `config_override` (prompt / model / tools)<br/>
        /// applied to every test without editing the tests, and/or a<br/>
        /// `flow_version_id` to target a specific flow version instead of<br/>
        /// the agent's active flow. Omit the body to run against the<br/>
        /// agent's live config and active flow.<br/>
        /// Runs are admitted against the workspace's remaining credit and its<br/>
        /// spending limits. `config_override.model` must be a model the<br/>
        /// workspace's plan includes; an over-tier model returns `402` before<br/>
        /// any run is queued.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RunAgentTestsResponse> RunAllTestsAsync(
            string agentId,

            global::Speechify.RunAllTestsRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run All Agent Tests<br/>
        /// Enqueue runs for every test on the agent concurrently. Up to 50<br/>
        /// tests are dispatched in one call. Each returned run starts in<br/>
        /// `pending` status; poll `GET /v1/agents/tests/runs/{test_run_id}` for the terminal<br/>
        /// result (`completed` / `failed` / `cancelled`, with the pass/fail<br/>
        /// judgment in the separate `verdict` field).<br/>
        /// An optional request body runs the whole suite against<br/>
        /// a proposed config: a `config_override` (prompt / model / tools)<br/>
        /// applied to every test without editing the tests, and/or a<br/>
        /// `flow_version_id` to target a specific flow version instead of<br/>
        /// the agent's active flow. Omit the body to run against the<br/>
        /// agent's live config and active flow.<br/>
        /// Runs are admitted against the workspace's remaining credit and its<br/>
        /// spending limits. `config_override.model` must be a model the<br/>
        /// workspace's plan includes; an over-tier model returns `402` before<br/>
        /// any run is queued.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.RunAgentTestsResponse>> RunAllTestsAsResponseAsync(
            string agentId,

            global::Speechify.RunAllTestsRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run All Agent Tests<br/>
        /// Enqueue runs for every test on the agent concurrently. Up to 50<br/>
        /// tests are dispatched in one call. Each returned run starts in<br/>
        /// `pending` status; poll `GET /v1/agents/tests/runs/{test_run_id}` for the terminal<br/>
        /// result (`completed` / `failed` / `cancelled`, with the pass/fail<br/>
        /// judgment in the separate `verdict` field).<br/>
        /// An optional request body runs the whole suite against<br/>
        /// a proposed config: a `config_override` (prompt / model / tools)<br/>
        /// applied to every test without editing the tests, and/or a<br/>
        /// `flow_version_id` to target a specific flow version instead of<br/>
        /// the agent's active flow. Omit the body to run against the<br/>
        /// agent's live config and active flow.<br/>
        /// Runs are admitted against the workspace's remaining credit and its<br/>
        /// spending limits. `config_override.model` must be a model the<br/>
        /// workspace's plan includes; an over-tier model returns `402` before<br/>
        /// any run is queued.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
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
        /// <param name="flowVersionId">
        /// Targets a specific flow version (an `agent_versions` row)<br/>
        /// instead of the agent's active flow — version-targeted<br/>
        /// regression. Must be a flow version of the agent under test.<br/>
        /// Prefixed external id (`fver_...`).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RunAgentTestsResponse> RunAllTestsAsync(
            string agentId,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.TestRunConfigOverride? configOverride = default,
            string? flowVersionId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}