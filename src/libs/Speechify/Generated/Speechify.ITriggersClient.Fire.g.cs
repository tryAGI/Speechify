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
        /// original run instead of starting a second one.
        /// </summary>
        /// <param name="triggerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTriggerFireResponse> FireAsync(
            string triggerId,

            object request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fire Agent Trigger<br/>
        /// Inbound fire URL for a webhook trigger. Authenticate with the trigger's<br/>
        /// one-time fire token as `Authorization: Bearer &lt;secret&gt;`. The JSON body<br/>
        /// becomes the started run's payload variable. Supply an `Idempotency-Key`<br/>
        /// (or `Speechify-Delivery-Id`) header to make a redelivery replay the<br/>
        /// original run instead of starting a second one.
        /// </summary>
        /// <param name="triggerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTriggerFireResponse>> FireAsResponseAsync(
            string triggerId,

            object request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fire Agent Trigger<br/>
        /// Inbound fire URL for a webhook trigger. Authenticate with the trigger's<br/>
        /// one-time fire token as `Authorization: Bearer &lt;secret&gt;`. The JSON body<br/>
        /// becomes the started run's payload variable. Supply an `Idempotency-Key`<br/>
        /// (or `Speechify-Delivery-Id`) header to make a redelivery replay the<br/>
        /// original run instead of starting a second one.
        /// </summary>
        /// <param name="triggerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTriggerFireResponse> FireAsync(
            string triggerId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}