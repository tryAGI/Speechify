#nullable enable

namespace Speechify
{
    public partial interface IHostedApisClient
    {
        /// <summary>
        /// Create Hosted API<br/>
        /// Create a hosted API. The slug is a DNS label, globally unique on the<br/>
        /// shared domain (409 `hosted_api_slug_taken`) and immutable afterwards.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPI> CreateAsync(

            global::Speechify.CreateHostedAPIRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Hosted API<br/>
        /// Create a hosted API. The slug is a DNS label, globally unique on the<br/>
        /// shared domain (409 `hosted_api_slug_taken`) and immutable afterwards.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.HostedAPI>> CreateAsResponseAsync(

            global::Speechify.CreateHostedAPIRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Hosted API<br/>
        /// Create a hosted API. The slug is a DNS label, globally unique on the<br/>
        /// shared domain (409 `hosted_api_slug_taken`) and immutable afterwards.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="slug">
        /// 3-40 lowercase letters, digits or hyphens; a DNS label, unique on the shared domain; immutable.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="authMode">
        /// consumer_key when omitted.
        /// </param>
        /// <param name="corsOrigins"></param>
        /// <param name="dailyRunCap">
        /// Runs the API may start per UTC day through its run routes; 1000 when omitted.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPI> CreateAsync(
            string slug,
            string name,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? description = default,
            global::Speechify.CreateHostedApiRequestAuthMode? authMode = default,
            global::System.Collections.Generic.IList<string>? corsOrigins = default,
            int? dailyRunCap = default,
            string? projectId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}