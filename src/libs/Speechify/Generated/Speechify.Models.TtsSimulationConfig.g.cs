
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Configuration for a `simulation` test. An AI caller drives a<br/>
    /// multi-turn conversation with the agent according to `scenario`.<br/>
    /// After `max_turns` exchanges (or when the agent ends the call), an<br/>
    /// LLM judge evaluates whether `success_condition` was met.<br/>
    /// Use `initial_chat_history` to seed the conversation at a specific<br/>
    /// mid-flow state.
    /// </summary>
    public sealed partial class TtsSimulationConfig
    {
        /// <summary>
        /// Instructions for the AI caller describing who they are and what they want.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenario")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scenario { get; set; }

        /// <summary>
        /// Natural-language description of what a passing conversation looks like.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SuccessCondition { get; set; }

        /// <summary>
        /// Maximum agent turns before the simulation is cut off and judged.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTurns { get; set; }

        /// <summary>
        /// Optional seed conversation that precedes the AI caller's first generated message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_chat_history")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsSimulationMessage>? InitialChatHistory { get; set; }

        /// <summary>
        /// Replaces the agent's system prompt for this run only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt_override")]
        public string? SystemPromptOverride { get; set; }

        /// <summary>
        /// Overrides the LLM model used by the agent for this run only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_override")]
        public string? ModelOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSimulationConfig" /> class.
        /// </summary>
        /// <param name="scenario">
        /// Instructions for the AI caller describing who they are and what they want.
        /// </param>
        /// <param name="successCondition">
        /// Natural-language description of what a passing conversation looks like.
        /// </param>
        /// <param name="maxTurns">
        /// Maximum agent turns before the simulation is cut off and judged.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="initialChatHistory">
        /// Optional seed conversation that precedes the AI caller's first generated message.
        /// </param>
        /// <param name="systemPromptOverride">
        /// Replaces the agent's system prompt for this run only.
        /// </param>
        /// <param name="modelOverride">
        /// Overrides the LLM model used by the agent for this run only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsSimulationConfig(
            string scenario,
            string successCondition,
            int maxTurns,
            global::System.Collections.Generic.IList<global::Speechify.TtsSimulationMessage>? initialChatHistory,
            string? systemPromptOverride,
            string? modelOverride)
        {
            this.Scenario = scenario ?? throw new global::System.ArgumentNullException(nameof(scenario));
            this.SuccessCondition = successCondition ?? throw new global::System.ArgumentNullException(nameof(successCondition));
            this.MaxTurns = maxTurns;
            this.InitialChatHistory = initialChatHistory;
            this.SystemPromptOverride = systemPromptOverride;
            this.ModelOverride = modelOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSimulationConfig" /> class.
        /// </summary>
        public TtsSimulationConfig()
        {
        }
    }
}