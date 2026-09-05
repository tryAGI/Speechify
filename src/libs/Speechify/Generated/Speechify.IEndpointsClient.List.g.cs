#nullable enable

namespace Speechify
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// List webhook endpoints<br/>
        /// The caller's workspace's registered webhook endpoints. Cursor-paginated:<br/>
        /// omit `cursor` for the first page; walk pages while `has_more` is true<br/>
        /// (default page size 50, max 200). The signing `secret` is never returned<br/>
        /// here — it is shown only when an endpoint is created or its secret is<br/>
        /// rotated. Filter by delivery scope with `project_id`.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListWebhookEndpointsResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List webhook endpoints<br/>
        /// The caller's workspace's registered webhook endpoints. Cursor-paginated:<br/>
        /// omit `cursor` for the first page; walk pages while `has_more` is true<br/>
        /// (default page size 50, max 200). The signing `secret` is never returned<br/>
        /// here — it is shown only when an endpoint is created or its secret is<br/>
        /// rotated. Filter by delivery scope with `project_id`.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListWebhookEndpointsResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}