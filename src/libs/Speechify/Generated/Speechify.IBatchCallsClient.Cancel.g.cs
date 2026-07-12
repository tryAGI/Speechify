#nullable enable

namespace Speechify
{
    public partial interface IBatchCallsClient
    {
        /// <summary>
        /// Cancel Batch Call<br/>
        /// Cancel a batch call. Moves any non-terminal batch - `pending`<br/>
        /// (including one deferred to a future `scheduled_at`) or `running` - to<br/>
        /// `cancelled` and stops the dispatcher from dialing the not-yet-dialed<br/>
        /// recipients (they become `cancelled`; calls already placed keep their<br/>
        /// outcome). Idempotent (§16): cancelling an already-terminal batch<br/>
        /// (`completed` / `failed` / `cancelled`) returns it unchanged. 404 only<br/>
        /// when the batch id is unknown.
        /// </summary>
        /// <param name="batchCallId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.BatchCall> CancelAsync(
            string batchCallId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Batch Call<br/>
        /// Cancel a batch call. Moves any non-terminal batch - `pending`<br/>
        /// (including one deferred to a future `scheduled_at`) or `running` - to<br/>
        /// `cancelled` and stops the dispatcher from dialing the not-yet-dialed<br/>
        /// recipients (they become `cancelled`; calls already placed keep their<br/>
        /// outcome). Idempotent (§16): cancelling an already-terminal batch<br/>
        /// (`completed` / `failed` / `cancelled`) returns it unchanged. 404 only<br/>
        /// when the batch id is unknown.
        /// </summary>
        /// <param name="batchCallId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.BatchCall>> CancelAsResponseAsync(
            string batchCallId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}