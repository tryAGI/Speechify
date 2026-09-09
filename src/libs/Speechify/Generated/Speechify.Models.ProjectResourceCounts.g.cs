
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Live counts of every resource kind grouped under one project. Each<br/>
    /// count is zero, never absent, when the project holds none of that<br/>
    /// kind.<br/>
    /// The resource kinds here are what the project's `resource_count`<br/>
    /// totals, plus the records of work that happened (conversations,<br/>
    /// callers, batch calls, suite runs, memories), which are counted but<br/>
    /// never hold a project open.
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
        /// Number of external brains in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Brains { get; set; }

        /// <summary>
        /// Number of skills in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Skills { get; set; }

        /// <summary>
        /// Number of agent teams in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Teams { get; set; }

        /// <summary>
        /// Number of channel instances (front doors) in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_instances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChannelInstances { get; set; }

        /// <summary>
        /// Number of stores in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Stores { get; set; }

        /// <summary>
        /// Number of hosted APIs in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosted_apis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HostedApis { get; set; }

        /// <summary>
        /// Number of live uploaded files in the project. Files expire on<br/>
        /// their own within a fortnight, so this count falls without<br/>
        /// anyone deleting anything.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Files { get; set; }

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
        /// <param name="brains">
        /// Number of external brains in the project.
        /// </param>
        /// <param name="skills">
        /// Number of skills in the project.
        /// </param>
        /// <param name="teams">
        /// Number of agent teams in the project.
        /// </param>
        /// <param name="channelInstances">
        /// Number of channel instances (front doors) in the project.
        /// </param>
        /// <param name="stores">
        /// Number of stores in the project.
        /// </param>
        /// <param name="hostedApis">
        /// Number of hosted APIs in the project.
        /// </param>
        /// <param name="files">
        /// Number of live uploaded files in the project. Files expire on<br/>
        /// their own within a fortnight, so this count falls without<br/>
        /// anyone deleting anything.
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
            int memories,
            int brains,
            int skills,
            int teams,
            int channelInstances,
            int stores,
            int hostedApis,
            int files)
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
            this.Brains = brains;
            this.Skills = skills;
            this.Teams = teams;
            this.ChannelInstances = channelInstances;
            this.Stores = stores;
            this.HostedApis = hostedApis;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectResourceCounts" /> class.
        /// </summary>
        public ProjectResourceCounts()
        {
        }

    }
}