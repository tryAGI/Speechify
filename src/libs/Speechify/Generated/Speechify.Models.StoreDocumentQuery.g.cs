
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StoreDocumentQuery
    {
        /// <summary>
        /// Filters, ANDed. Only top-level string / number / boolean / null fields are queryable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("where")]
        public global::System.Collections.Generic.IList<global::Speechify.StoreWhereClause>? Where { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public global::Speechify.StoreOrderBy? OrderBy { get; set; }

        /// <summary>
        /// Page size, 50 when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The `next_cursor` of the previous page; must belong to the same ordering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Set false to return index rows only; bodies are included when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_data")]
        public bool? IncludeData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDocumentQuery" /> class.
        /// </summary>
        /// <param name="where">
        /// Filters, ANDed. Only top-level string / number / boolean / null fields are queryable.
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="limit">
        /// Page size, 50 when omitted.
        /// </param>
        /// <param name="cursor">
        /// The `next_cursor` of the previous page; must belong to the same ordering.
        /// </param>
        /// <param name="includeData">
        /// Set false to return index rows only; bodies are included when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreDocumentQuery(
            global::System.Collections.Generic.IList<global::Speechify.StoreWhereClause>? where,
            global::Speechify.StoreOrderBy? orderBy,
            int? limit,
            string? cursor,
            bool? includeData)
        {
            this.Where = where;
            this.OrderBy = orderBy;
            this.Limit = limit;
            this.Cursor = cursor;
            this.IncludeData = includeData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDocumentQuery" /> class.
        /// </summary>
        public StoreDocumentQuery()
        {
        }

    }
}