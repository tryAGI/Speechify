#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentToolDefinitionsClient
    {
        /// <summary>
        /// Test MCP Connection<br/>
        /// Probe a customer-supplied MCP server config without persisting<br/>
        /// anything. The server opens the configured transport, runs the<br/>
        /// `initialize` + `list_tools` handshake, and returns either the<br/>
        /// discovered tool catalogue or a structured error string. Pass<br/>
        /// `tool_id` from the edit-form flow when the auth payload carries<br/>
        /// `_set` markers but no plaintext, so the server can hydrate the<br/>
        /// stored secret from the encrypted column before probing.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.MCPProbeResult> TestMcpConnectionAsync(

            global::Speechify.TestMCPConnectionRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test MCP Connection<br/>
        /// Probe a customer-supplied MCP server config without persisting<br/>
        /// anything. The server opens the configured transport, runs the<br/>
        /// `initialize` + `list_tools` handshake, and returns either the<br/>
        /// discovered tool catalogue or a structured error string. Pass<br/>
        /// `tool_id` from the edit-form flow when the auth payload carries<br/>
        /// `_set` markers but no plaintext, so the server can hydrate the<br/>
        /// stored secret from the encrypted column before probing.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.MCPProbeResult>> TestMcpConnectionAsResponseAsync(

            global::Speechify.TestMCPConnectionRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test MCP Connection<br/>
        /// Probe a customer-supplied MCP server config without persisting<br/>
        /// anything. The server opens the configured transport, runs the<br/>
        /// `initialize` + `list_tools` handshake, and returns either the<br/>
        /// discovered tool catalogue or a structured error string. Pass<br/>
        /// `tool_id` from the edit-form flow when the auth payload carries<br/>
        /// `_set` markers but no plaintext, so the server can hydrate the<br/>
        /// stored secret from the encrypted column before probing.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="config">
        /// Config shape for `kind=mcp`. The worker opens the<br/>
        /// configured transport at session start, runs `initialize` +<br/>
        /// `list_tools`, and registers each discovered remote tool as a<br/>
        /// livekit-agents function_tool proxying through the long-lived<br/>
        /// ClientSession.
        /// </param>
        /// <param name="toolId">
        /// Optional `tool_&lt;crockford&gt;` id of the existing tool to hydrate<br/>
        /// stored secrets from. Raw UUIDs and other-resource prefixes are<br/>
        /// rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.MCPProbeResult> TestMcpConnectionAsync(
            global::Speechify.MCPToolConfig config,
            string? speechifyVersion = default,
            string? toolId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}