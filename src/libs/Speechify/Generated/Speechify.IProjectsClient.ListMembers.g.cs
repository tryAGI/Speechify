#nullable enable

namespace Speechify
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List Project Members<br/>
        /// List the workspace members granted access to this project, oldest<br/>
        /// grant first. Paginate by passing `cursor` from the previous response.<br/>
        /// A member with no grants anywhere is workspace-wide and does not appear<br/>
        /// here: this lists people who have been narrowed to specific projects,<br/>
        /// not everyone who can reach this one.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ProjectMembersResponse> ListMembersAsync(
            string projectId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Project Members<br/>
        /// List the workspace members granted access to this project, oldest<br/>
        /// grant first. Paginate by passing `cursor` from the previous response.<br/>
        /// A member with no grants anywhere is workspace-wide and does not appear<br/>
        /// here: this lists people who have been narrowed to specific projects,<br/>
        /// not everyone who can reach this one.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ProjectMembersResponse>> ListMembersAsResponseAsync(
            string projectId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}