#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentTestsClient
    {
        /// <summary>
        /// Get Suite Run<br/>
        /// Retrieve a suite run by ID with its child runs and the derived<br/>
        /// aggregate `status`, `verdict`, and progress counts.
        /// </summary>
        /// <param name="suiteRunId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTestSuiteRunWithRuns> GetSuiteRunAsync(
            string suiteRunId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Suite Run<br/>
        /// Retrieve a suite run by ID with its child runs and the derived<br/>
        /// aggregate `status`, `verdict`, and progress counts.
        /// </summary>
        /// <param name="suiteRunId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTestSuiteRunWithRuns>> GetSuiteRunAsResponseAsync(
            string suiteRunId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}