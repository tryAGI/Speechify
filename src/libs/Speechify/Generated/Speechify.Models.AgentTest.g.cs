
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A configured test against a voice agent. `config` is a<br/>
    /// type-specific document - see `ReplyConfig`, `ToolCallConfig`,<br/>
    /// and `SimulationConfig` for the per-type shapes (discriminated by `type`).
    /// </summary>
    public sealed partial class AgentTest
    {
        /// <summary>
        /// Prefixed wire identifier (`test_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent this test was authored against, or `null` for a<br/>
        /// bare workspace test with no authoring agent. This is<br/>
        /// authored-from provenance - it records which agent's tool schemas<br/>
        /// and variables the test was built from, plus an audit of where<br/>
        /// the test came from - not an ownership or access handle: every<br/>
        /// read, list, and run is scoped by workspace, and the run target<br/>
        /// is bound at run time independently of this field. It also stays<br/>
        /// put (a dangling provenance pointer) if the authoring agent is<br/>
        /// later deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

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
        /// - `reply` - send one message to the agent and judge the response with an LLM.<br/>
        /// - `tool` - assert that the agent calls a specific tool given a context.<br/>
        /// - `simulation` - run a multi-turn conversation between the agent and an AI caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TestType Type { get; set; }

        /// <summary>
        /// Type-specific configuration document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentTestConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentTestConfig Config { get; set; }

        /// <summary>
        /// Optional tool-mocking config applied during runs of this test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_mock_config")]
        public global::Speechify.ToolMockConfig? ToolMockConfig { get; set; }

        /// <summary>
        /// Per-test dynamic-variable overrides. Keys substitute `{{key}}`<br/>
        /// placeholders inside the test config at run-start. Unknown keys<br/>
        /// render as empty string, matching session dispatch behaviour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// When set, prefixed wire identifier<br/>
        /// (`folder_&lt;26 char Crockford base32&gt;`) of the containing folder.<br/>
        /// Null means root (unfiled).
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTest" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`test_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="type">
        /// Discriminates the shape of `AgentTest.config`.<br/>
        /// - `reply` - send one message to the agent and judge the response with an LLM.<br/>
        /// - `tool` - assert that the agent calls a specific tool given a context.<br/>
        /// - `simulation` - run a multi-turn conversation between the agent and an AI caller.
        /// </param>
        /// <param name="config">
        /// Type-specific configuration document.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="agentId">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent this test was authored against, or `null` for a<br/>
        /// bare workspace test with no authoring agent. This is<br/>
        /// authored-from provenance - it records which agent's tool schemas<br/>
        /// and variables the test was built from, plus an audit of where<br/>
        /// the test came from - not an ownership or access handle: every<br/>
        /// read, list, and run is scoped by workspace, and the run target<br/>
        /// is bound at run time independently of this field. It also stays<br/>
        /// put (a dangling provenance pointer) if the authoring agent is<br/>
        /// later deleted.
        /// </param>
        /// <param name="toolMockConfig">
        /// Optional tool-mocking config applied during runs of this test.
        /// </param>
        /// <param name="variables">
        /// Per-test dynamic-variable overrides. Keys substitute `{{key}}`<br/>
        /// placeholders inside the test config at run-start. Unknown keys<br/>
        /// render as empty string, matching session dispatch behaviour.
        /// </param>
        /// <param name="folderId">
        /// When set, prefixed wire identifier<br/>
        /// (`folder_&lt;26 char Crockford base32&gt;`) of the containing folder.<br/>
        /// Null means root (unfiled).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTest(
            string id,
            string name,
            string description,
            global::Speechify.TestType type,
            global::Speechify.AgentTestConfig config,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? agentId,
            global::Speechify.ToolMockConfig? toolMockConfig,
            object? variables,
            string? folderId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
            this.Config = config;
            this.ToolMockConfig = toolMockConfig;
            this.Variables = variables;
            this.FolderId = folderId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTest" /> class.
        /// </summary>
        public AgentTest()
        {
        }

    }
}