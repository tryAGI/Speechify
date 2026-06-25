#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// Create Agent Tool<br/>
        /// Add a tool to the agent. With `kind=builtin` this creates a<br/>
        /// per-agent built-in instance (e.g. `end_call`, `play_audio`); the<br/>
        /// `builtin` capability name comes from `config.builtin`. With<br/>
        /// `kind=webhook`, `client`, or `mcp` this atomically creates a<br/>
        /// workspace tool definition AND attaches it to the agent in one<br/>
        /// call. To attach a definition that already exists, use<br/>
        /// `PUT /v1/agents/{id}/tools/{toolId}` instead.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTool> CreateToolAsync(
            string id,

            global::Speechify.CreateAgentToolRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Tool<br/>
        /// Add a tool to the agent. With `kind=builtin` this creates a<br/>
        /// per-agent built-in instance (e.g. `end_call`, `play_audio`); the<br/>
        /// `builtin` capability name comes from `config.builtin`. With<br/>
        /// `kind=webhook`, `client`, or `mcp` this atomically creates a<br/>
        /// workspace tool definition AND attaches it to the agent in one<br/>
        /// call. To attach a definition that already exists, use<br/>
        /// `PUT /v1/agents/{id}/tools/{toolId}` instead.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTool>> CreateToolAsResponseAsync(
            string id,

            global::Speechify.CreateAgentToolRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Tool<br/>
        /// Add a tool to the agent. With `kind=builtin` this creates a<br/>
        /// per-agent built-in instance (e.g. `end_call`, `play_audio`); the<br/>
        /// `builtin` capability name comes from `config.builtin`. With<br/>
        /// `kind=webhook`, `client`, or `mcp` this atomically creates a<br/>
        /// workspace tool definition AND attaches it to the agent in one<br/>
        /// call. To attach a definition that already exists, use<br/>
        /// `PUT /v1/agents/{id}/tools/{toolId}` instead.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="kind">
        /// What kind of tool this is, and where it executes.<br/>
        /// - `builtin`: a worker-resident platform capability (e.g. end_call, play_audio), configured per-agent<br/>
        /// - `webhook`: worker signs a payload and POSTs it to your URL<br/>
        /// - `client`:  worker dispatches to the caller's browser/SDK via data channel<br/>
        /// - `mcp`:     worker connects to a customer-hosted MCP server and proxies tool calls
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="enabled">
        /// Defaults to true on the server when omitted.
        /// </param>
        /// <param name="config"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTool> CreateToolAsync(
            string id,
            global::Speechify.ToolKind kind,
            string name,
            global::Speechify.CreateAgentToolRequestConfig config,
            string? description = default,
            bool? enabled = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}