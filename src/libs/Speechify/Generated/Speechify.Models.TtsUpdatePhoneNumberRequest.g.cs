
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH body for `PATCH /v1/agents/phone-numbers/{id}`. Only `label`,<br/>
    /// `agent_id`, and `clear_agent_id` are mutable; `source` and `e164`<br/>
    /// are immutable after import. Set `agent_id` to bind a new agent;<br/>
    /// send `clear_agent_id: true` to unbind. The clear flag is the<br/>
    /// explicit signal because JSON `null` is indistinguishable from<br/>
    /// absent for pointer fields in Go's encoding/json.
    /// </summary>
    public sealed partial class TtsUpdatePhoneNumberRequest
    {
        /// <summary>
        /// New label. Pass an empty string to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Agent to bind the number to. Prefixed wire identifier<br/>
        /// (`agent_&lt;26 char Crockford base32&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// When `true`, unbinds the current agent (clears `agent_id`).<br/>
        /// Wins over `agent_id` when both are sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_agent_id")]
        public bool? ClearAgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdatePhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// New label. Pass an empty string to clear.
        /// </param>
        /// <param name="agentId">
        /// Agent to bind the number to. Prefixed wire identifier<br/>
        /// (`agent_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="clearAgentId">
        /// When `true`, unbinds the current agent (clears `agent_id`).<br/>
        /// Wins over `agent_id` when both are sent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsUpdatePhoneNumberRequest(
            string? label,
            string? agentId,
            bool? clearAgentId)
        {
            this.Label = label;
            this.AgentId = agentId;
            this.ClearAgentId = clearAgentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdatePhoneNumberRequest" /> class.
        /// </summary>
        public TtsUpdatePhoneNumberRequest()
        {
        }

    }
}