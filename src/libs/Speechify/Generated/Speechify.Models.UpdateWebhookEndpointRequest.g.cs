
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Partial update; omitted fields are left unchanged.
    /// </summary>
    public sealed partial class UpdateWebhookEndpointRequest
    {
        /// <summary>
        /// HTTPS destination for event deliveries. Must be a publicly<br/>
        /// reachable host: loopback, private, link-local, and cloud-metadata<br/>
        /// addresses (and reserved hostnames like `localhost`) are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_events")]
        public global::System.Collections.Generic.IList<string>? EnabledEvents { get; set; }

        /// <summary>
        /// Payload-shaping keys (see `WebhookEndpoint.include`). Send `[]` to<br/>
        /// clear back to the lean default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        /// Opt the endpoint into a different (typically newer) payload shape<br/>
        /// (`YYYY-MM-DD`, see `WebhookEndpoint.api_version`). Omit to leave it<br/>
        /// unchanged. An unknown version is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public global::System.DateTime? ApiVersion { get; set; }

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
        /// <param name="url">
        /// HTTPS destination for event deliveries. Must be a publicly<br/>
        /// reachable host: loopback, private, link-local, and cloud-metadata<br/>
        /// addresses (and reserved hostnames like `localhost`) are rejected.
        /// </param>
        /// <param name="enabledEvents"></param>
        /// <param name="include">
        /// Payload-shaping keys (see `WebhookEndpoint.include`). Send `[]` to<br/>
        /// clear back to the lean default.
        /// </param>
        /// <param name="apiVersion">
        /// Opt the endpoint into a different (typically newer) payload shape<br/>
        /// (`YYYY-MM-DD`, see `WebhookEndpoint.api_version`). Omit to leave it<br/>
        /// unchanged. An unknown version is rejected.
        /// </param>
        /// <param name="description"></param>
        /// <param name="disabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWebhookEndpointRequest(
            string? url,
            global::System.Collections.Generic.IList<string>? enabledEvents,
            global::System.Collections.Generic.IList<string>? include,
            global::System.DateTime? apiVersion,
            string? description,
            bool? disabled)
        {
            this.Url = url;
            this.EnabledEvents = enabledEvents;
            this.Include = include;
            this.ApiVersion = apiVersion;
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