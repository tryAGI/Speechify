
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for `POST /v1/agents/tests`.
    /// </summary>
    public sealed partial class CreateAgentTestRequest
    {
        /// <summary>
        /// Optional authoring agent (`agent_&lt;26 char Crockford base32&gt;`).<br/>
        /// When supplied it must be an agent in the caller's workspace; it<br/>
        /// seeds the test's tool schemas and variables and is recorded as<br/>
        /// authored-from provenance. Omit it to create a bare workspace<br/>
        /// test with no authoring agent. It is never a scope, and the run<br/>
        /// target is bound at run time independently of it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

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
        /// - `reply` - send one message to the agent and judge the response with an LLM.<br/>
        /// - `tool` - assert that the agent calls a specific tool given a context.<br/>
        /// - `simulation` - run a multi-turn conversation between the agent and an AI caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TestType Type { get; set; }

        /// <summary>
        /// Type-specific configuration. Must match the shape for the given `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.CreateAgentTestRequestConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.CreateAgentTestRequestConfig Config { get; set; }

        /// <summary>
        /// Optional tool-mocking config applied during every run of this test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_mock_config")]
        public global::Speechify.ToolMockConfig? ToolMockConfig { get; set; }

        /// <summary>
        /// Per-test variable values substituted into string fields of the<br/>
        /// config at run-start. Keys use the same rules as agent-level<br/>
        /// `DynamicVariable` keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`folder_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the folder to place the test in. Omit / null for root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentTestRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Short human-readable label for the test.
        /// </param>
        /// <param name="type">
        /// Discriminates the shape of `AgentTest.config`.<br/>
        /// - `reply` - send one message to the agent and judge the response with an LLM.<br/>
        /// - `tool` - assert that the agent calls a specific tool given a context.<br/>
        /// - `simulation` - run a multi-turn conversation between the agent and an AI caller.
        /// </param>
        /// <param name="config">
        /// Type-specific configuration. Must match the shape for the given `type`.
        /// </param>
        /// <param name="agentId">
        /// Optional authoring agent (`agent_&lt;26 char Crockford base32&gt;`).<br/>
        /// When supplied it must be an agent in the caller's workspace; it<br/>
        /// seeds the test's tool schemas and variables and is recorded as<br/>
        /// authored-from provenance. Omit it to create a bare workspace<br/>
        /// test with no authoring agent. It is never a scope, and the run<br/>
        /// target is bound at run time independently of it.
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
        /// Prefixed wire identifier (`folder_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the folder to place the test in. Omit / null for root.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentTestRequest(
            string name,
            global::Speechify.TestType type,
            global::Speechify.CreateAgentTestRequestConfig config,
            string? agentId,
            string? description,
            global::Speechify.ToolMockConfig? toolMockConfig,
            object? variables,
            string? folderId)
        {
            this.AgentId = agentId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Type = type;
            this.Config = config;
            this.ToolMockConfig = toolMockConfig;
            this.Variables = variables;
            this.FolderId = folderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentTestRequest" /> class.
        /// </summary>
        public CreateAgentTestRequest()
        {
        }

    }
}