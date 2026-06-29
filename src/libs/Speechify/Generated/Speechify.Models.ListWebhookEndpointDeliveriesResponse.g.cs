
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for GET /v1/webhooks/endpoints/{webhook_endpoint_id}/deliveries.
    /// </summary>
    public sealed partial class ListWebhookEndpointDeliveriesResponse
    {
        /// <summary>
        /// Opaque keyset cursor for the next page. Pass back as the<br/>
        /// `cursor` request parameter. `null` when the caller has<br/>
        /// reached the end of the list (`has_more` is also `false`<br/>
        /// in that case).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// True when more rows exist beyond this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.WebhookEndpointDelivery> Deliveries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebhookEndpointDeliveriesResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// True when more rows exist beyond this page.
        /// </param>
        /// <param name="deliveries"></param>
        /// <param name="nextCursor">
        /// Opaque keyset cursor for the next page. Pass back as the<br/>
        /// `cursor` request parameter. `null` when the caller has<br/>
        /// reached the end of the list (`has_more` is also `false`<br/>
        /// in that case).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWebhookEndpointDeliveriesResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::Speechify.WebhookEndpointDelivery> deliveries,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.Deliveries = deliveries ?? throw new global::System.ArgumentNullException(nameof(deliveries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebhookEndpointDeliveriesResponse" /> class.
        /// </summary>
        public ListWebhookEndpointDeliveriesResponse()
        {
        }

    }
}