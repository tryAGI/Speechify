
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Structured upstream signal for an MCP probe failure. All fields<br/>
    /// are optional; a client renders what's present. `stage` names<br/>
    /// the phase the probe was in (`validation`, `oauth2_token`,<br/>
    /// `mcp_connect`, `mcp_initialize`, `mcp_notify`, `mcp_list_tools`).<br/>
    /// `oauth2_error` / `oauth2_error_description` mirror RFC 6749 §5.2<br/>
    /// when the customer's auth server returned the standard error<br/>
    /// shape. `http_status` is the upstream status code for transport<br/>
    /// failures. `upstream_body` is a truncated prefix (max ~1 KiB) of<br/>
    /// the upstream response body when the failure isn't structured.<br/>
    /// `field_hint` names a form field (`endpoint`, `transport`,<br/>
    /// `token`, `token_url`, `client_id`, `client_secret`, `scope`)<br/>
    /// a client should highlight so the customer knows what to fix.
    /// </summary>
    public sealed partial class MCPProbeErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.McpProbeErrorDetailsStageJsonConverter))]
        public global::Speechify.McpProbeErrorDetailsStage? Stage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_status")]
        public int? HttpStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2_error")]
        public string? Oauth2Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2_error_description")]
        public string? Oauth2ErrorDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_body")]
        public string? UpstreamBody { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_hint")]
        public string? FieldHint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPProbeErrorDetails" /> class.
        /// </summary>
        /// <param name="stage"></param>
        /// <param name="httpStatus"></param>
        /// <param name="oauth2Error"></param>
        /// <param name="oauth2ErrorDescription"></param>
        /// <param name="upstreamBody"></param>
        /// <param name="fieldHint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPProbeErrorDetails(
            global::Speechify.McpProbeErrorDetailsStage? stage,
            int? httpStatus,
            string? oauth2Error,
            string? oauth2ErrorDescription,
            string? upstreamBody,
            string? fieldHint)
        {
            this.Stage = stage;
            this.HttpStatus = httpStatus;
            this.Oauth2Error = oauth2Error;
            this.Oauth2ErrorDescription = oauth2ErrorDescription;
            this.UpstreamBody = upstreamBody;
            this.FieldHint = fieldHint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPProbeErrorDetails" /> class.
        /// </summary>
        public MCPProbeErrorDetails()
        {
        }

    }
}