
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for `GET /v1/agents/voices`. The curated agent voice<br/>
    /// catalogue is bounded (the `ai-api-agents` VMS scope plus a<br/>
    /// handful of builtins), so it is returned in full with no<br/>
    /// pagination metadata.
    /// </summary>
    public sealed partial class ListAgentVoicesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.AgentVoice> Voices { get; set; }

        /// <summary>
        /// Every language an agent may declare in `additional_languages`.<br/>
        /// Render language pickers from this rather than a hard-coded<br/>
        /// list: it is derived from the same routing the write path<br/>
        /// validates against, so it can never offer a language a save<br/>
        /// would reject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multilingual_languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.MultilingualLanguage> MultilingualLanguages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentVoicesResponse" /> class.
        /// </summary>
        /// <param name="voices"></param>
        /// <param name="multilingualLanguages">
        /// Every language an agent may declare in `additional_languages`.<br/>
        /// Render language pickers from this rather than a hard-coded<br/>
        /// list: it is derived from the same routing the write path<br/>
        /// validates against, so it can never offer a language a save<br/>
        /// would reject.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentVoicesResponse(
            global::System.Collections.Generic.IList<global::Speechify.AgentVoice> voices,
            global::System.Collections.Generic.IList<global::Speechify.MultilingualLanguage> multilingualLanguages)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
            this.MultilingualLanguages = multilingualLanguages ?? throw new global::System.ArgumentNullException(nameof(multilingualLanguages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentVoicesResponse" /> class.
        /// </summary>
        public ListAgentVoicesResponse()
        {
        }

    }
}