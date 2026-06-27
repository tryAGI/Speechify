#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// Attach Agent Knowledge Base<br/>
        /// Attach a knowledge base to an agent. The `search_knowledge` tool<br/>
        /// is auto-registered on the next conversation and can only query the<br/>
        /// attached knowledge bases.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AttachKnowledgeBaseAsync(
            string agentId,
            string kbId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach Agent Knowledge Base<br/>
        /// Attach a knowledge base to an agent. The `search_knowledge` tool<br/>
        /// is auto-registered on the next conversation and can only query the<br/>
        /// attached knowledge bases.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> AttachKnowledgeBaseAsResponseAsync(
            string agentId,
            string kbId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}