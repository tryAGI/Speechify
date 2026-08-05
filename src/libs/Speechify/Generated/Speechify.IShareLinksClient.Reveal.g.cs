#nullable enable

namespace Speechify
{
    public partial interface IShareLinksClient
    {
        /// <summary>
        /// Reveal Share Link Token<br/>
        /// Return a share link's bearer token, so the URL can be copied again.<br/>
        /// A `POST` rather than a `GET`, and permission-gated like a mutation<br/>
        /// even though it changes nothing: the response is a live bearer<br/>
        /// credential, so it must never be cacheable or replayable from a<br/>
        /// browser's history, and whoever may hand a link out is whoever may<br/>
        /// hand it out again. It is separately rate-limited.<br/>
        /// Revoked and expired links still reveal — the owner can already see<br/>
        /// that state and may need to tell a recipient which link they hold.<br/>
        /// Links created before tokens were stored recoverably return `409<br/>
        /// share_link_token_unavailable`: theirs was hashed and discarded, and<br/>
        /// no retry will produce it. Check `token_recoverable` on the link first<br/>
        /// rather than offering an action that can only fail.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="shareLinkId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RevealShareLinkTokenResponse> RevealAsync(
            string agentId,
            string shareLinkId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reveal Share Link Token<br/>
        /// Return a share link's bearer token, so the URL can be copied again.<br/>
        /// A `POST` rather than a `GET`, and permission-gated like a mutation<br/>
        /// even though it changes nothing: the response is a live bearer<br/>
        /// credential, so it must never be cacheable or replayable from a<br/>
        /// browser's history, and whoever may hand a link out is whoever may<br/>
        /// hand it out again. It is separately rate-limited.<br/>
        /// Revoked and expired links still reveal — the owner can already see<br/>
        /// that state and may need to tell a recipient which link they hold.<br/>
        /// Links created before tokens were stored recoverably return `409<br/>
        /// share_link_token_unavailable`: theirs was hashed and discarded, and<br/>
        /// no retry will produce it. Check `token_recoverable` on the link first<br/>
        /// rather than offering an action that can only fail.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="shareLinkId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.RevealShareLinkTokenResponse>> RevealAsResponseAsync(
            string agentId,
            string shareLinkId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}