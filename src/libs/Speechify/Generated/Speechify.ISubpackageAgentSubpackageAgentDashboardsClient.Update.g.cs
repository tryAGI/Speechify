#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentDashboardsClient
    {
        /// <summary>
        /// Update dashboard<br/>
        /// Partial update; omitted fields are left unchanged.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Dashboard> UpdateAsync(
            string dashboardId,

            global::Speechify.UpdateDashboardRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update dashboard<br/>
        /// Partial update; omitted fields are left unchanged.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Dashboard>> UpdateAsResponseAsync(
            string dashboardId,

            global::Speechify.UpdateDashboardRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update dashboard<br/>
        /// Partial update; omitted fields are left unchanged.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="layout"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Dashboard> UpdateAsync(
            string dashboardId,
            string? speechifyVersion = default,
            string? name = default,
            string? description = default,
            global::Speechify.DashboardLayout? layout = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}