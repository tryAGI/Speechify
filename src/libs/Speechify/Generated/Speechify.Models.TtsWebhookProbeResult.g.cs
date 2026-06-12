
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Result of a webhook probe. `ok` is true only when the endpoint<br/>
    /// returned a 2xx. A non-2xx response still populates `status_code`<br/>
    /// and `response_body` with `ok=false` — the request reached the<br/>
    /// endpoint, the endpoint just declined it. `error` is set only for<br/>
    /// transport-level failures (DNS, connect, TLS, timeout, blocked<br/>
    /// address range) where no response was received; `status_code` is<br/>
    /// absent in that case. `signed` reports whether the probe carried<br/>
    /// an `X-Speechify-Signature` header — false on the create-form<br/>
    /// flow, which has no stored secret yet. Both success and failure<br/>
    /// use the 200 envelope so the console renders them inline.
    /// </summary>
    public sealed partial class TtsWebhookProbeResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ok")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Ok { get; set; }

        /// <summary>
        /// HTTP status the endpoint returned. Absent on a transport failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Wall-clock round-trip time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_ms")]
        public long? LatencyMs { get; set; }

        /// <summary>
        /// Truncated prefix (max ~2 KiB) of the endpoint's response body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_body")]
        public string? ResponseBody { get; set; }

        /// <summary>
        /// Whether the probe request carried an HMAC signature header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Signed { get; set; }

        /// <summary>
        /// Human-readable transport-level failure reason. Absent when any response was received.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsWebhookProbeResult" /> class.
        /// </summary>
        /// <param name="ok"></param>
        /// <param name="signed">
        /// Whether the probe request carried an HMAC signature header.
        /// </param>
        /// <param name="statusCode">
        /// HTTP status the endpoint returned. Absent on a transport failure.
        /// </param>
        /// <param name="latencyMs">
        /// Wall-clock round-trip time in milliseconds.
        /// </param>
        /// <param name="responseBody">
        /// Truncated prefix (max ~2 KiB) of the endpoint's response body.
        /// </param>
        /// <param name="error">
        /// Human-readable transport-level failure reason. Absent when any response was received.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsWebhookProbeResult(
            bool ok,
            bool signed,
            int? statusCode,
            long? latencyMs,
            string? responseBody,
            string? error)
        {
            this.Ok = ok;
            this.StatusCode = statusCode;
            this.LatencyMs = latencyMs;
            this.ResponseBody = responseBody;
            this.Signed = signed;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsWebhookProbeResult" /> class.
        /// </summary>
        public TtsWebhookProbeResult()
        {
        }

    }
}