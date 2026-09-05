
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StoreWhereClause
    {
        /// <summary>
        /// A top-level field name of the documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.StoreWhereClauseOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.StoreWhereClauseOp Op { get; set; }

        /// <summary>
        /// A string, number, boolean or null; an array of those for `in`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreWhereClause" /> class.
        /// </summary>
        /// <param name="field">
        /// A top-level field name of the documents.
        /// </param>
        /// <param name="op"></param>
        /// <param name="value">
        /// A string, number, boolean or null; an array of those for `in`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreWhereClause(
            string field,
            global::Speechify.StoreWhereClauseOp op,
            object value)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Op = op;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreWhereClause" /> class.
        /// </summary>
        public StoreWhereClause()
        {
        }

    }
}