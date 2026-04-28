#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Run Test<br/>
        /// Enqueue a single run of the test. The returned run starts in<br/>
        /// `queued` status. Poll `GET /v1/test-runs/{id}` until the status<br/>
        /// reaches a terminal state (`passed`, `failed`, or `error`).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgentTestRun> RunTestAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}