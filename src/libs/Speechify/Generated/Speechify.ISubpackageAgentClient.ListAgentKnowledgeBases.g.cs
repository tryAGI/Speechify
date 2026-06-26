#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// List Agent Knowledge Bases<br/>
        /// List knowledge bases attached to an agent. Bare list — the<br/>
        /// attachment count is bounded by configuration, not by data<br/>
        /// scale, so this endpoint does not paginate.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AttachedKnowledgeBasesResponse> ListAgentKnowledgeBasesAsync(
            string id,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Knowledge Bases<br/>
        /// List knowledge bases attached to an agent. Bare list — the<br/>
        /// attachment count is bounded by configuration, not by data<br/>
        /// scale, so this endpoint does not paginate.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AttachedKnowledgeBasesResponse>> ListAgentKnowledgeBasesAsResponseAsync(
            string id,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}