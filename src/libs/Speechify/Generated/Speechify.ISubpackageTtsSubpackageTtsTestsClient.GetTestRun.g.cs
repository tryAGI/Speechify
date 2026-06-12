#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsTestsClient
    {
        /// <summary>
        /// Get Agent Test Run<br/>
        /// Retrieve a single test run by ID. Poll this endpoint until<br/>
        /// `status` reaches a terminal state (`passed`, `failed`, or `error`).<br/>
        /// The `result` field is populated on terminal states.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgentTestRun> GetTestRunAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Test Run<br/>
        /// Retrieve a single test run by ID. Poll this endpoint until<br/>
        /// `status` reaches a terminal state (`passed`, `failed`, or `error`).<br/>
        /// The `result` field is populated on terminal states.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsAgentTestRun>> GetTestRunAsResponseAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}