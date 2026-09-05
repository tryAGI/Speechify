#nullable enable

namespace Speechify
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List Teams<br/>
        /// List the teams in the caller's workspace, most recently updated<br/>
        /// first. Cursor-paginated: omit `cursor` to fetch the first page.<br/>
        /// Default page size is 50 and max is 200. Walk pages while `has_more`<br/>
        /// is true.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListTeamsResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Teams<br/>
        /// List the teams in the caller's workspace, most recently updated<br/>
        /// first. Cursor-paginated: omit `cursor` to fetch the first page.<br/>
        /// Default page size is 50 and max is 200. Walk pages while `has_more`<br/>
        /// is true.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListTeamsResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}