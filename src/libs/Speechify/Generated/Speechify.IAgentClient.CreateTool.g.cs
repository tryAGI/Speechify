#nullable enable

namespace Speechify
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Create Agent Tool<br/>
        /// Add a tool to the agent. With `kind=builtin` this creates a<br/>
        /// per-agent built-in instance (e.g. `end_call`, `play_audio`); the<br/>
        /// `builtin` capability name comes from `config.builtin`. With<br/>
        /// `kind=webhook`, `client`, or `mcp` this atomically creates a<br/>
        /// workspace tool definition AND attaches it to the agent in one<br/>
        /// call. To attach a definition that already exists, use<br/>
        /// `PUT /v1/agents/{agent_id}/tools/{tool_id}` instead.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTool> CreateToolAsync(
            string agentId,

            global::Speechify.CreateAgentToolRequest request,
            string? speechifyVersion = default,
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
        /// `PUT /v1/agents/{agent_id}/tools/{tool_id}` instead.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentTool>> CreateToolAsResponseAsync(
            string agentId,

            global::Speechify.CreateAgentToolRequest request,
            string? speechifyVersion = default,
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
        /// `PUT /v1/agents/{agent_id}/tools/{tool_id}` instead.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
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
        /// <param name="actionClass">
        /// The impact class for a shared kind (`webhook`/`client`/`mcp`),<br/>
        /// whose definition is created here. Omitted, the server stamps the<br/>
        /// verb default. Ignored for a built-in, whose class the platform fixes.
        /// </param>
        /// <param name="approval">
        /// Overrides the approval derived from the class, for a shared kind.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentTool> CreateToolAsync(
            string agentId,
            global::Speechify.ToolKind kind,
            string name,
            global::Speechify.CreateAgentToolRequestConfig config,
            string? speechifyVersion = default,
            string? description = default,
            bool? enabled = default,
            global::Speechify.ToolActionClass? actionClass = default,
            global::Speechify.ToolApprovalClass? approval = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}