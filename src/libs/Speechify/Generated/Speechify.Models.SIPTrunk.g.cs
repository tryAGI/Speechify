
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A SIP trunk in the workspace. Trunks back one or more phone numbers<br/>
    /// and hold the carrier credentials LiveKit uses to route calls.<br/>
    /// `auth_password` is never echoed - `auth_password_set` indicates<br/>
    /// whether one is configured.
    /// </summary>
    public sealed partial class SIPTrunk
    {
        /// <summary>
        /// Prefixed wire identifier (`trunk_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable name.
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
        /// LiveKit's inbound trunk ID (present when direction is `inbound` or `both`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit_inbound_trunk_id")]
        public string? LivekitInboundTrunkId { get; set; }

        /// <summary>
        /// LiveKit's outbound trunk ID (present when direction is `outbound` or `both`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit_outbound_trunk_id")]
        public string? LivekitOutboundTrunkId { get; set; }

        /// <summary>
        /// LiveKit dispatch rule ID that routes inbound calls into rooms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit_dispatch_rule_id")]
        public string? LivekitDispatchRuleId { get; set; }

        /// <summary>
        /// SIP endpoint hostname (e.g. `sip.telnyx.com`). Required for `kind=byoc`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_address")]
        public string? SipAddress { get; set; }

        /// <summary>
        /// SIP digest auth username.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_username")]
        public string? AuthUsername { get; set; }

        /// <summary>
        /// Whether a SIP digest auth password is configured. The value is never returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_password_set")]
        public bool? AuthPasswordSet { get; set; }

        /// <summary>
        /// IP address / CIDR allowlist for inbound SIP connections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_addresses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedAddresses { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code for the outbound dial plan<br/>
        /// (e.g. `US`, `DE`). Required for international outbound on<br/>
        /// some carriers.
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.SIPTransport Transport { get; set; }

        /// <summary>
        /// SRTP media encryption policy.<br/>
        /// - `disable` - Unencrypted media only.<br/>
        /// - `allow` - Negotiate SRTP; fall back to unencrypted. Recommended default.<br/>
        /// - `require` - Reject calls that do not support SRTP.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.SIPMediaEncryptionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.SIPMediaEncryption MediaEncryption { get; set; }

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
        /// Initializes a new instance of the <see cref="SIPTrunk" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`trunk_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </param>
        /// <param name="name">
        /// Human-readable name.
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
        /// <param name="allowedAddresses">
        /// IP address / CIDR allowlist for inbound SIP connections.
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
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="livekitInboundTrunkId">
        /// LiveKit's inbound trunk ID (present when direction is `inbound` or `both`).
        /// </param>
        /// <param name="livekitOutboundTrunkId">
        /// LiveKit's outbound trunk ID (present when direction is `outbound` or `both`).
        /// </param>
        /// <param name="livekitDispatchRuleId">
        /// LiveKit dispatch rule ID that routes inbound calls into rooms.
        /// </param>
        /// <param name="sipAddress">
        /// SIP endpoint hostname (e.g. `sip.telnyx.com`). Required for `kind=byoc`.
        /// </param>
        /// <param name="authUsername">
        /// SIP digest auth username.
        /// </param>
        /// <param name="authPasswordSet">
        /// Whether a SIP digest auth password is configured. The value is never returned.
        /// </param>
        /// <param name="destinationCountry">
        /// ISO 3166-1 alpha-2 country code for the outbound dial plan<br/>
        /// (e.g. `US`, `DE`). Required for international outbound on<br/>
        /// some carriers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPTrunk(
            string id,
            string name,
            global::Speechify.SIPTrunkKind kind,
            global::Speechify.SIPTrunkDirection direction,
            global::System.Collections.Generic.IList<string> allowedAddresses,
            global::Speechify.SIPTransport transport,
            global::Speechify.SIPMediaEncryption mediaEncryption,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? livekitInboundTrunkId,
            string? livekitOutboundTrunkId,
            string? livekitDispatchRuleId,
            string? sipAddress,
            string? authUsername,
            bool? authPasswordSet,
            string? destinationCountry)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind;
            this.Direction = direction;
            this.LivekitInboundTrunkId = livekitInboundTrunkId;
            this.LivekitOutboundTrunkId = livekitOutboundTrunkId;
            this.LivekitDispatchRuleId = livekitDispatchRuleId;
            this.SipAddress = sipAddress;
            this.AuthUsername = authUsername;
            this.AuthPasswordSet = authPasswordSet;
            this.AllowedAddresses = allowedAddresses ?? throw new global::System.ArgumentNullException(nameof(allowedAddresses));
            this.DestinationCountry = destinationCountry;
            this.Transport = transport;
            this.MediaEncryption = mediaEncryption;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunk" /> class.
        /// </summary>
        public SIPTrunk()
        {
        }

    }
}