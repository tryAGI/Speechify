
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Request body for creating (POST) or replacing (PATCH) a flow<br/>
    /// template. PATCH replaces the whole template, it is not a<br/>
    /// field-by-field patch.
    /// </summary>
    public sealed partial class TtsCreateFlowTemplateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

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
        /// Defaults to "custom" when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Request-side flow graph: nodes, edges, and variables only.<br/>
        /// Unlike the response-side FlowGraph it carries no `version`<br/>
        /// block - the server owns version metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsFlowGraphInput Graph { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateFlowTemplateRequest" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="graph">
        /// Request-side flow graph: nodes, edges, and variables only.<br/>
        /// Unlike the response-side FlowGraph it carries no `version`<br/>
        /// block - the server owns version metadata.
        /// </param>
        /// <param name="description"></param>
        /// <param name="category">
        /// Defaults to "custom" when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateFlowTemplateRequest(
            string key,
            string name,
            global::Speechify.TtsFlowGraphInput graph,
            string? description,
            string? category)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Category = category;
            this.Graph = graph ?? throw new global::System.ArgumentNullException(nameof(graph));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateFlowTemplateRequest" /> class.
        /// </summary>
        public TtsCreateFlowTemplateRequest()
        {
        }

    }
}