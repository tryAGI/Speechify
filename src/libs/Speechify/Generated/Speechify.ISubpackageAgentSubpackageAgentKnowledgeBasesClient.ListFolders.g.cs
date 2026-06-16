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
        /// The console builds the folder tree from `parent_folder_id`, so<br/>
        /// consumers should walk every page until `has_more` is `false`<br/>
        /// before rendering the tree.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListKnowledgeBaseFoldersResponse> ListFoldersAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Folders<br/>
        /// List folders inside a knowledge base. Root-level folders have<br/>
        /// `parent_folder_id: null`. Cursor-paginated: omit `cursor` to<br/>
        /// fetch the first page. Default page size is 50 and max is 200.<br/>
        /// The console builds the folder tree from `parent_folder_id`, so<br/>
        /// consumers should walk every page until `has_more` is `false`<br/>
        /// before rendering the tree.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListKnowledgeBaseFoldersResponse>> ListFoldersAsResponseAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}