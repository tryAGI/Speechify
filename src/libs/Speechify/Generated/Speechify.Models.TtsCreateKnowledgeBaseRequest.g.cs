
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsCreateKnowledgeBaseRequest
    {
        /// <summary>
        /// Human-readable label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateKnowledgeBaseRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable label.
        /// </param>
        /// <param name="description">
        /// Optional description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateKnowledgeBaseRequest(
            string name,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateKnowledgeBaseRequest" /> class.
        /// </summary>
        public TtsCreateKnowledgeBaseRequest()
        {
        }
    }
}