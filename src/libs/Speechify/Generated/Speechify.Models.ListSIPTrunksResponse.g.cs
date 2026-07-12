
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Response for `GET /v1/agents/sip-trunks`.
    /// </summary>
    public sealed partial class ListSIPTrunksResponse
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
        /// SIP trunks in the workspace (up to 20).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.SIPTrunk> Trunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSIPTrunksResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// True when more rows exist beyond this page.
        /// </param>
        /// <param name="trunks">
        /// SIP trunks in the workspace (up to 20).
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
        public ListSIPTrunksResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::Speechify.SIPTrunk> trunks,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.Trunks = trunks ?? throw new global::System.ArgumentNullException(nameof(trunks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSIPTrunksResponse" /> class.
        /// </summary>
        public ListSIPTrunksResponse()
        {
        }

    }
}