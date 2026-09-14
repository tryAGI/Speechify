
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Config shape for `kind=openapi`: a REST API described by its OpenAPI<br/>
    /// document, pinned to the operations you selected. Get the operations<br/>
    /// from `POST /v1/agents/tool-definitions/import-openapi`, which answers<br/>
    /// them in exactly this shape, or write them by hand. The document itself<br/>
    /// is never stored; the compiled operations are, so a vendor rename cannot<br/>
    /// change a published agent's schemas until you re-import. Each operation<br/>
    /// is offered to the agent as the function `&lt;tool name&gt;__&lt;operation id&gt;`<br/>
    /// whose arguments are the operation's params by name plus `body` when it<br/>
    /// takes one.<br/>
    /// Speechify's servers make every call, on a durable run, a live voice<br/>
    /// session, a text conversation and a hosted API `tool` route alike, so<br/>
    /// the vendor credential never leaves them. `auth` is the same vault<br/>
    /// reference the `mcp` kind takes; a `bearer` or<br/>
    /// `oauth2_client_credentials` auth requires `credential_id`, whose<br/>
    /// credential must be of the matching kind.
    /// </summary>
    public sealed partial class OpenAPIToolConfig
    {
        /// <summary>
        /// The API's base URL every operation path is appended to. https<br/>
        /// only, and never with credentials in it: the vault holds those. It<br/>
        /// wins over the document's `servers`: a vendor with regional bases<br/>
        /// needs the one this workspace signed up to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        /// Where the operations were imported from, kept for a later refresh.<br/>
        /// Nothing reads it at call time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec_url")]
        public string? SpecUrl { get; set; }

        /// <summary>
        /// How the platform authenticates to an MCP server or an OpenAPI tool's<br/>
        /// REST API: `none`, `bearer` or `oauth2_client_credentials`, a<br/>
        /// discriminated union over `type`. Other credential kinds (an API key<br/>
        /// in a custom header or query parameter, HTTP Basic) are not supported<br/>
        /// here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.MCPAuthJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.MCPAuth Auth { get; set; }

        /// <summary>
        /// How long one operation call may take. Defaults to 30000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// A ceiling on calls to this API per minute across every agent, run<br/>
        /// and hosted API route in the workspace, so an agent cannot starve<br/>
        /// the people who share the vendor's budget. Omitted means unbounded on our side; the<br/>
        /// vendor's own 429 still reaches the model as an observation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_requests_per_minute")]
        public int? MaxRequestsPerMinute { get; set; }

        /// <summary>
        /// The operations the agent may call. At most forty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.OpenAPIOperation> Operations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIToolConfig" /> class.
        /// </summary>
        /// <param name="baseUrl">
        /// The API's base URL every operation path is appended to. https<br/>
        /// only, and never with credentials in it: the vault holds those. It<br/>
        /// wins over the document's `servers`: a vendor with regional bases<br/>
        /// needs the one this workspace signed up to.
        /// </param>
        /// <param name="auth">
        /// How the platform authenticates to an MCP server or an OpenAPI tool's<br/>
        /// REST API: `none`, `bearer` or `oauth2_client_credentials`, a<br/>
        /// discriminated union over `type`. Other credential kinds (an API key<br/>
        /// in a custom header or query parameter, HTTP Basic) are not supported<br/>
        /// here.
        /// </param>
        /// <param name="operations">
        /// The operations the agent may call. At most forty.
        /// </param>
        /// <param name="specUrl">
        /// Where the operations were imported from, kept for a later refresh.<br/>
        /// Nothing reads it at call time.
        /// </param>
        /// <param name="timeoutMs">
        /// How long one operation call may take. Defaults to 30000.
        /// </param>
        /// <param name="maxRequestsPerMinute">
        /// A ceiling on calls to this API per minute across every agent, run<br/>
        /// and hosted API route in the workspace, so an agent cannot starve<br/>
        /// the people who share the vendor's budget. Omitted means unbounded on our side; the<br/>
        /// vendor's own 429 still reaches the model as an observation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIToolConfig(
            string baseUrl,
            global::Speechify.MCPAuth auth,
            global::System.Collections.Generic.IList<global::Speechify.OpenAPIOperation> operations,
            string? specUrl,
            int? timeoutMs,
            int? maxRequestsPerMinute)
        {
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.SpecUrl = specUrl;
            this.Auth = auth;
            this.TimeoutMs = timeoutMs;
            this.MaxRequestsPerMinute = maxRequestsPerMinute;
            this.Operations = operations ?? throw new global::System.ArgumentNullException(nameof(operations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIToolConfig" /> class.
        /// </summary>
        public OpenAPIToolConfig()
        {
        }

    }
}