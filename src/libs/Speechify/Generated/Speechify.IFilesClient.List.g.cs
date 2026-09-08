#nullable enable

namespace Speechify
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List Files<br/>
        /// List the workspace's live files, newest first. A file that has passed<br/>
        /// its `expires_at` is gone from this list and from every read.<br/>
        /// Cursor-paginated; walk pages while `has_more` is true.<br/>
        /// Dark launch: requires the `durable_runs_access` entitlement (402 `durable_runs_not_in_plan` otherwise).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="userIdentity"></param>
        /// <param name="kind"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListFilesResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            string? projectId = default,
            string? userIdentity = default,
            global::Speechify.V1FilesGetParametersKind? kind = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Files<br/>
        /// List the workspace's live files, newest first. A file that has passed<br/>
        /// its `expires_at` is gone from this list and from every read.<br/>
        /// Cursor-paginated; walk pages while `has_more` is true.<br/>
        /// Dark launch: requires the `durable_runs_access` entitlement (402 `durable_runs_not_in_plan` otherwise).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="userIdentity"></param>
        /// <param name="kind"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListFilesResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? projectId = default,
            string? userIdentity = default,
            global::Speechify.V1FilesGetParametersKind? kind = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}