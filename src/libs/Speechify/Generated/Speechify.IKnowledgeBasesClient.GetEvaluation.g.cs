#nullable enable

namespace Speechify
{
    public partial interface IKnowledgeBasesClient
    {
        /// <summary>
        /// Get Knowledge Base Evaluation<br/>
        /// Retrieve one evaluation: its lifecycle status, progress counts, the<br/>
        /// verdict breakdown and, once completed, its metrics.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseEvaluation> GetEvaluationAsync(
            string kbId,
            string evaluationId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Knowledge Base Evaluation<br/>
        /// Retrieve one evaluation: its lifecycle status, progress counts, the<br/>
        /// verdict breakdown and, once completed, its metrics.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.KnowledgeBaseEvaluation>> GetEvaluationAsResponseAsync(
            string kbId,
            string evaluationId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}