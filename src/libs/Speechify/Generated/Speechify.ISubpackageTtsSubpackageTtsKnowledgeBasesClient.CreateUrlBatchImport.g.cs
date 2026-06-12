#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsKnowledgeBasesClient
    {
        /// <summary>
        /// Create Multi-URL Import<br/>
        /// Kick off an async multi-URL import. Accepts 1..N URLs in a<br/>
        /// single job (capped per-deployment, default 50) and runs the<br/>
        /// same per-URL pipeline as the sitemap worker. Returns 202 with<br/>
        /// the import job row; client polls `GET /{id}/imports` for<br/>
        /// progress.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsImportJobResponse> CreateUrlBatchImportAsync(
            string id,

            global::Speechify.TtsCreateURLBatchImportRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Multi-URL Import<br/>
        /// Kick off an async multi-URL import. Accepts 1..N URLs in a<br/>
        /// single job (capped per-deployment, default 50) and runs the<br/>
        /// same per-URL pipeline as the sitemap worker. Returns 202 with<br/>
        /// the import job row; client polls `GET /{id}/imports` for<br/>
        /// progress.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsImportJobResponse>> CreateUrlBatchImportAsResponseAsync(
            string id,

            global::Speechify.TtsCreateURLBatchImportRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Multi-URL Import<br/>
        /// Kick off an async multi-URL import. Accepts 1..N URLs in a<br/>
        /// single job (capped per-deployment, default 50) and runs the<br/>
        /// same per-URL pipeline as the sitemap worker. Returns 202 with<br/>
        /// the import job row; client polls `GET /{id}/imports` for<br/>
        /// progress.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="urls"></param>
        /// <param name="folderId">
        /// Folder to import the documents into. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null/omitted = root.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsImportJobResponse> CreateUrlBatchImportAsync(
            string id,
            global::System.Collections.Generic.IList<string> urls,
            string? folderId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}