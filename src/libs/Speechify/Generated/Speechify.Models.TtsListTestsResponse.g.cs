
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Workspace-wide paginated list of tests. `next_cursor` is the opaque<br/>
    /// page cursor; omit on the first call, then pass through to get the<br/>
    /// next page until the field is absent.
    /// </summary>
    public sealed partial class TtsListTestsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestWithLastRun> Tests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListTestsResponse" /> class.
        /// </summary>
        /// <param name="tests"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListTestsResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestWithLastRun> tests,
            string? nextCursor)
        {
            this.Tests = tests ?? throw new global::System.ArgumentNullException(nameof(tests));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListTestsResponse" /> class.
        /// </summary>
        public TtsListTestsResponse()
        {
        }
    }
}