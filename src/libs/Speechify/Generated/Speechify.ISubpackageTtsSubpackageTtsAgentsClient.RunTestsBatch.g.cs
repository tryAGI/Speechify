#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Run Tests Batch<br/>
        /// Queue runs for every (test, agent) pair in the body. Entries<br/>
        /// without an `agent_id` fan out to every agent the test is<br/>
        /// attached to. Total expanded runs are capped at 100 per call.<br/>
        /// Each entry in the response is a queued run; poll<br/>
        /// `GET /v1/test-runs/{id}` for each.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsRunBatchResponse> RunTestsBatchAsync(

            global::Speechify.TtsRunBatchRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Tests Batch<br/>
        /// Queue runs for every (test, agent) pair in the body. Entries<br/>
        /// without an `agent_id` fan out to every agent the test is<br/>
        /// attached to. Total expanded runs are capped at 100 per call.<br/>
        /// Each entry in the response is a queued run; poll<br/>
        /// `GET /v1/test-runs/{id}` for each.
        /// </summary>
        /// <param name="entries"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsRunBatchResponse> RunTestsBatchAsync(
            global::System.Collections.Generic.IList<global::Speechify.TtsBatchRunEntry> entries,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}