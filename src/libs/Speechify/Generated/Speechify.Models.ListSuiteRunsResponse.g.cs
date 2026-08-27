
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One page of suite runs, newest first. Walk pages while<br/>
    /// `has_more` is true; pass `next_cursor` back as the request<br/>
    /// `cursor` parameter.
    /// </summary>
    public sealed partial class ListSuiteRunsResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("suite_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.AgentTestSuiteRun> SuiteRuns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSuiteRunsResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// True when more rows exist beyond this page.
        /// </param>
        /// <param name="suiteRuns"></param>
        /// <param name="nextCursor">
        /// Opaque keyset cursor for the next page. Pass back as the<br/>
        /// `cursor` request parameter. `null` when the caller has<br/>
        /// reached the end of the list (`has_more` is also `false`<br/>
        /// in that case).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSuiteRunsResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::Speechify.AgentTestSuiteRun> suiteRuns,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.SuiteRuns = suiteRuns ?? throw new global::System.ArgumentNullException(nameof(suiteRuns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSuiteRunsResponse" /> class.
        /// </summary>
        public ListSuiteRunsResponse()
        {
        }

    }
}