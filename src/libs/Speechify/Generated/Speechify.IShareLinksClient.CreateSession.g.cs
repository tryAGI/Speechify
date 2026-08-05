#nullable enable

namespace Speechify
{
    public partial interface IShareLinksClient
    {
        /// <summary>
        /// Create Share Link Session<br/>
        /// Start a realtime voice session against a share link.<br/>
        /// Unauthenticated: the link token is the credential, and it is sent in<br/>
        /// the request body rather than the URL so it never reaches request<br/>
        /// logs. The agent's owner is billed for the call.<br/>
        /// The response carries only the realtime handles — `token` and `url` —<br/>
        /// which is exactly the shape the `&lt;speechify-agent&gt;` element's<br/>
        /// `sessionProvider` expects. It deliberately omits the conversation id<br/>
        /// and the agent snapshot that `createSession` returns, because those<br/>
        /// are owner-side facts an anonymous visitor should not hold.<br/>
        /// Call time is claimed from the link's budget before anything is<br/>
        /// dispatched. A link with too little budget left for another call<br/>
        /// answers `409 share_link_exhausted`; one already running its maximum<br/>
        /// number of simultaneous calls answers `429`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ShareLinkSession> CreateSessionAsync(

            global::Speechify.CreateShareLinkSessionRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Share Link Session<br/>
        /// Start a realtime voice session against a share link.<br/>
        /// Unauthenticated: the link token is the credential, and it is sent in<br/>
        /// the request body rather than the URL so it never reaches request<br/>
        /// logs. The agent's owner is billed for the call.<br/>
        /// The response carries only the realtime handles — `token` and `url` —<br/>
        /// which is exactly the shape the `&lt;speechify-agent&gt;` element's<br/>
        /// `sessionProvider` expects. It deliberately omits the conversation id<br/>
        /// and the agent snapshot that `createSession` returns, because those<br/>
        /// are owner-side facts an anonymous visitor should not hold.<br/>
        /// Call time is claimed from the link's budget before anything is<br/>
        /// dispatched. A link with too little budget left for another call<br/>
        /// answers `409 share_link_exhausted`; one already running its maximum<br/>
        /// number of simultaneous calls answers `429`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ShareLinkSession>> CreateSessionAsResponseAsync(

            global::Speechify.CreateShareLinkSessionRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Share Link Session<br/>
        /// Start a realtime voice session against a share link.<br/>
        /// Unauthenticated: the link token is the credential, and it is sent in<br/>
        /// the request body rather than the URL so it never reaches request<br/>
        /// logs. The agent's owner is billed for the call.<br/>
        /// The response carries only the realtime handles — `token` and `url` —<br/>
        /// which is exactly the shape the `&lt;speechify-agent&gt;` element's<br/>
        /// `sessionProvider` expects. It deliberately omits the conversation id<br/>
        /// and the agent snapshot that `createSession` returns, because those<br/>
        /// are owner-side facts an anonymous visitor should not hold.<br/>
        /// Call time is claimed from the link's budget before anything is<br/>
        /// dispatched. A link with too little budget left for another call<br/>
        /// answers `409 share_link_exhausted`; one already running its maximum<br/>
        /// number of simultaneous calls answers `429`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="token">
        /// The share link's opaque bearer token.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ShareLinkSession> CreateSessionAsync(
            string token,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}