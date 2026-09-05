#nullable enable

namespace Speechify
{
    public partial interface IKnowledgeBasesClient
    {
        /// <summary>
        /// Create Evaluation Case<br/>
        /// Add a labelled question: the documents that answer it, or<br/>
        /// `unanswerable` when nothing in the knowledge base should. Every<br/>
        /// expected document must belong to this knowledge base. A knowledge<br/>
        /// base holds at most 500 cases.
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
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseEvalCase> CreateEvalCaseAsync(
            string kbId,

            global::Speechify.CreateKnowledgeBaseEvalCaseRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Evaluation Case<br/>
        /// Add a labelled question: the documents that answer it, or<br/>
        /// `unanswerable` when nothing in the knowledge base should. Every<br/>
        /// expected document must belong to this knowledge base. A knowledge<br/>
        /// base holds at most 500 cases.
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.KnowledgeBaseEvalCase>> CreateEvalCaseAsResponseAsync(
            string kbId,

            global::Speechify.CreateKnowledgeBaseEvalCaseRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Evaluation Case<br/>
        /// Add a labelled question: the documents that answer it, or<br/>
        /// `unanswerable` when nothing in the knowledge base should. Every<br/>
        /// expected document must belong to this knowledge base. A knowledge<br/>
        /// base holds at most 500 cases.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="query"></param>
        /// <param name="expectedDocumentIds">
        /// Required unless `unanswerable`; every id must belong to this knowledge base.
        /// </param>
        /// <param name="unanswerable">
        /// Default Value: false
        /// </param>
        /// <param name="note"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseEvalCase> CreateEvalCaseAsync(
            string kbId,
            string query,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::System.Collections.Generic.IList<string>? expectedDocumentIds = default,
            bool? unanswerable = default,
            string? note = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}