#nullable enable

namespace Speechify
{
    public partial interface ITestsClient
    {
        /// <summary>
        /// Cancel Suite Run<br/>
        /// Cancel a suite run: every child run still pending or running is<br/>
        /// cancelled, which makes the suite's derived `status` `cancelled`.<br/>
        /// Child runs that already produced a verdict or errored are left<br/>
        /// untouched. Idempotent on a terminal suite - returns it unchanged.
        /// </summary>
        /// <param name="suiteRunId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTestSuiteRunWithRuns> CancelSuiteRunAsync(
            string suiteRunId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Suite Run<br/>
        /// Cancel a suite run: every child run still pending or running is<br/>
        /// cancelled, which makes the suite's derived `status` `cancelled`.<br/>
        /// Child runs that already produced a verdict or errored are left<br/>
        /// untouched. Idempotent on a terminal suite - returns it unchanged.
        /// </summary>
        /// <param name="suiteRunId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTestSuiteRunWithRuns>> CancelSuiteRunAsResponseAsync(
            string suiteRunId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}