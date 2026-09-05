#nullable enable

namespace Speechify
{
    public partial interface IKnowledgeBasesClient
    {
        /// <summary>
        /// Update Evaluation Case<br/>
        /// Change a case. Omitted fields keep their value. Past evaluations<br/>
        /// keep the question and expectation they ran against.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="caseId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseEvalCase> UpdateEvalCaseAsync(
            string kbId,
            string caseId,

            global::Speechify.UpdateKnowledgeBaseEvalCaseRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Evaluation Case<br/>
        /// Change a case. Omitted fields keep their value. Past evaluations<br/>
        /// keep the question and expectation they ran against.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="caseId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.KnowledgeBaseEvalCase>> UpdateEvalCaseAsResponseAsync(
            string kbId,
            string caseId,

            global::Speechify.UpdateKnowledgeBaseEvalCaseRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Evaluation Case<br/>
        /// Change a case. Omitted fields keep their value. Past evaluations<br/>
        /// keep the question and expectation they ran against.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="caseId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="query"></param>
        /// <param name="expectedDocumentIds"></param>
        /// <param name="unanswerable"></param>
        /// <param name="note"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseEvalCase> UpdateEvalCaseAsync(
            string kbId,
            string caseId,
            string? speechifyVersion = default,
            string? query = default,
            global::System.Collections.Generic.IList<string>? expectedDocumentIds = default,
            bool? unanswerable = default,
            string? note = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}