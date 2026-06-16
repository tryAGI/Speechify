
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One entry in the system-builtin catalogue.
    /// </summary>
    public sealed partial class SystemBuiltinInfo
    {
        /// <summary>
        /// Identifier of a worker-resident system builtin. New entries are<br/>
        /// added together on the server (a new `tool_builtin_&lt;name&gt;.go`<br/>
        /// file) and worker (`tools/builtins/&lt;name&gt;.py`) - the 2-file rule<br/>
        /// the server pins. Customers read the catalogue from<br/>
        /// `GET /v1/agents/tools/system-builtins` rather than depending on this<br/>
        /// string set staying stable across releases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Console-facing display label for the builtin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Console-facing one-line summary of what the builtin does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemBuiltinInfo" /> class.
        /// </summary>
        /// <param name="name">
        /// Identifier of a worker-resident system builtin. New entries are<br/>
        /// added together on the server (a new `tool_builtin_&lt;name&gt;.go`<br/>
        /// file) and worker (`tools/builtins/&lt;name&gt;.py`) - the 2-file rule<br/>
        /// the server pins. Customers read the catalogue from<br/>
        /// `GET /v1/agents/tools/system-builtins` rather than depending on this<br/>
        /// string set staying stable across releases.
        /// </param>
        /// <param name="label">
        /// Console-facing display label for the builtin.
        /// </param>
        /// <param name="description">
        /// Console-facing one-line summary of what the builtin does.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemBuiltinInfo(
            string name,
            string label,
            string description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemBuiltinInfo" /> class.
        /// </summary>
        public SystemBuiltinInfo()
        {
        }

    }
}