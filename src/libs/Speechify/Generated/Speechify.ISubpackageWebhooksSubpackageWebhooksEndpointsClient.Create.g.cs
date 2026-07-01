#nullable enable

namespace Speechify
{
    public partial interface ISubpackageWebhooksSubpackageWebhooksEndpointsClient
    {
        /// <summary>
        /// Create webhook endpoint<br/>
        /// Register a webhook endpoint. Speechify mints an HMAC signing secret<br/>
        /// and returns it in the response `secret` field — exactly once. Store it<br/>
        /// then; subsequent reads omit it (rotate it with the rotate-secret action<br/>
        /// if lost). Select events via `enabled_events`: a list of catalog event<br/>
        /// names or `["*"]` for every event. Limited to 50 endpoints per workspace.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WebhookEndpoint> CreateAsync(

            global::Speechify.CreateWebhookEndpointRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create webhook endpoint<br/>
        /// Register a webhook endpoint. Speechify mints an HMAC signing secret<br/>
        /// and returns it in the response `secret` field — exactly once. Store it<br/>
        /// then; subsequent reads omit it (rotate it with the rotate-secret action<br/>
        /// if lost). Select events via `enabled_events`: a list of catalog event<br/>
        /// names or `["*"]` for every event. Limited to 50 endpoints per workspace.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.WebhookEndpoint>> CreateAsResponseAsync(

            global::Speechify.CreateWebhookEndpointRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create webhook endpoint<br/>
        /// Register a webhook endpoint. Speechify mints an HMAC signing secret<br/>
        /// and returns it in the response `secret` field — exactly once. Store it<br/>
        /// then; subsequent reads omit it (rotate it with the rotate-secret action<br/>
        /// if lost). Select events via `enabled_events`: a list of catalog event<br/>
        /// names or `["*"]` for every event. Limited to 50 endpoints per workspace.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="url">
        /// HTTPS destination for event deliveries. Must be a publicly<br/>
        /// reachable host: loopback, private, link-local, and cloud-metadata<br/>
        /// addresses (and reserved hostnames like `localhost`) are rejected.
        /// </param>
        /// <param name="enabledEvents">
        /// Catalog event names to subscribe to, or `["*"]` for all events.
        /// </param>
        /// <param name="include">
        /// Optional payload-shaping keys (see `WebhookEndpoint.include`):<br/>
        /// `messages`, `evaluations`. Omit for the lean default.
        /// </param>
        /// <param name="apiVersion">
        /// Optionally pin the endpoint's payload shape to a dated version<br/>
        /// (`YYYY-MM-DD`, see `WebhookEndpoint.api_version`). Omit to use the<br/>
        /// workspace's current version. An unknown version is rejected.
        /// </param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WebhookEndpoint> CreateAsync(
            string url,
            global::System.Collections.Generic.IList<string> enabledEvents,
            string? speechifyVersion = default,
            global::System.Collections.Generic.IList<string>? include = default,
            global::System.DateTime? apiVersion = default,
            string? description = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}