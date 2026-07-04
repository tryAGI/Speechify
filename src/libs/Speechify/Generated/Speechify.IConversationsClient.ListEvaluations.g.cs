#nullable enable

namespace Speechify
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// List Evaluations<br/>
        /// Retrieve post-call evaluation results for a conversation.<br/>
        /// Cursor-paginated: omit `cursor` for the first page; walk pages while<br/>
        /// `has_more` is true (default page size 50, max 200).
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
        global::System.Threading.Tasks.Task<global::Speechify.ListEvaluationsResponse> ListEvaluationsAsync(
            string conversationId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Evaluations<br/>
        /// Retrieve post-call evaluation results for a conversation.<br/>
        /// Cursor-paginated: omit `cursor` for the first page; walk pages while<br/>
        /// `has_more` is true (default page size 50, max 200).
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListEvaluationsResponse>> ListEvaluationsAsResponseAsync(
            string conversationId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}