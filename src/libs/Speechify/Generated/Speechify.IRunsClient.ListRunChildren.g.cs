#nullable enable

namespace Speechify
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// List Agent Run Children<br/>
        /// List the runs this run **delegated to**, newest first. When a run hands a<br/>
        /// sub-goal to another agent (a team member), the sub-goal executes as its own<br/>
        /// bounded child run with its own status, output, and `usage` - so a run's true<br/>
        /// cost is its own usage plus its children's.<br/>
        /// Each child runs under the MEMBER's agent, not this one, so children never<br/>
        /// appear in this agent's `listRuns`. This is the downward half of lineage; the<br/>
        /// upward half is `parent_run_id` on the run object. A run that delegated<br/>
        /// nothing returns an empty list.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="runId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListAgentRunsResponse> ListRunChildrenAsync(
            string agentId,
            string runId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Run Children<br/>
        /// List the runs this run **delegated to**, newest first. When a run hands a<br/>
        /// sub-goal to another agent (a team member), the sub-goal executes as its own<br/>
        /// bounded child run with its own status, output, and `usage` - so a run's true<br/>
        /// cost is its own usage plus its children's.<br/>
        /// Each child runs under the MEMBER's agent, not this one, so children never<br/>
        /// appear in this agent's `listRuns`. This is the downward half of lineage; the<br/>
        /// upward half is `parent_run_id` on the run object. A run that delegated<br/>
        /// nothing returns an empty list.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="runId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListAgentRunsResponse>> ListRunChildrenAsResponseAsync(
            string agentId,
            string runId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}