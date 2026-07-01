#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Create URL Document<br/>
        /// Fetch a URL via Firecrawl and ingest the rendered content as a<br/>
        /// document. The fetch happens synchronously; expect a few<br/>
        /// seconds per page. Use the sitemap / crawl endpoints for<br/>
        /// multi-page imports.
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
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseDocument> CreateUrlDocumentAsync(
            string kbId,

            global::Speechify.CreateURLDocumentRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create URL Document<br/>
        /// Fetch a URL via Firecrawl and ingest the rendered content as a<br/>
        /// document. The fetch happens synchronously; expect a few<br/>
        /// seconds per page. Use the sitemap / crawl endpoints for<br/>
        /// multi-page imports.
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.KnowledgeBaseDocument>> CreateUrlDocumentAsResponseAsync(
            string kbId,

            global::Speechify.CreateURLDocumentRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create URL Document<br/>
        /// Fetch a URL via Firecrawl and ingest the rendered content as a<br/>
        /// document. The fetch happens synchronously; expect a few<br/>
        /// seconds per page. Use the sitemap / crawl endpoints for<br/>
        /// multi-page imports.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="url"></param>
        /// <param name="folderId">
        /// Folder to drop the document into. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null/omitted = root.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseDocument> CreateUrlDocumentAsync(
            string kbId,
            string url,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? folderId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}