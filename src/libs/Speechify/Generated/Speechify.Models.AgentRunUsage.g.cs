
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What the run cost, populated once it reaches a terminal state: its wall-clock time plus its token usage summed across every step.<br/>
    /// The counts are THIS run's own. A run that delegated sub-goals does not include its children's, so a team run's true cost is this plus the usage of each run from `listRunChildren`.<br/>
    /// Attribute and forecast spend against the token counts. The model is not reported; your plan, not a model name, is what prices a run.
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