
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Aggregate run metrics over the requested window. `buckets` is<br/>
    /// dense - one entry per day in the window, zero-filled, so a chart<br/>
    /// never has gaps. `by_type` counts runs per test type across the<br/>
    /// whole window.
    /// </summary>
    public sealed partial class TtsTestStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WindowDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsTestStatsBucket> Buckets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PassedRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errored_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErroredRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AvgDurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_type")]
        public global::System.Collections.Generic.Dictionary<string, int>? ByType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTestStats" /> class.
        /// </summary>
        /// <param name="windowDays"></param>
        /// <param name="buckets"></param>
        /// <param name="totalRuns"></param>
        /// <param name="passedRuns"></param>
        /// <param name="failedRuns"></param>
        /// <param name="erroredRuns"></param>
        /// <param name="avgDurationMs"></param>
        /// <param name="byType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsTestStats(
            int windowDays,
            global::System.Collections.Generic.IList<global::Speechify.TtsTestStatsBucket> buckets,
            int totalRuns,
            int passedRuns,
            int failedRuns,
            int erroredRuns,
            int avgDurationMs,
            global::System.Collections.Generic.Dictionary<string, int>? byType)
        {
            this.WindowDays = windowDays;
            this.Buckets = buckets ?? throw new global::System.ArgumentNullException(nameof(buckets));
            this.TotalRuns = totalRuns;
            this.PassedRuns = passedRuns;
            this.FailedRuns = failedRuns;
            this.ErroredRuns = erroredRuns;
            this.AvgDurationMs = avgDurationMs;
            this.ByType = byType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTestStats" /> class.
        /// </summary>
        public TtsTestStats()
        {
        }

    }
}