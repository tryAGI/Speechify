
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One granularity bucket of the request analytics series.
    /// </summary>
    public sealed partial class RequestAnalyticsBucket
    {
        /// <summary>
        /// Start of the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ServerErrors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SuccessRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_latency_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgLatencyMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50_latency_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P50LatencyMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95_latency_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P95LatencyMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99_latency_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P99LatencyMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsBucket" /> class.
        /// </summary>
        /// <param name="time">
        /// Start of the bucket.
        /// </param>
        /// <param name="requests"></param>
        /// <param name="errors"></param>
        /// <param name="serverErrors"></param>
        /// <param name="successRate"></param>
        /// <param name="avgLatencyMs"></param>
        /// <param name="p50LatencyMs"></param>
        /// <param name="p95LatencyMs"></param>
        /// <param name="p99LatencyMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsBucket(
            global::System.DateTime time,
            int requests,
            int errors,
            int serverErrors,
            double successRate,
            double avgLatencyMs,
            double p50LatencyMs,
            double p95LatencyMs,
            double p99LatencyMs)
        {
            this.Time = time;
            this.Requests = requests;
            this.Errors = errors;
            this.ServerErrors = serverErrors;
            this.SuccessRate = successRate;
            this.AvgLatencyMs = avgLatencyMs;
            this.P50LatencyMs = p50LatencyMs;
            this.P95LatencyMs = p95LatencyMs;
            this.P99LatencyMs = p99LatencyMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsBucket" /> class.
        /// </summary>
        public RequestAnalyticsBucket()
        {
        }

    }
}