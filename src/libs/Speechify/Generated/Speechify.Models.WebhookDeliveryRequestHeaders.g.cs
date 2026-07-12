
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The HTTP headers Speechify sent with the delivery, including<br/>
    /// `Speechify-Signature` (`t=&lt;unix&gt;,v0=&lt;hmac-sha256-hex&gt;`),<br/>
    /// `Speechify-Event`, and `Speechify-Delivery-Id`. Reflects the<br/>
    /// most recent attempt.
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