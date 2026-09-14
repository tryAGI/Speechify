
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One REST operation, compiled from the document or authored by hand in<br/>
    /// the same shape.
    /// </summary>
    public sealed partial class OpenAPIOperation
    {
        /// <summary>
        /// The operation's name, unique within the tool regardless of case:<br/>
        /// the id `POST /v1/agents/tool-definitions/import-openapi` answered<br/>
        /// (the document's operationId made safe for a function name, or a<br/>
        /// name built from the method and path), or any name you choose in<br/>
        /// this grammar. The qualified `&lt;tool name&gt;__&lt;id&gt;` must fit 64<br/>
        /// characters. This is the value the<br/>
        /// `operation` field names in<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call` and in a hosted<br/>
        /// API `tool` route's resolver.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.OpenApiOperationMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.OpenApiOperationMethod Method { get; set; }

        /// <summary>
        /// The path appended to `base_url`, with `{name}` placeholders bound<br/>
        /// from path params. Parameter names are one namespace across path,<br/>
        /// query and header: the agent fills one argument object keyed by name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// A one-line account of the operation. A hosted API `tool` route<br/>
        /// with no description of its own shows it to MCP clients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// What the agent is told the operation does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.IList<global::Speechify.OpenAPIParam>? Params { get; set; }

        /// <summary>
        /// The JSON request body an operation takes, offered to the agent as the `body` argument.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public global::Speechify.OpenAPIBody? Body { get; set; }

        /// <summary>
        /// Your own statement of this operation's impact. Omitted, a GET or<br/>
        /// HEAD reads and every other method carries the tool's class, which<br/>
        /// is `irreversible_other` when the tool declares none. It decides<br/>
        /// what runs unattended: a `read` operation runs on a durable run<br/>
        /// without asking anyone, is the only kind `test-openapi-call` will<br/>
        /// call, and is the only kind a hosted API `tool` route may serve (on<br/>
        /// a tool whose `approval` is null or `auto`),<br/>
        /// while an undeclared write parks the run for a person. An explicit<br/>
        /// tool-level `approval` still wins over every operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_class")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ToolActionClassJsonConverter))]
        public global::Speechify.ToolActionClass? ActionClass { get; set; }

        /// <summary>
        /// What this operation's JSON result passes through before the agent<br/>
        /// reads it, on every surface. Omitted, the vendor's answer is passed<br/>
        /// as it came, trimmed to the observation window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::Speechify.ToolResponseMapping? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIOperation" /> class.
        /// </summary>
        /// <param name="id">
        /// The operation's name, unique within the tool regardless of case:<br/>
        /// the id `POST /v1/agents/tool-definitions/import-openapi` answered<br/>
        /// (the document's operationId made safe for a function name, or a<br/>
        /// name built from the method and path), or any name you choose in<br/>
        /// this grammar. The qualified `&lt;tool name&gt;__&lt;id&gt;` must fit 64<br/>
        /// characters. This is the value the<br/>
        /// `operation` field names in<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call` and in a hosted<br/>
        /// API `tool` route's resolver.
        /// </param>
        /// <param name="method"></param>
        /// <param name="path">
        /// The path appended to `base_url`, with `{name}` placeholders bound<br/>
        /// from path params. Parameter names are one namespace across path,<br/>
        /// query and header: the agent fills one argument object keyed by name.
        /// </param>
        /// <param name="summary">
        /// A one-line account of the operation. A hosted API `tool` route<br/>
        /// with no description of its own shows it to MCP clients.
        /// </param>
        /// <param name="description">
        /// What the agent is told the operation does.
        /// </param>
        /// <param name="params"></param>
        /// <param name="body">
        /// The JSON request body an operation takes, offered to the agent as the `body` argument.
        /// </param>
        /// <param name="actionClass">
        /// Your own statement of this operation's impact. Omitted, a GET or<br/>
        /// HEAD reads and every other method carries the tool's class, which<br/>
        /// is `irreversible_other` when the tool declares none. It decides<br/>
        /// what runs unattended: a `read` operation runs on a durable run<br/>
        /// without asking anyone, is the only kind `test-openapi-call` will<br/>
        /// call, and is the only kind a hosted API `tool` route may serve (on<br/>
        /// a tool whose `approval` is null or `auto`),<br/>
        /// while an undeclared write parks the run for a person. An explicit<br/>
        /// tool-level `approval` still wins over every operation.
        /// </param>
        /// <param name="response">
        /// What this operation's JSON result passes through before the agent<br/>
        /// reads it, on every surface. Omitted, the vendor's answer is passed<br/>
        /// as it came, trimmed to the observation window.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIOperation(
            string id,
            global::Speechify.OpenApiOperationMethod method,
            string path,
            string? summary,
            string? description,
            global::System.Collections.Generic.IList<global::Speechify.OpenAPIParam>? @params,
            global::Speechify.OpenAPIBody? body,
            global::Speechify.ToolActionClass? actionClass,
            global::Speechify.ToolResponseMapping? response)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Method = method;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Summary = summary;
            this.Description = description;
            this.Params = @params;
            this.Body = body;
            this.ActionClass = actionClass;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIOperation" /> class.
        /// </summary>
        public OpenAPIOperation()
        {
        }

    }
}