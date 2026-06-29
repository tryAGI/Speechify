
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebhookEndpointRequest
    {
        /// <summary>
        /// HTTPS destination for event deliveries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Catalog event names to subscribe to, or `["*"]` for all events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EnabledEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookEndpointRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// HTTPS destination for event deliveries.
        /// </param>
        /// <param name="enabledEvents">
        /// Catalog event names to subscribe to, or `["*"]` for all events.
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebhookEndpointRequest(
            string url,
            global::System.Collections.Generic.IList<string> enabledEvents,
            string? description)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.EnabledEvents = enabledEvents ?? throw new global::System.ArgumentNullException(nameof(enabledEvents));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookEndpointRequest" /> class.
        /// </summary>
        public CreateWebhookEndpointRequest()
        {
        }

    }
}