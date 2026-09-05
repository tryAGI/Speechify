#nullable enable

namespace Speechify
{
    public partial interface IEndpointsClient
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
        /// <param name="url">
        /// HTTPS destination for event deliveries. Must be a publicly<br/>
        /// reachable host: loopback, private, link-local, and cloud-metadata<br/>
        /// addresses (and reserved hostnames like `localhost`) are rejected.
        /// </param>
        /// <param name="projectId">
        /// Re-scope the endpoint: a `proj_...` id narrows it to that<br/>
        /// project's events, an explicit null makes it workspace-wide<br/>
        /// (every project's events), omitted leaves it unchanged. The<br/>
        /// signing secret and delivery history are untouched, so<br/>
        /// re-scoping never requires redeploying your receiver. An<br/>
        /// unknown id returns 404 project_not_found. A project-pinned API<br/>
        /// key may only scope an endpoint to its own project.
        /// </param>
        /// <param name="enabledEvents"></param>
        /// <param name="include">
        /// Payload-shaping keys (see `WebhookEndpoint.include`). Send `[]` to<br/>
        /// clear back to the lean default.
        /// </param>
        /// <param name="apiVersion">
        /// Opt the endpoint into a different (typically newer) payload shape<br/>
        /// (`YYYY-MM-DD`, see `WebhookEndpoint.api_version`). Omit to leave it<br/>
        /// unchanged. An unknown version is rejected.
        /// </param>
        /// <param name="description"></param>
        /// <param name="disabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WebhookEndpoint> UpdateAsync(
            string webhookEndpointId,
            string? speechifyVersion = default,
            string? url = default,
            string? projectId = default,
            global::System.Collections.Generic.IList<string>? enabledEvents = default,
            global::System.Collections.Generic.IList<string>? include = default,
            global::System.DateTime? apiVersion = default,
            string? description = default,
            bool? disabled = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}