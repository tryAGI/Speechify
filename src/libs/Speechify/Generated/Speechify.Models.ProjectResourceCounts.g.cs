
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Live counts of every resource kind grouped under one project. Each<br/>
    /// count is zero, never absent, when the project holds none of that<br/>
    /// kind.
    /// </summary>
    public sealed partial class ProjectResourceCounts
    {
        /// <summary>
        /// Number of agents in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Agents { get; set; }

        /// <summary>
        /// Number of knowledge bases in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_bases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int KnowledgeBases { get; set; }

        /// <summary>
        /// Number of tools in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Tools { get; set; }

        /// <summary>
        /// Number of phone numbers in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PhoneNumbers { get; set; }

        /// <summary>
        /// Number of audio assets in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioAssets { get; set; }

        /// <summary>
        /// Number of conversations attributed to the project. Attribution is<br/>
        /// frozen at the conversation's creation time and does not follow<br/>
        /// its agent to a later project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Conversations { get; set; }

        /// <summary>
        /// Number of callers attributed to the project, frozen the same way<br/>
        /// as conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Callers { get; set; }

        /// <summary>
        /// Number of agent tests attributed to the project, frozen the same<br/>
        /// way as conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_tests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AgentTests { get; set; }

        /// <summary>
        /// Number of batch calls attributed to the project, frozen the same<br/>
        /// way as conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BatchCalls { get; set; }

        /// <summary>
        /// Number of agent test suite runs attributed to the project, frozen<br/>
        /// the same way as conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_test_suite_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AgentTestSuiteRuns { get; set; }

        /// <summary>
        /// Number of live caller memories attributed to the project, frozen<br/>
        /// the same way as conversations. A count only; the extracted facts<br/>
        /// themselves are never returned here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Memories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectResourceCounts" /> class.
        /// </summary>
        /// <param name="agents">
        /// Number of agents in the project.
        /// </param>
        /// <param name="knowledgeBases">
        /// Number of knowledge bases in the project.
        /// </param>
        /// <param name="tools">
        /// Number of tools in the project.
        /// </param>
        /// <param name="phoneNumbers">
        /// Number of phone numbers in the project.
        /// </param>
        /// <param name="audioAssets">
        /// Number of audio assets in the project.
        /// </param>
        /// <param name="conversations">
        /// Number of conversations attributed to the project. Attribution is<br/>
        /// frozen at the conversation's creation time and does not follow<br/>
        /// its agent to a later project.
        /// </param>
        /// <param name="callers">
        /// Number of callers attributed to the project, frozen the same way<br/>
        /// as conversations.
        /// </param>
        /// <param name="agentTests">
        /// Number of agent tests attributed to the project, frozen the same<br/>
        /// way as conversations.
        /// </param>
        /// <param name="batchCalls">
        /// Number of batch calls attributed to the project, frozen the same<br/>
        /// way as conversations.
        /// </param>
        /// <param name="agentTestSuiteRuns">
        /// Number of agent test suite runs attributed to the project, frozen<br/>
        /// the same way as conversations.
        /// </param>
        /// <param name="memories">
        /// Number of live caller memories attributed to the project, frozen<br/>
        /// the same way as conversations. A count only; the extracted facts<br/>
        /// themselves are never returned here.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectResourceCounts(
            int agents,
            int knowledgeBases,
            int tools,
            int phoneNumbers,
            int audioAssets,
            int conversations,
            int callers,
            int agentTests,
            int batchCalls,
            int agentTestSuiteRuns,
            int memories)
        {
            this.Agents = agents;
            this.KnowledgeBases = knowledgeBases;
            this.Tools = tools;
            this.PhoneNumbers = phoneNumbers;
            this.AudioAssets = audioAssets;
            this.Conversations = conversations;
            this.Callers = callers;
            this.AgentTests = agentTests;
            this.BatchCalls = batchCalls;
            this.AgentTestSuiteRuns = agentTestSuiteRuns;
            this.Memories = memories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectResourceCounts" /> class.
        /// </summary>
        public ProjectResourceCounts()
        {
        }

    }
}