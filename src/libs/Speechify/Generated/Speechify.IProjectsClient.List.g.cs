#nullable enable

namespace Speechify
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List Projects<br/>
        /// List the workspace's projects, newest first. The implicit Default<br/>
        /// project is not a row and is never listed; resources with no<br/>
        /// `project_id` live in it. Archived projects are hidden unless<br/>
        /// `include_archived=true`, and purged ones unless<br/>
        /// `include_purged=true`. Cursor-paginated: omit `cursor` for the<br/>
        /// first page; walk pages while `has_more` is true (default page size<br/>
        /// 50, max 200).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="includeArchived">
        /// Default Value: false
        /// </param>
        /// <param name="includePurged">
        /// Default Value: false
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListProjectsResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            bool? includeArchived = default,
            bool? includePurged = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Projects<br/>
        /// List the workspace's projects, newest first. The implicit Default<br/>
        /// project is not a row and is never listed; resources with no<br/>
        /// `project_id` live in it. Archived projects are hidden unless<br/>
        /// `include_archived=true`, and purged ones unless<br/>
        /// `include_purged=true`. Cursor-paginated: omit `cursor` for the<br/>
        /// first page; walk pages while `has_more` is true (default page size<br/>
        /// 50, max 200).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="includeArchived">
        /// Default Value: false
        /// </param>
        /// <param name="includePurged">
        /// Default Value: false
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListProjectsResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            bool? includeArchived = default,
            bool? includePurged = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}