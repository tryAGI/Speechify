
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/tools/test-mcp-connection`. `config` is the<br/>
    /// same MCPToolConfig shape `POST /v1/agents/tools` would persist; nothing<br/>
    /// is persisted by the probe itself. `tool_id` is only meaningful<br/>
    /// in the edit-form flow — when set, the server hydrates stored<br/>
    /// bearer / oauth2 secrets from the encrypted column before<br/>
    /// probing, so customers can hit "Test Connection" on an existing<br/>
    /// tool without re-typing the secret.
    /// </summary>
    public sealed partial class TtsTestMCPConnectionRequest
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
        public required global::Speechify.TtsMCPToolConfig Config { get; set; }

        /// <summary>
        /// Optional `tool_&lt;crockford&gt;` id of the existing tool to hydrate<br/>
        /// stored secrets from. Raw UUIDs and other-resource prefixes are<br/>
        /// rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        public string? ToolId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTestMCPConnectionRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsTestMCPConnectionRequest(
            global::Speechify.TtsMCPToolConfig config,
            string? toolId)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.ToolId = toolId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTestMCPConnectionRequest" /> class.
        /// </summary>
        public TtsTestMCPConnectionRequest()
        {
        }

    }
}