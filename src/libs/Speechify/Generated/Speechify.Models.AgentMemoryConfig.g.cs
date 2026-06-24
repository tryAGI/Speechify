
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-caller long-term memory configuration.
    /// </summary>
    public sealed partial class AgentMemoryConfig
    {
        /// <summary>
        /// When true, the post-call extractor writes durable facts about<br/>
        /// each caller and the retriever injects the top matches into the<br/>
        /// system prompt via the `{{memory}}` variable. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Maximum age (in days) of memories kept and surfaced. 0<br/>
        /// disables the cap. Defaults to 90.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_days")]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMemoryConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// When true, the post-call extractor writes durable facts about<br/>
        /// each caller and the retriever injects the top matches into the<br/>
        /// system prompt via the `{{memory}}` variable. Defaults to false.
        /// </param>
        /// <param name="retentionDays">
        /// Maximum age (in days) of memories kept and surfaced. 0<br/>
        /// disables the cap. Defaults to 90.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMemoryConfig(
            bool? enabled,
            int? retentionDays)
        {
            this.Enabled = enabled;
            this.RetentionDays = retentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMemoryConfig" /> class.
        /// </summary>
        public AgentMemoryConfig()
        {
        }

    }
}