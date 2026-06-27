#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentTestsClient
    {
        /// <summary>
        /// Get Agent Test Run<br/>
        /// Retrieve a single test run by ID. Poll this endpoint until<br/>
        /// `status` reaches a terminal state (`passed`, `failed`, or `error`).<br/>
        /// The `result` field is populated on terminal states.
        /// </summary>
        /// <param name="testRunId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTestRun> GetTestRunAsync(
            string testRunId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Test Run<br/>
        /// Retrieve a single test run by ID. Poll this endpoint until<br/>
        /// `status` reaches a terminal state (`passed`, `failed`, or `error`).<br/>
        /// The `result` field is populated on terminal states.
        /// </summary>
        /// <param name="testRunId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTestRun>> GetTestRunAsResponseAsync(
            string testRunId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}