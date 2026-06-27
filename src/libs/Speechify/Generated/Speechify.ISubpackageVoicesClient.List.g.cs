#nullable enable

namespace Speechify
{
    public partial interface ISubpackageVoicesClient
    {
        /// <summary>
        /// List Voices<br/>
        /// Lists the voices available to the caller - the shared voice<br/>
        /// catalog plus the workspace's personal cloned voices. By default<br/>
        /// the full catalogue is returned in one response. Pagination is<br/>
        /// opt-in: pass `limit` (and then `cursor` from the previous<br/>
        /// response) to page through the list while `has_more` is true. Max<br/>
        /// page size is 200.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListVoicesResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Voices<br/>
        /// Lists the voices available to the caller - the shared voice<br/>
        /// catalog plus the workspace's personal cloned voices. By default<br/>
        /// the full catalogue is returned in one response. Pagination is<br/>
        /// opt-in: pass `limit` (and then `cursor` from the previous<br/>
        /// response) to page through the list while `has_more` is true. Max<br/>
        /// page size is 200.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListVoicesResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}