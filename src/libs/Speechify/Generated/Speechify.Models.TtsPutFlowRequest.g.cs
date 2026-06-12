
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Request body for PUT /v1/agents/{id}/flow. Replaces the draft graph.
    /// </summary>
    public sealed partial class TtsPutFlowRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsPutFlowRequestNodesItems> Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsPutFlowRequestEdgesItems> Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsPutFlowRequestVariablesItems>? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsPutFlowRequest" /> class.
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="edges"></param>
        /// <param name="name"></param>
        /// <param name="notes"></param>
        /// <param name="variables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsPutFlowRequest(
            global::System.Collections.Generic.IList<global::Speechify.TtsPutFlowRequestNodesItems> nodes,
            global::System.Collections.Generic.IList<global::Speechify.TtsPutFlowRequestEdgesItems> edges,
            string? name,
            string? notes,
            global::System.Collections.Generic.IList<global::Speechify.TtsPutFlowRequestVariablesItems>? variables)
        {
            this.Name = name;
            this.Notes = notes;
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.Edges = edges ?? throw new global::System.ArgumentNullException(nameof(edges));
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsPutFlowRequest" /> class.
        /// </summary>
        public TtsPutFlowRequest()
        {
        }

    }
}