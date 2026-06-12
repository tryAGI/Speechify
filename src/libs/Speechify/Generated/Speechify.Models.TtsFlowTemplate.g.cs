
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A reusable flow graph that can be cloned onto an agent as a new draft.
    /// </summary>
    public sealed partial class TtsFlowTemplate
    {
        /// <summary>
        /// Flow template id. A raw UUID, not a prefixed external id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Stable unique key for the template.
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// A flow graph: an ordered set of typed nodes connected by edges,<br/>
        /// plus flow variables. The node, edge, and variable shapes are<br/>
        /// governed by the live JSON Schema at GET /v1/agents/flow/schema<br/>
        /// and are intentionally opaque here so this spec cannot drift<br/>
        /// from that authoritative definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsFlowGraph Graph { get; set; }

        /// <summary>
        /// True for platform-provided templates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsFlowTemplate" /> class.
        /// </summary>
        /// <param name="id">
        /// Flow template id. A raw UUID, not a prefixed external id.
        /// </param>
        /// <param name="key">
        /// Stable unique key for the template.
        /// </param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="graph">
        /// A flow graph: an ordered set of typed nodes connected by edges,<br/>
        /// plus flow variables. The node, edge, and variable shapes are<br/>
        /// governed by the live JSON Schema at GET /v1/agents/flow/schema<br/>
        /// and are intentionally opaque here so this spec cannot drift<br/>
        /// from that authoritative definition.
        /// </param>
        /// <param name="isSeed">
        /// True for platform-provided templates.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsFlowTemplate(
            string id,
            string key,
            string name,
            string category,
            global::Speechify.TtsFlowGraph graph,
            bool isSeed,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Graph = graph ?? throw new global::System.ArgumentNullException(nameof(graph));
            this.IsSeed = isSeed;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsFlowTemplate" /> class.
        /// </summary>
        public TtsFlowTemplate()
        {
        }

    }
}