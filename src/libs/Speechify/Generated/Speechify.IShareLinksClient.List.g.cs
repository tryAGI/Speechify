#nullable enable

namespace Speechify
{
    public partial interface IShareLinksClient
    {
        /// <summary>
        /// List Share Links<br/>
        /// List the agent's share links, most recently created first.<br/>
        /// Cursor-paginated: omit `cursor` to fetch the first page.<br/>
        /// Revoked and expired links are included — an owner needs to see what<br/>
        /// they have handed out, not only what is currently live. The bearer<br/>
        /// token is never returned; only a short masked prefix so two links can<br/>
        /// be told apart.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListShareLinksResponse> ListAsync(
            string agentId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Share Links<br/>
        /// List the agent's share links, most recently created first.<br/>
        /// Cursor-paginated: omit `cursor` to fetch the first page.<br/>
        /// Revoked and expired links are included — an owner needs to see what<br/>
        /// they have handed out, not only what is currently live. The bearer<br/>
        /// token is never returned; only a short masked prefix so two links can<br/>
        /// be told apart.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListShareLinksResponse>> ListAsResponseAsync(
            string agentId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}