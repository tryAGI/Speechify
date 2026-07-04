#nullable enable

namespace Speechify
{
    public partial interface ITestsClient
    {
        /// <summary>
        /// Cancel Agent Test Run<br/>
        /// Cancel a non-terminal test run. Idempotent on a terminal run<br/>
        /// (`completed` / `failed` / `cancelled`) - the call returns the<br/>
        /// unchanged run.
        /// </summary>
        /// <param name="testRunId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTestRun> CancelTestRunAsync(
            string testRunId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Agent Test Run<br/>
        /// Cancel a non-terminal test run. Idempotent on a terminal run<br/>
        /// (`completed` / `failed` / `cancelled`) - the call returns the<br/>
        /// unchanged run.
        /// </summary>
        /// <param name="testRunId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTestRun>> CancelTestRunAsResponseAsync(
            string testRunId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}