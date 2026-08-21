#nullable enable

namespace Speechify
{
    public partial interface ICallersClient
    {
        /// <summary>
        /// List Callers<br/>
        /// List the workspace's callers, ordered by most-recently-seen first.<br/>
        /// A caller is the per-(tenant, agent, identity) entity that owns<br/>
        /// long-term memories and conversation history.<br/>
        /// `project_id` matches the project the caller was FIRST SEEN under,<br/>
        /// frozen at that moment. Moving an agent to another project therefore<br/>
        /// leaves the callers it already knows attributed where they were met.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="q"></param>
        /// <param name="lastSeenAfter"></param>
        /// <param name="projectId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListCallersResponse> ListAsync(
            string? agentId = default,
            string? q = default,
            global::System.DateTime? lastSeenAfter = default,
            string? projectId = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Callers<br/>
        /// List the workspace's callers, ordered by most-recently-seen first.<br/>
        /// A caller is the per-(tenant, agent, identity) entity that owns<br/>
        /// long-term memories and conversation history.<br/>
        /// `project_id` matches the project the caller was FIRST SEEN under,<br/>
        /// frozen at that moment. Moving an agent to another project therefore<br/>
        /// leaves the callers it already knows attributed where they were met.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="q"></param>
        /// <param name="lastSeenAfter"></param>
        /// <param name="projectId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListCallersResponse>> ListAsResponseAsync(
            string? agentId = default,
            string? q = default,
            global::System.DateTime? lastSeenAfter = default,
            string? projectId = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}