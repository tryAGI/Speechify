#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentTestsClient
    {
        /// <summary>
        /// Update Test Folder<br/>
        /// Rename or reparent a test folder. Cycles are rejected.
        /// </summary>
        /// <param name="testFolderId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTestFolder> UpdateTestFolderAsync(
            string testFolderId,

            global::Speechify.UpdateAgentTestFolderRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Test Folder<br/>
        /// Rename or reparent a test folder. Cycles are rejected.
        /// </summary>
        /// <param name="testFolderId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTestFolder>> UpdateTestFolderAsResponseAsync(
            string testFolderId,

            global::Speechify.UpdateAgentTestFolderRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Test Folder<br/>
        /// Rename or reparent a test folder. Cycles are rejected.
        /// </summary>
        /// <param name="testFolderId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="name"></param>
        /// <param name="parentFolderId">
        /// Prefixed wire identifier (`folder_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the folder to reparent this folder under.
        /// </param>
        /// <param name="clearParentFolderId">
        /// When `true`, reparents this folder to root (clears<br/>
        /// `parent_folder_id`). Wins over `parent_folder_id` when<br/>
        /// both are sent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTestFolder> UpdateTestFolderAsync(
            string testFolderId,
            string? speechifyVersion = default,
            string? name = default,
            string? parentFolderId = default,
            bool? clearParentFolderId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}