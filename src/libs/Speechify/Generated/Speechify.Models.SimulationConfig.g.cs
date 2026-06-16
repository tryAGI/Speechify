
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Configuration for a `simulation` test. An AI caller drives a<br/>
    /// multi-turn conversation with the agent according to `scenario`.<br/>
    /// After `max_turns` exchanges (or when the agent ends the call),<br/>
    /// the unified post-call evaluator scores the synthetic transcript<br/>
    /// against the agent's configured evaluation criteria + data<br/>
    /// collection fields. A test passes when no configured criterion<br/>
    /// fails and every `data_assertions` entry passes.
    /// </summary>
    public sealed partial class SimulationConfig
    {
        /// <summary>
        /// Instructions for the AI caller describing who they are and what they want.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenario")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scenario { get; set; }

        /// <summary>
        /// Maximum agent turns before the simulation is cut off and judged.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_turns")]
        public int? MaxTurns { get; set; }

        /// <summary>
        /// Optional seed conversation that precedes the AI caller's first generated message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_chat_history")]
        public global::System.Collections.Generic.IList<global::Speechify.SimulationMessage>? InitialChatHistory { get; set; }

        /// <summary>
        /// Optional assertions on the LLM-extracted data-collection<br/>
        /// map. Each entry references a key from the agent's<br/>
        /// data_collection config and validates the extracted value.<br/>
        /// The test fails if any assertion fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_assertions")]
        public global::System.Collections.Generic.IList<global::Speechify.DataAssertion>? DataAssertions { get; set; }

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
        /// Initializes a new instance of the <see cref="SimulationConfig" /> class.
        /// </summary>
        /// <param name="scenario">
        /// Instructions for the AI caller describing who they are and what they want.
        /// </param>
        /// <param name="maxTurns">
        /// Maximum agent turns before the simulation is cut off and judged.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="initialChatHistory">
        /// Optional seed conversation that precedes the AI caller's first generated message.
        /// </param>
        /// <param name="dataAssertions">
        /// Optional assertions on the LLM-extracted data-collection<br/>
        /// map. Each entry references a key from the agent's<br/>
        /// data_collection config and validates the extracted value.<br/>
        /// The test fails if any assertion fails.
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
        public SimulationConfig(
            string scenario,
            int? maxTurns,
            global::System.Collections.Generic.IList<global::Speechify.SimulationMessage>? initialChatHistory,
            global::System.Collections.Generic.IList<global::Speechify.DataAssertion>? dataAssertions,
            string? systemPromptOverride,
            string? modelOverride)
        {
            this.Scenario = scenario ?? throw new global::System.ArgumentNullException(nameof(scenario));
            this.MaxTurns = maxTurns;
            this.InitialChatHistory = initialChatHistory;
            this.DataAssertions = dataAssertions;
            this.SystemPromptOverride = systemPromptOverride;
            this.ModelOverride = modelOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationConfig" /> class.
        /// </summary>
        public SimulationConfig()
        {
        }

    }
}