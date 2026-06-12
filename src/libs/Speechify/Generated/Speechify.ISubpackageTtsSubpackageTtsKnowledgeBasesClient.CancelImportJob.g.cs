#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsKnowledgeBasesClient
    {
        /// <summary>
        /// Cancel Import Job<br/>
        /// Cancel a non-terminal import job. Idempotent on terminal jobs<br/>
        /// (completed / failed / cancelled) — the cancel call returns the<br/>
        /// unchanged row.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="importId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsImportJob> CancelImportJobAsync(
            string id,
            string importId,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Import Job<br/>
        /// Cancel a non-terminal import job. Idempotent on terminal jobs<br/>
        /// (completed / failed / cancelled) — the cancel call returns the<br/>
        /// unchanged row.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="importId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsImportJob>> CancelImportJobAsResponseAsync(
            string id,
            string importId,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}