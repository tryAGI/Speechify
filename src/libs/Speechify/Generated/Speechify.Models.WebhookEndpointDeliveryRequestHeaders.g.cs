
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Headers sent, including `Speechify-Signature` / `Speechify-Event` / `Speechify-Delivery-Id`.
    /// </summary>
    public sealed partial class WebhookEndpointDeliveryRequestHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}