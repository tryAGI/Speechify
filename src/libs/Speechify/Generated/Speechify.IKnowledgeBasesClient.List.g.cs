#nullable enable

namespace Speechify
{
    public partial interface IKnowledgeBasesClient
    {
        /// <summary>
        /// List Knowledge Bases<br/>
        /// List knowledge bases owned by the caller. Cursor-paginated:<br/>
        /// omit `cursor` to fetch the first page. The default page size is<br/>
        /// 50 and the max is 200; values outside that range are clamped.<br/>
        /// Walk pages while `has_more` is true.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListKnowledgeBasesResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Knowledge Bases<br/>
        /// List knowledge bases owned by the caller. Cursor-paginated:<br/>
        /// omit `cursor` to fetch the first page. The default page size is<br/>
        /// 50 and the max is 200; values outside that range are clamped.<br/>
        /// Walk pages while `has_more` is true.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListKnowledgeBasesResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}