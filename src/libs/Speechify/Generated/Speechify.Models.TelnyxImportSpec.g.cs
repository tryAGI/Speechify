
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Telnyx connection details for the bring-your-own-connection import<br/>
    /// flow. Used only when `provider=telnyx`. You provision an FQDN<br/>
    /// connection on your Telnyx account whose inbound calls forward to<br/>
    /// Speechify's LiveKit SIP ingress, assign the number to it, then import<br/>
    /// by passing the connection's id. A second number on the same connection<br/>
    /// reuses the one shared trunk + dispatch rule.
    /// </summary>
    public sealed partial class TelnyxImportSpec
    {
        /// <summary>
        /// The Telnyx FQDN connection id (numeric string) the number is<br/>
        /// routed through. Required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionId { get; set; }

        /// <summary>
        /// Optional credential-auth username for the Telnyx connection.<br/>
        /// When both `sip_username` and `sip_password` are provided, the<br/>
        /// import also provisions outbound calling for the number; omit them<br/>
        /// for an inbound-only import. Write-only - never echoed back.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_username")]
        public string? SipUsername { get; set; }

        /// <summary>
        /// Optional credential-auth password for the Telnyx connection,<br/>
        /// paired with `sip_username`. Write-only - never echoed back.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_password")]
        public string? SipPassword { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelnyxImportSpec" /> class.
        /// </summary>
        /// <param name="connectionId">
        /// The Telnyx FQDN connection id (numeric string) the number is<br/>
        /// routed through. Required.
        /// </param>
        /// <param name="sipUsername">
        /// Optional credential-auth username for the Telnyx connection.<br/>
        /// When both `sip_username` and `sip_password` are provided, the<br/>
        /// import also provisions outbound calling for the number; omit them<br/>
        /// for an inbound-only import. Write-only - never echoed back.
        /// </param>
        /// <param name="sipPassword">
        /// Optional credential-auth password for the Telnyx connection,<br/>
        /// paired with `sip_username`. Write-only - never echoed back.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelnyxImportSpec(
            string connectionId,
            string? sipUsername,
            string? sipPassword)
        {
            this.ConnectionId = connectionId ?? throw new global::System.ArgumentNullException(nameof(connectionId));
            this.SipUsername = sipUsername;
            this.SipPassword = sipPassword;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelnyxImportSpec" /> class.
        /// </summary>
        public TelnyxImportSpec()
        {
        }

    }
}