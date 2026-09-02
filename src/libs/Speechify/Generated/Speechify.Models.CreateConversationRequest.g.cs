
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional body for `POST /v1/agents/{agent_id}/conversations`.
    /// </summary>
    public sealed partial class CreateConversationRequest
    {
        /// <summary>
        /// Voice transport for the session: one of `web`, `sip_inbound`, or `sip_outbound`. Omit (or null) to use the default, `web`. This endpoint dispatches a LiveKit voice session, so any other value is rejected with a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        public string? Transport { get; set; }

        /// <summary>
        /// Stable opaque identifier for the end-user in your application.<br/>
        /// Persisted verbatim as `caller_identity` for caller correlation<br/>
        /// and memory, but never exposed as the realtime participant<br/>
        /// identity. The same value sent to an authenticated<br/>
        /// `POST /v1/agents/{agent_id}/sessions` is the same caller record.<br/>
        /// Omit to preserve `user_&lt;authenticated principal&gt;` as the caller<br/>
        /// key.<br/>
        /// May not begin with `embed_`, `anon_` or `user_`: those namespaces<br/>
        /// are reserved for identities the platform derives rather than<br/>
        /// takes on trust, and claiming one is rejected with a 400 naming<br/>
        /// `user_identity`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_identity")]
        public string? UserIdentity { get; set; }

        /// <summary>
        /// Starts the conversation in one of the agent's configured<br/>
        /// languages (the default `language` or an `additional_languages`<br/>
        /// entry, matched by primary subtag). Omit for the agent's default<br/>
        /// language; an unconfigured language is rejected with 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Per-session variable overrides that merge on top of the agent's<br/>
        /// stored variable defaults for this one conversation. Keys in the<br/>
        /// reserved `system__` namespace are rejected. Values must match the<br/>
        /// declared type of the corresponding variable definition on the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// Authenticated, per-conversation configuration overrides. Overrides are<br/>
        /// validated and applied before the agent is dispatched; the effective<br/>
        /// configuration is captured in the conversation's `agent_snapshot`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::Speechify.CreateConversationOverrides? Overrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationRequest" /> class.
        /// </summary>
        /// <param name="transport">
        /// Voice transport for the session: one of `web`, `sip_inbound`, or `sip_outbound`. Omit (or null) to use the default, `web`. This endpoint dispatches a LiveKit voice session, so any other value is rejected with a 400.
        /// </param>
        /// <param name="userIdentity">
        /// Stable opaque identifier for the end-user in your application.<br/>
        /// Persisted verbatim as `caller_identity` for caller correlation<br/>
        /// and memory, but never exposed as the realtime participant<br/>
        /// identity. The same value sent to an authenticated<br/>
        /// `POST /v1/agents/{agent_id}/sessions` is the same caller record.<br/>
        /// Omit to preserve `user_&lt;authenticated principal&gt;` as the caller<br/>
        /// key.<br/>
        /// May not begin with `embed_`, `anon_` or `user_`: those namespaces<br/>
        /// are reserved for identities the platform derives rather than<br/>
        /// takes on trust, and claiming one is rejected with a 400 naming<br/>
        /// `user_identity`.
        /// </param>
        /// <param name="language">
        /// Starts the conversation in one of the agent's configured<br/>
        /// languages (the default `language` or an `additional_languages`<br/>
        /// entry, matched by primary subtag). Omit for the agent's default<br/>
        /// language; an unconfigured language is rejected with 400.
        /// </param>
        /// <param name="dynamicVariables">
        /// Per-session variable overrides that merge on top of the agent's<br/>
        /// stored variable defaults for this one conversation. Keys in the<br/>
        /// reserved `system__` namespace are rejected. Values must match the<br/>
        /// declared type of the corresponding variable definition on the agent.
        /// </param>
        /// <param name="overrides">
        /// Authenticated, per-conversation configuration overrides. Overrides are<br/>
        /// validated and applied before the agent is dispatched; the effective<br/>
        /// configuration is captured in the conversation's `agent_snapshot`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConversationRequest(
            string? transport,
            string? userIdentity,
            string? language,
            object? dynamicVariables,
            global::Speechify.CreateConversationOverrides? overrides)
        {
            this.Transport = transport;
            this.UserIdentity = userIdentity;
            this.Language = language;
            this.DynamicVariables = dynamicVariables;
            this.Overrides = overrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationRequest" /> class.
        /// </summary>
        public CreateConversationRequest()
        {
        }

    }
}