
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional body for `POST /v1/agents/{agent_id}/conversations`.
    /// </summary>
    public sealed partial class CreateConversationRequest
    {
        /// <summary>
        /// Transport hint. Omit to use the agent's default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        public string? Transport { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationRequest" /> class.
        /// </summary>
        /// <param name="transport">
        /// Transport hint. Omit to use the agent's default.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConversationRequest(
            string? transport,
            string? language,
            object? dynamicVariables)
        {
            this.Transport = transport;
            this.Language = language;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationRequest" /> class.
        /// </summary>
        public CreateConversationRequest()
        {
        }

    }
}