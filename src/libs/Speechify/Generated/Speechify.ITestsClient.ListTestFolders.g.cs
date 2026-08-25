#nullable enable

namespace Speechify
{
    public partial interface ITestsClient
    {
        /// <summary>
        /// List Test Folders<br/>
        /// List every test folder the caller owns. Flat list; build the tree<br/>
        /// client-side. Cursor-paginated: omit `cursor` for the first page;<br/>
        /// walk pages while `has_more` is true (default page size 50, max 200).<br/>
        /// Folders are workspace-wide, so `project_id` never hides a folder:<br/>
        /// it narrows each folder's `test_count` to the tests that project<br/>
        /// scope admits, the same rows `GET /v1/agents/tests?folder_id=&lt;id&gt;`<br/>
        /// lists under that scope, while `total_test_count` counts what the<br/>
        /// caller could see with no filter (pin and grants still apply).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListAgentTestFoldersResponse> ListTestFoldersAsync(
            string? projectId = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Test Folders<br/>
        /// List every test folder the caller owns. Flat list; build the tree<br/>
        /// client-side. Cursor-paginated: omit `cursor` for the first page;<br/>
        /// walk pages while `has_more` is true (default page size 50, max 200).<br/>
        /// Folders are workspace-wide, so `project_id` never hides a folder:<br/>
        /// it narrows each folder's `test_count` to the tests that project<br/>
        /// scope admits, the same rows `GET /v1/agents/tests?folder_id=&lt;id&gt;`<br/>
        /// lists under that scope, while `total_test_count` counts what the<br/>
        /// caller could see with no filter (pin and grants still apply).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListAgentTestFoldersResponse>> ListTestFoldersAsResponseAsync(
            string? projectId = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}