#nullable enable

namespace Speechify
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Fire Agent Trigger<br/>
        /// Inbound fire URL for a webhook trigger. Authenticate with the trigger's<br/>
        /// one-time fire token as `Authorization: Bearer &lt;secret&gt;`. The JSON body<br/>
        /// becomes the started run's payload variable. Supply an `Idempotency-Key`<br/>
        /// (or `Speechify-Delivery-Id`) header to make a redelivery replay the<br/>
        /// original run instead of starting a second one.<br/>
        /// **Reacting to something that happened, for one person.** Set the<br/>
        /// trigger's `webhook.user_identity_source` to `fire` and send<br/>
        /// `Speechify-User-Identity` on each POST. The run then acts for that<br/>
        /// person - their memory, and every tool call told who it is for - so one<br/>
        /// trigger serves every person your connector watches and you hold no<br/>
        /// trigger id per person. Use the plain form (`user_identity_source:<br/>
        /// trigger`) when the work is the same whoever it is for: a nightly<br/>
        /// reconciliation, an alert fan-out, a build that finished.<br/>
        /// **Rate.** A trigger admits 60 fires a minute, and 12 a minute for any<br/>
        /// one person; past either the endpoint answers `429` with `Retry-After`.<br/>
        /// A fire starts a durable run against your credit balance, so a burst is<br/>
        /// deferred rather than fanned out. Retry the refused delivery under the<br/>
        /// same delivery id and it runs exactly once.
        /// </summary>
        /// <param name="triggerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="speechifyUserIdentity"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTriggerFireResponse> FireAsync(
            string triggerId,

            object request,
            string? speechifyVersion = default,
            string? speechifyUserIdentity = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fire Agent Trigger<br/>
        /// Inbound fire URL for a webhook trigger. Authenticate with the trigger's<br/>
        /// one-time fire token as `Authorization: Bearer &lt;secret&gt;`. The JSON body<br/>
        /// becomes the started run's payload variable. Supply an `Idempotency-Key`<br/>
        /// (or `Speechify-Delivery-Id`) header to make a redelivery replay the<br/>
        /// original run instead of starting a second one.<br/>
        /// **Reacting to something that happened, for one person.** Set the<br/>
        /// trigger's `webhook.user_identity_source` to `fire` and send<br/>
        /// `Speechify-User-Identity` on each POST. The run then acts for that<br/>
        /// person - their memory, and every tool call told who it is for - so one<br/>
        /// trigger serves every person your connector watches and you hold no<br/>
        /// trigger id per person. Use the plain form (`user_identity_source:<br/>
        /// trigger`) when the work is the same whoever it is for: a nightly<br/>
        /// reconciliation, an alert fan-out, a build that finished.<br/>
        /// **Rate.** A trigger admits 60 fires a minute, and 12 a minute for any<br/>
        /// one person; past either the endpoint answers `429` with `Retry-After`.<br/>
        /// A fire starts a durable run against your credit balance, so a burst is<br/>
        /// deferred rather than fanned out. Retry the refused delivery under the<br/>
        /// same delivery id and it runs exactly once.
        /// </summary>
        /// <param name="triggerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="speechifyUserIdentity"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTriggerFireResponse>> FireAsResponseAsync(
            string triggerId,

            object request,
            string? speechifyVersion = default,
            string? speechifyUserIdentity = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fire Agent Trigger<br/>
        /// Inbound fire URL for a webhook trigger. Authenticate with the trigger's<br/>
        /// one-time fire token as `Authorization: Bearer &lt;secret&gt;`. The JSON body<br/>
        /// becomes the started run's payload variable. Supply an `Idempotency-Key`<br/>
        /// (or `Speechify-Delivery-Id`) header to make a redelivery replay the<br/>
        /// original run instead of starting a second one.<br/>
        /// **Reacting to something that happened, for one person.** Set the<br/>
        /// trigger's `webhook.user_identity_source` to `fire` and send<br/>
        /// `Speechify-User-Identity` on each POST. The run then acts for that<br/>
        /// person - their memory, and every tool call told who it is for - so one<br/>
        /// trigger serves every person your connector watches and you hold no<br/>
        /// trigger id per person. Use the plain form (`user_identity_source:<br/>
        /// trigger`) when the work is the same whoever it is for: a nightly<br/>
        /// reconciliation, an alert fan-out, a build that finished.<br/>
        /// **Rate.** A trigger admits 60 fires a minute, and 12 a minute for any<br/>
        /// one person; past either the endpoint answers `429` with `Retry-After`.<br/>
        /// A fire starts a durable run against your credit balance, so a burst is<br/>
        /// deferred rather than fanned out. Retry the refused delivery under the<br/>
        /// same delivery id and it runs exactly once.
        /// </summary>
        /// <param name="triggerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="speechifyUserIdentity"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTriggerFireResponse> FireAsync(
            string triggerId,
            string? speechifyVersion = default,
            string? speechifyUserIdentity = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}