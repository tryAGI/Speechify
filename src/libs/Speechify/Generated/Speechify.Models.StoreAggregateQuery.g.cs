
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StoreAggregateQuery
    {
        /// <summary>
        /// Filters, ANDed, the same ones a query takes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("where")]
        public global::System.Collections.Generic.IList<global::Speechify.StoreWhereClause>? Where { get; set; }

        /// <summary>
        /// One projected field to group by. A string that reaches the index's 256-byte limit may have been cut there, and the answer says so.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public string? GroupBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.StoreAggregateMetric> Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAggregateQuery" /> class.
        /// </summary>
        /// <param name="metrics"></param>
        /// <param name="where">
        /// Filters, ANDed, the same ones a query takes.
        /// </param>
        /// <param name="groupBy">
        /// One projected field to group by. A string that reaches the index's 256-byte limit may have been cut there, and the answer says so.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreAggregateQuery(
            global::System.Collections.Generic.IList<global::Speechify.StoreAggregateMetric> metrics,
            global::System.Collections.Generic.IList<global::Speechify.StoreWhereClause>? where,
            string? groupBy)
        {
            this.Where = where;
            this.GroupBy = groupBy;
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAggregateQuery" /> class.
        /// </summary>
        public StoreAggregateQuery()
        {
        }

    }
}