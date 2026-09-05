#nullable enable

namespace Speechify
{
    public partial interface IKnowledgeBasesClient
    {
        /// <summary>
        /// Cancel Knowledge Base Evaluation<br/>
        /// Stop a pending or running evaluation. Idempotent: a finished<br/>
        /// evaluation comes back unchanged.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseEvaluation> CancelEvaluationAsync(
            string kbId,
            string evaluationId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Knowledge Base Evaluation<br/>
        /// Stop a pending or running evaluation. Idempotent: a finished<br/>
        /// evaluation comes back unchanged.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.KnowledgeBaseEvaluation>> CancelEvaluationAsResponseAsync(
            string kbId,
            string evaluationId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}