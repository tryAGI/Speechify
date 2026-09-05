
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One row of an endpoint's delivery log. One row per (endpoint, event,<br/>
    /// resource); updated in place across retry attempts. Each row records the<br/>
    /// exact request payload + signed headers Speechify sent and the response<br/>
    /// your server returned, so you can verify the signature and debug failures.
    /// </summary>
    public sealed partial class WebhookEndpointDelivery
    {
        /// <summary>
        /// Prefixed delivery id (`whd_&lt;26 char Crockford base32&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The endpoint this delivery targeted (`whe_…`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookEndpointId { get; set; }

        /// <summary>
        /// The event type delivered (see `WebhookEventType`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// The destination URL at delivery time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Lifecycle of a post-call webhook delivery row. The sender<br/>
        /// updates the same row across retries so the UI always sees the<br/>
        /// latest outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.WebhookDeliveryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.WebhookDeliveryStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AttemptCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_attempt_at")]
        public global::System.DateTime? LastAttemptAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_status_code")]
        public int? LastStatusCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_error")]
        public string? LastError { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The verbatim payload the `Speechify-Signature` HMAC was computed over<br/>
        /// (as `&lt;t&gt;.&lt;raw_body&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_body")]
        public string? RequestBody { get; set; }

        /// <summary>
        /// Headers sent, including `Speechify-Signature` / `Speechify-Event` / `Speechify-Delivery-Id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequestHeaders { get; set; }

        /// <summary>
        /// Your server's response body on the most recent attempt (truncated to 8 KiB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_response_body")]
        public string? LastResponseBody { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_response_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? LastResponseHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEndpointDelivery" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed delivery id (`whd_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="webhookEndpointId">
        /// The endpoint this delivery targeted (`whe_…`).
        /// </param>
        /// <param name="event">
        /// The event type delivered (see `WebhookEventType`).
        /// </param>
        /// <param name="url">
        /// The destination URL at delivery time.
        /// </param>
        /// <param name="status">
        /// Lifecycle of a post-call webhook delivery row. The sender<br/>
        /// updates the same row across retries so the UI always sees the<br/>
        /// latest outcome.
        /// </param>
        /// <param name="attemptCount"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastAttemptAt"></param>
        /// <param name="lastStatusCode"></param>
        /// <param name="lastError"></param>
        /// <param name="requestBody">
        /// The verbatim payload the `Speechify-Signature` HMAC was computed over<br/>
        /// (as `&lt;t&gt;.&lt;raw_body&gt;`).
        /// </param>
        /// <param name="requestHeaders">
        /// Headers sent, including `Speechify-Signature` / `Speechify-Event` / `Speechify-Delivery-Id`.
        /// </param>
        /// <param name="lastResponseBody">
        /// Your server's response body on the most recent attempt (truncated to 8 KiB).
        /// </param>
        /// <param name="lastResponseHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookEndpointDelivery(
            string id,
            string webhookEndpointId,
            string @event,
            string url,
            global::Speechify.WebhookDeliveryStatus status,
            int attemptCount,
            global::System.DateTime createdAt,
            global::System.DateTime? lastAttemptAt,
            int? lastStatusCode,
            string? lastError,
            string? requestBody,
            global::System.Collections.Generic.Dictionary<string, string>? requestHeaders,
            string? lastResponseBody,
            global::System.Collections.Generic.Dictionary<string, string>? lastResponseHeaders)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.WebhookEndpointId = webhookEndpointId ?? throw new global::System.ArgumentNullException(nameof(webhookEndpointId));
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Status = status;
            this.AttemptCount = attemptCount;
            this.LastAttemptAt = lastAttemptAt;
            this.LastStatusCode = lastStatusCode;
            this.LastError = lastError;
            this.CreatedAt = createdAt;
            this.RequestBody = requestBody;
            this.RequestHeaders = requestHeaders;
            this.LastResponseBody = lastResponseBody;
            this.LastResponseHeaders = lastResponseHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEndpointDelivery" /> class.
        /// </summary>
        public WebhookEndpointDelivery()
        {
        }

    }
}