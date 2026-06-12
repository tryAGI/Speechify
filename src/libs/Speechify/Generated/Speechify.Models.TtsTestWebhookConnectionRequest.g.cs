
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/tools/test-webhook-connection`.<br/>
    /// `config` is the same WebhookToolConfig shape `POST /v1/agents/tools`<br/>
    /// would persist; nothing is persisted by the probe. `tool_id` is<br/>
    /// only meaningful in the edit-form flow — when set, the server<br/>
    /// signs the probe request with the tool's stored HMAC secret so<br/>
    /// the test exercises the real signature path.
    /// </summary>
    public sealed partial class TtsTestWebhookConnectionRequest
    {
        /// <summary>
        /// Config shape for `kind=webhook`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsWebhookToolConfig Config { get; set; }

        /// <summary>
        /// Optional `tool_&lt;crockford&gt;` id of the existing tool to sign<br/>
        /// the probe with. Raw UUIDs and other-resource prefixes are<br/>
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
        /// Initializes a new instance of the <see cref="TtsTestWebhookConnectionRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Config shape for `kind=webhook`.
        /// </param>
        /// <param name="toolId">
        /// Optional `tool_&lt;crockford&gt;` id of the existing tool to sign<br/>
        /// the probe with. Raw UUIDs and other-resource prefixes are<br/>
        /// rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsTestWebhookConnectionRequest(
            global::Speechify.TtsWebhookToolConfig config,
            string? toolId)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.ToolId = toolId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTestWebhookConnectionRequest" /> class.
        /// </summary>
        public TtsTestWebhookConnectionRequest()
        {
        }

    }
}