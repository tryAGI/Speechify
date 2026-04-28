
#nullable enable

namespace Speechify
{
    /// <summary>
    /// List-view projection of a test that includes the most recent run<br/>
    /// so the console can display pass/fail badges without an extra<br/>
    /// round-trip. On the global `/v1/tests` surface, also carries<br/>
    /// `attached_agent_ids` so the row can render agent chips without a<br/>
    /// follow-up request.
    /// </summary>
    public sealed partial class TtsAgentTestWithLastRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Discriminates the shape of `AgentTest.config`.<br/>
        /// - `scenario` - send one message to the agent and judge the response with an LLM.<br/>
        /// - `tool` - assert that the agent calls a specific tool given a context.<br/>
        /// - `simulation` - run a multi-turn conversation between the agent and an AI caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsTestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsTestType Type { get; set; }

        /// <summary>
        /// Type-specific configuration document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsAgentTestConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsAgentTestConfig Config { get; set; }

        /// <summary>
        /// Optional tool-mocking config applied during runs of this test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_mock_config")]
        public global::Speechify.TtsToolMockConfig? ToolMockConfig { get; set; }

        /// <summary>
        /// Per-test dynamic-variable overrides. Keys substitute `{{key}}`<br/>
        /// placeholders inside the test config at run-start. Unknown keys<br/>
        /// render as empty string, matching session dispatch behaviour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Folder the test belongs to; null = root (unfiled).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

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
        /// The most recent run, or null if the test has never been run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsAgentTestRun, object>))]
        public global::Speechify.OneOf<global::Speechify.TtsAgentTestRun, object>? LastRun { get; set; }

        /// <summary>
        /// Every agent this test runs against. Always includes the owner agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attached_agent_ids")]
        public global::System.Collections.Generic.IList<string>? AttachedAgentIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAgentTestWithLastRun" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="type">
        /// Discriminates the shape of `AgentTest.config`.<br/>
        /// - `scenario` - send one message to the agent and judge the response with an LLM.<br/>
        /// - `tool` - assert that the agent calls a specific tool given a context.<br/>
        /// - `simulation` - run a multi-turn conversation between the agent and an AI caller.
        /// </param>
        /// <param name="config">
        /// Type-specific configuration document.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="toolMockConfig">
        /// Optional tool-mocking config applied during runs of this test.
        /// </param>
        /// <param name="variables">
        /// Per-test dynamic-variable overrides. Keys substitute `{{key}}`<br/>
        /// placeholders inside the test config at run-start. Unknown keys<br/>
        /// render as empty string, matching session dispatch behaviour.
        /// </param>
        /// <param name="folderId">
        /// Folder the test belongs to; null = root (unfiled).
        /// </param>
        /// <param name="lastRun">
        /// The most recent run, or null if the test has never been run.
        /// </param>
        /// <param name="attachedAgentIds">
        /// Every agent this test runs against. Always includes the owner agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAgentTestWithLastRun(
            string id,
            string agentId,
            string name,
            string description,
            global::Speechify.TtsTestType type,
            global::Speechify.TtsAgentTestConfig config,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Speechify.TtsToolMockConfig? toolMockConfig,
            object? variables,
            string? folderId,
            global::Speechify.OneOf<global::Speechify.TtsAgentTestRun, object>? lastRun,
            global::System.Collections.Generic.IList<string>? attachedAgentIds)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
            this.Config = config;
            this.ToolMockConfig = toolMockConfig;
            this.Variables = variables;
            this.FolderId = folderId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastRun = lastRun;
            this.AttachedAgentIds = attachedAgentIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAgentTestWithLastRun" /> class.
        /// </summary>
        public TtsAgentTestWithLastRun()
        {
        }
    }
}