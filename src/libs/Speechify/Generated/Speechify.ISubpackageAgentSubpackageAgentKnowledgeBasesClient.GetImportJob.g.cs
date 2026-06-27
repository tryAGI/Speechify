#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Get Import Job<br/>
        /// Retrieve a single import job by ID. Poll this endpoint until<br/>
        /// `status` reaches a terminal state (`completed` / `failed` /<br/>
        /// `cancelled`).
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="importId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ImportJob> GetImportJobAsync(
            string kbId,
            string importId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Import Job<br/>
        /// Retrieve a single import job by ID. Poll this endpoint until<br/>
        /// `status` reaches a terminal state (`completed` / `failed` /<br/>
        /// `cancelled`).
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="importId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ImportJob>> GetImportJobAsResponseAsync(
            string kbId,
            string importId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}