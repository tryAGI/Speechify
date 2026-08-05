#nullable enable

namespace Speechify
{
    public partial interface IShareLinksClient
    {
        /// <summary>
        /// Revoke Share Link<br/>
        /// Revoke a share link. Idempotent — revoking an already-revoked link<br/>
        /// succeeds and leaves the original timestamp intact.<br/>
        /// Revocation stops new calls immediately. It does not hang up a call<br/>
        /// already in progress: that call is already bounded by its own<br/>
        /// duration limit and has already drawn its time from the link's<br/>
        /// budget, so ending it mid-sentence would surprise the person talking<br/>
        /// without saving the owner anything.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="shareLinkId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RevokeAsync(
            string agentId,
            string shareLinkId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke Share Link<br/>
        /// Revoke a share link. Idempotent — revoking an already-revoked link<br/>
        /// succeeds and leaves the original timestamp intact.<br/>
        /// Revocation stops new calls immediately. It does not hang up a call<br/>
        /// already in progress: that call is already bounded by its own<br/>
        /// duration limit and has already drawn its time from the link's<br/>
        /// budget, so ending it mid-sentence would surprise the person talking<br/>
        /// without saving the owner anything.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="shareLinkId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> RevokeAsResponseAsync(
            string agentId,
            string shareLinkId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}