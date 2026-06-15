#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsToolsClient
    {
        /// <summary>
        /// Create Tool<br/>
        /// Create a tool. For webhook tools, the response includes the HMAC<br/>
        /// `webhook_secret` exactly once — store it immediately; subsequent<br/>
        /// reads return a masked placeholder.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsTool> CreateAsync(

            global::Speechify.TtsCreateToolRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool<br/>
        /// Create a tool. For webhook tools, the response includes the HMAC<br/>
        /// `webhook_secret` exactly once — store it immediately; subsequent<br/>
        /// reads return a masked placeholder.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsTool>> CreateAsResponseAsync(

            global::Speechify.TtsCreateToolRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool<br/>
        /// Create a tool. For webhook tools, the response includes the HMAC<br/>
        /// `webhook_secret` exactly once — store it immediately; subsequent<br/>
        /// reads return a masked placeholder.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="kind">
        /// Where the tool executes.<br/>
        /// - `system`:  worker-resident built-in (e.g. end_call, play_audio)<br/>
        /// - `webhook`: worker signs a payload and POSTs it to your URL<br/>
        /// - `client`:  worker dispatches to the caller's browser/SDK via data channel<br/>
        /// - `mcp`:     worker connects to a customer-hosted MCP server and proxies tool calls
        /// </param>
        /// <param name="config"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsTool> CreateAsync(
            string name,
            string description,
            global::Speechify.TtsToolKind kind,
            global::Speechify.TtsCreateToolRequestConfig config,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}