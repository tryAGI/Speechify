#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentDashboardsClient
    {
        /// <summary>
        /// Create dashboard<br/>
        /// Create a saved dashboard. Each widget carries a chart type, a grid<br/>
        /// position, and an analytics query spec validated against the<br/>
        /// dimension registry. Limited to 10 dashboards per workspace.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Dashboard> CreateAsync(

            global::Speechify.CreateDashboardRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dashboard<br/>
        /// Create a saved dashboard. Each widget carries a chart type, a grid<br/>
        /// position, and an analytics query spec validated against the<br/>
        /// dimension registry. Limited to 10 dashboards per workspace.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Dashboard>> CreateAsResponseAsync(

            global::Speechify.CreateDashboardRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dashboard<br/>
        /// Create a saved dashboard. Each widget carries a chart type, a grid<br/>
        /// position, and an analytics query spec validated against the<br/>
        /// dimension registry. Limited to 10 dashboards per workspace.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="layout"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Dashboard> CreateAsync(
            string name,
            global::Speechify.DashboardLayout layout,
            string? speechifyVersion = default,
            string? description = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}