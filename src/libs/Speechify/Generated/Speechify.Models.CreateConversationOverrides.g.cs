
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Authenticated, per-conversation configuration overrides. Overrides are<br/>
    /// validated and applied before the agent is dispatched; the effective<br/>
    /// configuration is captured in the conversation's `agent_snapshot`.
    /// </summary>
    public sealed partial class CreateConversationOverrides
    {
        /// <summary>
        /// Voice to use for this entire conversation; see<br/>
        /// `GET /v1/agents/voices` for the recommended set.<br/>
        /// For a multilingual agent, this replaces every<br/>
        /// configured per-language voice. The selected voice must support<br/>
        /// the agent's complete configured language set; otherwise the<br/>
        /// request is rejected. An unavailable voice is never silently<br/>
        /// replaced with the default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationOverrides" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Voice to use for this entire conversation; see<br/>
        /// `GET /v1/agents/voices` for the recommended set.<br/>
        /// For a multilingual agent, this replaces every<br/>
        /// configured per-language voice. The selected voice must support<br/>
        /// the agent's complete configured language set; otherwise the<br/>
        /// request is rejected. An unavailable voice is never silently<br/>
        /// replaced with the default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConversationOverrides(
            string? voiceId)
        {
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationOverrides" /> class.
        /// </summary>
        public CreateConversationOverrides()
        {
        }

    }
}