#nullable enable

namespace Speechify
{
    public partial interface ICallersClient
    {
        /// <summary>
        /// List Memories For Caller<br/>
        /// List one page of memories belonging to the caller, newest first.<br/>
        /// Soft-deleted memories AND memories whose parent caller is<br/>
        /// soft-deleted are hidden — the GDPR purge semantics require the<br/>
        /// API to behave as if those rows do not exist.
        /// </summary>
        /// <param name="callerId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListCallerMemoriesResponse> ListMemoriesAsync(
            string callerId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Memories For Caller<br/>
        /// List one page of memories belonging to the caller, newest first.<br/>
        /// Soft-deleted memories AND memories whose parent caller is<br/>
        /// soft-deleted are hidden — the GDPR purge semantics require the<br/>
        /// API to behave as if those rows do not exist.
        /// </summary>
        /// <param name="callerId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListCallerMemoriesResponse>> ListMemoriesAsResponseAsync(
            string callerId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}