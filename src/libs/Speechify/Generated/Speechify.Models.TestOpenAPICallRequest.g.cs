
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/tool-definitions/test-openapi-call`: an<br/>
    /// unsaved `openapi` config, the operation to call on it, and the<br/>
    /// arguments the agent would pass.
    /// </summary>
    public sealed partial class TestOpenAPICallRequest
    {
        /// <summary>
        /// The `openapi` config exactly as `POST /v1/agents/tool-definitions`<br/>
        /// takes it, with the credential by reference. The whole config is<br/>
        /// validated, not only the operation called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.OpenAPIToolConfig Config { get; set; }

        /// <summary>
        /// The `id` of the operation to call, one of `config.operations[].id`;<br/>
        /// the same value a hosted API `tool` route's `operation` names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operation { get; set; }

        /// <summary>
        /// The arguments the agent would pass: each param by its `name`, plus<br/>
        /// `body` when the operation takes one. Omitted, the call carries none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public object? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestOpenAPICallRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// The `openapi` config exactly as `POST /v1/agents/tool-definitions`<br/>
        /// takes it, with the credential by reference. The whole config is<br/>
        /// validated, not only the operation called.
        /// </param>
        /// <param name="operation">
        /// The `id` of the operation to call, one of `config.operations[].id`;<br/>
        /// the same value a hosted API `tool` route's `operation` names.
        /// </param>
        /// <param name="arguments">
        /// The arguments the agent would pass: each param by its `name`, plus<br/>
        /// `body` when the operation takes one. Omitted, the call carries none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestOpenAPICallRequest(
            global::Speechify.OpenAPIToolConfig config,
            string operation,
            object? arguments)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestOpenAPICallRequest" /> class.
        /// </summary>
        public TestOpenAPICallRequest()
        {
        }

    }
}