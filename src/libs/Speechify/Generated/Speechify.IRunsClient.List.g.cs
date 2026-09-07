#nullable enable

namespace Speechify
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// List Runs<br/>
        /// List runs across the whole workspace, newest first, optionally narrowed<br/>
        /// to one `status`.<br/>
        /// Use this rather than listing per agent when you want to know what is<br/>
        /// happening overall, and above all what is waiting on a person: pass<br/>
        /// `?status=requires_action`. Listing per agent cannot answer that<br/>
        /// question completely, because a run delegated to a team member executes<br/>
        /// under that member's agent - so an approval that blocks the team's work<br/>
        /// appears under an agent you would not think to open.<br/>
        /// Respects `?project_id` like every other workspace-wide list, and<br/>
        /// `?agent_id` narrows it to one agent's runs.<br/>
        /// The filters are exactly the ones listed here. A query parameter this<br/>
        /// list does not accept is a 400 naming it, never silently ignored: a<br/>
        /// filter that is accepted and dropped returns the wrong runs with a 200.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="userIdentity"></param>
        /// <param name="agentId"></param>
        /// <param name="projectId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListAgentRunsResponse> ListAsync(
            global::Speechify.V1AgentsRunsGetParametersStatus? status = default,
            string? userIdentity = default,
            string? agentId = default,
            string? projectId = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Runs<br/>
        /// List runs across the whole workspace, newest first, optionally narrowed<br/>
        /// to one `status`.<br/>
        /// Use this rather than listing per agent when you want to know what is<br/>
        /// happening overall, and above all what is waiting on a person: pass<br/>
        /// `?status=requires_action`. Listing per agent cannot answer that<br/>
        /// question completely, because a run delegated to a team member executes<br/>
        /// under that member's agent - so an approval that blocks the team's work<br/>
        /// appears under an agent you would not think to open.<br/>
        /// Respects `?project_id` like every other workspace-wide list, and<br/>
        /// `?agent_id` narrows it to one agent's runs.<br/>
        /// The filters are exactly the ones listed here. A query parameter this<br/>
        /// list does not accept is a 400 naming it, never silently ignored: a<br/>
        /// filter that is accepted and dropped returns the wrong runs with a 200.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="userIdentity"></param>
        /// <param name="agentId"></param>
        /// <param name="projectId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListAgentRunsResponse>> ListAsResponseAsync(
            global::Speechify.V1AgentsRunsGetParametersStatus? status = default,
            string? userIdentity = default,
            string? agentId = default,
            string? projectId = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}