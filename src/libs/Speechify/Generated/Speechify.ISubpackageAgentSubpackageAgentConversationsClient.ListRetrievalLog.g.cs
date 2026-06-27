#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentConversationsClient
    {
        /// <summary>
        /// List Retrieval Log<br/>
        /// Per-conversation retrieval log, newest first — one row per<br/>
        /// `search_knowledge` invocation made during the call. Each entry<br/>
        /// records the query, ranked chunks (denormalised so deletions<br/>
        /// don't render history unreadable), `top_k`, and hit count.<br/>
        /// Powers the Retrieval panel on the conversation detail view.<br/>
        /// Cursor-paginated: omit `cursor` to fetch the first page.<br/>
        /// Default page size is 50 and max is 200. Walk pages while<br/>
        /// `has_more` is true.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListRetrievalLogsResponse> ListRetrievalLogAsync(
            string conversationId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Retrieval Log<br/>
        /// Per-conversation retrieval log, newest first — one row per<br/>
        /// `search_knowledge` invocation made during the call. Each entry<br/>
        /// records the query, ranked chunks (denormalised so deletions<br/>
        /// don't render history unreadable), `top_k`, and hit count.<br/>
        /// Powers the Retrieval panel on the conversation detail view.<br/>
        /// Cursor-paginated: omit `cursor` to fetch the first page.<br/>
        /// Default page size is 50 and max is 200. Walk pages while<br/>
        /// `has_more` is true.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListRetrievalLogsResponse>> ListRetrievalLogAsResponseAsync(
            string conversationId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}