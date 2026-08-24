#nullable enable

namespace Speechify
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Revoke Project Access<br/>
        /// Remove a member's access to this project.<br/>
        /// A member who loses their last grant is not locked out - they return<br/>
        /// to workspace-wide access, because holding no grants is the unrestricted<br/>
        /// state. To restrict someone, grant them the projects they should keep<br/>
        /// rather than revoking everything. Requires `members.manage_project_scope`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RevokeMemberAsync(
            string projectId,
            string userId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke Project Access<br/>
        /// Remove a member's access to this project.<br/>
        /// A member who loses their last grant is not locked out - they return<br/>
        /// to workspace-wide access, because holding no grants is the unrestricted<br/>
        /// state. To restrict someone, grant them the projects they should keep<br/>
        /// rather than revoking everything. Requires `members.manage_project_scope`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> RevokeMemberAsResponseAsync(
            string projectId,
            string userId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}