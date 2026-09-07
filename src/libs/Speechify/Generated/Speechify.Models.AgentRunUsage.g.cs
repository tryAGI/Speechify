
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What the run spent, present only once it has settled: wall-clock, the tokens summed across every step, the same tokens split per model, and what they cost at your plan's rates. Written once at settle and never restated; the webhook payload carries the same values. `input_tokens` includes the cached reads and `cached_input_tokens` is that subset, so the two are never added. `cost_micro_usd` is an integer in millionths of a US dollar, computed from the rate card version named alongside it, and is informational: your invoice is authoritative. A delegated child run reports its own usage; the parent never sums it.
    /// </summary>
    public sealed partial class AgentRunUsage
    {
        /// <summary>
        /// Wall-clock time the agent spent working, summed across steps. Excludes time the run spent queued or parked on a human.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Input tokens summed across every step, cached reads included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// The subset of `input_tokens` served from provider cache reads. Absent when the provider reported none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_input_tokens")]
        public int? CachedInputTokens { get; set; }

        /// <summary>
        /// Output tokens summed across every step, reasoning tokens included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// `input_tokens` + `output_tokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// What the run cost in millionths of a US dollar, the sum of `models[].cost_micro_usd`, priced at your plan's rates on the rate card named by `rate_card_version`. Informational; the invoice is authoritative.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_micro_usd")]
        public long? CostMicroUsd { get; set; }

        /// <summary>
        /// The rate card version the cost was computed against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_card_version")]
        public string? RateCardVersion { get; set; }

        /// <summary>
        /// The token usage and cost split per model, in the order the run first used each; the totals above are the sum over these entries. A run that never changed model has one entry. The model named is the one that actually served the steps, which can differ from the model the agent is configured with when the platform routes a step elsewhere; it is a report, not a promise that the same model serves the next run. An entry whose `model` is empty covers steps whose provider reported no model name.
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
        /// <param name="inputTokens">
        /// Input tokens summed across every step, cached reads included.
        /// </param>
        /// <param name="cachedInputTokens">
        /// The subset of `input_tokens` served from provider cache reads. Absent when the provider reported none.
        /// </param>
        /// <param name="outputTokens">
        /// Output tokens summed across every step, reasoning tokens included.
        /// </param>
        /// <param name="totalTokens">
        /// `input_tokens` + `output_tokens`.
        /// </param>
        /// <param name="costMicroUsd">
        /// What the run cost in millionths of a US dollar, the sum of `models[].cost_micro_usd`, priced at your plan's rates on the rate card named by `rate_card_version`. Informational; the invoice is authoritative.
        /// </param>
        /// <param name="rateCardVersion">
        /// The rate card version the cost was computed against.
        /// </param>
        /// <param name="models">
        /// The token usage and cost split per model, in the order the run first used each; the totals above are the sum over these entries. A run that never changed model has one entry. The model named is the one that actually served the steps, which can differ from the model the agent is configured with when the platform routes a step elsewhere; it is a report, not a promise that the same model serves the next run. An entry whose `model` is empty covers steps whose provider reported no model name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunUsage(
            int? durationMs,
            int? inputTokens,
            int? cachedInputTokens,
            int? outputTokens,
            int? totalTokens,
            long? costMicroUsd,
            string? rateCardVersion,
            global::System.Collections.Generic.IList<global::Speechify.AgentRunUsageModelsItems>? models)
        {
            this.DurationMs = durationMs;
            this.InputTokens = inputTokens;
            this.CachedInputTokens = cachedInputTokens;
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
            this.CostMicroUsd = costMicroUsd;
            this.RateCardVersion = rateCardVersion;
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