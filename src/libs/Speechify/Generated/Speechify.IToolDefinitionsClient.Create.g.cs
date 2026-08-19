#nullable enable

namespace Speechify
{
    public partial interface IToolDefinitionsClient
    {
        /// <summary>
        /// Create Tool<br/>
        /// Create a tool. For webhook tools, the response includes the HMAC<br/>
        /// `webhook_secret` exactly once — store it immediately; subsequent<br/>
        /// reads return a masked placeholder.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Tool> CreateAsync(

            global::Speechify.CreateToolRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool<br/>
        /// Create a tool. For webhook tools, the response includes the HMAC<br/>
        /// `webhook_secret` exactly once — store it immediately; subsequent<br/>
        /// reads return a masked placeholder.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Tool>> CreateAsResponseAsync(

            global::Speechify.CreateToolRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool<br/>
        /// Create a tool. For webhook tools, the response includes the HMAC<br/>
        /// `webhook_secret` exactly once — store it immediately; subsequent<br/>
        /// reads return a masked placeholder.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="projectId">
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="kind">
        /// What kind of tool this is, and where it executes.<br/>
        /// - `builtin`: a worker-resident platform capability (e.g. end_call, play_audio), configured per-agent<br/>
        /// - `webhook`: worker signs a payload and POSTs it to your URL<br/>
        /// - `client`:  worker dispatches to the caller's browser/SDK via data channel<br/>
        /// - `mcp`:     worker connects to a customer-hosted MCP server and proxies tool calls
        /// </param>
        /// <param name="config"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Tool> CreateAsync(
            string name,
            string description,
            global::Speechify.ToolKind kind,
            global::Speechify.CreateToolRequestConfig config,
            string? speechifyVersion = default,
            string? projectId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}