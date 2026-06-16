
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Request-side flow graph: nodes, edges, and variables only.<br/>
    /// Unlike the response-side FlowGraph it carries no `version`<br/>
    /// block - the server owns version metadata.
    /// </summary>
    public sealed partial class FlowGraphInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.FlowGraphInputNodesItems> Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.FlowGraphInputEdgesItems> Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::Speechify.FlowGraphInputVariablesItems>? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowGraphInput" /> class.
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="edges"></param>
        /// <param name="variables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlowGraphInput(
            global::System.Collections.Generic.IList<global::Speechify.FlowGraphInputNodesItems> nodes,
            global::System.Collections.Generic.IList<global::Speechify.FlowGraphInputEdgesItems> edges,
            global::System.Collections.Generic.IList<global::Speechify.FlowGraphInputVariablesItems>? variables)
        {
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.Edges = edges ?? throw new global::System.ArgumentNullException(nameof(edges));
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowGraphInput" /> class.
        /// </summary>
        public FlowGraphInput()
        {
        }

    }
}