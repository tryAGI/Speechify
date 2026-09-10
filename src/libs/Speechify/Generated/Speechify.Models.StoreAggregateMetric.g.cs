
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StoreAggregateMetric
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.StoreAggregateMetricOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.StoreAggregateMetricOp Op { get; set; }

        /// <summary>
        /// The projected numeric field to reduce; `count` takes none. A document whose field is absent or not a number is left out of that metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string? Field { get; set; }

        /// <summary>
        /// The key the metric answers under; `op` or `op_field` when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("as")]
        public string? As { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAggregateMetric" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="field">
        /// The projected numeric field to reduce; `count` takes none. A document whose field is absent or not a number is left out of that metric.
        /// </param>
        /// <param name="as">
        /// The key the metric answers under; `op` or `op_field` when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreAggregateMetric(
            global::Speechify.StoreAggregateMetricOp op,
            string? field,
            string? @as)
        {
            this.Op = op;
            this.Field = field;
            this.As = @as;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAggregateMetric" /> class.
        /// </summary>
        public StoreAggregateMetric()
        {
        }

    }
}