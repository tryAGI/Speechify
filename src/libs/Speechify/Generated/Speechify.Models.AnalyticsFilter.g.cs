
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One filter condition. `field` is a filterable dimension key; `op` is the comparison; `value` is a scalar (or array for `in`). Numeric comparison operators require a numeric field.
    /// </summary>
    public sealed partial class AnalyticsFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AnalyticsFilterOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AnalyticsFilterOp Op { get; set; }

        /// <summary>
        /// Comparison value — a string, number, boolean, or array of strings (for `in`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsFilter" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="op"></param>
        /// <param name="value">
        /// Comparison value — a string, number, boolean, or array of strings (for `in`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsFilter(
            string field,
            global::Speechify.AnalyticsFilterOp op,
            object? value)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Op = op;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsFilter" /> class.
        /// </summary>
        public AnalyticsFilter()
        {
        }

    }
}