
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StoreAggregateResponse
    {
        /// <summary>
        /// One entry per group, largest count first; exactly one without `group_by`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.StoreAggregateGroup> Groups { get; set; }

        /// <summary>
        /// More than 100 groups existed; the largest are here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups_truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool GroupsTruncated { get; set; }

        /// <summary>
        /// At least one group key is a string that reached the index's 256-byte limit and may have been cut there, so groups may have merged on a prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool KeyTruncated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAggregateResponse" /> class.
        /// </summary>
        /// <param name="groups">
        /// One entry per group, largest count first; exactly one without `group_by`.
        /// </param>
        /// <param name="groupsTruncated">
        /// More than 100 groups existed; the largest are here.
        /// </param>
        /// <param name="keyTruncated">
        /// At least one group key is a string that reached the index's 256-byte limit and may have been cut there, so groups may have merged on a prefix.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreAggregateResponse(
            global::System.Collections.Generic.IList<global::Speechify.StoreAggregateGroup> groups,
            bool groupsTruncated,
            bool keyTruncated)
        {
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
            this.GroupsTruncated = groupsTruncated;
            this.KeyTruncated = keyTruncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAggregateResponse" /> class.
        /// </summary>
        public StoreAggregateResponse()
        {
        }

    }
}