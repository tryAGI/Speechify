
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Response shape for GET /v1/agents/tool-definitions/{tool_definition_id}/api-routes.<br/>
    /// Ordered by API name, then by route creation.
    /// </summary>
    public sealed partial class ListToolAPIRoutesResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.ToolAPIRoute> Routes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolAPIRoutesResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// True when more rows exist beyond this page.
        /// </param>
        /// <param name="routes"></param>
        /// <param name="nextCursor">
        /// Opaque keyset cursor for the next page. Pass back as the<br/>
        /// `cursor` request parameter. `null` when the caller has<br/>
        /// reached the end of the list (`has_more` is also `false`<br/>
        /// in that case).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListToolAPIRoutesResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::Speechify.ToolAPIRoute> routes,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.Routes = routes ?? throw new global::System.ArgumentNullException(nameof(routes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolAPIRoutesResponse" /> class.
        /// </summary>
        public ListToolAPIRoutesResponse()
        {
        }

    }
}