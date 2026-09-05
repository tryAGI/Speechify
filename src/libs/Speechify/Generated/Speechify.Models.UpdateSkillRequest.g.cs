
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Merge-patch. `name` and `description` edit in place; any of<br/>
    /// `instructions`, `tool_ids`, `knowledge_base_ids` or `variables` mints a<br/>
    /// new version instead. A present list replaces rather than appends.
    /// </summary>
    public sealed partial class UpdateSkillRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_ids")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_ids")]
        public global::System.Collections.Generic.IList<string>? KnowledgeBaseIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSkillRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="instructions"></param>
        /// <param name="toolIds"></param>
        /// <param name="knowledgeBaseIds"></param>
        /// <param name="variables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSkillRequest(
            string? name,
            string? description,
            string? instructions,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::System.Collections.Generic.IList<string>? knowledgeBaseIds,
            global::System.Collections.Generic.Dictionary<string, string>? variables)
        {
            this.Name = name;
            this.Description = description;
            this.Instructions = instructions;
            this.ToolIds = toolIds;
            this.KnowledgeBaseIds = knowledgeBaseIds;
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSkillRequest" /> class.
        /// </summary>
        public UpdateSkillRequest()
        {
        }

    }
}