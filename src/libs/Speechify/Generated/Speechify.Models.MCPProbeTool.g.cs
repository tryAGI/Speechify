
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One discovered tool in a probe result.
    /// </summary>
    public sealed partial class MCPProbeTool
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The server's own account of this tool, read from the MCP<br/>
        /// `annotations.readOnlyHint` it published. Offered as a starting<br/>
        /// point when you classify the server's tools in `action_classes`;<br/>
        /// it is never a policy input on its own, because a server declaring<br/>
        /// itself harmless is not the same as you deciding it is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPProbeTool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="readOnly">
        /// The server's own account of this tool, read from the MCP<br/>
        /// `annotations.readOnlyHint` it published. Offered as a starting<br/>
        /// point when you classify the server's tools in `action_classes`;<br/>
        /// it is never a policy input on its own, because a server declaring<br/>
        /// itself harmless is not the same as you deciding it is.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPProbeTool(
            string name,
            string? description,
            bool? readOnly)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPProbeTool" /> class.
        /// </summary>
        public MCPProbeTool()
        {
        }

    }
}