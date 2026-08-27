
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for `GET /v1/agents/voices`: the curated shared set (the<br/>
    /// `ai-api-agents` VMS scope plus a handful of builtins) followed by the<br/>
    /// calling workspace's cloned voices. Cursor-paginated - walk pages while<br/>
    /// `has_more` is true.
    /// </summary>
    public sealed partial class ListAgentVoicesResponse
    {
        /// <summary>
        /// Opaque keyset cursor for the next page. Pass back as the<br/>
        /// `cursor` request parameter. `null` when the caller has<br/>
        /// reached the end of the list (`has_more` is also `false`<br/>
        /// in that case).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// True when more rows exist beyond this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

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
        /// <param name="hasMore">
        /// True when more rows exist beyond this page.
        /// </param>
        /// <param name="voices"></param>
        /// <param name="multilingualLanguages">
        /// Every language an agent may declare in `additional_languages`.<br/>
        /// Render language pickers from this rather than a hard-coded<br/>
        /// list: it is derived from the same routing the write path<br/>
        /// validates against, so it can never offer a language a save<br/>
        /// would reject.
        /// </param>
        /// <param name="nextCursor">
        /// Opaque keyset cursor for the next page. Pass back as the<br/>
        /// `cursor` request parameter. `null` when the caller has<br/>
        /// reached the end of the list (`has_more` is also `false`<br/>
        /// in that case).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentVoicesResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::Speechify.AgentVoice> voices,
            global::System.Collections.Generic.IList<global::Speechify.MultilingualLanguage> multilingualLanguages,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
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