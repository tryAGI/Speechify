
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Response for GET /v1/agents/{id}/flow.
    /// </summary>
    public sealed partial class GetFlowResponse
    {
        /// <summary>
        /// A flow graph: an ordered set of typed nodes connected by edges,<br/>
        /// plus flow variables. The node, edge, and variable shapes are<br/>
        /// governed by the live JSON Schema at GET /v1/agents/flow/schema<br/>
        /// and are intentionally opaque here so this spec cannot drift<br/>
        /// from that authoritative definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public global::Speechify.FlowGraph? Draft { get; set; }

        /// <summary>
        /// A flow graph: an ordered set of typed nodes connected by edges,<br/>
        /// plus flow variables. The node, edge, and variable shapes are<br/>
        /// governed by the live JSON Schema at GET /v1/agents/flow/schema<br/>
        /// and are intentionally opaque here so this spec cannot drift<br/>
        /// from that authoritative definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public global::Speechify.FlowGraph? Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.FlowVersion> History { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFlowResponse" /> class.
        /// </summary>
        /// <param name="history"></param>
        /// <param name="draft">
        /// A flow graph: an ordered set of typed nodes connected by edges,<br/>
        /// plus flow variables. The node, edge, and variable shapes are<br/>
        /// governed by the live JSON Schema at GET /v1/agents/flow/schema<br/>
        /// and are intentionally opaque here so this spec cannot drift<br/>
        /// from that authoritative definition.
        /// </param>
        /// <param name="active">
        /// A flow graph: an ordered set of typed nodes connected by edges,<br/>
        /// plus flow variables. The node, edge, and variable shapes are<br/>
        /// governed by the live JSON Schema at GET /v1/agents/flow/schema<br/>
        /// and are intentionally opaque here so this spec cannot drift<br/>
        /// from that authoritative definition.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFlowResponse(
            global::System.Collections.Generic.IList<global::Speechify.FlowVersion> history,
            global::Speechify.FlowGraph? draft,
            global::Speechify.FlowGraph? active)
        {
            this.Draft = draft;
            this.Active = active;
            this.History = history ?? throw new global::System.ArgumentNullException(nameof(history));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFlowResponse" /> class.
        /// </summary>
        public GetFlowResponse()
        {
        }

    }
}