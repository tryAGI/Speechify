
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsTool
    {
        /// <summary>
        /// Prefixed wire identifier (`tool_&lt;26 char Crockford base32&gt;`).<br/>
        /// ADR 0015 Cluster 1 hard-break.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        /// - `mcp`:     worker connects to a customer-hosted MCP server and proxies tool calls (AIS-3056)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsToolKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsToolKind Kind { get; set; }

        /// <summary>
        /// One of `SystemToolConfig`, `WebhookToolConfig`, `ClientToolConfig`, or `MCPToolConfig` depending on `kind`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsToolConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsToolConfig Config { get; set; }

        /// <summary>
        /// HMAC signing secret for `kind=webhook`. Returned in full **only** on the create<br/>
        /// response; all subsequent reads return a masked placeholder. Store it on first<br/>
        /// create — there is no way to retrieve it later.
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
        /// Initializes a new instance of the <see cref="TtsTool" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`tool_&lt;26 char Crockford base32&gt;`).<br/>
        /// ADR 0015 Cluster 1 hard-break.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="kind">
        /// Where the tool executes.<br/>
        /// - `system`:  worker-resident built-in (e.g. end_call, play_audio)<br/>
        /// - `webhook`: worker signs a payload and POSTs it to your URL<br/>
        /// - `client`:  worker dispatches to the caller's browser/SDK via data channel<br/>
        /// - `mcp`:     worker connects to a customer-hosted MCP server and proxies tool calls (AIS-3056)
        /// </param>
        /// <param name="config">
        /// One of `SystemToolConfig`, `WebhookToolConfig`, `ClientToolConfig`, or `MCPToolConfig` depending on `kind`.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="webhookSecret">
        /// HMAC signing secret for `kind=webhook`. Returned in full **only** on the create<br/>
        /// response; all subsequent reads return a masked placeholder. Store it on first<br/>
        /// create — there is no way to retrieve it later.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsTool(
            string id,
            string name,
            string description,
            global::Speechify.TtsToolKind kind,
            global::Speechify.TtsToolConfig config,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? webhookSecret)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Kind = kind;
            this.Config = config;
            this.WebhookSecret = webhookSecret;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTool" /> class.
        /// </summary>
        public TtsTool()
        {
        }

    }
}