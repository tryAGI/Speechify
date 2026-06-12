
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Request-side flow graph: nodes, edges, and variables only.<br/>
    /// Unlike the response-side FlowGraph it carries no `version`<br/>
    /// block - the server owns version metadata.
    /// </summary>
    public sealed partial class TtsFlowGraphInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphInputNodesItems> Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphInputEdgesItems> Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphInputVariablesItems>? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsFlowGraphInput" /> class.
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="edges"></param>
        /// <param name="variables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsFlowGraphInput(
            global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphInputNodesItems> nodes,
            global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphInputEdgesItems> edges,
            global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphInputVariablesItems>? variables)
        {
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.Edges = edges ?? throw new global::System.ArgumentNullException(nameof(edges));
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsFlowGraphInput" /> class.
        /// </summary>
        public TtsFlowGraphInput()
        {
        }

    }
}