
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The HTTP headers Speechify sent with the delivery, including<br/>
    /// `X-Speechify-Signature`, `X-Speechify-Timestamp`,<br/>
    /// `X-Speechify-Event`, and `X-Speechify-Delivery-Id`. Reflects<br/>
    /// the most recent attempt.
    /// </summary>
    public sealed partial class WebhookDeliveryRequestHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}