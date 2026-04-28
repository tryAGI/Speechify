#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Run All Tests<br/>
        /// Enqueue runs for every test on the agent concurrently. Up to 50<br/>
        /// tests are dispatched in one call. Each returned run starts in<br/>
        /// `queued` status; poll `GET /v1/test-runs/{id}` for the terminal<br/>
        /// result.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsRunAgentTestsResponse> RunAllTestsAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}