
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A workspace webhook endpoint: a destination URL, the events it<br/>
    /// subscribes to, and a server-minted HMAC signing secret. `secret` is<br/>
    /// returned ONLY in the create and rotate-secret responses — store it<br/>
    /// then; every other read omits it.<br/>
    /// An endpoint is either scoped to one project (`project_id`) or<br/>
    /// workspace-wide, and a workspace-wide endpoint receives events from<br/>
    /// every project.
    /// </summary>
    public sealed partial class WebhookEndpoint
    {
        /// <summary>
        /// Prefixed wire id (`whe_&lt;26 char Crockford base32&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// HTTPS destination Speechify POSTs signed events to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The project whose events this endpoint receives (prefixed<br/>
        /// external id). Null means workspace-wide - it receives every<br/>
        /// project's events. Endpoints have no Default project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The events this endpoint receives: a list of catalog event names<br/>
        /// (see `WebhookEventType`) or `["*"]` for every event, current and<br/>
        /// future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EnabledEvents { get; set; }

        /// <summary>
        /// Per-event payload shaping. Deliveries are lean by default:<br/>
        /// `data.object` carries only the resource GET snapshot. List heavy<br/>
        /// collections here to have them appended under the event's `data`<br/>
        /// alongside `object`, so receivers behind hard request-size caps stay<br/>
        /// lean unless they opt in. Recognised keys (conversation events only):<br/>
        /// `messages` (the full transcript) and `evaluations`. Empty = lean.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Include { get; set; }

        /// <summary>
        /// The dated payload shape this endpoint receives (`YYYY-MM-DD`), the<br/>
        /// same versioning vocabulary the REST API uses. Every delivery is<br/>
        /// rendered back to this version and carries it in the<br/>
        /// `Speechify-Version` header and the payload's top-level `version`<br/>
        /// field. Defaults to your workspace's current version at creation;<br/>
        /// change it to opt into a newer shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ApiVersion { get; set; }

        /// <summary>
        /// Optional human-readable label for the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// When true, Speechify stops delivering to this endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Disabled { get; set; }

        /// <summary>
        /// The HMAC-SHA256 signing secret (`whsec_…`) used to verify the<br/>
        /// `Speechify-Signature` header. Returned ONLY when the endpoint is<br/>
        /// created or its secret is rotated — it is never shown again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEndpoint" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire id (`whe_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="url">
        /// HTTPS destination Speechify POSTs signed events to.
        /// </param>
        /// <param name="enabledEvents">
        /// The events this endpoint receives: a list of catalog event names<br/>
        /// (see `WebhookEventType`) or `["*"]` for every event, current and<br/>
        /// future.
        /// </param>
        /// <param name="include">
        /// Per-event payload shaping. Deliveries are lean by default:<br/>
        /// `data.object` carries only the resource GET snapshot. List heavy<br/>
        /// collections here to have them appended under the event's `data`<br/>
        /// alongside `object`, so receivers behind hard request-size caps stay<br/>
        /// lean unless they opt in. Recognised keys (conversation events only):<br/>
        /// `messages` (the full transcript) and `evaluations`. Empty = lean.
        /// </param>
        /// <param name="apiVersion">
        /// The dated payload shape this endpoint receives (`YYYY-MM-DD`), the<br/>
        /// same versioning vocabulary the REST API uses. Every delivery is<br/>
        /// rendered back to this version and carries it in the<br/>
        /// `Speechify-Version` header and the payload's top-level `version`<br/>
        /// field. Defaults to your workspace's current version at creation;<br/>
        /// change it to opt into a newer shape.
        /// </param>
        /// <param name="disabled">
        /// When true, Speechify stops delivering to this endpoint.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="projectId">
        /// The project whose events this endpoint receives (prefixed<br/>
        /// external id). Null means workspace-wide - it receives every<br/>
        /// project's events. Endpoints have no Default project.
        /// </param>
        /// <param name="description">
        /// Optional human-readable label for the endpoint.
        /// </param>
        /// <param name="secret">
        /// The HMAC-SHA256 signing secret (`whsec_…`) used to verify the<br/>
        /// `Speechify-Signature` header. Returned ONLY when the endpoint is<br/>
        /// created or its secret is rotated — it is never shown again.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookEndpoint(
            string id,
            string url,
            global::System.Collections.Generic.IList<string> enabledEvents,
            global::System.Collections.Generic.IList<string> include,
            global::System.DateTime apiVersion,
            bool disabled,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? projectId,
            string? description,
            string? secret)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ProjectId = projectId;
            this.EnabledEvents = enabledEvents ?? throw new global::System.ArgumentNullException(nameof(enabledEvents));
            this.Include = include ?? throw new global::System.ArgumentNullException(nameof(include));
            this.ApiVersion = apiVersion;
            this.Description = description;
            this.Disabled = disabled;
            this.Secret = secret;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEndpoint" /> class.
        /// </summary>
        public WebhookEndpoint()
        {
        }

    }
}