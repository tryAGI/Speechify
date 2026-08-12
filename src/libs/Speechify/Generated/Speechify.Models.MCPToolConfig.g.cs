
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Config shape for `kind=mcp`. The worker opens the<br/>
    /// configured transport at session start, runs `initialize` +<br/>
    /// `list_tools`, and registers each discovered remote tool as a<br/>
    /// livekit-agents function_tool proxying through the long-lived<br/>
    /// ClientSession.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolConfig(
            string endpoint,
            global::Speechify.MCPAuth auth,
            global::Speechify.MCPTransport? transport,
            global::Speechify.LongRunningToolConfig? longRunning)
        {
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Transport = transport;
            this.Auth = auth;
            this.LongRunning = longRunning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfig" /> class.
        /// </summary>
        public MCPToolConfig()
        {
        }

    }
}