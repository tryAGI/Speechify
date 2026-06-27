#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentDashboardsClient
    {
        /// <summary>
        /// List dashboards<br/>
        /// The caller's workspace's saved analytics dashboards. Dashboards are<br/>
        /// shared across the workspace. Cursor-paginated: omit `cursor` for the<br/>
        /// first page; walk pages while `has_more` is true (default page size 50,<br/>
        /// max 200).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListDashboardsResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List dashboards<br/>
        /// The caller's workspace's saved analytics dashboards. Dashboards are<br/>
        /// shared across the workspace. Cursor-paginated: omit `cursor` for the<br/>
        /// first page; walk pages while `has_more` is true (default page size 50,<br/>
        /// max 200).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListDashboardsResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}