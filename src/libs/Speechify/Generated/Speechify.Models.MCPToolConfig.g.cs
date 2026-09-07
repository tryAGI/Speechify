
#nullable enable

namespace Speechify
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
    /// run, its agent and the person it acts for from the id alone.
    /// </summary>
    public sealed partial class MCPToolConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// MCP transport. `http_streamable` is the default; `sse` is the<br/>
        /// legacy fallback for servers that haven't migrated yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.MCPTransportJsonConverter))]
        public global::Speechify.MCPTransport? Transport { get; set; }

        /// <summary>
        /// Discriminated union over `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.MCPAuthJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.MCPAuth Auth { get; set; }

        /// <summary>
        /// Declares the SERVER slow. Applies to every remote tool the<br/>
        /// `list_tools` handshake discovers on it — MCP publishes no<br/>
        /// per-tool latency signal at config time, so this describes the<br/>
        /// server rather than one of its verbs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("long_running")]
        public global::Speechify.LongRunningToolConfig? LongRunning { get; set; }

        /// <summary>
        /// What each of the server's own tools does, keyed by the remote tool<br/>
        /// name. One MCP tool is a whole server of mixed verbs, so without<br/>
        /// this the server carries a single impact and an autonomous run<br/>
        /// either treats its writes as safe or stops for a human on its<br/>
        /// lookups. Classify the lookups `read` and they run unattended.<br/>
        /// A tool you do not name here keeps the server-level class, which is<br/>
        /// deliberately the cautious one. An explicit server-level `approval`<br/>
        /// still wins over everything here, so gating a whole server stays a<br/>
        /// single switch you can trust.<br/>
        /// Your server can also classify its own tools: a `tools/list` entry<br/>
        /// carrying `_meta: {"speechify/action_class": "communicate_external"}`<br/>
        /// declares that tool's impact. The declaration is honoured under the<br/>
        /// ceiling set by the tool definition's `action_class`: a declared<br/>
        /// class at least as strong as the definition's is used, a weaker one<br/>
        /// is held to the definition's, and an unclassified definition<br/>
        /// (`irreversible_other`) makes every declaration moot. So one server<br/>
        /// with `action_class: read` runs its reads unattended and parks a run<br/>
        /// on the tool it declared `communicate_external`, with no second<br/>
        /// server and no entry here. What you declare here beats what the<br/>
        /// server declares.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_classes")]
        public global::System.Collections.Generic.Dictionary<string, global::Speechify.ToolActionClass>? ActionClasses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfig" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="auth">
        /// Discriminated union over `type`.
        /// </param>
        /// <param name="transport">
        /// MCP transport. `http_streamable` is the default; `sse` is the<br/>
        /// legacy fallback for servers that haven't migrated yet.
        /// </param>
        /// <param name="longRunning">
        /// Declares the SERVER slow. Applies to every remote tool the<br/>
        /// `list_tools` handshake discovers on it — MCP publishes no<br/>
        /// per-tool latency signal at config time, so this describes the<br/>
        /// server rather than one of its verbs.
        /// </param>
        /// <param name="actionClasses">
        /// What each of the server's own tools does, keyed by the remote tool<br/>
        /// name. One MCP tool is a whole server of mixed verbs, so without<br/>
        /// this the server carries a single impact and an autonomous run<br/>
        /// either treats its writes as safe or stops for a human on its<br/>
        /// lookups. Classify the lookups `read` and they run unattended.<br/>
        /// A tool you do not name here keeps the server-level class, which is<br/>
        /// deliberately the cautious one. An explicit server-level `approval`<br/>
        /// still wins over everything here, so gating a whole server stays a<br/>
        /// single switch you can trust.<br/>
        /// Your server can also classify its own tools: a `tools/list` entry<br/>
        /// carrying `_meta: {"speechify/action_class": "communicate_external"}`<br/>
        /// declares that tool's impact. The declaration is honoured under the<br/>
        /// ceiling set by the tool definition's `action_class`: a declared<br/>
        /// class at least as strong as the definition's is used, a weaker one<br/>
        /// is held to the definition's, and an unclassified definition<br/>
        /// (`irreversible_other`) makes every declaration moot. So one server<br/>
        /// with `action_class: read` runs its reads unattended and parks a run<br/>
        /// on the tool it declared `communicate_external`, with no second<br/>
        /// server and no entry here. What you declare here beats what the<br/>
        /// server declares.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolConfig(
            string endpoint,
            global::Speechify.MCPAuth auth,
            global::Speechify.MCPTransport? transport,
            global::Speechify.LongRunningToolConfig? longRunning,
            global::System.Collections.Generic.Dictionary<string, global::Speechify.ToolActionClass>? actionClasses)
        {
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Transport = transport;
            this.Auth = auth;
            this.LongRunning = longRunning;
            this.ActionClasses = actionClasses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfig" /> class.
        /// </summary>
        public MCPToolConfig()
        {
        }

    }
}