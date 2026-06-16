
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Result of an MCP probe. On success, `tools` is the discovered<br/>
    /// catalogue and `error` is absent. On failure, `tools` is `null`<br/>
    /// and `error` carries a human-readable reason the console renders<br/>
    /// inline next to the form. `details` is optional structured<br/>
    /// signal from the upstream (OAuth2 RFC 6749 fields, HTTP status,<br/>
    /// truncated upstream body, form field hint) the console uses to<br/>
    /// expand the inline banner and highlight the offending input.<br/>
    /// Older consoles ignore `details` and fall back to `error`. Both<br/>
    /// validation and network failures land in `error` rather than<br/>
    /// non-2xx responses, so consumers must check `error` before<br/>
    /// reading `tools`.
    /// </summary>
    public sealed partial class MCPProbeResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Speechify.MCPProbeTool>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Structured upstream signal for an MCP probe failure. All fields<br/>
        /// are optional; the console renders what's present. `stage` names<br/>
        /// the phase the probe was in (`validation`, `oauth2_token`,<br/>
        /// `mcp_connect`, `mcp_initialize`, `mcp_notify`, `mcp_list_tools`).<br/>
        /// `oauth2_error` / `oauth2_error_description` mirror RFC 6749 §5.2<br/>
        /// when the customer's auth server returned the standard error<br/>
        /// shape. `http_status` is the upstream status code for transport<br/>
        /// failures. `upstream_body` is a truncated prefix (max ~1 KiB) of<br/>
        /// the upstream response body when the failure isn't structured.<br/>
        /// `field_hint` names a form field (`endpoint`, `transport`,<br/>
        /// `token`, `token_url`, `client_id`, `client_secret`, `scope`)<br/>
        /// the console should highlight so the customer knows what to fix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Speechify.MCPProbeErrorDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPProbeResult" /> class.
        /// </summary>
        /// <param name="tools"></param>
        /// <param name="error"></param>
        /// <param name="details">
        /// Structured upstream signal for an MCP probe failure. All fields<br/>
        /// are optional; the console renders what's present. `stage` names<br/>
        /// the phase the probe was in (`validation`, `oauth2_token`,<br/>
        /// `mcp_connect`, `mcp_initialize`, `mcp_notify`, `mcp_list_tools`).<br/>
        /// `oauth2_error` / `oauth2_error_description` mirror RFC 6749 §5.2<br/>
        /// when the customer's auth server returned the standard error<br/>
        /// shape. `http_status` is the upstream status code for transport<br/>
        /// failures. `upstream_body` is a truncated prefix (max ~1 KiB) of<br/>
        /// the upstream response body when the failure isn't structured.<br/>
        /// `field_hint` names a form field (`endpoint`, `transport`,<br/>
        /// `token`, `token_url`, `client_id`, `client_secret`, `scope`)<br/>
        /// the console should highlight so the customer knows what to fix.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPProbeResult(
            global::System.Collections.Generic.IList<global::Speechify.MCPProbeTool>? tools,
            string? error,
            global::Speechify.MCPProbeErrorDetails? details)
        {
            this.Tools = tools;
            this.Error = error;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPProbeResult" /> class.
        /// </summary>
        public MCPProbeResult()
        {
        }

    }
}