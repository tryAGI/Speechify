#nullable enable

namespace Speechify
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Get Run<br/>
        /// Get a run by its id alone, when that is all you hold: the run id<br/>
        /// arrives on its own in the `Speechify-Idempotency-Key` an MCP<br/>
        /// connector receives (`&lt;run_id&gt;:&lt;step&gt;`), in the `Idempotency-Key` a<br/>
        /// webhook tool receives, and on every `run.*` webhook event. The<br/>
        /// response is the same run object `getRun` returns, `agent_id`<br/>
        /// included, so one call resolves the agent and the run together.<br/>
        /// Scoped to your workspace and to the projects your key can reach; a<br/>
        /// run outside either is a 404.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentRun> GetAsync(
            string runId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Run<br/>
        /// Get a run by its id alone, when that is all you hold: the run id<br/>
        /// arrives on its own in the `Speechify-Idempotency-Key` an MCP<br/>
        /// connector receives (`&lt;run_id&gt;:&lt;step&gt;`), in the `Idempotency-Key` a<br/>
        /// webhook tool receives, and on every `run.*` webhook event. The<br/>
        /// response is the same run object `getRun` returns, `agent_id`<br/>
        /// included, so one call resolves the agent and the run together.<br/>
        /// Scoped to your workspace and to the projects your key can reach; a<br/>
        /// run outside either is a 404.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentRun>> GetAsResponseAsync(
            string runId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}