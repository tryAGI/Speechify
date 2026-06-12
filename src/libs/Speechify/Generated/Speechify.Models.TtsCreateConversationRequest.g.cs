
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional body for `POST /v1/agents/{id}/conversations`.
    /// </summary>
    public sealed partial class TtsCreateConversationRequest
    {
        /// <summary>
        /// Transport hint. Omit to use the agent's default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        public string? Transport { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsCreateConversationRequest" /> class.
        /// </summary>
        /// <param name="transport">
        /// Transport hint. Omit to use the agent's default.
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
        public TtsCreateConversationRequest(
            string? transport,
            object? dynamicVariables)
        {
            this.Transport = transport;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateConversationRequest" /> class.
        /// </summary>
        public TtsCreateConversationRequest()
        {
        }

    }
}