#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentConversationsClient
    {
        /// <summary>
        /// List Messages<br/>
        /// Retrieve the transcript for a conversation in started_at order<br/>
        /// (oldest first). Cursor-paginated: omit `cursor` to fetch the<br/>
        /// first page. Default page size is 50 and max is 200. Walk pages<br/>
        /// while `has_more` is true.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListMessagesResponse> ListMessagesAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Messages<br/>
        /// Retrieve the transcript for a conversation in started_at order<br/>
        /// (oldest first). Cursor-paginated: omit `cursor` to fetch the<br/>
        /// first page. Default page size is 50 and max is 200. Walk pages<br/>
        /// while `has_more` is true.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListMessagesResponse>> ListMessagesAsResponseAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}