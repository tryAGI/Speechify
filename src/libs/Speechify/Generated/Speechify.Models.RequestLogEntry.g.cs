
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One API request in the workspace Request Log.
    /// </summary>
    public sealed partial class RequestLogEntry
    {
        /// <summary>
        /// When the request completed (RFC-3339 / ISO-8601).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Time { get; set; }

        /// <summary>
        /// HTTP method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        /// The matched route pattern (ids collapsed, e.g. `/v1/agents/{id}`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Route { get; set; }

        /// <summary>
        /// The concrete request path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// HTTP response status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Server-measured request latency in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LatencyMs { get; set; }

        /// <summary>
        /// The resolving user principal (`user_…`); omitted when the request was key-authenticated with no user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The authenticating API key (`key_…`); present only for key-authenticated requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// The authenticating key's public prefix (`sk_…`), when present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_prefix")]
        public string? KeyPrefix { get; set; }

        /// <summary>
        /// The resolving principal's credential class.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principal_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.RequestLogEntryPrincipalTypeJsonConverter))]
        public global::Speechify.RequestLogEntryPrincipalType? PrincipalType { get; set; }

        /// <summary>
        /// Correlation id stamped on the request (matches the `X-Request-ID` response header).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Distributed-trace id for the request, when sampled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLogEntry" /> class.
        /// </summary>
        /// <param name="time">
        /// When the request completed (RFC-3339 / ISO-8601).
        /// </param>
        /// <param name="method">
        /// HTTP method.
        /// </param>
        /// <param name="route">
        /// The matched route pattern (ids collapsed, e.g. `/v1/agents/{id}`).
        /// </param>
        /// <param name="path">
        /// The concrete request path.
        /// </param>
        /// <param name="statusCode">
        /// HTTP response status code.
        /// </param>
        /// <param name="latencyMs">
        /// Server-measured request latency in milliseconds.
        /// </param>
        /// <param name="requestId">
        /// Correlation id stamped on the request (matches the `X-Request-ID` response header).
        /// </param>
        /// <param name="userId">
        /// The resolving user principal (`user_…`); omitted when the request was key-authenticated with no user.
        /// </param>
        /// <param name="apiKeyId">
        /// The authenticating API key (`key_…`); present only for key-authenticated requests.
        /// </param>
        /// <param name="keyPrefix">
        /// The authenticating key's public prefix (`sk_…`), when present.
        /// </param>
        /// <param name="principalType">
        /// The resolving principal's credential class.
        /// </param>
        /// <param name="traceId">
        /// Distributed-trace id for the request, when sampled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestLogEntry(
            global::System.DateTime time,
            string method,
            string route,
            string path,
            int statusCode,
            int latencyMs,
            string requestId,
            string? userId,
            string? apiKeyId,
            string? keyPrefix,
            global::Speechify.RequestLogEntryPrincipalType? principalType,
            string? traceId)
        {
            this.Time = time;
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.StatusCode = statusCode;
            this.LatencyMs = latencyMs;
            this.UserId = userId;
            this.ApiKeyId = apiKeyId;
            this.KeyPrefix = keyPrefix;
            this.PrincipalType = principalType;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.TraceId = traceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLogEntry" /> class.
        /// </summary>
        public RequestLogEntry()
        {
        }

    }
}