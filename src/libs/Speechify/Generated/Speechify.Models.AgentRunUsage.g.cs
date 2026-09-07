
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What the run spent, populated once it reaches a terminal state: its wall-clock time plus its token usage summed across every step, and the same tokens split by the model that spent them (`models`).<br/>
    /// The counts are THIS run's own. A run that delegated sub-goals does not include its children's, so a team run's true cost is this plus the usage of each run from `listRunChildren`; each child reports its own `usage` the same way, and nothing is counted twice.<br/>
    /// It is final. Usage is written once, when the run settles, and never restated; the same object rides every `run.*` webhook event.<br/>
    /// No dollar figure is carried: price the run against your plan's per-model token rates using `models`, and treat your invoice as authoritative.
    /// </summary>
    public sealed partial class AgentRunUsage
    {
        /// <summary>
        /// Wall-clock time the agent spent working, summed across steps. Excludes time the run spent queued or parked on a human.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Prompt tokens summed across every step of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Completion tokens summed across every step of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// `prompt_tokens` + `completion_tokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// The token usage split per model, in the order the run first used each; the totals above are the sum over these entries. A run that never changed model has one entry. The model named is the one that actually served the steps, which can differ from the model the agent is configured with when the platform routes a step elsewhere; it is a report, not a promise that the same model serves the next run. An entry whose `model` is empty covers steps whose provider reported no model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::Speechify.AgentRunUsageModelsItems>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunUsage" /> class.
        /// </summary>
        /// <param name="durationMs">
        /// Wall-clock time the agent spent working, summed across steps. Excludes time the run spent queued or parked on a human.
        /// </param>
        /// <param name="promptTokens">
        /// Prompt tokens summed across every step of the run.
        /// </param>
        /// <param name="completionTokens">
        /// Completion tokens summed across every step of the run.
        /// </param>
        /// <param name="totalTokens">
        /// `prompt_tokens` + `completion_tokens`.
        /// </param>
        /// <param name="models">
        /// The token usage split per model, in the order the run first used each; the totals above are the sum over these entries. A run that never changed model has one entry. The model named is the one that actually served the steps, which can differ from the model the agent is configured with when the platform routes a step elsewhere; it is a report, not a promise that the same model serves the next run. An entry whose `model` is empty covers steps whose provider reported no model name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunUsage(
            int? durationMs,
            int? promptTokens,
            int? completionTokens,
            int? totalTokens,
            global::System.Collections.Generic.IList<global::Speechify.AgentRunUsageModelsItems>? models)
        {
            this.DurationMs = durationMs;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunUsage" /> class.
        /// </summary>
        public AgentRunUsage()
        {
        }

    }
}