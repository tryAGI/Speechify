#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentDashboardsClient
    {
        /// <summary>
        /// List dashboards<br/>
        /// The caller's workspace's saved analytics dashboards. Dashboards are<br/>
        /// shared across the workspace. Returns the full set in a single<br/>
        /// response: bounded by the workspace's saved dashboards (hard-capped<br/>
        /// at 10), so this list is intentionally not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListDashboardsResponse> ListAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List dashboards<br/>
        /// The caller's workspace's saved analytics dashboards. Dashboards are<br/>
        /// shared across the workspace. Returns the full set in a single<br/>
        /// response: bounded by the workspace's saved dashboards (hard-capped<br/>
        /// at 10), so this list is intentionally not paginated.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListDashboardsResponse>> ListAsResponseAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}