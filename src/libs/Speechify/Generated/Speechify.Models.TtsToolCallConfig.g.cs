
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Configuration for a `tool` test. The runner sends `context` as a<br/>
    /// user message and asserts that the agent calls `expected_tool` with<br/>
    /// arguments matching all `parameter_checks`. Use<br/>
    /// `initial_chat_history` to test tool invocations that only make<br/>
    /// sense mid-conversation.
    /// </summary>
    public sealed partial class TtsToolCallConfig
    {
        /// <summary>
        /// User message that should cause the agent to invoke the expected tool. Optional when `initial_chat_history` already ends with a user message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Name of the tool the agent is expected to call. Leave empty to<br/>
        /// invert the assertion: the test passes only when the agent calls<br/>
        /// no tool at all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpectedTool { get; set; }

        /// <summary>
        /// Assertions on specific arguments of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter_checks")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsParameterCheck>? ParameterChecks { get; set; }

        /// <summary>
        /// Optional seed conversation prepended before `context`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_chat_history")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsSimulationMessage>? InitialChatHistory { get; set; }

        /// <summary>
        /// Deprecated. Prefer the run-level `config_override`<br/>
        /// on `POST /v1/agents/{id}/tests/runs`. Still honoured; the<br/>
        /// run-level override wins when both are set. Replaces the<br/>
        /// agent's system prompt for this run only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt_override")]
        public string? SystemPromptOverride { get; set; }

        /// <summary>
        /// Deprecated. Prefer the run-level `config_override`<br/>
        /// on `POST /v1/agents/{id}/tests/runs`. Still honoured; the<br/>
        /// run-level override wins when both are set. Overrides the LLM<br/>
        /// model used by the agent for this run only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_override")]
        public string? ModelOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsToolCallConfig" /> class.
        /// </summary>
        /// <param name="expectedTool">
        /// Name of the tool the agent is expected to call. Leave empty to<br/>
        /// invert the assertion: the test passes only when the agent calls<br/>
        /// no tool at all.
        /// </param>
        /// <param name="context">
        /// User message that should cause the agent to invoke the expected tool. Optional when `initial_chat_history` already ends with a user message.
        /// </param>
        /// <param name="parameterChecks">
        /// Assertions on specific arguments of the tool call.
        /// </param>
        /// <param name="initialChatHistory">
        /// Optional seed conversation prepended before `context`.
        /// </param>
        /// <param name="systemPromptOverride">
        /// Deprecated. Prefer the run-level `config_override`<br/>
        /// on `POST /v1/agents/{id}/tests/runs`. Still honoured; the<br/>
        /// run-level override wins when both are set. Replaces the<br/>
        /// agent's system prompt for this run only.
        /// </param>
        /// <param name="modelOverride">
        /// Deprecated. Prefer the run-level `config_override`<br/>
        /// on `POST /v1/agents/{id}/tests/runs`. Still honoured; the<br/>
        /// run-level override wins when both are set. Overrides the LLM<br/>
        /// model used by the agent for this run only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsToolCallConfig(
            string expectedTool,
            string? context,
            global::System.Collections.Generic.IList<global::Speechify.TtsParameterCheck>? parameterChecks,
            global::System.Collections.Generic.IList<global::Speechify.TtsSimulationMessage>? initialChatHistory,
            string? systemPromptOverride,
            string? modelOverride)
        {
            this.Context = context;
            this.ExpectedTool = expectedTool ?? throw new global::System.ArgumentNullException(nameof(expectedTool));
            this.ParameterChecks = parameterChecks;
            this.InitialChatHistory = initialChatHistory;
            this.SystemPromptOverride = systemPromptOverride;
            this.ModelOverride = modelOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsToolCallConfig" /> class.
        /// </summary>
        public TtsToolCallConfig()
        {
        }

    }
}