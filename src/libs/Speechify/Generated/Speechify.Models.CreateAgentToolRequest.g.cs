
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Add a tool to an agent. With `kind=builtin`, `config` carries a<br/>
    /// `BuiltinToolConfig` and a per-agent built-in instance is created.<br/>
    /// With `kind=webhook`/`client`/`mcp`, `config` carries that kind's<br/>
    /// config and a workspace definition is created AND attached in one<br/>
    /// call.
    /// </summary>
    public sealed partial class CreateAgentToolRequest
    {
        /// <summary>
        /// What kind of tool this is, and where it executes.<br/>
        /// - `builtin`: a worker-resident platform capability (e.g. end_call, play_audio), configured per-agent<br/>
        /// - `webhook`: worker signs a payload and POSTs it to your URL<br/>
        /// - `client`:  worker dispatches to the caller's browser/SDK via data channel<br/>
        /// - `mcp`:     worker connects to a customer-hosted MCP server and proxies tool calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ToolKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ToolKind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Defaults to true on the server when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.CreateAgentToolRequestConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.CreateAgentToolRequestConfig Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentToolRequest" /> class.
        /// </summary>
        /// <param name="kind">
        /// What kind of tool this is, and where it executes.<br/>
        /// - `builtin`: a worker-resident platform capability (e.g. end_call, play_audio), configured per-agent<br/>
        /// - `webhook`: worker signs a payload and POSTs it to your URL<br/>
        /// - `client`:  worker dispatches to the caller's browser/SDK via data channel<br/>
        /// - `mcp`:     worker connects to a customer-hosted MCP server and proxies tool calls
        /// </param>
        /// <param name="name"></param>
        /// <param name="config"></param>
        /// <param name="description"></param>
        /// <param name="enabled">
        /// Defaults to true on the server when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentToolRequest(
            global::Speechify.ToolKind kind,
            string name,
            global::Speechify.CreateAgentToolRequestConfig config,
            string? description,
            bool? enabled)
        {
            this.Kind = kind;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Enabled = enabled;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentToolRequest" /> class.
        /// </summary>
        public CreateAgentToolRequest()
        {
        }

    }
}