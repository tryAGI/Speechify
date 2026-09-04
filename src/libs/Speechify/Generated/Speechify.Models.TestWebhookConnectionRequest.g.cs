
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/tool-definitions/test-webhook-connection`.<br/>
    /// `config` is the same WebhookToolConfig shape `POST /v1/agents/tool-definitions`<br/>
    /// would persist; nothing is persisted by the probe. `tool_id` is<br/>
    /// only meaningful in the edit-form flow — when set, the server<br/>
    /// signs the probe request with the tool's stored HMAC secret so<br/>
    /// the test exercises the real signature path.
    /// </summary>
    public sealed partial class TestWebhookConnectionRequest
    {
        /// <summary>
        /// Config shape for `kind=webhook`.<br/>
        /// On a durable run (`POST /v1/agents/{agent_id}/runs`) your endpoint is<br/>
        /// told `user_identity`: the person the agent is acting for, exactly as<br/>
        /// your application supplied it when it started the run. The field is<br/>
        /// absent when the run is acting for nobody in particular, so treat an<br/>
        /// absent value as "no person", never as a default one. Voice<br/>
        /// conversations and sessions do not carry it yet.<br/>
        /// On `method: POST` it rides inside the **signed** JSON body rather than<br/>
        /// a header, so an endpoint deciding whose data to touch can verify the<br/>
        /// answer with the same HMAC it already checks. On `method: GET` there is<br/>
        /// no body to sign, so it arrives as a **`user_identity` query<br/>
        /// parameter**, unverifiable exactly as the arguments beside it are: a<br/>
        /// GET's signature covers an envelope that is not on the wire. Use POST<br/>
        /// for any endpoint that authorizes on who the call is for. A tool<br/>
        /// argument of the same name never overrides it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.WebhookToolConfig Config { get; set; }

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
        /// Initializes a new instance of the <see cref="TestWebhookConnectionRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Config shape for `kind=webhook`.<br/>
        /// On a durable run (`POST /v1/agents/{agent_id}/runs`) your endpoint is<br/>
        /// told `user_identity`: the person the agent is acting for, exactly as<br/>
        /// your application supplied it when it started the run. The field is<br/>
        /// absent when the run is acting for nobody in particular, so treat an<br/>
        /// absent value as "no person", never as a default one. Voice<br/>
        /// conversations and sessions do not carry it yet.<br/>
        /// On `method: POST` it rides inside the **signed** JSON body rather than<br/>
        /// a header, so an endpoint deciding whose data to touch can verify the<br/>
        /// answer with the same HMAC it already checks. On `method: GET` there is<br/>
        /// no body to sign, so it arrives as a **`user_identity` query<br/>
        /// parameter**, unverifiable exactly as the arguments beside it are: a<br/>
        /// GET's signature covers an envelope that is not on the wire. Use POST<br/>
        /// for any endpoint that authorizes on who the call is for. A tool<br/>
        /// argument of the same name never overrides it.
        /// </param>
        /// <param name="toolId">
        /// Optional `tool_&lt;crockford&gt;` id of the existing tool to sign<br/>
        /// the probe with. Raw UUIDs and other-resource prefixes are<br/>
        /// rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestWebhookConnectionRequest(
            global::Speechify.WebhookToolConfig config,
            string? toolId)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.ToolId = toolId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestWebhookConnectionRequest" /> class.
        /// </summary>
        public TestWebhookConnectionRequest()
        {
        }

    }
}