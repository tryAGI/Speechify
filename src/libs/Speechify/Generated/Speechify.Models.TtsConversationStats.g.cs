
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Counts + averages over the caller's conversations matching the supplied filters. AVG fields are null when no rows match the FILTER predicate.
    /// </summary>
    public sealed partial class TtsConversationStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Completed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Failed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Pending { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_duration_ms")]
        public double? AvgDurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_cost_cents")]
        public double? AvgCostCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsConversationStats" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="active"></param>
        /// <param name="pending"></param>
        /// <param name="avgDurationMs"></param>
        /// <param name="avgCostCents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsConversationStats(
            long total,
            long completed,
            long failed,
            long active,
            long pending,
            double? avgDurationMs,
            double? avgCostCents)
        {
            this.Total = total;
            this.Completed = completed;
            this.Failed = failed;
            this.Active = active;
            this.Pending = pending;
            this.AvgDurationMs = avgDurationMs;
            this.AvgCostCents = avgCostCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsConversationStats" /> class.
        /// </summary>
        public TtsConversationStats()
        {
        }

    }
}