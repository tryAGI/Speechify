#nullable enable

namespace Speechify
{
    public partial interface IShareLinksClient
    {
        /// <summary>
        /// Create Share Link<br/>
        /// Mint a share link for the agent.<br/>
        /// The response carries the link's bearer `token`. It is also stored<br/>
        /// encrypted, so a caller who loses it reads it back with<br/>
        /// `revealShareLinkToken` instead of revoking and re-creating — which<br/>
        /// would kill the copy the recipient already has.<br/>
        /// Every cap is optional and falls back to a bounded default. There is<br/>
        /// no way to express "unlimited": an anonymous link that spends the<br/>
        /// workspace's balance should not be creatable by omitting a field.
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
        global::System.Threading.Tasks.Task<global::Speechify.CreateShareLinkResponse> CreateAsync(
            string agentId,

            global::Speechify.CreateShareLinkRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Share Link<br/>
        /// Mint a share link for the agent.<br/>
        /// The response carries the link's bearer `token`. It is also stored<br/>
        /// encrypted, so a caller who loses it reads it back with<br/>
        /// `revealShareLinkToken` instead of revoking and re-creating — which<br/>
        /// would kill the copy the recipient already has.<br/>
        /// Every cap is optional and falls back to a bounded default. There is<br/>
        /// no way to express "unlimited": an anonymous link that spends the<br/>
        /// workspace's balance should not be creatable by omitting a field.
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.CreateShareLinkResponse>> CreateAsResponseAsync(
            string agentId,

            global::Speechify.CreateShareLinkRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Share Link<br/>
        /// Mint a share link for the agent.<br/>
        /// The response carries the link's bearer `token`. It is also stored<br/>
        /// encrypted, so a caller who loses it reads it back with<br/>
        /// `revealShareLinkToken` instead of revoking and re-creating — which<br/>
        /// would kill the copy the recipient already has.<br/>
        /// Every cap is optional and falls back to a bounded default. There is<br/>
        /// no way to express "unlimited": an anonymous link that spends the<br/>
        /// workspace's balance should not be creatable by omitting a field.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="label">
        /// An optional note so several links can be told apart.
        /// </param>
        /// <param name="expiresInSeconds">
        /// How long the link stays usable. A duration rather than a<br/>
        /// timestamp, so a client with a skewed clock cannot mint a link<br/>
        /// that is already expired. Defaults to 7 days, maximum 30.
        /// </param>
        /// <param name="budgetSeconds">
        /// Total conversation time the link may authorise, across all its<br/>
        /// calls. This is the control that bounds what a leaked link can<br/>
        /// cost. Defaults to 1 hour, maximum 4.
        /// </param>
        /// <param name="maxCallDurationSeconds">
        /// Ceiling on a single call. Defaults to 5 minutes, maximum 30, and<br/>
        /// is clamped again to the agent's own limit.
        /// </param>
        /// <param name="maxConcurrent">
        /// Simultaneous calls allowed on this link. Defaults to 3, maximum 10.
        /// </param>
        /// <param name="allowedToolIds">
        /// Tools to opt this link into, by id. Omit for the default<br/>
        /// posture (call controls and knowledge search only). Opting a<br/>
        /// webhook or MCP tool in lets a stranger drive it, so it is an<br/>
        /// explicit act rather than something inherited from the agent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.CreateShareLinkResponse> CreateAsync(
            string agentId,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? label = default,
            int? expiresInSeconds = default,
            int? budgetSeconds = default,
            int? maxCallDurationSeconds = default,
            int? maxConcurrent = default,
            global::System.Collections.Generic.IList<string>? allowedToolIds = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}