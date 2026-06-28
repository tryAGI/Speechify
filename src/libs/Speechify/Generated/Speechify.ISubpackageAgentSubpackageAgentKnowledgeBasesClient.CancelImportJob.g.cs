#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Cancel Import Job<br/>
        /// Cancel a non-terminal import job. Returns 204 with no body on<br/>
        /// success. Returns 404 when the job is already terminal<br/>
        /// (completed / failed / cancelled), unknown, or its kb_id does not<br/>
        /// match the `{kb_id}` path segment.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="importId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CancelImportJobAsync(
            string kbId,
            string importId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Import Job<br/>
        /// Cancel a non-terminal import job. Returns 204 with no body on<br/>
        /// success. Returns 404 when the job is already terminal<br/>
        /// (completed / failed / cancelled), unknown, or its kb_id does not<br/>
        /// match the `{kb_id}` path segment.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="importId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> CancelImportJobAsResponseAsync(
            string kbId,
            string importId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}