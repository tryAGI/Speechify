#nullable enable

namespace Speechify
{
    public partial interface ISubpackageWebhooksSubpackageWebhooksEndpointsClient
    {
        /// <summary>
        /// Update webhook endpoint<br/>
        /// Partial update; omitted fields are left unchanged. Set `disabled` to pause delivery without deleting the endpoint.
        /// </summary>
        /// <param name="webhookEndpointId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WebhookEndpoint> UpdateAsync(
            string webhookEndpointId,

            global::Speechify.UpdateWebhookEndpointRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook endpoint<br/>
        /// Partial update; omitted fields are left unchanged. Set `disabled` to pause delivery without deleting the endpoint.
        /// </summary>
        /// <param name="webhookEndpointId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.WebhookEndpoint>> UpdateAsResponseAsync(
            string webhookEndpointId,

            global::Speechify.UpdateWebhookEndpointRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook endpoint<br/>
        /// Partial update; omitted fields are left unchanged. Set `disabled` to pause delivery without deleting the endpoint.
        /// </summary>
        /// <param name="webhookEndpointId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="url"></param>
        /// <param name="enabledEvents"></param>
        /// <param name="description"></param>
        /// <param name="disabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WebhookEndpoint> UpdateAsync(
            string webhookEndpointId,
            string? speechifyVersion = default,
            string? url = default,
            global::System.Collections.Generic.IList<string>? enabledEvents = default,
            string? description = default,
            bool? disabled = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}