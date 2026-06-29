#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// List Folders<br/>
        /// List folders inside a knowledge base. Root-level folders have<br/>
        /// `parent_folder_id: null`. Cursor-paginated: omit `cursor` to<br/>
        /// fetch the first page. Default page size is 50 and max is 200.<br/>
        /// Build the folder tree from `parent_folder_id`, so consumers<br/>
        /// should walk every page until `has_more` is `false` before<br/>
        /// rendering the tree.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListKnowledgeBaseFoldersResponse> ListFoldersAsync(
            string kbId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Folders<br/>
        /// List folders inside a knowledge base. Root-level folders have<br/>
        /// `parent_folder_id: null`. Cursor-paginated: omit `cursor` to<br/>
        /// fetch the first page. Default page size is 50 and max is 200.<br/>
        /// Build the folder tree from `parent_folder_id`, so consumers<br/>
        /// should walk every page until `has_more` is `false` before<br/>
        /// rendering the tree.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListKnowledgeBaseFoldersResponse>> ListFoldersAsResponseAsync(
            string kbId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}