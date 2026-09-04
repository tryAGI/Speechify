
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One iteration of a durable run's plan-act-observe loop, journaled in order. A `plan` step carries the agent's rationale (`content`); a `tool_call` step carries the tool it invoked (`tool`) and its rendered arguments (`args`); an `observation` step carries the tool's result (`content`); a `delegation` step carries the sub-goal it handed to a team member (`content`) and the member + child run that took it (`delegation`). The run's final answer is not a step - read it from the run object. Credential-shaped values in `args` and `content` are redacted.
    /// </summary>
    public sealed partial class AgentRunStep
    {
        /// <summary>
        /// 1-based position in the run's append-only journal (ascending = chronological).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seq { get; set; }

        /// <summary>
        /// The step type. `output` is reserved for a future step kind - a run's final answer lives on the run object today, not in the journal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentRunStepKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentRunStepKind Kind { get; set; }

        /// <summary>
        /// The step's payload, per kind: a `plan`'s rationale, an `observation`'s result, or a `delegation`'s sub-goal (redacted).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The tool a `tool_call` / `observation` step is about.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        public string? Tool { get; set; }

        /// <summary>
        /// The rendered arguments of a `tool_call`, with credential-shaped values redacted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public object? Args { get; set; }

        /// <summary>
        /// The hand-off a step describes: which team member took a sub-goal, and the child run that pursued it.<br/>
        /// It appears on BOTH halves of a hand-off, keyed by the same `child_run_id`: the `delegation` step that made it (carrying `depth`), and the later `observation` step that folded the child's result back (carrying `child_status`). Pair them on `child_run_id` to read a sub-goal and its outcome together. The sub-goal and the result themselves are those steps' `content`.<br/>
        /// `child_run_id` is a real run - fetch it with `getRun` (under `agent_id`) for the member's own status, output, and token usage. That is what makes a team run traversable: the parent's timeline links to each member's actual work rather than summarizing it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation")]
        public global::Speechify.RunStepDelegation? Delegation { get; set; }

        /// <summary>
        /// Wall-clock the brain spent producing this step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunStep" /> class.
        /// </summary>
        /// <param name="seq">
        /// 1-based position in the run's append-only journal (ascending = chronological).
        /// </param>
        /// <param name="kind">
        /// The step type. `output` is reserved for a future step kind - a run's final answer lives on the run object today, not in the journal.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="content">
        /// The step's payload, per kind: a `plan`'s rationale, an `observation`'s result, or a `delegation`'s sub-goal (redacted).
        /// </param>
        /// <param name="tool">
        /// The tool a `tool_call` / `observation` step is about.
        /// </param>
        /// <param name="args">
        /// The rendered arguments of a `tool_call`, with credential-shaped values redacted.
        /// </param>
        /// <param name="delegation">
        /// The hand-off a step describes: which team member took a sub-goal, and the child run that pursued it.<br/>
        /// It appears on BOTH halves of a hand-off, keyed by the same `child_run_id`: the `delegation` step that made it (carrying `depth`), and the later `observation` step that folded the child's result back (carrying `child_status`). Pair them on `child_run_id` to read a sub-goal and its outcome together. The sub-goal and the result themselves are those steps' `content`.<br/>
        /// `child_run_id` is a real run - fetch it with `getRun` (under `agent_id`) for the member's own status, output, and token usage. That is what makes a team run traversable: the parent's timeline links to each member's actual work rather than summarizing it.
        /// </param>
        /// <param name="durationMs">
        /// Wall-clock the brain spent producing this step.
        /// </param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="totalTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunStep(
            int seq,
            global::Speechify.AgentRunStepKind kind,
            global::System.DateTime createdAt,
            string? content,
            string? tool,
            object? args,
            global::Speechify.RunStepDelegation? delegation,
            int? durationMs,
            int? promptTokens,
            int? completionTokens,
            int? totalTokens)
        {
            this.Seq = seq;
            this.Kind = kind;
            this.Content = content;
            this.Tool = tool;
            this.Args = args;
            this.Delegation = delegation;
            this.DurationMs = durationMs;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunStep" /> class.
        /// </summary>
        public AgentRunStep()
        {
        }

    }
}