#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentIvrMemoryClient
    {
        /// <summary>
        /// List IVR Menus<br/>
        /// List the active IVR menus the caller's workspace has learned.<br/>
        /// One row per (fingerprint, tenant).<br/>
        /// Invalidated rows and the cross-tenant shared slot are excluded.<br/>
        /// Sorted by `last_observed_at` DESC so the freshest IVRs land at<br/>
        /// the top. Cursor-paginated: omit `cursor` to fetch the first<br/>
        /// page. Default page size is 50 and max is 200. Walk pages while<br/>
        /// `has_more` is true.
        /// </summary>
        /// <param name="fingerprint"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListIVRMenusResponse> ListAsync(
            string? fingerprint = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List IVR Menus<br/>
        /// List the active IVR menus the caller's workspace has learned.<br/>
        /// One row per (fingerprint, tenant).<br/>
        /// Invalidated rows and the cross-tenant shared slot are excluded.<br/>
        /// Sorted by `last_observed_at` DESC so the freshest IVRs land at<br/>
        /// the top. Cursor-paginated: omit `cursor` to fetch the first<br/>
        /// page. Default page size is 50 and max is 200. Walk pages while<br/>
        /// `has_more` is true.
        /// </summary>
        /// <param name="fingerprint"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListIVRMenusResponse>> ListAsResponseAsync(
            string? fingerprint = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}