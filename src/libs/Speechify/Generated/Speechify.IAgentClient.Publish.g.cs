#nullable enable

namespace Speechify
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Publish Agent For Runs<br/>
        /// Publish an agent's current configuration for durable runs.<br/>
        /// The configuration a run executes is live as soon as it is written, so<br/>
        /// this promotes nothing. What a publish does is submit the configuration<br/>
        /// to the workspace's publish gates and record the decision against a<br/>
        /// fingerprint of that configuration. On a gated workspace a run will only<br/>
        /// start against a configuration that carries a passing (or overridden)<br/>
        /// decision, so this is the step that makes an agent runnable after it is<br/>
        /// created or edited.<br/>
        /// Any agent publishes here. The conversations it answers are versioned<br/>
        /// separately, by promoting a flow version via<br/>
        /// `/v1/agents/{agent_id}/flow/publish`.<br/>
        /// On an ungated workspace this succeeds and returns no `gate` object.<br/>
        /// This endpoint is in beta: the gate runs only on workspaces granted<br/>
        /// `publish_eval_gate`, and the runs a publish authorises need<br/>
        /// `durable_runs_access` (the run endpoints answer<br/>
        /// `402 durable_runs_not_in_plan` without it).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PublishAgentResponse> PublishAsync(
            string agentId,

            global::Speechify.PublishAgentRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish Agent For Runs<br/>
        /// Publish an agent's current configuration for durable runs.<br/>
        /// The configuration a run executes is live as soon as it is written, so<br/>
        /// this promotes nothing. What a publish does is submit the configuration<br/>
        /// to the workspace's publish gates and record the decision against a<br/>
        /// fingerprint of that configuration. On a gated workspace a run will only<br/>
        /// start against a configuration that carries a passing (or overridden)<br/>
        /// decision, so this is the step that makes an agent runnable after it is<br/>
        /// created or edited.<br/>
        /// Any agent publishes here. The conversations it answers are versioned<br/>
        /// separately, by promoting a flow version via<br/>
        /// `/v1/agents/{agent_id}/flow/publish`.<br/>
        /// On an ungated workspace this succeeds and returns no `gate` object.<br/>
        /// This endpoint is in beta: the gate runs only on workspaces granted<br/>
        /// `publish_eval_gate`, and the runs a publish authorises need<br/>
        /// `durable_runs_access` (the run endpoints answer<br/>
        /// `402 durable_runs_not_in_plan` without it).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.PublishAgentResponse>> PublishAsResponseAsync(
            string agentId,

            global::Speechify.PublishAgentRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish Agent For Runs<br/>
        /// Publish an agent's current configuration for durable runs.<br/>
        /// The configuration a run executes is live as soon as it is written, so<br/>
        /// this promotes nothing. What a publish does is submit the configuration<br/>
        /// to the workspace's publish gates and record the decision against a<br/>
        /// fingerprint of that configuration. On a gated workspace a run will only<br/>
        /// start against a configuration that carries a passing (or overridden)<br/>
        /// decision, so this is the step that makes an agent runnable after it is<br/>
        /// created or edited.<br/>
        /// Any agent publishes here. The conversations it answers are versioned<br/>
        /// separately, by promoting a flow version via<br/>
        /// `/v1/agents/{agent_id}/flow/publish`.<br/>
        /// On an ungated workspace this succeeds and returns no `gate` object.<br/>
        /// This endpoint is in beta: the gate runs only on workspaces granted<br/>
        /// `publish_eval_gate`, and the runs a publish authorises need<br/>
        /// `durable_runs_access` (the run endpoints answer<br/>
        /// `402 durable_runs_not_in_plan` without it).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="gateOverrideReason">
        /// On a gated workspace, a non-empty justification publishes past failing<br/>
        /// checks. The suite still runs and its verdict is recorded with this<br/>
        /// reason - an override bypasses blocking, not measurement. Must be at<br/>
        /// least 10 characters after trimming.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.PublishAgentResponse> PublishAsync(
            string agentId,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? gateOverrideReason = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}