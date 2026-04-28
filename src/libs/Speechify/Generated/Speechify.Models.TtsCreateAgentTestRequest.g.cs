
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for `POST /v1/agents/{id}/tests`.
    /// </summary>
    public sealed partial class TtsCreateAgentTestRequest
    {
        /// <summary>
        /// Short human-readable label for the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional longer description of what this test verifies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        /// Type-specific configuration. Must match the shape for the given `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsCreateAgentTestRequestConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsCreateAgentTestRequestConfig Config { get; set; }

        /// <summary>
        /// Optional tool-mocking config applied during every run of this test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_mock_config")]
        public global::Speechify.TtsToolMockConfig? ToolMockConfig { get; set; }

        /// <summary>
        /// Per-test variable values substituted into string fields of the<br/>
        /// config at run-start. Keys use the same rules as agent-level<br/>
        /// `DynamicVariable` keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Folder to place the test in. Omit for root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Optional list of additional agents this test should also run<br/>
        /// against. The owner agent (path param) is always attached<br/>
        /// implicitly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attached_agent_ids")]
        public global::System.Collections.Generic.IList<string>? AttachedAgentIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateAgentTestRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Short human-readable label for the test.
        /// </param>
        /// <param name="type">
        /// Discriminates the shape of `AgentTest.config`.<br/>
        /// - `scenario` - send one message to the agent and judge the response with an LLM.<br/>
        /// - `tool` - assert that the agent calls a specific tool given a context.<br/>
        /// - `simulation` - run a multi-turn conversation between the agent and an AI caller.
        /// </param>
        /// <param name="config">
        /// Type-specific configuration. Must match the shape for the given `type`.
        /// </param>
        /// <param name="description">
        /// Optional longer description of what this test verifies.
        /// </param>
        /// <param name="toolMockConfig">
        /// Optional tool-mocking config applied during every run of this test.
        /// </param>
        /// <param name="variables">
        /// Per-test variable values substituted into string fields of the<br/>
        /// config at run-start. Keys use the same rules as agent-level<br/>
        /// `DynamicVariable` keys.
        /// </param>
        /// <param name="folderId">
        /// Folder to place the test in. Omit for root.
        /// </param>
        /// <param name="attachedAgentIds">
        /// Optional list of additional agents this test should also run<br/>
        /// against. The owner agent (path param) is always attached<br/>
        /// implicitly.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateAgentTestRequest(
            string name,
            global::Speechify.TtsTestType type,
            global::Speechify.TtsCreateAgentTestRequestConfig config,
            string? description,
            global::Speechify.TtsToolMockConfig? toolMockConfig,
            object? variables,
            string? folderId,
            global::System.Collections.Generic.IList<string>? attachedAgentIds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Type = type;
            this.Config = config;
            this.ToolMockConfig = toolMockConfig;
            this.Variables = variables;
            this.FolderId = folderId;
            this.AttachedAgentIds = attachedAgentIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateAgentTestRequest" /> class.
        /// </summary>
        public TtsCreateAgentTestRequest()
        {
        }
    }
}