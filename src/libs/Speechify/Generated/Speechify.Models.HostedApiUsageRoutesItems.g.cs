
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HostedApiUsageRoutesItems
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RouteId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Reads { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Writes { get; set; }

        /// <summary>
        /// For a `tool` route, the calls its connector was asked to answer today, whatever the outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public long? ToolCalls { get; set; }

        /// <summary>
        /// For a `tool` route, today's calls the connector answered with an error or never answered (502 `route_upstream_error`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_errors")]
        public long? UpstreamErrors { get; set; }

        /// <summary>
        /// For a `tool` route, today's calls throttled by the tool's `max_requests_per_minute` or by the connector (429 `route_upstream_rate_limited`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_throttles")]
        public long? UpstreamThrottles { get; set; }

        /// <summary>
        /// For a `tool` route, the mean time today's calls took, in milliseconds, connector included; null before the first call. A slow or failing connector shows here rather than as a slow API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_latency_ms_mean")]
        public long? UpstreamLatencyMsMean { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedApiUsageRoutesItems" /> class.
        /// </summary>
        /// <param name="routeId"></param>
        /// <param name="reads"></param>
        /// <param name="writes"></param>
        /// <param name="toolCalls">
        /// For a `tool` route, the calls its connector was asked to answer today, whatever the outcome.
        /// </param>
        /// <param name="upstreamErrors">
        /// For a `tool` route, today's calls the connector answered with an error or never answered (502 `route_upstream_error`).
        /// </param>
        /// <param name="upstreamThrottles">
        /// For a `tool` route, today's calls throttled by the tool's `max_requests_per_minute` or by the connector (429 `route_upstream_rate_limited`).
        /// </param>
        /// <param name="upstreamLatencyMsMean">
        /// For a `tool` route, the mean time today's calls took, in milliseconds, connector included; null before the first call. A slow or failing connector shows here rather than as a slow API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedApiUsageRoutesItems(
            string routeId,
            long reads,
            long writes,
            long? toolCalls,
            long? upstreamErrors,
            long? upstreamThrottles,
            long? upstreamLatencyMsMean)
        {
            this.RouteId = routeId ?? throw new global::System.ArgumentNullException(nameof(routeId));
            this.Reads = reads;
            this.Writes = writes;
            this.ToolCalls = toolCalls;
            this.UpstreamErrors = upstreamErrors;
            this.UpstreamThrottles = upstreamThrottles;
            this.UpstreamLatencyMsMean = upstreamLatencyMsMean;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedApiUsageRoutesItems" /> class.
        /// </summary>
        public HostedApiUsageRoutesItems()
        {
        }

    }
}