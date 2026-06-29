
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Partial update; omitted fields are left unchanged.
    /// </summary>
    public sealed partial class UpdateWebhookEndpointRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_events")]
        public global::System.Collections.Generic.IList<string>? EnabledEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookEndpointRequest" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="enabledEvents"></param>
        /// <param name="description"></param>
        /// <param name="disabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWebhookEndpointRequest(
            string? url,
            global::System.Collections.Generic.IList<string>? enabledEvents,
            string? description,
            bool? disabled)
        {
            this.Url = url;
            this.EnabledEvents = enabledEvents;
            this.Description = description;
            this.Disabled = disabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookEndpointRequest" /> class.
        /// </summary>
        public UpdateWebhookEndpointRequest()
        {
        }

    }
}