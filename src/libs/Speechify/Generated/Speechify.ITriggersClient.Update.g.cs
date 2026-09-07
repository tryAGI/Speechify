#nullable enable

namespace Speechify
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Update Agent Trigger<br/>
        /// Update a trigger. Merge-patch semantics: an omitted field is left<br/>
        /// unchanged. `type` is immutable. Changing a schedule's cadence or<br/>
        /// `enabled` reschedules its next fire.<br/>
        /// A field this endpoint does not define is refused with `400<br/>
        /// validation_failed` naming every unknown field, rather than accepted<br/>
        /// and silently dropped.<br/>
        /// Keys inside `run.variables` and `run.metadata`, and the contents of<br/>
        /// `run.output_schema`, are your own data rather than field names, and<br/>
        /// are never refused.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="triggerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTrigger> UpdateAsync(
            string agentId,
            string triggerId,

            global::Speechify.UpdateAgentTriggerRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Trigger<br/>
        /// Update a trigger. Merge-patch semantics: an omitted field is left<br/>
        /// unchanged. `type` is immutable. Changing a schedule's cadence or<br/>
        /// `enabled` reschedules its next fire.<br/>
        /// A field this endpoint does not define is refused with `400<br/>
        /// validation_failed` naming every unknown field, rather than accepted<br/>
        /// and silently dropped.<br/>
        /// Keys inside `run.variables` and `run.metadata`, and the contents of<br/>
        /// `run.output_schema`, are your own data rather than field names, and<br/>
        /// are never refused.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="triggerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTrigger>> UpdateAsResponseAsync(
            string agentId,
            string triggerId,

            global::Speechify.UpdateAgentTriggerRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Trigger<br/>
        /// Update a trigger. Merge-patch semantics: an omitted field is left<br/>
        /// unchanged. `type` is immutable. Changing a schedule's cadence or<br/>
        /// `enabled` reschedules its next fire.<br/>
        /// A field this endpoint does not define is refused with `400<br/>
        /// validation_failed` naming every unknown field, rather than accepted<br/>
        /// and silently dropped.<br/>
        /// Keys inside `run.variables` and `run.metadata`, and the contents of<br/>
        /// `run.output_schema`, are your own data rather than field names, and<br/>
        /// are never refused.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="triggerId"></param>
        /// <param name="speechifyVersion"></param>
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
        global::System.Threading.Tasks.Task<global::Speechify.AgentTrigger> UpdateAsync(
            string agentId,
            string triggerId,
            string? speechifyVersion = default,
            string? name = default,
            bool? enabled = default,
            global::Speechify.TriggerRunSpec? run = default,
            global::Speechify.TriggerScheduleConfig? schedule = default,
            global::Speechify.TriggerWebhookConfig? webhook = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}