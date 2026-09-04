
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Metered cost, populated at a terminal state: the run's wall-clock plus its aggregate token usage summed across every step. Token counts are THIS run's own - a run that delegated sub-goals does not include its children's usage, so a team run's total cost is this plus the usage of each run from `listRunChildren`.<br/>
    /// Token counts are what to attribute and forecast spend against. The underlying model is not reported: which model serves a tier is ours to route and may change, and pricing lives in your plan rather than in the model name.
    /// </summary>
    public sealed partial class AgentRunUsage
    {
        /// <summary>
        ///
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunUsage" /> class.
        /// </summary>
        /// <param name="durationMs"></param>
        /// <param name="promptTokens">
        /// Prompt tokens summed across every step of the run.
        /// </param>
        /// <param name="completionTokens">
        /// Completion tokens summed across every step of the run.
        /// </param>
        /// <param name="totalTokens">
        /// `prompt_tokens` + `completion_tokens`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunUsage(
            int? durationMs,
            int? promptTokens,
            int? completionTokens,
            int? totalTokens)
        {
            this.DurationMs = durationMs;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunUsage" /> class.
        /// </summary>
        public AgentRunUsage()
        {
        }

    }
}