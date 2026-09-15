
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-caller long-term memory configuration.
    /// </summary>
    public sealed partial class AgentMemoryConfig
    {
        /// <summary>
        /// When true, the retriever injects the top facts about each caller<br/>
        /// into the system prompt via the `{{memory}}` variable, and the<br/>
        /// extractor writes durable facts while `learning_enabled` is true.<br/>
        /// Defaults to false.
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
        /// When false, the agent keeps recalling what it already knows about<br/>
        /// each caller but learns nothing new: no call, run or text<br/>
        /// conversation writes a memory, and turning it back on does not learn<br/>
        /// from what was said while it was off. Has no effect while `enabled`<br/>
        /// is false. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_enabled")]
        public bool? LearningEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMemoryConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// When true, the retriever injects the top facts about each caller<br/>
        /// into the system prompt via the `{{memory}}` variable, and the<br/>
        /// extractor writes durable facts while `learning_enabled` is true.<br/>
        /// Defaults to false.
        /// </param>
        /// <param name="retentionDays">
        /// Maximum age (in days) of memories kept and surfaced. 0<br/>
        /// disables the cap. Defaults to 90.
        /// </param>
        /// <param name="learningEnabled">
        /// When false, the agent keeps recalling what it already knows about<br/>
        /// each caller but learns nothing new: no call, run or text<br/>
        /// conversation writes a memory, and turning it back on does not learn<br/>
        /// from what was said while it was off. Has no effect while `enabled`<br/>
        /// is false. Defaults to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMemoryConfig(
            bool? enabled,
            int? retentionDays,
            bool? learningEnabled)
        {
            this.Enabled = enabled;
            this.RetentionDays = retentionDays;
            this.LearningEnabled = learningEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMemoryConfig" /> class.
        /// </summary>
        public AgentMemoryConfig()
        {
        }

    }
}