#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Create Crawl Import<br/>
        /// Kick off an async website crawl. Returns 202 with the import<br/>
        /// job row; client polls `GET /{id}/imports` for progress.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ImportJobResponse> CreateCrawlImportAsync(
            string id,

            global::Speechify.CreateCrawlImportRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Crawl Import<br/>
        /// Kick off an async website crawl. Returns 202 with the import<br/>
        /// job row; client polls `GET /{id}/imports` for progress.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ImportJobResponse>> CreateCrawlImportAsResponseAsync(
            string id,

            global::Speechify.CreateCrawlImportRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Crawl Import<br/>
        /// Kick off an async website crawl. Returns 202 with the import<br/>
        /// job row; client polls `GET /{id}/imports` for progress.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="url"></param>
        /// <param name="maxPages"></param>
        /// <param name="maxDepth"></param>
        /// <param name="folderId">
        /// Folder to import the documents into. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null/omitted = root.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ImportJobResponse> CreateCrawlImportAsync(
            string id,
            string url,
            string? speechifyVersion = default,
            int? maxPages = default,
            int? maxDepth = default,
            string? folderId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}