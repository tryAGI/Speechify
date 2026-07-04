#nullable enable

namespace Speechify
{
    public partial interface IBatchCallsClient
    {
        /// <summary>
        /// Get Batch Call<br/>
        /// Returns the batch call. List its recipients with<br/>
        /// `GET /v1/agents/batch-calls/{batch_call_id}/recipients`.
        /// </summary>
        /// <param name="batchCallId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.BatchCall> GetAsync(
            string batchCallId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Batch Call<br/>
        /// Returns the batch call. List its recipients with<br/>
        /// `GET /v1/agents/batch-calls/{batch_call_id}/recipients`.
        /// </summary>
        /// <param name="batchCallId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.BatchCall>> GetAsResponseAsync(
            string batchCallId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}