
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/tool-definitions/test-mcp-connection`. `config` is the<br/>
    /// same MCPToolConfig shape `POST /v1/agents/tool-definitions` would persist; nothing<br/>
    /// is persisted by the probe itself. For a non-none auth, the server<br/>
    /// resolves `auth.credential_id` to the vault secret before probing —<br/>
    /// the credential is created up front via `POST /v1/credentials`, so it<br/>
    /// resolves independently of any tool.
    /// </summary>
    public sealed partial class TestMCPConnectionRequest
    {
        /// <summary>
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
        /// run, its agent and the person it acts for from the id alone.<br/>
        /// Every request of a tool-call session also carries<br/>
        /// `Speechify-Conversation-Id`, naming the unit of work on Speechify's<br/>
        /// side the call belongs to, so you can trace one end to end: we hold<br/>
        /// the question, your server holds the tool calls, and this is the<br/>
        /// join. On a voice, text or Slack conversation it is the<br/>
        /// conversation's `conv_…` id, set once when the session opens so its<br/>
        /// handshake carries it too, and<br/>
        /// `GET /v1/agents/conversations/{conversation_id}` resolves it. A<br/>
        /// durable run has no conversation, so each tool call sends the run's<br/>
        /// `arun_…` id instead, the same id that prefixes<br/>
        /// `Speechify-Idempotency-Key`. The prefix says which you were sent.<br/>
        /// The tool discovery a durable run performs before a step<br/>
        /// (`initialize` + `tools/list`, no `tools/call`) is the one request<br/>
        /// without it: its result is reused across runs, so it names no run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.MCPToolConfig Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestMCPConnectionRequest" /> class.
        /// </summary>
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
        /// run, its agent and the person it acts for from the id alone.<br/>
        /// Every request of a tool-call session also carries<br/>
        /// `Speechify-Conversation-Id`, naming the unit of work on Speechify's<br/>
        /// side the call belongs to, so you can trace one end to end: we hold<br/>
        /// the question, your server holds the tool calls, and this is the<br/>
        /// join. On a voice, text or Slack conversation it is the<br/>
        /// conversation's `conv_…` id, set once when the session opens so its<br/>
        /// handshake carries it too, and<br/>
        /// `GET /v1/agents/conversations/{conversation_id}` resolves it. A<br/>
        /// durable run has no conversation, so each tool call sends the run's<br/>
        /// `arun_…` id instead, the same id that prefixes<br/>
        /// `Speechify-Idempotency-Key`. The prefix says which you were sent.<br/>
        /// The tool discovery a durable run performs before a step<br/>
        /// (`initialize` + `tools/list`, no `tools/call`) is the one request<br/>
        /// without it: its result is reused across runs, so it names no run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestMCPConnectionRequest(
            global::Speechify.MCPToolConfig config)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestMCPConnectionRequest" /> class.
        /// </summary>
        public TestMCPConnectionRequest()
        {
        }

    }
}