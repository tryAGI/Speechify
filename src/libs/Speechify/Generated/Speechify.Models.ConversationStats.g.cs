
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Counts + averages over the caller's conversations matching the supplied filters. AVG fields are null when no rows match the FILTER predicate.
    /// </summary>
    public sealed partial class ConversationStats
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
        /// Conversations that are a realtime session in progress - a call you<br/>
        /// could listen to or end. A strict subset of `active` + `pending`,<br/>
        /// and deliberately smaller: a text conversation stays non-terminal<br/>
        /// for as long as the person might return to the thread, so it is<br/>
        /// open rather than live and is not counted here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("live")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Live { get; set; }

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
        /// Initializes a new instance of the <see cref="ConversationStats" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="active"></param>
        /// <param name="pending"></param>
        /// <param name="live">
        /// Conversations that are a realtime session in progress - a call you<br/>
        /// could listen to or end. A strict subset of `active` + `pending`,<br/>
        /// and deliberately smaller: a text conversation stays non-terminal<br/>
        /// for as long as the person might return to the thread, so it is<br/>
        /// open rather than live and is not counted here.
        /// </param>
        /// <param name="avgDurationMs"></param>
        /// <param name="avgCostCents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationStats(
            long total,
            long completed,
            long failed,
            long active,
            long pending,
            long live,
            double? avgDurationMs,
            double? avgCostCents)
        {
            this.Total = total;
            this.Completed = completed;
            this.Failed = failed;
            this.Active = active;
            this.Pending = pending;
            this.Live = live;
            this.AvgDurationMs = avgDurationMs;
            this.AvgCostCents = avgCostCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationStats" /> class.
        /// </summary>
        public ConversationStats()
        {
        }

    }
}