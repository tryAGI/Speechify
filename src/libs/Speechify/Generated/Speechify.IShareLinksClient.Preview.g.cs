#nullable enable

namespace Speechify
{
    public partial interface IShareLinksClient
    {
        /// <summary>
        /// Preview Share Link<br/>
        /// Resolve a share link for display, before any call is started.<br/>
        /// Unauthenticated: the link token is the credential. The response is<br/>
        /// deliberately cosmetic-only — the agent's display name, the embed's<br/>
        /// visual configuration, and the link's remaining budget. It never<br/>
        /// returns the agent id, the workspace id, the prompt, the model, or<br/>
        /// any tool or knowledge-base name.<br/>
        /// This endpoint performs no write and consumes no budget. Link<br/>
        /// unfurlers (chat clients, mail providers, security scanners) will<br/>
        /// fetch a pasted URL, so a preview must never be able to spend a<br/>
        /// link's remaining call time.<br/>
        /// Unknown, revoked and expired links all answer `404<br/>
        /// share_link_not_found`. The states are indistinguishable on purpose:<br/>
        /// the token is a bearer credential that spends money, so telling a<br/>
        /// caller which of their guesses named a real link would hand them an<br/>
        /// enumeration oracle.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ShareLinkPreview> PreviewAsync(
            string token,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Share Link<br/>
        /// Resolve a share link for display, before any call is started.<br/>
        /// Unauthenticated: the link token is the credential. The response is<br/>
        /// deliberately cosmetic-only — the agent's display name, the embed's<br/>
        /// visual configuration, and the link's remaining budget. It never<br/>
        /// returns the agent id, the workspace id, the prompt, the model, or<br/>
        /// any tool or knowledge-base name.<br/>
        /// This endpoint performs no write and consumes no budget. Link<br/>
        /// unfurlers (chat clients, mail providers, security scanners) will<br/>
        /// fetch a pasted URL, so a preview must never be able to spend a<br/>
        /// link's remaining call time.<br/>
        /// Unknown, revoked and expired links all answer `404<br/>
        /// share_link_not_found`. The states are indistinguishable on purpose:<br/>
        /// the token is a bearer credential that spends money, so telling a<br/>
        /// caller which of their guesses named a real link would hand them an<br/>
        /// enumeration oracle.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ShareLinkPreview>> PreviewAsResponseAsync(
            string token,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}