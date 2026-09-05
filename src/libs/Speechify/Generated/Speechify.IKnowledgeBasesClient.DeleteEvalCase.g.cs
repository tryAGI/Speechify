#nullable enable

namespace Speechify
{
    public partial interface IKnowledgeBasesClient
    {
        /// <summary>
        /// Delete Evaluation Case<br/>
        /// Remove a case. Past evaluations keep the outcome they recorded for<br/>
        /// it.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="caseId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteEvalCaseAsync(
            string kbId,
            string caseId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Evaluation Case<br/>
        /// Remove a case. Past evaluations keep the outcome they recorded for<br/>
        /// it.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="caseId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteEvalCaseAsResponseAsync(
            string kbId,
            string caseId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}