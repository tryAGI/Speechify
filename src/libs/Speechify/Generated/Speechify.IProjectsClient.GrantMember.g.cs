#nullable enable

namespace Speechify
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Grant Project Access<br/>
        /// Grant a workspace member access to this project. Once a member holds<br/>
        /// any grant, they see and touch only the projects they have been granted.<br/>
        /// Requires `members.manage_project_scope` (owner or admin). An owner or<br/>
        /// billing admin cannot be scoped: both already hold workspace-wide access<br/>
        /// that a project scope would contradict without restricting anything.<br/>
        /// Idempotent: granting a project the member already holds is a no-op.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GrantMemberAsync(
            string projectId,

            global::Speechify.GrantProjectMemberRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Grant Project Access<br/>
        /// Grant a workspace member access to this project. Once a member holds<br/>
        /// any grant, they see and touch only the projects they have been granted.<br/>
        /// Requires `members.manage_project_scope` (owner or admin). An owner or<br/>
        /// billing admin cannot be scoped: both already hold workspace-wide access<br/>
        /// that a project scope would contradict without restricting anything.<br/>
        /// Idempotent: granting a project the member already holds is a no-op.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> GrantMemberAsResponseAsync(
            string projectId,

            global::Speechify.GrantProjectMemberRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Grant Project Access<br/>
        /// Grant a workspace member access to this project. Once a member holds<br/>
        /// any grant, they see and touch only the projects they have been granted.<br/>
        /// Requires `members.manage_project_scope` (owner or admin). An owner or<br/>
        /// billing admin cannot be scoped: both already hold workspace-wide access<br/>
        /// that a project scope would contradict without restricting anything.<br/>
        /// Idempotent: granting a project the member already holds is a no-op.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="userId">
        /// The prefixed user id of the workspace member to grant.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GrantMemberAsync(
            string projectId,
            string userId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}