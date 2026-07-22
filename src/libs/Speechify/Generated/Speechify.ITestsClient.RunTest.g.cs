#nullable enable

namespace Speechify
{
    public partial interface ITestsClient
    {
        /// <summary>
        /// Run Agent Test<br/>
        /// Enqueue a single run of the test. The returned run starts in<br/>
        /// `pending` status. Poll `GET /v1/agents/tests/runs/{test_run_id}` until the status<br/>
        /// reaches a terminal state (`completed`, `failed`, or `cancelled`). A<br/>
        /// run that reached `completed` produced a judgment - read the separate<br/>
        /// `verdict` field (`passed` / `failed`) for the pass/fail result.<br/>
        /// A run is admitted against the workspace's remaining credit and its<br/>
        /// spending limits, and executes on the models the workspace's plan<br/>
        /// includes. A depleted balance or an exhausted spend limit returns<br/>
        /// `402`.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTestRun> RunTestAsync(
            string testId,

            global::Speechify.RunTestRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Agent Test<br/>
        /// Enqueue a single run of the test. The returned run starts in<br/>
        /// `pending` status. Poll `GET /v1/agents/tests/runs/{test_run_id}` until the status<br/>
        /// reaches a terminal state (`completed`, `failed`, or `cancelled`). A<br/>
        /// run that reached `completed` produced a judgment - read the separate<br/>
        /// `verdict` field (`passed` / `failed`) for the pass/fail result.<br/>
        /// A run is admitted against the workspace's remaining credit and its<br/>
        /// spending limits, and executes on the models the workspace's plan<br/>
        /// includes. A depleted balance or an exhausted spend limit returns<br/>
        /// `402`.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTestRun>> RunTestAsResponseAsync(
            string testId,

            global::Speechify.RunTestRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Agent Test<br/>
        /// Enqueue a single run of the test. The returned run starts in<br/>
        /// `pending` status. Poll `GET /v1/agents/tests/runs/{test_run_id}` until the status<br/>
        /// reaches a terminal state (`completed`, `failed`, or `cancelled`). A<br/>
        /// run that reached `completed` produced a judgment - read the separate<br/>
        /// `verdict` field (`passed` / `failed`) for the pass/fail result.<br/>
        /// A run is admitted against the workspace's remaining credit and its<br/>
        /// spending limits, and executes on the models the workspace's plan<br/>
        /// includes. A depleted balance or an exhausted spend limit returns<br/>
        /// `402`.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="agentId">
        /// Run the test against this agent instead of the test's default agent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTestRun> RunTestAsync(
            string testId,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? agentId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}