
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StoreOrderBy
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// asc when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.StoreOrderByDirectionJsonConverter))]
        public global::Speechify.StoreOrderByDirection? Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreOrderBy" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="direction">
        /// asc when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreOrderBy(
            string field,
            global::Speechify.StoreOrderByDirection? direction)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreOrderBy" /> class.
        /// </summary>
        public StoreOrderBy()
        {
        }

    }
}