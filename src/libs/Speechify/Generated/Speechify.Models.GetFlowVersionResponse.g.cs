
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFlowVersionResponse
    {
        /// <summary>
        /// A flow graph: an ordered set of typed nodes connected by edges,<br/>
        /// plus flow variables. The node, edge, and variable shapes are<br/>
        /// governed by the live JSON Schema at GET /v1/agents/flow/schema<br/>
        /// and are intentionally opaque here so this spec cannot drift<br/>
        /// from that authoritative definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.FlowGraph Graph { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFlowVersionResponse" /> class.
        /// </summary>
        /// <param name="graph">
        /// A flow graph: an ordered set of typed nodes connected by edges,<br/>
        /// plus flow variables. The node, edge, and variable shapes are<br/>
        /// governed by the live JSON Schema at GET /v1/agents/flow/schema<br/>
        /// and are intentionally opaque here so this spec cannot drift<br/>
        /// from that authoritative definition.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFlowVersionResponse(
            global::Speechify.FlowGraph graph)
        {
            this.Graph = graph ?? throw new global::System.ArgumentNullException(nameof(graph));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFlowVersionResponse" /> class.
        /// </summary>
        public GetFlowVersionResponse()
        {
        }

    }
}