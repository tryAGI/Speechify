
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What a restore brought back, by kind. Every field is a real count,<br/>
    /// including zero.
    /// </summary>
    public sealed partial class ProjectRestoredCounts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public int? Agents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_tests")]
        public int? AgentTests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_bases")]
        public int? KnowledgeBases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public int? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_assets")]
        public int? AudioAssets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRestoredCounts" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="agentTests"></param>
        /// <param name="knowledgeBases"></param>
        /// <param name="tools"></param>
        /// <param name="audioAssets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectRestoredCounts(
            int? agents,
            int? agentTests,
            int? knowledgeBases,
            int? tools,
            int? audioAssets)
        {
            this.Agents = agents;
            this.AgentTests = agentTests;
            this.KnowledgeBases = knowledgeBases;
            this.Tools = tools;
            this.AudioAssets = audioAssets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRestoredCounts" /> class.
        /// </summary>
        public ProjectRestoredCounts()
        {
        }

    }
}