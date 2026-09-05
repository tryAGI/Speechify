
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HostedApiResolverWhereItems
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.HostedApiResolverWhereItemsOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.HostedApiResolverWhereItemsOp Op { get; set; }

        /// <summary>
        /// A literal, or a `{{query.x}}` / `{{path.x}}` / `{{body.x}}` template; a clause whose template is absent from the request is skipped.
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
        /// Initializes a new instance of the <see cref="HostedApiResolverWhereItems" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="op"></param>
        /// <param name="value">
        /// A literal, or a `{{query.x}}` / `{{path.x}}` / `{{body.x}}` template; a clause whose template is absent from the request is skipped.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedApiResolverWhereItems(
            string field,
            global::Speechify.HostedApiResolverWhereItemsOp op,
            object value)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Op = op;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedApiResolverWhereItems" /> class.
        /// </summary>
        public HostedApiResolverWhereItems()
        {
        }

    }
}