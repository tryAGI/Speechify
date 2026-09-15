
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A hosted API route that calls a tool, with the API it answers on.
    /// </summary>
    public sealed partial class ToolAPIRoute
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The route's name; on an API with `mcp_enabled`, the MCP tool name comes from it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ToolApiRouteMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ToolApiRouteMethod Method { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The operation the route calls, an `openapi` operation's id or an `mcp` server's tool name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operation { get; set; }

        /// <summary>
        /// Whether the route serves an operation that is not a read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_write")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowWrite { get; set; }

        /// <summary>
        /// Whether the route answers; a disabled route answers nothing whatever the tool does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The hosted API a route belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ToolAPIRouteAPI Api { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolAPIRoute" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// The route's name; on an API with `mcp_enabled`, the MCP tool name comes from it.
        /// </param>
        /// <param name="method"></param>
        /// <param name="path"></param>
        /// <param name="operation">
        /// The operation the route calls, an `openapi` operation's id or an `mcp` server's tool name.
        /// </param>
        /// <param name="allowWrite">
        /// Whether the route serves an operation that is not a read.
        /// </param>
        /// <param name="enabled">
        /// Whether the route answers; a disabled route answers nothing whatever the tool does.
        /// </param>
        /// <param name="api">
        /// The hosted API a route belongs to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolAPIRoute(
            string id,
            string name,
            global::Speechify.ToolApiRouteMethod method,
            string path,
            string operation,
            bool allowWrite,
            bool enabled,
            global::Speechify.ToolAPIRouteAPI api)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Method = method;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
            this.AllowWrite = allowWrite;
            this.Enabled = enabled;
            this.Api = api ?? throw new global::System.ArgumentNullException(nameof(api));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolAPIRoute" /> class.
        /// </summary>
        public ToolAPIRoute()
        {
        }

    }
}