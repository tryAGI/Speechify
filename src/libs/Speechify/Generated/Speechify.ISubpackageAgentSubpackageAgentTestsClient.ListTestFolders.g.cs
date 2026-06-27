#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentTestsClient
    {
        /// <summary>
        /// List Test Folders<br/>
        /// List every test folder the caller owns. Flat list; build the tree<br/>
        /// client-side. Cursor-paginated: omit `cursor` for the first page;<br/>
        /// walk pages while `has_more` is true (default page size 50, max 200).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListAgentTestFoldersResponse> ListTestFoldersAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Test Folders<br/>
        /// List every test folder the caller owns. Flat list; build the tree<br/>
        /// client-side. Cursor-paginated: omit `cursor` for the first page;<br/>
        /// walk pages while `has_more` is true (default page size 50, max 200).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListAgentTestFoldersResponse>> ListTestFoldersAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}