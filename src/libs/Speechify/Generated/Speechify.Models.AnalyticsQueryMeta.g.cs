
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsQueryMeta
    {
        /// <summary>
        /// Number of breakdown groups returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GroupCount { get; set; }

        /// <summary>
        /// True when more groups existed than `breakdown_limit` allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Truncated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryMeta" /> class.
        /// </summary>
        /// <param name="groupCount">
        /// Number of breakdown groups returned.
        /// </param>
        /// <param name="truncated">
        /// True when more groups existed than `breakdown_limit` allowed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsQueryMeta(
            int groupCount,
            bool truncated)
        {
            this.GroupCount = groupCount;
            this.Truncated = truncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryMeta" /> class.
        /// </summary>
        public AnalyticsQueryMeta()
        {
        }

    }
}