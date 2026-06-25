#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// List Agent Tools<br/>
        /// List everything this agent can do: built-in capabilities and<br/>
        /// attached external tool definitions (webhook / client / MCP) in<br/>
        /// one mixed-kind list. Each item carries its resolved config inline.<br/>
        /// Bare list — an agent's tool count is bounded by configuration, so<br/>
        /// this endpoint does not paginate.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListAgentToolsResponse> ListToolsAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Tools<br/>
        /// List everything this agent can do: built-in capabilities and<br/>
        /// attached external tool definitions (webhook / client / MCP) in<br/>
        /// one mixed-kind list. Each item carries its resolved config inline.<br/>
        /// Bare list — an agent's tool count is bounded by configuration, so<br/>
        /// this endpoint does not paginate.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListAgentToolsResponse>> ListToolsAsResponseAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}