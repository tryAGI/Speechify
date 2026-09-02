#nullable enable

namespace Speechify
{
    public partial interface ITestsClient
    {
        /// <summary>
        /// Run Tests (Targeted)<br/>
        /// Run a chosen set of tests against a target agent, bound at run<br/>
        /// time. The tests are not attached to the agent, so the same set can<br/>
        /// run against another agent variant in a second call (A/B) and,<br/>
        /// once agent versioning ships, against a pinned version<br/>
        /// (version-pinned regression). Every child run records the resolved<br/>
        /// target on the returned suite run. Total runs are capped at 100 per<br/>
        /// call; poll `GET /v1/agents/tests/runs/{test_run_id}` for each.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RunAgentTestsResponse> RunTargetedTestsAsync(

            global::Speechify.RunTargetedTestsRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Tests (Targeted)<br/>
        /// Run a chosen set of tests against a target agent, bound at run<br/>
        /// time. The tests are not attached to the agent, so the same set can<br/>
        /// run against another agent variant in a second call (A/B) and,<br/>
        /// once agent versioning ships, against a pinned version<br/>
        /// (version-pinned regression). Every child run records the resolved<br/>
        /// target on the returned suite run. Total runs are capped at 100 per<br/>
        /// call; poll `GET /v1/agents/tests/runs/{test_run_id}` for each.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.RunAgentTestsResponse>> RunTargetedTestsAsResponseAsync(

            global::Speechify.RunTargetedTestsRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Tests (Targeted)<br/>
        /// Run a chosen set of tests against a target agent, bound at run<br/>
        /// time. The tests are not attached to the agent, so the same set can<br/>
        /// run against another agent variant in a second call (A/B) and,<br/>
        /// once agent versioning ships, against a pinned version<br/>
        /// (version-pinned regression). Every child run records the resolved<br/>
        /// target on the returned suite run. Total runs are capped at 100 per<br/>
        /// call; poll `GET /v1/agents/tests/runs/{test_run_id}` for each.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RunAgentTestsResponse> RunTargetedTestsAsync(
            global::System.Collections.Generic.IList<string> testIds,
            global::Speechify.RunTarget target,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.TestRunConfigOverride? configOverride = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}