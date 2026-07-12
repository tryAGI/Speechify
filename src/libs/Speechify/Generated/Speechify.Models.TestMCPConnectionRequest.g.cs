
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
        /// ClientSession.
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
        /// ClientSession.
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