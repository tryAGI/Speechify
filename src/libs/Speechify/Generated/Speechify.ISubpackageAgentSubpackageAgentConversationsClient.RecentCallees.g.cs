#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentConversationsClient
    {
        /// <summary>
        /// List recent callees<br/>
        /// Distinct phone numbers the caller's workspace has dialled on<br/>
        /// outbound calls, ordered by most recent. Feeds the batch-calls<br/>
        /// composer's "Suggested from history" surface. Cursor-paginated:<br/>
        /// omit `cursor` to fetch the first page. Default page size is 50<br/>
        /// and max is 200. Walk pages while `has_more` is true.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListRecentCalleesResponse> RecentCalleesAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List recent callees<br/>
        /// Distinct phone numbers the caller's workspace has dialled on<br/>
        /// outbound calls, ordered by most recent. Feeds the batch-calls<br/>
        /// composer's "Suggested from history" surface. Cursor-paginated:<br/>
        /// omit `cursor` to fetch the first page. Default page size is 50<br/>
        /// and max is 200. Walk pages while `has_more` is true.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListRecentCalleesResponse>> RecentCalleesAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}