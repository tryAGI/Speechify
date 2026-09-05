#nullable enable

namespace Speechify
{
    public partial interface IKnowledgeBasesClient
    {
        /// <summary>
        /// Start Knowledge Base Evaluation<br/>
        /// Run every case against the live retrieval pipeline. Returns 202 with<br/>
        /// the evaluation; poll `GET /{kb_id}/evaluations/{evaluation_id}` until<br/>
        /// its `status` is terminal, then read the metrics on it and the per-case<br/>
        /// outcomes from `/results`. Each case is one search the workspace pays<br/>
        /// for, so the same spend limits as a search apply.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseEvaluation> StartEvaluationAsync(
            string kbId,

            global::Speechify.StartKnowledgeBaseEvaluationRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Knowledge Base Evaluation<br/>
        /// Run every case against the live retrieval pipeline. Returns 202 with<br/>
        /// the evaluation; poll `GET /{kb_id}/evaluations/{evaluation_id}` until<br/>
        /// its `status` is terminal, then read the metrics on it and the per-case<br/>
        /// outcomes from `/results`. Each case is one search the workspace pays<br/>
        /// for, so the same spend limits as a search apply.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.KnowledgeBaseEvaluation>> StartEvaluationAsResponseAsync(
            string kbId,

            global::Speechify.StartKnowledgeBaseEvaluationRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Knowledge Base Evaluation<br/>
        /// Run every case against the live retrieval pipeline. Returns 202 with<br/>
        /// the evaluation; poll `GET /{kb_id}/evaluations/{evaluation_id}` until<br/>
        /// its `status` is terminal, then read the metrics on it and the per-case<br/>
        /// outcomes from `/results`. Each case is one search the workspace pays<br/>
        /// for, so the same spend limits as a search apply.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="topK">
        /// How many passages each search returns; the metrics are computed at this depth.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseEvaluation> StartEvaluationAsync(
            string kbId,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            int? topK = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}