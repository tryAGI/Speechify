
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
        /// How many of `requests` were streaming synthesis (`POST<br/>
        /// /v1/audio/stream`) and so reported a time-to-first-byte. Every other<br/>
        /// route leaves the `p*_ttfb_ms` fields meaningless; when this is 0,<br/>
        /// render a gap rather than a zero.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttfb_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TtfbRequests { get; set; }

        /// <summary>
        /// Median time to first byte over the bucket's streaming requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50_ttfb_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P50TtfbMs { get; set; }

        /// <summary>
        /// 95th-percentile time to first byte over the bucket's streaming<br/>
        /// requests. This is also time to first *audio*: the streaming response<br/>
        /// body is raw audio, so the first byte is the first audio byte.<br/>
        /// Scoped to streaming on purpose. `POST /v1/audio/speech` returns the<br/>
        /// whole audio Base64-encoded in one JSON response, so its TTFB is its<br/>
        /// total latency (already reported as `p*_latency_ms`) and blending the<br/>
        /// two would describe neither.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95_ttfb_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P95TtfbMs { get; set; }

        /// <summary>
        /// 99th-percentile time to first byte over the bucket's streaming requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99_ttfb_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P99TtfbMs { get; set; }

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
        /// <param name="ttfbRequests">
        /// How many of `requests` were streaming synthesis (`POST<br/>
        /// /v1/audio/stream`) and so reported a time-to-first-byte. Every other<br/>
        /// route leaves the `p*_ttfb_ms` fields meaningless; when this is 0,<br/>
        /// render a gap rather than a zero.
        /// </param>
        /// <param name="p50TtfbMs">
        /// Median time to first byte over the bucket's streaming requests.
        /// </param>
        /// <param name="p95TtfbMs">
        /// 95th-percentile time to first byte over the bucket's streaming<br/>
        /// requests. This is also time to first *audio*: the streaming response<br/>
        /// body is raw audio, so the first byte is the first audio byte.<br/>
        /// Scoped to streaming on purpose. `POST /v1/audio/speech` returns the<br/>
        /// whole audio Base64-encoded in one JSON response, so its TTFB is its<br/>
        /// total latency (already reported as `p*_latency_ms`) and blending the<br/>
        /// two would describe neither.
        /// </param>
        /// <param name="p99TtfbMs">
        /// 99th-percentile time to first byte over the bucket's streaming requests.
        /// </param>
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
            double p99LatencyMs,
            int ttfbRequests,
            double p50TtfbMs,
            double p95TtfbMs,
            double p99TtfbMs)
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
            this.TtfbRequests = ttfbRequests;
            this.P50TtfbMs = p50TtfbMs;
            this.P95TtfbMs = p95TtfbMs;
            this.P99TtfbMs = p99TtfbMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsBucket" /> class.
        /// </summary>
        public RequestAnalyticsBucket()
        {
        }

    }
}