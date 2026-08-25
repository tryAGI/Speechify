#nullable enable

namespace Speechify
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update Project<br/>
        /// Edit a project in place - its name, its monthly spend limit, or its<br/>
        /// capacity ceilings - keeping the same id so every grouped resource<br/>
        /// follows the edit with no re-pointing. Names are unique per<br/>
        /// workspace (case-insensitive). The limit fields require<br/>
        /// `billing.manage`; a capacity ceiling above the workspace's own is<br/>
        /// refused, since it could never apply.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Project> UpdateAsync(
            string projectId,

            global::Speechify.UpdateProjectRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Project<br/>
        /// Edit a project in place - its name, its monthly spend limit, or its<br/>
        /// capacity ceilings - keeping the same id so every grouped resource<br/>
        /// follows the edit with no re-pointing. Names are unique per<br/>
        /// workspace (case-insensitive). The limit fields require<br/>
        /// `billing.manage`; a capacity ceiling above the workspace's own is<br/>
        /// refused, since it could never apply.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Project>> UpdateAsResponseAsync(
            string projectId,

            global::Speechify.UpdateProjectRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Project<br/>
        /// Edit a project in place - its name, its monthly spend limit, or its<br/>
        /// capacity ceilings - keeping the same id so every grouped resource<br/>
        /// follows the edit with no re-pointing. Names are unique per<br/>
        /// workspace (case-insensitive). The limit fields require<br/>
        /// `billing.manage`; a capacity ceiling above the workspace's own is<br/>
        /// refused, since it could never apply.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="maxConcurrentCalls">
        /// Sets the project's active-call ceiling; `null` removes it.<br/>
        /// Must be a positive integer at or below the workspace's own<br/>
        /// active-call cap, otherwise the request is refused with<br/>
        /// `400 validation_failed` naming the field and the ceiling: a<br/>
        /// project can only narrow the workspace's capacity, never raise<br/>
        /// it. Requires the `billing.manage` permission, like the spend<br/>
        /// limit beside it. Takes effect on the next call start.
        /// </param>
        /// <param name="maxRequestsPerMinute">
        /// Sets the project's request-rate ceiling in requests per<br/>
        /// minute; `null` removes it. Must be a positive integer at or<br/>
        /// below the workspace's widest per-surface request rate over a<br/>
        /// minute, otherwise the request is refused with<br/>
        /// `400 validation_failed` naming the field and the ceiling.<br/>
        /// Requires the `billing.manage` permission. Takes effect on the<br/>
        /// next request from a credential pinned to the project.
        /// </param>
        /// <param name="name">
        /// New project name; unique per workspace (case-insensitive),<br/>
        /// surrounding whitespace is trimmed.
        /// </param>
        /// <param name="monthlyBudget">
        /// Edits the project's MONTHLY spend limit in US dollars: omit to<br/>
        /// leave it unchanged, send a positive value to set or change it, or<br/>
        /// an explicit `0` to remove it. Amounts are whole cents written as a<br/>
        /// plain decimal; a finer value, or exponent notation, is refused<br/>
        /// rather than rounded. Requires the<br/>
        /// `billing.manage`<br/>
        /// permission (owners/admins), like the workspace budget — a<br/>
        /// spend ceiling is a billing control, not a grouping edit. Once the<br/>
        /// project's billed spend within the current calendar month (UTC)<br/>
        /// reaches the limit, new billable work attributed to that project is<br/>
        /// refused with the coded `402 project_spend_limit_exceeded` until<br/>
        /// the month resets or the limit is raised.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Project> UpdateAsync(
            string projectId,
            string? speechifyVersion = default,
            int? maxConcurrentCalls = default,
            int? maxRequestsPerMinute = default,
            string? name = default,
            double? monthlyBudget = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}