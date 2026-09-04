#nullable enable

namespace Speechify
{
    public partial interface IToolDefinitionsClient
    {
        /// <summary>
        /// Test Webhook Connection<br/>
        /// Probe a customer-supplied webhook tool config without persisting<br/>
        /// anything. The server fires the exact request shape used on a real<br/>
        /// invocation — same JSON body, same HMAC-SHA256<br/>
        /// signature — with an empty argument set, and reports the<br/>
        /// endpoint's status code, latency, and a truncated response body,<br/>
        /// or a transport-level failure reason. The probe carries a<br/>
        /// `Speechify-Webhook-Test: true` header so a careful endpoint<br/>
        /// can recognise the test and skip its real side effect. Pass<br/>
        /// `tool_id` from the edit-form flow so the server signs the probe<br/>
        /// with the tool's stored HMAC secret.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WebhookProbeResult> TestWebhookConnectionAsync(

            global::Speechify.TestWebhookConnectionRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Webhook Connection<br/>
        /// Probe a customer-supplied webhook tool config without persisting<br/>
        /// anything. The server fires the exact request shape used on a real<br/>
        /// invocation — same JSON body, same HMAC-SHA256<br/>
        /// signature — with an empty argument set, and reports the<br/>
        /// endpoint's status code, latency, and a truncated response body,<br/>
        /// or a transport-level failure reason. The probe carries a<br/>
        /// `Speechify-Webhook-Test: true` header so a careful endpoint<br/>
        /// can recognise the test and skip its real side effect. Pass<br/>
        /// `tool_id` from the edit-form flow so the server signs the probe<br/>
        /// with the tool's stored HMAC secret.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.WebhookProbeResult>> TestWebhookConnectionAsResponseAsync(

            global::Speechify.TestWebhookConnectionRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Webhook Connection<br/>
        /// Probe a customer-supplied webhook tool config without persisting<br/>
        /// anything. The server fires the exact request shape used on a real<br/>
        /// invocation — same JSON body, same HMAC-SHA256<br/>
        /// signature — with an empty argument set, and reports the<br/>
        /// endpoint's status code, latency, and a truncated response body,<br/>
        /// or a transport-level failure reason. The probe carries a<br/>
        /// `Speechify-Webhook-Test: true` header so a careful endpoint<br/>
        /// can recognise the test and skip its real side effect. Pass<br/>
        /// `tool_id` from the edit-form flow so the server signs the probe<br/>
        /// with the tool's stored HMAC secret.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="config">
        /// Config shape for `kind=webhook`.<br/>
        /// On a durable run (`POST /v1/agents/{agent_id}/runs`) your endpoint is<br/>
        /// told `user_identity`: the person the agent is acting for, exactly as<br/>
        /// your application supplied it when it started the run. The field is<br/>
        /// absent when the run is acting for nobody in particular, so treat an<br/>
        /// absent value as "no person", never as a default one. Voice<br/>
        /// conversations and sessions do not carry it yet.<br/>
        /// On `method: POST` it rides inside the **signed** JSON body rather than<br/>
        /// a header, so an endpoint deciding whose data to touch can verify the<br/>
        /// answer with the same HMAC it already checks. On `method: GET` there is<br/>
        /// no body to sign, so it arrives as a **`user_identity` query<br/>
        /// parameter**, unverifiable exactly as the arguments beside it are: a<br/>
        /// GET's signature covers an envelope that is not on the wire. Use POST<br/>
        /// for any endpoint that authorizes on who the call is for. A tool<br/>
        /// argument of the same name never overrides it.
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
            string? speechifyVersion = default,
            string? toolId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}