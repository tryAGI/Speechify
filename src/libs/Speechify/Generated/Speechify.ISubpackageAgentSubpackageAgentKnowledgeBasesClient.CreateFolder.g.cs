#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Create Folder<br/>
        /// Create a folder inside a knowledge base.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseFolder> CreateFolderAsync(
            string id,

            global::Speechify.CreateFolderRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Folder<br/>
        /// Create a folder inside a knowledge base.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.KnowledgeBaseFolder>> CreateFolderAsResponseAsync(
            string id,

            global::Speechify.CreateFolderRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Folder<br/>
        /// Create a folder inside a knowledge base.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="parentFolderId">
        /// Parent folder. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null/omitted creates a<br/>
        /// root-level folder.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseFolder> CreateFolderAsync(
            string id,
            string name,
            string? parentFolderId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}