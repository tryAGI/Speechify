#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// List Agent Tools<br/>
        /// List tools currently attached to the agent. Bare list — an<br/>
        /// agent's tool attachment count is bounded by configuration, so<br/>
        /// this endpoint does not paginate.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AttachedToolsResponse> ListToolsAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Tools<br/>
        /// List tools currently attached to the agent. Bare list — an<br/>
        /// agent's tool attachment count is bounded by configuration, so<br/>
        /// this endpoint does not paginate.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AttachedToolsResponse>> ListToolsAsResponseAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}