#nullable enable

namespace Speechify
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Create Agent Trigger<br/>
        /// Create a trigger that starts a durable run of a task agent. A<br/>
        /// `schedule` trigger fires on a cron expression or an interval; a<br/>
        /// `webhook` trigger returns a one-time `secret` plus a `fire_path` your<br/>
        /// backend POSTs to. Idempotent via `Idempotency-Key`.
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
        global::System.Threading.Tasks.Task<global::Speechify.AgentTrigger> CreateAsync(
            string agentId,

            global::Speechify.CreateAgentTriggerRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Trigger<br/>
        /// Create a trigger that starts a durable run of a task agent. A<br/>
        /// `schedule` trigger fires on a cron expression or an interval; a<br/>
        /// `webhook` trigger returns a one-time `secret` plus a `fire_path` your<br/>
        /// backend POSTs to. Idempotent via `Idempotency-Key`.
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTrigger>> CreateAsResponseAsync(
            string agentId,

            global::Speechify.CreateAgentTriggerRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Trigger<br/>
        /// Create a trigger that starts a durable run of a task agent. A<br/>
        /// `schedule` trigger fires on a cron expression or an interval; a<br/>
        /// `webhook` trigger returns a one-time `secret` plus a `fire_path` your<br/>
        /// backend POSTs to. Idempotent via `Idempotency-Key`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="enabled"></param>
        /// <param name="run">
        /// The durable run a trigger starts when it fires.
        /// </param>
        /// <param name="schedule">
        /// The cadence of a schedule trigger. Set exactly one of `cron` or<br/>
        /// `interval_seconds`.
        /// </param>
        /// <param name="webhook">
        /// The inbound-fire config of a webhook trigger.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTrigger> CreateAsync(
            string agentId,
            global::Speechify.CreateAgentTriggerRequestType type,
            string name,
            global::Speechify.TriggerRunSpec run,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            bool? enabled = default,
            global::Speechify.TriggerScheduleConfig? schedule = default,
            global::Speechify.TriggerWebhookConfig? webhook = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}