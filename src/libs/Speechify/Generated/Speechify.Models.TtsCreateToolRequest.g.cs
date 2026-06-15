
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsCreateToolRequest
    {
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Where the tool executes.<br/>
        /// - `system`:  worker-resident built-in (e.g. end_call, play_audio)<br/>
        /// - `webhook`: worker signs a payload and POSTs it to your URL<br/>
        /// - `client`:  worker dispatches to the caller's browser/SDK via data channel<br/>
        /// - `mcp`:     worker connects to a customer-hosted MCP server and proxies tool calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsToolKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsToolKind Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsCreateToolRequestConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsCreateToolRequestConfig Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateToolRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="kind">
        /// Where the tool executes.<br/>
        /// - `system`:  worker-resident built-in (e.g. end_call, play_audio)<br/>
        /// - `webhook`: worker signs a payload and POSTs it to your URL<br/>
        /// - `client`:  worker dispatches to the caller's browser/SDK via data channel<br/>
        /// - `mcp`:     worker connects to a customer-hosted MCP server and proxies tool calls
        /// </param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateToolRequest(
            string name,
            string description,
            global::Speechify.TtsToolKind kind,
            global::Speechify.TtsCreateToolRequestConfig config)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Kind = kind;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateToolRequest" /> class.
        /// </summary>
        public TtsCreateToolRequest()
        {
        }

    }
}