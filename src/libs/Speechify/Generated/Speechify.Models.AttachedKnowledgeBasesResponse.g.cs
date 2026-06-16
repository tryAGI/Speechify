
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Bare list of the knowledge bases attached to an agent. Not<br/>
    /// paginated — an agent's KB attachment count is naturally<br/>
    /// bounded (configuration, not data scale).
    /// </summary>
    public sealed partial class AttachedKnowledgeBasesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_bases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.KnowledgeBase> KnowledgeBases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedKnowledgeBasesResponse" /> class.
        /// </summary>
        /// <param name="knowledgeBases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachedKnowledgeBasesResponse(
            global::System.Collections.Generic.IList<global::Speechify.KnowledgeBase> knowledgeBases)
        {
            this.KnowledgeBases = knowledgeBases ?? throw new global::System.ArgumentNullException(nameof(knowledgeBases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedKnowledgeBasesResponse" /> class.
        /// </summary>
        public AttachedKnowledgeBasesResponse()
        {
        }

    }
}