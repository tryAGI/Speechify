
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The JSON request body an operation takes, offered to the agent as the `body` argument.
    /// </summary>
    public sealed partial class OpenAPIBody
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.OpenApiBodyContentTypeJsonConverter))]
        public global::Speechify.OpenApiBodyContentType? ContentType { get; set; }

        /// <summary>
        /// A JSON Schema object for the body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIBody" /> class.
        /// </summary>
        /// <param name="schema">
        /// A JSON Schema object for the body.
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="required"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIBody(
            object schema,
            global::Speechify.OpenApiBodyContentType? contentType,
            bool? required)
        {
            this.ContentType = contentType;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIBody" /> class.
        /// </summary>
        public OpenAPIBody()
        {
        }

    }
}