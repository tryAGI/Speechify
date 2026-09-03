#nullable enable

namespace Speechify
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Submit Agent Run Approval<br/>
        /// Resolve a run that is durably waiting for human approval (status<br/>
        /// `requires_action`). Read the run's `pending_action` first - it describes,<br/>
        /// verbatim, the exact action awaiting approval and the effect of each<br/>
        /// disposition. `approve` resumes the run to execute the action; `deny`<br/>
        /// resumes it down its could-not-complete path. Because the wait is durable,<br/>
        /// a run resumes even across a deploy.<br/>
        /// Idempotent via `Idempotency-Key`: a retry replays the first decision<br/>
        /// rather than re-deciding. If nobody responds before the pending action's<br/>
        /// `expires_at`, the run applies its `default_decision` (deny, for a<br/>
        /// consequential action).<br/>
        /// Returns `409 agent_run_not_pending` if the run is not awaiting approval,<br/>
        /// and `409 agent_run_action_stale` if `action_key` no longer matches the<br/>
        /// run's current pending action.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="runId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentRun> SubmitRunAsync(
            string agentId,
            string runId,

            global::Speechify.SubmitAgentRunRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Agent Run Approval<br/>
        /// Resolve a run that is durably waiting for human approval (status<br/>
        /// `requires_action`). Read the run's `pending_action` first - it describes,<br/>
        /// verbatim, the exact action awaiting approval and the effect of each<br/>
        /// disposition. `approve` resumes the run to execute the action; `deny`<br/>
        /// resumes it down its could-not-complete path. Because the wait is durable,<br/>
        /// a run resumes even across a deploy.<br/>
        /// Idempotent via `Idempotency-Key`: a retry replays the first decision<br/>
        /// rather than re-deciding. If nobody responds before the pending action's<br/>
        /// `expires_at`, the run applies its `default_decision` (deny, for a<br/>
        /// consequential action).<br/>
        /// Returns `409 agent_run_not_pending` if the run is not awaiting approval,<br/>
        /// and `409 agent_run_action_stale` if `action_key` no longer matches the<br/>
        /// run's current pending action.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="runId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentRun>> SubmitRunAsResponseAsync(
            string agentId,
            string runId,

            global::Speechify.SubmitAgentRunRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Agent Run Approval<br/>
        /// Resolve a run that is durably waiting for human approval (status<br/>
        /// `requires_action`). Read the run's `pending_action` first - it describes,<br/>
        /// verbatim, the exact action awaiting approval and the effect of each<br/>
        /// disposition. `approve` resumes the run to execute the action; `deny`<br/>
        /// resumes it down its could-not-complete path. Because the wait is durable,<br/>
        /// a run resumes even across a deploy.<br/>
        /// Idempotent via `Idempotency-Key`: a retry replays the first decision<br/>
        /// rather than re-deciding. If nobody responds before the pending action's<br/>
        /// `expires_at`, the run applies its `default_decision` (deny, for a<br/>
        /// consequential action).<br/>
        /// Returns `409 agent_run_not_pending` if the run is not awaiting approval,<br/>
        /// and `409 agent_run_action_stale` if `action_key` no longer matches the<br/>
        /// run's current pending action.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="runId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="decision">
        /// The approval disposition. `approve` resumes the run to execute the pending action; `deny` resumes it down its could-not-complete path.
        /// </param>
        /// <param name="actionKey">
        /// The pending action being decided (the run's `pending_action.key`). Required, so a decision always targets the specific action the human saw: it guards against resolving a stale action - a `409 agent_run_action_stale` if it no longer matches the run's current pending action.
        /// </param>
        /// <param name="note">
        /// Optional free-text rationale recorded on the immutable approval audit entry.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentRun> SubmitRunAsync(
            string agentId,
            string runId,
            global::Speechify.SubmitAgentRunRequestDecision decision,
            string actionKey,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? note = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}