#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentToolDefinitionsClient
    {
        /// <summary>
        /// List Tools<br/>
        /// List tools in the caller's workspace, most recently updated<br/>
        /// first. Cursor-paginated: omit `cursor` to fetch the first page.<br/>
        /// Default page size is 50 and max is 200. Walk pages while<br/>
        /// `has_more` is true.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListToolsResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tools<br/>
        /// List tools in the caller's workspace, most recently updated<br/>
        /// first. Cursor-paginated: omit `cursor` to fetch the first page.<br/>
        /// Default page size is 50 and max is 200. Walk pages while<br/>
        /// `has_more` is true.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListToolsResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}