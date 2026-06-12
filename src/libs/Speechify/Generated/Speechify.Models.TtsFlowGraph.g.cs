
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A flow graph: an ordered set of typed nodes connected by edges,<br/>
    /// plus flow variables. The node, edge, and variable shapes are<br/>
    /// governed by the live JSON Schema at GET /v1/agents/flow/schema<br/>
    /// and are intentionally opaque here so this spec cannot drift<br/>
    /// from that authoritative definition.
    /// </summary>
    public sealed partial class TtsFlowGraph
    {
        /// <summary>
        /// One published or draft revision of an agent's flow graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsFlowVersion Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphNodesItems> Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphEdgesItems> Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphVariablesItems>? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsFlowGraph" /> class.
        /// </summary>
        /// <param name="version">
        /// One published or draft revision of an agent's flow graph.
        /// </param>
        /// <param name="nodes"></param>
        /// <param name="edges"></param>
        /// <param name="variables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsFlowGraph(
            global::Speechify.TtsFlowVersion version,
            global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphNodesItems> nodes,
            global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphEdgesItems> edges,
            global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphVariablesItems>? variables)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.Edges = edges ?? throw new global::System.ArgumentNullException(nameof(edges));
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsFlowGraph" /> class.
        /// </summary>
        public TtsFlowGraph()
        {
        }

    }
}