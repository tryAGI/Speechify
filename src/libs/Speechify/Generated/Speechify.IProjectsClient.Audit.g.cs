#nullable enable

namespace Speechify
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Project Audit Trail<br/>
        /// Who changed this project's access or its lifecycle state, and when.<br/>
        /// Newest first. Covers the last 90 days; paginate by passing `cursor`<br/>
        /// from the previous response.<br/>
        /// Each entry names the SUBJECT (whose access changed) and the ACTOR (who<br/>
        /// changed it), with the role the actor held at the time. When a change<br/>
        /// was made by Speechify support acting on the workspace's behalf, the<br/>
        /// entry also carries that admin's email, so a support-initiated change<br/>
        /// never reads as one a colleague made.<br/>
        /// Requires `members.manage_project_scope` (owner or admin): who widened<br/>
        /// a member's access is a stronger fact than who currently holds it.<br/>
        /// Returns 404 for missing or foreign-workspace projects.
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
        global::System.Threading.Tasks.Task<global::Speechify.ProjectAuditResponse> AuditAsync(
            string projectId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Project Audit Trail<br/>
        /// Who changed this project's access or its lifecycle state, and when.<br/>
        /// Newest first. Covers the last 90 days; paginate by passing `cursor`<br/>
        /// from the previous response.<br/>
        /// Each entry names the SUBJECT (whose access changed) and the ACTOR (who<br/>
        /// changed it), with the role the actor held at the time. When a change<br/>
        /// was made by Speechify support acting on the workspace's behalf, the<br/>
        /// entry also carries that admin's email, so a support-initiated change<br/>
        /// never reads as one a colleague made.<br/>
        /// Requires `members.manage_project_scope` (owner or admin): who widened<br/>
        /// a member's access is a stronger fact than who currently holds it.<br/>
        /// Returns 404 for missing or foreign-workspace projects.
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ProjectAuditResponse>> AuditAsResponseAsync(
            string projectId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}