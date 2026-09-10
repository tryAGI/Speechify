
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
        /// A literal; a `{{query.x}}` / `{{path.x}}` / `{{body.x}}` template<br/>
        /// bound from the request; or a `{{user.x}}` claim of the verified<br/>
        /// end-user token (only on a `user_token` API). A clause whose<br/>
        /// template is absent from the request is skipped. The field<br/>
        /// `user_identity` is the person a document belongs to, and a<br/>
        /// clause on it must bind `{{user.sub}}`, never a request template:<br/>
        /// a request parameter is whatever the caller sends, so scoping on<br/>
        /// it would let any caller read any user's rows.
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
        /// A literal; a `{{query.x}}` / `{{path.x}}` / `{{body.x}}` template<br/>
        /// bound from the request; or a `{{user.x}}` claim of the verified<br/>
        /// end-user token (only on a `user_token` API). A clause whose<br/>
        /// template is absent from the request is skipped. The field<br/>
        /// `user_identity` is the person a document belongs to, and a<br/>
        /// clause on it must bind `{{user.sub}}`, never a request template:<br/>
        /// a request parameter is whatever the caller sends, so scoping on<br/>
        /// it would let any caller read any user's rows.
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