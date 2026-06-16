
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/sip-trunks`.
    /// </summary>
    public sealed partial class CreateSIPTrunkRequest
    {
        /// <summary>
        /// Human-readable name for the trunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Where the trunk came from. Informs the provisioning path and<br/>
        /// portability story.<br/>
        /// - `livekit` - Provisioned by LiveKit's native phone-number API.<br/>
        /// - `twilio` - Backed by a Twilio Elastic SIP Trunk on the customer's account.<br/>
        /// - `byoc` - Any SIP provider with a customer-managed trunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.SIPTrunkKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.SIPTrunkKind Kind { get; set; }

        /// <summary>
        /// Whether the trunk handles inbound calls, outbound calls, or both.<br/>
        /// A `both` trunk has distinct LiveKit inbound and outbound trunk IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.SIPTrunkDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.SIPTrunkDirection Direction { get; set; }

        /// <summary>
        /// SIP endpoint hostname. Required for `kind=byoc`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_address")]
        public string? SipAddress { get; set; }

        /// <summary>
        /// SIP digest auth username.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_username")]
        public string? AuthUsername { get; set; }

        /// <summary>
        /// SIP digest auth password. Write-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_password")]
        public string? AuthPassword { get; set; }

        /// <summary>
        /// IP / CIDR allowlist for inbound connections. Empty means any source is accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_addresses")]
        public global::System.Collections.Generic.IList<string>? AllowedAddresses { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country for the outbound dial plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_country")]
        public string? DestinationCountry { get; set; }

        /// <summary>
        /// SIP transport protocol. `auto` lets LiveKit negotiate. Use `tls`<br/>
        /// for production where available - note that TLS is incompatible<br/>
        /// with SIP REFER (cold transfer). Trunks that need `transfer_to_number`<br/>
        /// should use `udp` or `tcp`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.SIPTransportJsonConverter))]
        public global::Speechify.SIPTransport? Transport { get; set; }

        /// <summary>
        /// SRTP media encryption policy.<br/>
        /// - `disable` - Unencrypted media only.<br/>
        /// - `allow` - Negotiate SRTP; fall back to unencrypted. Recommended default.<br/>
        /// - `require` - Reject calls that do not support SRTP.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.SIPMediaEncryptionJsonConverter))]
        public global::Speechify.SIPMediaEncryption? MediaEncryption { get; set; }

        /// <summary>
        /// Provider-specific credential blob (for future extensibility).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Speechify.CreateSipTrunkRequestCredentials? Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSIPTrunkRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the trunk.
        /// </param>
        /// <param name="kind">
        /// Where the trunk came from. Informs the provisioning path and<br/>
        /// portability story.<br/>
        /// - `livekit` - Provisioned by LiveKit's native phone-number API.<br/>
        /// - `twilio` - Backed by a Twilio Elastic SIP Trunk on the customer's account.<br/>
        /// - `byoc` - Any SIP provider with a customer-managed trunk.
        /// </param>
        /// <param name="direction">
        /// Whether the trunk handles inbound calls, outbound calls, or both.<br/>
        /// A `both` trunk has distinct LiveKit inbound and outbound trunk IDs.
        /// </param>
        /// <param name="sipAddress">
        /// SIP endpoint hostname. Required for `kind=byoc`.
        /// </param>
        /// <param name="authUsername">
        /// SIP digest auth username.
        /// </param>
        /// <param name="authPassword">
        /// SIP digest auth password. Write-only.
        /// </param>
        /// <param name="allowedAddresses">
        /// IP / CIDR allowlist for inbound connections. Empty means any source is accepted.
        /// </param>
        /// <param name="destinationCountry">
        /// ISO 3166-1 alpha-2 country for the outbound dial plan.
        /// </param>
        /// <param name="transport">
        /// SIP transport protocol. `auto` lets LiveKit negotiate. Use `tls`<br/>
        /// for production where available - note that TLS is incompatible<br/>
        /// with SIP REFER (cold transfer). Trunks that need `transfer_to_number`<br/>
        /// should use `udp` or `tcp`.
        /// </param>
        /// <param name="mediaEncryption">
        /// SRTP media encryption policy.<br/>
        /// - `disable` - Unencrypted media only.<br/>
        /// - `allow` - Negotiate SRTP; fall back to unencrypted. Recommended default.<br/>
        /// - `require` - Reject calls that do not support SRTP.
        /// </param>
        /// <param name="credentials">
        /// Provider-specific credential blob (for future extensibility).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSIPTrunkRequest(
            string name,
            global::Speechify.SIPTrunkKind kind,
            global::Speechify.SIPTrunkDirection direction,
            string? sipAddress,
            string? authUsername,
            string? authPassword,
            global::System.Collections.Generic.IList<string>? allowedAddresses,
            string? destinationCountry,
            global::Speechify.SIPTransport? transport,
            global::Speechify.SIPMediaEncryption? mediaEncryption,
            global::Speechify.CreateSipTrunkRequestCredentials? credentials)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind;
            this.Direction = direction;
            this.SipAddress = sipAddress;
            this.AuthUsername = authUsername;
            this.AuthPassword = authPassword;
            this.AllowedAddresses = allowedAddresses;
            this.DestinationCountry = destinationCountry;
            this.Transport = transport;
            this.MediaEncryption = mediaEncryption;
            this.Credentials = credentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSIPTrunkRequest" /> class.
        /// </summary>
        public CreateSIPTrunkRequest()
        {
        }

    }
}