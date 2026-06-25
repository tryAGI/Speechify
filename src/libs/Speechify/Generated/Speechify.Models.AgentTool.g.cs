
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One thing an agent can do, in the unified per-agent view. Kind<br/>
    /// discriminates a per-agent built-in instance (`builtin`) from an<br/>
    /// attached workspace tool definition (`webhook`/`client`/`mcp`).<br/>
    /// The config is resolved + embedded so consumers never have to fetch<br/>
    /// the backing definition. `id` is a `tool_&lt;...&gt;` for every kind.
    /// </summary>
    public sealed partial class AgentTool
    {
        /// <summary>
        /// Prefixed wire identifier (`tool_&lt;26 char Crockford base32&gt;`), stable across kinds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// When false the tool is configured but skipped at dispatch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Provenance: the backing workspace tool definition id for<br/>
        /// shared kinds (webhook/client/mcp), or `null` for a built-in.<br/>
        /// Non-null ⟺ the tool's config is shared and edited at<br/>
        /// `/v1/agents/tool-definitions/{id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition_id")]
        public string? DefinitionId { get; set; }

        /// <summary>
        /// Resolved config - `BuiltinToolConfig`, `WebhookToolConfig`, `ClientToolConfig`, or `MCPToolConfig` depending on `kind`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentToolConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentToolConfig Config { get; set; }

        /// <summary>
        /// HMAC signing secret for a `webhook` tool. Returned in full<br/>
        /// **only** on the create response; subsequent reads return a<br/>
        /// masked placeholder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTool" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`tool_&lt;26 char Crockford base32&gt;`), stable across kinds.
        /// </param>
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
        /// When false the tool is configured but skipped at dispatch.
        /// </param>
        /// <param name="config">
        /// Resolved config - `BuiltinToolConfig`, `WebhookToolConfig`, `ClientToolConfig`, or `MCPToolConfig` depending on `kind`.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="definitionId">
        /// Provenance: the backing workspace tool definition id for<br/>
        /// shared kinds (webhook/client/mcp), or `null` for a built-in.<br/>
        /// Non-null ⟺ the tool's config is shared and edited at<br/>
        /// `/v1/agents/tool-definitions/{id}`.
        /// </param>
        /// <param name="webhookSecret">
        /// HMAC signing secret for a `webhook` tool. Returned in full<br/>
        /// **only** on the create response; subsequent reads return a<br/>
        /// masked placeholder.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTool(
            string id,
            global::Speechify.ToolKind kind,
            string name,
            string description,
            bool enabled,
            global::Speechify.AgentToolConfig config,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? definitionId,
            string? webhookSecret)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Kind = kind;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Enabled = enabled;
            this.DefinitionId = definitionId;
            this.Config = config;
            this.WebhookSecret = webhookSecret;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTool" /> class.
        /// </summary>
        public AgentTool()
        {
        }

    }
}