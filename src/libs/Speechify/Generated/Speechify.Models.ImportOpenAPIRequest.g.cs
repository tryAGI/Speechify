
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/tool-definitions/import-openapi`. Exactly one<br/>
    /// of `spec_url` and `spec` names the document. `auth` is the credential<br/>
    /// to fetch `spec_url` with when the vendor serves its document behind the<br/>
    /// same auth as its API, usually the same `auth` the tool will carry; omit<br/>
    /// it for a public document.
    /// </summary>
    public sealed partial class ImportOpenAPIRequest
    {
        /// <summary>
        /// An https URL the server fetches the document from, with the headers<br/>
        /// of the credential `auth` names when it names one. A private or<br/>
        /// loopback address is refused. At most 2 MiB. Keep it as the tool's<br/>
        /// `spec_url` so a later import can refresh the operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec_url")]
        public string? SpecUrl { get; set; }

        /// <summary>
        /// The document inline: a JSON object, or a string holding the JSON<br/>
        /// or YAML text. At most 2 MiB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ImportOpenApiRequestSpecJsonConverter))]
        public global::Speechify.ImportOpenApiRequestSpec? Spec { get; set; }

        /// <summary>
        /// How the platform authenticates to an MCP server or an OpenAPI tool's<br/>
        /// REST API: `none`, `bearer` or `oauth2_client_credentials`, a<br/>
        /// discriminated union over `type`. Other credential kinds (an API key<br/>
        /// in a custom header or query parameter, HTTP Basic) are not supported<br/>
        /// here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.MCPAuthJsonConverter))]
        public global::Speechify.MCPAuth? Auth { get; set; }

        /// <summary>
        /// Overrides the document's `servers` in the result's `base_url`: the<br/>
        /// regional or tenant host this workspace signed up to. The create<br/>
        /// endpoint requires https.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportOpenAPIRequest" /> class.
        /// </summary>
        /// <param name="specUrl">
        /// An https URL the server fetches the document from, with the headers<br/>
        /// of the credential `auth` names when it names one. A private or<br/>
        /// loopback address is refused. At most 2 MiB. Keep it as the tool's<br/>
        /// `spec_url` so a later import can refresh the operations.
        /// </param>
        /// <param name="spec">
        /// The document inline: a JSON object, or a string holding the JSON<br/>
        /// or YAML text. At most 2 MiB.
        /// </param>
        /// <param name="auth">
        /// How the platform authenticates to an MCP server or an OpenAPI tool's<br/>
        /// REST API: `none`, `bearer` or `oauth2_client_credentials`, a<br/>
        /// discriminated union over `type`. Other credential kinds (an API key<br/>
        /// in a custom header or query parameter, HTTP Basic) are not supported<br/>
        /// here.
        /// </param>
        /// <param name="baseUrl">
        /// Overrides the document's `servers` in the result's `base_url`: the<br/>
        /// regional or tenant host this workspace signed up to. The create<br/>
        /// endpoint requires https.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportOpenAPIRequest(
            string? specUrl,
            global::Speechify.ImportOpenApiRequestSpec? spec,
            global::Speechify.MCPAuth? auth,
            string? baseUrl)
        {
            this.SpecUrl = specUrl;
            this.Spec = spec;
            this.Auth = auth;
            this.BaseUrl = baseUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportOpenAPIRequest" /> class.
        /// </summary>
        public ImportOpenAPIRequest()
        {
        }

    }
}