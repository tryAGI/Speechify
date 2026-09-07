#nullable enable

namespace Speechify
{
    public partial interface IToolDefinitionsClient
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
        global::System.Threading.Tasks.Task<global::Speechify.MCPProbeResult> TestMCPConnectionAsync(

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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.MCPProbeResult>> TestMCPConnectionAsResponseAsync(

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
        /// ClientSession.<br/>
        /// On a durable run (`POST /v1/agents/{agent_id}/runs`) every request to<br/>
        /// your server carries a `Speechify-User-Identity` header holding the<br/>
        /// person the agent is acting for, exactly as your application supplied<br/>
        /// it when it started the run. This is what lets a server you wrote hold<br/>
        /// your users' third-party credentials and act for the right one; the<br/>
        /// header is absent when the run is acting for nobody. It is a header<br/>
        /// rather than a body field because MCP owns its own JSON-RPC envelope,<br/>
        /// so trust it exactly as far as you trust the connection your server<br/>
        /// already authenticated. Voice conversations and sessions do not carry<br/>
        /// it yet.<br/>
        /// Every request also carries `Speechify-Idempotency-Key`, stable for one<br/>
        /// step of one run and identical to the `Idempotency-Key` a webhook tool<br/>
        /// receives. A durable run is retried if the platform redelivers it, so a<br/>
        /// tool that sends mail or takes payment can be called more than once for<br/>
        /// the same decision: key on this header and refuse to act twice. One<br/>
        /// connector serving both transports dedups on one identifier. The key<br/>
        /// is `&lt;run_id&gt;:&lt;step&gt;`, and `GET /v1/agents/runs/{run_id}` resolves the<br/>
        /// run, its agent and the person it acts for from the id alone.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.MCPProbeResult> TestMCPConnectionAsync(
            global::Speechify.MCPToolConfig config,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}