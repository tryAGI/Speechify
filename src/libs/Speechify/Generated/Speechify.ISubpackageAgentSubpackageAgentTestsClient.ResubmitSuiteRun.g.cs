#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentTestsClient
    {
        /// <summary>
        /// Resubmit Suite Run<br/>
        /// Re-run the failed and errored tests of a suite run as a fresh<br/>
        /// suite run, linked back to the original via<br/>
        /// `parent_suite_run_id`. Returns 400 when the suite run has no<br/>
        /// failed or errored tests to re-run.
        /// </summary>
        /// <param name="suiteRunId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RunAgentTestsResponse> ResubmitSuiteRunAsync(
            string suiteRunId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resubmit Suite Run<br/>
        /// Re-run the failed and errored tests of a suite run as a fresh<br/>
        /// suite run, linked back to the original via<br/>
        /// `parent_suite_run_id`. Returns 400 when the suite run has no<br/>
        /// failed or errored tests to re-run.
        /// </summary>
        /// <param name="suiteRunId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.RunAgentTestsResponse>> ResubmitSuiteRunAsResponseAsync(
            string suiteRunId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}