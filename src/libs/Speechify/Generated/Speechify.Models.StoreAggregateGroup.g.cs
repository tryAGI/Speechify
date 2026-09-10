
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StoreAggregateGroup
    {
        /// <summary>
        /// The `group_by` value; absent when nothing was grouped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public object? Key { get; set; }

        /// <summary>
        /// The metrics by their keys; null where no document contributed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double?> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAggregateGroup" /> class.
        /// </summary>
        /// <param name="values">
        /// The metrics by their keys; null where no document contributed.
        /// </param>
        /// <param name="key">
        /// The `group_by` value; absent when nothing was grouped.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreAggregateGroup(
            global::System.Collections.Generic.Dictionary<string, double?> values,
            object? key)
        {
            this.Key = key;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAggregateGroup" /> class.
        /// </summary>
        public StoreAggregateGroup()
        {
        }

    }
}