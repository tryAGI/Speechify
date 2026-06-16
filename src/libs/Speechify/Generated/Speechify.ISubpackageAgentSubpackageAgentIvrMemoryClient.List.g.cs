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
        /// the top. Capped at 200 rows.
        /// </summary>
        /// <param name="fingerprint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListIVRMenusResponse> ListAsync(
            string? fingerprint = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List IVR Menus<br/>
        /// List the active IVR menus the caller's workspace has learned.<br/>
        /// One row per (fingerprint, tenant).<br/>
        /// Invalidated rows and the cross-tenant shared slot are excluded.<br/>
        /// Sorted by `last_observed_at` DESC so the freshest IVRs land at<br/>
        /// the top. Capped at 200 rows.
        /// </summary>
        /// <param name="fingerprint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListIVRMenusResponse>> ListAsResponseAsync(
            string? fingerprint = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}