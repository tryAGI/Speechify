#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentTestsClient
    {
        /// <summary>
        /// Run Agent Test<br/>
        /// Enqueue a single run of the test. The returned run starts in<br/>
        /// `queued` status. Poll `GET /v1/agents/tests/runs/{test_run_id}` until the status<br/>
        /// reaches a terminal state (`passed`, `failed`, or `error`).
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTestRun> RunTestAsync(
            string testId,

            global::Speechify.RunTestRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Agent Test<br/>
        /// Enqueue a single run of the test. The returned run starts in<br/>
        /// `queued` status. Poll `GET /v1/agents/tests/runs/{test_run_id}` until the status<br/>
        /// reaches a terminal state (`passed`, `failed`, or `error`).
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTestRun>> RunTestAsResponseAsync(
            string testId,

            global::Speechify.RunTestRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Agent Test<br/>
        /// Enqueue a single run of the test. The returned run starts in<br/>
        /// `queued` status. Poll `GET /v1/agents/tests/runs/{test_run_id}` until the status<br/>
        /// reaches a terminal state (`passed`, `failed`, or `error`).
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="agentId">
        /// Run the test against this agent instead of the test's default agent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTestRun> RunTestAsync(
            string testId,
            string? speechifyVersion = default,
            string? agentId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}