#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentToolDefinitionsClient
    {
        /// <summary>
        /// Test Webhook Connection<br/>
        /// Probe a customer-supplied webhook tool config without persisting<br/>
        /// anything. The server fires the exact request shape the worker<br/>
        /// sends on a real invocation — same JSON body, same HMAC-SHA256<br/>
        /// signature — with an empty argument set, and reports the<br/>
        /// endpoint's status code, latency, and a truncated response body,<br/>
        /// or a transport-level failure reason. The probe carries an<br/>
        /// `X-Speechify-Webhook-Test: true` header so a careful endpoint<br/>
        /// can recognise the test and skip its real side effect. Pass<br/>
        /// `tool_id` from the edit-form flow so the server signs the probe<br/>
        /// with the tool's stored HMAC secret.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WebhookProbeResult> TestWebhookConnectionAsync(

            global::Speechify.TestWebhookConnectionRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Webhook Connection<br/>
        /// Probe a customer-supplied webhook tool config without persisting<br/>
        /// anything. The server fires the exact request shape the worker<br/>
        /// sends on a real invocation — same JSON body, same HMAC-SHA256<br/>
        /// signature — with an empty argument set, and reports the<br/>
        /// endpoint's status code, latency, and a truncated response body,<br/>
        /// or a transport-level failure reason. The probe carries an<br/>
        /// `X-Speechify-Webhook-Test: true` header so a careful endpoint<br/>
        /// can recognise the test and skip its real side effect. Pass<br/>
        /// `tool_id` from the edit-form flow so the server signs the probe<br/>
        /// with the tool's stored HMAC secret.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.WebhookProbeResult>> TestWebhookConnectionAsResponseAsync(

            global::Speechify.TestWebhookConnectionRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Webhook Connection<br/>
        /// Probe a customer-supplied webhook tool config without persisting<br/>
        /// anything. The server fires the exact request shape the worker<br/>
        /// sends on a real invocation — same JSON body, same HMAC-SHA256<br/>
        /// signature — with an empty argument set, and reports the<br/>
        /// endpoint's status code, latency, and a truncated response body,<br/>
        /// or a transport-level failure reason. The probe carries an<br/>
        /// `X-Speechify-Webhook-Test: true` header so a careful endpoint<br/>
        /// can recognise the test and skip its real side effect. Pass<br/>
        /// `tool_id` from the edit-form flow so the server signs the probe<br/>
        /// with the tool's stored HMAC secret.
        /// </summary>
        /// <param name="config">
        /// Config shape for `kind=webhook`.
        /// </param>
        /// <param name="toolId">
        /// Optional `tool_&lt;crockford&gt;` id of the existing tool to sign<br/>
        /// the probe with. Raw UUIDs and other-resource prefixes are<br/>
        /// rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WebhookProbeResult> TestWebhookConnectionAsync(
            global::Speechify.WebhookToolConfig config,
            string? toolId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}