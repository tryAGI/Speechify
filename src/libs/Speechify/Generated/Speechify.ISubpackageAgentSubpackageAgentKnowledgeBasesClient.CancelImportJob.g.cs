#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Cancel Import Job<br/>
        /// Cancel a non-terminal import job. Returns `200` with the<br/>
        /// cancelled job so callers see its new `status` without a follow-up<br/>
        /// `GET` — the same success shape as the other job-cancel verbs<br/>
        /// (`cancel` on batch calls, test runs, and suite runs). Returns 404<br/>
        /// when the job is already terminal (completed / failed / cancelled),<br/>
        /// unknown, or its kb_id does not match the `{kb_id}` path segment.
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
        /// Cancel a non-terminal import job. Returns `200` with the<br/>
        /// cancelled job so callers see its new `status` without a follow-up<br/>
        /// `GET` — the same success shape as the other job-cancel verbs<br/>
        /// (`cancel` on batch calls, test runs, and suite runs). Returns 404<br/>
        /// when the job is already terminal (completed / failed / cancelled),<br/>
        /// unknown, or its kb_id does not match the `{kb_id}` path segment.
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