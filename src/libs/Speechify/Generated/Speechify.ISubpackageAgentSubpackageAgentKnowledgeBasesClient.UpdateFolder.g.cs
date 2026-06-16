#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Update Folder<br/>
        /// Update a folder. Pass `parent_folder_id: null` to move to<br/>
        /// root; omit the field to leave it unchanged.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="folderId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseFolder> UpdateFolderAsync(
            string id,
            string folderId,

            global::Speechify.UpdateFolderRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Folder<br/>
        /// Update a folder. Pass `parent_folder_id: null` to move to<br/>
        /// root; omit the field to leave it unchanged.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="folderId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.KnowledgeBaseFolder>> UpdateFolderAsResponseAsync(
            string id,
            string folderId,

            global::Speechify.UpdateFolderRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Folder<br/>
        /// Update a folder. Pass `parent_folder_id: null` to move to<br/>
        /// root; omit the field to leave it unchanged.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="folderId"></param>
        /// <param name="name"></param>
        /// <param name="parentFolderId">
        /// Folder to reparent under. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="clearParentFolderId">
        /// When `true`, moves the folder to root (clears<br/>
        /// `parent_folder_id`). Wins over `parent_folder_id` when both<br/>
        /// are sent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseFolder> UpdateFolderAsync(
            string id,
            string folderId,
            string? name = default,
            string? parentFolderId = default,
            bool? clearParentFolderId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}