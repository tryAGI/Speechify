#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Create Multi-URL Import<br/>
        /// Kick off an async multi-URL import. Accepts 1..N URLs in a<br/>
        /// single job (capped per-deployment, default 50) and runs the<br/>
        /// same per-URL pipeline as the sitemap importer. Returns 202 with<br/>
        /// the import job row; client polls `GET /{kb_id}/imports` for<br/>
        /// progress.
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
        global::System.Threading.Tasks.Task<global::Speechify.ImportJob> CreateUrlBatchImportAsync(
            string kbId,

            global::Speechify.CreateURLBatchImportRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Multi-URL Import<br/>
        /// Kick off an async multi-URL import. Accepts 1..N URLs in a<br/>
        /// single job (capped per-deployment, default 50) and runs the<br/>
        /// same per-URL pipeline as the sitemap importer. Returns 202 with<br/>
        /// the import job row; client polls `GET /{kb_id}/imports` for<br/>
        /// progress.
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ImportJob>> CreateUrlBatchImportAsResponseAsync(
            string kbId,

            global::Speechify.CreateURLBatchImportRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Multi-URL Import<br/>
        /// Kick off an async multi-URL import. Accepts 1..N URLs in a<br/>
        /// single job (capped per-deployment, default 50) and runs the<br/>
        /// same per-URL pipeline as the sitemap importer. Returns 202 with<br/>
        /// the import job row; client polls `GET /{kb_id}/imports` for<br/>
        /// progress.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="urls"></param>
        /// <param name="folderId">
        /// Folder to import the documents into. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null/omitted = root.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ImportJob> CreateUrlBatchImportAsync(
            string kbId,
            global::System.Collections.Generic.IList<string> urls,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? folderId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}