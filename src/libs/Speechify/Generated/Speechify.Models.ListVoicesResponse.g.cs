
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for `GET /v1/voices` - the shared voice catalog plus the<br/>
    /// workspace's personal cloned voices. Carries the shared pagination<br/>
    /// metadata so the list can be paged when `limit` is supplied;<br/>
    /// `next_cursor` is null and `has_more` is false when the full<br/>
    /// catalogue is returned in one response.
    /// </summary>
    public sealed partial class ListVoicesResponse
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
        public required global::System.Collections.Generic.IList<global::Speechify.GetVoice> Voices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// True when more rows exist beyond this page.
        /// </param>
        /// <param name="voices"></param>
        /// <param name="nextCursor">
        /// Opaque keyset cursor for the next page. Pass back as the<br/>
        /// `cursor` request parameter. `null` when the caller has<br/>
        /// reached the end of the list (`has_more` is also `false`<br/>
        /// in that case).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVoicesResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::Speechify.GetVoice> voices,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesResponse" /> class.
        /// </summary>
        public ListVoicesResponse()
        {
        }

    }
}