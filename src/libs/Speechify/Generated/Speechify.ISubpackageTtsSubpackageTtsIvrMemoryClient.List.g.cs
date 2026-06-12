#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsIvrMemoryClient
    {
        /// <summary>
        /// List IVR Menus<br/>
        /// List the active IVR menus the caller's workspace has learned<br/>
        /// (AIS-3267 Phase 2/1.6/3). One row per (fingerprint, tenant).<br/>
        /// Invalidated rows and the cross-tenant shared slot are excluded.<br/>
        /// Sorted by `last_observed_at` DESC so the freshest IVRs land at<br/>
        /// the top. Capped at 200 rows.<br/>
        /// See `docs/adrs/0009-ivr-memory-consume-and-invalidate.md` for the<br/>
        /// memorization design.
        /// </summary>
        /// <param name="fingerprint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsListIVRMenusResponse> ListAsync(
            string? fingerprint = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List IVR Menus<br/>
        /// List the active IVR menus the caller's workspace has learned<br/>
        /// (AIS-3267 Phase 2/1.6/3). One row per (fingerprint, tenant).<br/>
        /// Invalidated rows and the cross-tenant shared slot are excluded.<br/>
        /// Sorted by `last_observed_at` DESC so the freshest IVRs land at<br/>
        /// the top. Capped at 200 rows.<br/>
        /// See `docs/adrs/0009-ivr-memory-consume-and-invalidate.md` for the<br/>
        /// memorization design.
        /// </summary>
        /// <param name="fingerprint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsListIVRMenusResponse>> ListAsResponseAsync(
            string? fingerprint = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}