
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One parameter of an operation and where it rides on the request. The<br/>
    /// agent supplies every parameter's value, so never declare a credential<br/>
    /// (an API key header or query parameter) as one: the tool's `auth`<br/>
    /// carries credentials.
    /// </summary>
    public sealed partial class OpenAPIParam
    {
        /// <summary>
        /// The argument name the agent fills, unique across the operation's<br/>
        /// path, query and header params. `body` is reserved for the request<br/>
        /// body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Where the value rides. A `header` param may not be `Authorization`,<br/>
        /// `Host`, `Content-Type`, `Content-Length`, `Transfer-Encoding`,<br/>
        /// `Connection` or any `Speechify-` header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.OpenApiParamInJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.OpenApiParamIn In { get; set; }

        /// <summary>
        /// A JSON Schema fragment for the value: `type` is string, number,<br/>
        /// integer, boolean or array (of a scalar `items`), plus `enum`,<br/>
        /// `description` and the ordinary scalar keywords.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Whether the agent must supply it. A path param always is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIParam" /> class.
        /// </summary>
        /// <param name="name">
        /// The argument name the agent fills, unique across the operation's<br/>
        /// path, query and header params. `body` is reserved for the request<br/>
        /// body.
        /// </param>
        /// <param name="in">
        /// Where the value rides. A `header` param may not be `Authorization`,<br/>
        /// `Host`, `Content-Type`, `Content-Length`, `Transfer-Encoding`,<br/>
        /// `Connection` or any `Speechify-` header.
        /// </param>
        /// <param name="schema">
        /// A JSON Schema fragment for the value: `type` is string, number,<br/>
        /// integer, boolean or array (of a scalar `items`), plus `enum`,<br/>
        /// `description` and the ordinary scalar keywords.
        /// </param>
        /// <param name="required">
        /// Whether the agent must supply it. A path param always is.
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIParam(
            string name,
            global::Speechify.OpenApiParamIn @in,
            object schema,
            bool? required,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.In = @in;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Required = required;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIParam" /> class.
        /// </summary>
        public OpenAPIParam()
        {
        }

    }
}