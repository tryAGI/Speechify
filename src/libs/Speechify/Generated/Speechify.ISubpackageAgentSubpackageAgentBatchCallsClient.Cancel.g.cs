#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentBatchCallsClient
    {
        /// <summary>
        /// Cancel Batch Call<br/>
        /// Cancels a pending batch before it starts dialing (including one<br/>
        /// deferred to a future `scheduled_at`). Returns 409 if the batch is<br/>
        /// already running or completed.
        /// </summary>
        /// <param name="batchCallId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.CreateBatchCallResponse> CancelAsync(
            string batchCallId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Batch Call<br/>
        /// Cancels a pending batch before it starts dialing (including one<br/>
        /// deferred to a future `scheduled_at`). Returns 409 if the batch is<br/>
        /// already running or completed.
        /// </summary>
        /// <param name="batchCallId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.CreateBatchCallResponse>> CancelAsResponseAsync(
            string batchCallId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}