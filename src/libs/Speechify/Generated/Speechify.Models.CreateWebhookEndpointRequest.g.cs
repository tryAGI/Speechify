
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWebhookEndpointRequest
    {
        /// <summary>
        /// HTTPS destination for event deliveries. Must be a publicly<br/>
        /// reachable host: loopback, private, link-local, and cloud-metadata<br/>
        /// addresses (and reserved hostnames like `localhost`) are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Optionally scope the endpoint to one project (prefixed<br/>
        /// `proj_...` id): a scoped endpoint receives only that project's<br/>
        /// events. Omit (or null) for workspace-wide - it receives every<br/>
        /// project's events. An unknown id returns 404 project_not_found.<br/>
        /// A project-pinned API key creates into its own project and<br/>
        /// cannot name the workspace-wide tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Catalog event names to subscribe to, or `["*"]` for all events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EnabledEvents { get; set; }

        /// <summary>
        /// Optional payload-shaping keys (see `WebhookEndpoint.include`):<br/>
        /// `messages`, `evaluations`. Omit for the lean default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        /// Optionally pin the endpoint's payload shape to a dated version<br/>
        /// (`YYYY-MM-DD`, see `WebhookEndpoint.api_version`). Omit to use the<br/>
        /// workspace's current version. An unknown version is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public global::System.DateTime? ApiVersion { get; set; }

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
        /// HTTPS destination for event deliveries. Must be a publicly<br/>
        /// reachable host: loopback, private, link-local, and cloud-metadata<br/>
        /// addresses (and reserved hostnames like `localhost`) are rejected.
        /// </param>
        /// <param name="enabledEvents">
        /// Catalog event names to subscribe to, or `["*"]` for all events.
        /// </param>
        /// <param name="projectId">
        /// Optionally scope the endpoint to one project (prefixed<br/>
        /// `proj_...` id): a scoped endpoint receives only that project's<br/>
        /// events. Omit (or null) for workspace-wide - it receives every<br/>
        /// project's events. An unknown id returns 404 project_not_found.<br/>
        /// A project-pinned API key creates into its own project and<br/>
        /// cannot name the workspace-wide tier.
        /// </param>
        /// <param name="include">
        /// Optional payload-shaping keys (see `WebhookEndpoint.include`):<br/>
        /// `messages`, `evaluations`. Omit for the lean default.
        /// </param>
        /// <param name="apiVersion">
        /// Optionally pin the endpoint's payload shape to a dated version<br/>
        /// (`YYYY-MM-DD`, see `WebhookEndpoint.api_version`). Omit to use the<br/>
        /// workspace's current version. An unknown version is rejected.
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebhookEndpointRequest(
            string url,
            global::System.Collections.Generic.IList<string> enabledEvents,
            string? projectId,
            global::System.Collections.Generic.IList<string>? include,
            global::System.DateTime? apiVersion,
            string? description)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ProjectId = projectId;
            this.EnabledEvents = enabledEvents ?? throw new global::System.ArgumentNullException(nameof(enabledEvents));
            this.Include = include;
            this.ApiVersion = apiVersion;
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