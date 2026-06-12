
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Configuration for a `reply` test. The runner sends `context` as<br/>
    /// a user message and asks an LLM judge to evaluate the agent response<br/>
    /// against `success_criteria`. Optional few-shot examples sharpen the<br/>
    /// judge's calibration. Use `initial_chat_history` to prepend prior<br/>
    /// turns before `context`; when the history already ends with a user<br/>
    /// message, `context` may be omitted and the agent is evaluated on<br/>
    /// its reply to that last history turn.
    /// </summary>
    public sealed partial class TtsReplyConfig
    {
        /// <summary>
        /// User message sent to the agent to trigger the behaviour under test. Optional when `initial_chat_history` already ends with a user message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Natural-language description of what a passing agent response looks like.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SuccessCriteria { get; set; }

        /// <summary>
        /// Concrete examples of passing responses (few-shot for the judge).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_examples")]
        public global::System.Collections.Generic.IList<string>? SuccessExamples { get; set; }

        /// <summary>
        /// Concrete examples of failing responses (few-shot for the judge).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_examples")]
        public global::System.Collections.Generic.IList<string>? FailureExamples { get; set; }

        /// <summary>
        /// Optional seed conversation prepended before `context`. Lets you test the agent's reply mid-conversation rather than on a cold single-turn prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_chat_history")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsSimulationMessage>? InitialChatHistory { get; set; }

        /// <summary>
        /// Deprecated (AIS-3443). Prefer the run-level `config_override`<br/>
        /// on `POST /v1/agents/{id}/tests/runs`, which applies a proposed<br/>
        /// prompt to every test in the run without editing each one.<br/>
        /// Still honoured; the run-level override wins when both are set.<br/>
        /// Replaces the agent's system prompt for this run only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt_override")]
        public string? SystemPromptOverride { get; set; }

        /// <summary>
        /// Replaces the agent's first message for this run only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_override")]
        public string? FirstMessageOverride { get; set; }

        /// <summary>
        /// Deprecated (AIS-3443). Prefer the run-level `config_override`<br/>
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
        /// Initializes a new instance of the <see cref="TtsReplyConfig" /> class.
        /// </summary>
        /// <param name="successCriteria">
        /// Natural-language description of what a passing agent response looks like.
        /// </param>
        /// <param name="context">
        /// User message sent to the agent to trigger the behaviour under test. Optional when `initial_chat_history` already ends with a user message.
        /// </param>
        /// <param name="successExamples">
        /// Concrete examples of passing responses (few-shot for the judge).
        /// </param>
        /// <param name="failureExamples">
        /// Concrete examples of failing responses (few-shot for the judge).
        /// </param>
        /// <param name="initialChatHistory">
        /// Optional seed conversation prepended before `context`. Lets you test the agent's reply mid-conversation rather than on a cold single-turn prompt.
        /// </param>
        /// <param name="systemPromptOverride">
        /// Deprecated (AIS-3443). Prefer the run-level `config_override`<br/>
        /// on `POST /v1/agents/{id}/tests/runs`, which applies a proposed<br/>
        /// prompt to every test in the run without editing each one.<br/>
        /// Still honoured; the run-level override wins when both are set.<br/>
        /// Replaces the agent's system prompt for this run only.
        /// </param>
        /// <param name="firstMessageOverride">
        /// Replaces the agent's first message for this run only.
        /// </param>
        /// <param name="modelOverride">
        /// Deprecated (AIS-3443). Prefer the run-level `config_override`<br/>
        /// on `POST /v1/agents/{id}/tests/runs`. Still honoured; the<br/>
        /// run-level override wins when both are set. Overrides the LLM<br/>
        /// model used by the agent for this run only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsReplyConfig(
            string successCriteria,
            string? context,
            global::System.Collections.Generic.IList<string>? successExamples,
            global::System.Collections.Generic.IList<string>? failureExamples,
            global::System.Collections.Generic.IList<global::Speechify.TtsSimulationMessage>? initialChatHistory,
            string? systemPromptOverride,
            string? firstMessageOverride,
            string? modelOverride)
        {
            this.Context = context;
            this.SuccessCriteria = successCriteria ?? throw new global::System.ArgumentNullException(nameof(successCriteria));
            this.SuccessExamples = successExamples;
            this.FailureExamples = failureExamples;
            this.InitialChatHistory = initialChatHistory;
            this.SystemPromptOverride = systemPromptOverride;
            this.FirstMessageOverride = firstMessageOverride;
            this.ModelOverride = modelOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsReplyConfig" /> class.
        /// </summary>
        public TtsReplyConfig()
        {
        }

    }
}