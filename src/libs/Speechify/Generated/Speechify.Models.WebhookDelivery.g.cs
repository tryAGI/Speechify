
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Post-call webhook delivery log row. One row per<br/>
    /// `(conversation, webhook-url)`; updated in place across retry<br/>
    /// attempts.
    /// </summary>
    public sealed partial class WebhookDelivery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`conv_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the conversation that triggered this delivery.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

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
        /// The exact JSON body Speechify POSTed to your webhook URL. This<br/>
        /// is the verbatim payload the `X-Speechify-Signature` HMAC was<br/>
        /// computed over, so you can re-verify the signature against it.<br/>
        /// Absent on deliveries that pre-date this capture.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_body")]
        public string? RequestBody { get; set; }

        /// <summary>
        /// The HTTP headers Speechify sent with the delivery, including<br/>
        /// `X-Speechify-Signature`, `X-Speechify-Timestamp`,<br/>
        /// `X-Speechify-Event`, and `X-Speechify-Delivery-Id`. Reflects<br/>
        /// the most recent attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequestHeaders { get; set; }

        /// <summary>
        /// The response body your server returned on the most recent<br/>
        /// attempt, truncated to 8 KiB. Useful for debugging a non-2xx<br/>
        /// response. Absent when no response was received (transport<br/>
        /// error) or on pre-capture deliveries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_response_body")]
        public string? LastResponseBody { get; set; }

        /// <summary>
        /// The response headers your server returned on the most recent<br/>
        /// attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_response_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? LastResponseHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDelivery" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="conversationId">
        /// Prefixed wire identifier (`conv_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the conversation that triggered this delivery.
        /// </param>
        /// <param name="agentId">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent.
        /// </param>
        /// <param name="url"></param>
        /// <param name="event"></param>
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
        /// The exact JSON body Speechify POSTed to your webhook URL. This<br/>
        /// is the verbatim payload the `X-Speechify-Signature` HMAC was<br/>
        /// computed over, so you can re-verify the signature against it.<br/>
        /// Absent on deliveries that pre-date this capture.
        /// </param>
        /// <param name="requestHeaders">
        /// The HTTP headers Speechify sent with the delivery, including<br/>
        /// `X-Speechify-Signature`, `X-Speechify-Timestamp`,<br/>
        /// `X-Speechify-Event`, and `X-Speechify-Delivery-Id`. Reflects<br/>
        /// the most recent attempt.
        /// </param>
        /// <param name="lastResponseBody">
        /// The response body your server returned on the most recent<br/>
        /// attempt, truncated to 8 KiB. Useful for debugging a non-2xx<br/>
        /// response. Absent when no response was received (transport<br/>
        /// error) or on pre-capture deliveries.
        /// </param>
        /// <param name="lastResponseHeaders">
        /// The response headers your server returned on the most recent<br/>
        /// attempt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDelivery(
            string id,
            string conversationId,
            string agentId,
            string url,
            string @event,
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
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
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
        /// Initializes a new instance of the <see cref="WebhookDelivery" /> class.
        /// </summary>
        public WebhookDelivery()
        {
        }

    }
}