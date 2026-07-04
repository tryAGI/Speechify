#nullable enable

namespace Speechify
{
    public partial interface IKnowledgeBasesClient
    {
        /// <summary>
        /// Cancel Import Job<br/>
        /// Cancel an import job. Moves a non-terminal job to `cancelled` and<br/>
        /// returns `200` with the job so callers see its new `status` without a<br/>
        /// follow-up `GET`. Idempotent (§16), matching the other job-cancel verbs<br/>
        /// (`cancel` on batch calls, test runs, and suite runs): cancelling an<br/>
        /// already-terminal job (`completed` / `failed` / `cancelled`) returns it<br/>
        /// unchanged. 404 only when the job id is unknown or its kb_id does not<br/>
        /// match the `{kb_id}` path segment.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="importId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ImportJob> CancelImportJobAsync(
            string kbId,
            string importId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Import Job<br/>
        /// Cancel an import job. Moves a non-terminal job to `cancelled` and<br/>
        /// returns `200` with the job so callers see its new `status` without a<br/>
        /// follow-up `GET`. Idempotent (§16), matching the other job-cancel verbs<br/>
        /// (`cancel` on batch calls, test runs, and suite runs): cancelling an<br/>
        /// already-terminal job (`completed` / `failed` / `cancelled`) returns it<br/>
        /// unchanged. 404 only when the job id is unknown or its kb_id does not<br/>
        /// match the `{kb_id}` path segment.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="importId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ImportJob>> CancelImportJobAsResponseAsync(
            string kbId,
            string importId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}