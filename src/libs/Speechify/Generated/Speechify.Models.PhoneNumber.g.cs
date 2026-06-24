
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A phone number in the workspace inventory. Bound to an agent via<br/>
    /// `agent_id`; unbound numbers are valid but non-functional until<br/>
    /// assigned.
    /// </summary>
    public sealed partial class PhoneNumber
    {
        /// <summary>
        /// Prefixed wire identifier (`phone_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The phone number in E.164 format (e.g. `+12025551234`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("e164")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string E164 { get; set; }

        /// <summary>
        /// Which provider the number came from. Determines the provisioning<br/>
        /// and portability path.<br/>
        /// - `livekit` - LiveKit owns the carrier relationship; US inbound only.<br/>
        /// - `twilio` - Customer's own Twilio number bridged via Elastic SIP Trunk.<br/>
        /// - `telnyx` - Customer's own Telnyx number bridged via a Telnyx FQDN connection.<br/>
        /// - `byoc` - Any SIP provider using a customer-supplied trunk.<br/>
        /// - `twilio_purchased` - Bought through `POST /v1/agents/phone-numbers/purchase` on Speechify's master Twilio account; billed to Speechify.<br/>
        /// - `telnyx_purchased` - Bought through `POST /v1/agents/phone-numbers/purchase` (with `provider=telnyx`) on Speechify's master Telnyx account; billed to Speechify.<br/>
        /// - `verified_caller_id` - Customer-verified outbound caller ID on<br/>
        ///   their own Twilio account (Twilio's OutgoingCallerIds resource).<br/>
        ///   Server-determined at import time: when an `e164` submitted with<br/>
        ///   `provider=twilio` is not a full DID on the customer's account but<br/>
        ///   IS a verified caller ID, the resulting row gets this provider.<br/>
        ///   Outbound-only, never agent-bindable, rides the customer's<br/>
        ///   existing shared Twilio trunk for outbound routing. Requires a<br/>
        ///   prior `twilio` full-DID import from the same account; without<br/>
        ///   it the import returns 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.PhoneNumberProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.PhoneNumberProvider Type { get; set; }

        /// <summary>
        /// Optional human-readable label set by the customer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// ID of the SIP trunk backing this number, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trunk_id")]
        public string? TrunkId { get; set; }

        /// <summary>
        /// ID of the agent that answers calls to this number. Null when unbound.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// What this number can do.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.PhoneNumberCapability> Capabilities { get; set; }

        /// <summary>
        /// The upstream provider's own identifier for this number, when<br/>
        /// the provider exposes one (e.g. LiveKit's phone number ID for<br/>
        /// `type=livekit`, or the Twilio number SID for `type=twilio_purchased`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_phone_number_id")]
        public string? ProviderPhoneNumberId { get; set; }

        /// <summary>
        /// When the number was imported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the number was last modified.
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
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`phone_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </param>
        /// <param name="e164">
        /// The phone number in E.164 format (e.g. `+12025551234`).
        /// </param>
        /// <param name="type">
        /// Which provider the number came from. Determines the provisioning<br/>
        /// and portability path.<br/>
        /// - `livekit` - LiveKit owns the carrier relationship; US inbound only.<br/>
        /// - `twilio` - Customer's own Twilio number bridged via Elastic SIP Trunk.<br/>
        /// - `telnyx` - Customer's own Telnyx number bridged via a Telnyx FQDN connection.<br/>
        /// - `byoc` - Any SIP provider using a customer-supplied trunk.<br/>
        /// - `twilio_purchased` - Bought through `POST /v1/agents/phone-numbers/purchase` on Speechify's master Twilio account; billed to Speechify.<br/>
        /// - `telnyx_purchased` - Bought through `POST /v1/agents/phone-numbers/purchase` (with `provider=telnyx`) on Speechify's master Telnyx account; billed to Speechify.<br/>
        /// - `verified_caller_id` - Customer-verified outbound caller ID on<br/>
        ///   their own Twilio account (Twilio's OutgoingCallerIds resource).<br/>
        ///   Server-determined at import time: when an `e164` submitted with<br/>
        ///   `provider=twilio` is not a full DID on the customer's account but<br/>
        ///   IS a verified caller ID, the resulting row gets this provider.<br/>
        ///   Outbound-only, never agent-bindable, rides the customer's<br/>
        ///   existing shared Twilio trunk for outbound routing. Requires a<br/>
        ///   prior `twilio` full-DID import from the same account; without<br/>
        ///   it the import returns 400.
        /// </param>
        /// <param name="capabilities">
        /// What this number can do.
        /// </param>
        /// <param name="createdAt">
        /// When the number was imported.
        /// </param>
        /// <param name="updatedAt">
        /// When the number was last modified.
        /// </param>
        /// <param name="label">
        /// Optional human-readable label set by the customer.
        /// </param>
        /// <param name="trunkId">
        /// ID of the SIP trunk backing this number, if applicable.
        /// </param>
        /// <param name="agentId">
        /// ID of the agent that answers calls to this number. Null when unbound.
        /// </param>
        /// <param name="providerPhoneNumberId">
        /// The upstream provider's own identifier for this number, when<br/>
        /// the provider exposes one (e.g. LiveKit's phone number ID for<br/>
        /// `type=livekit`, or the Twilio number SID for `type=twilio_purchased`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumber(
            string id,
            string e164,
            global::Speechify.PhoneNumberProvider type,
            global::System.Collections.Generic.IList<global::Speechify.PhoneNumberCapability> capabilities,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? label,
            string? trunkId,
            string? agentId,
            string? providerPhoneNumberId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.E164 = e164 ?? throw new global::System.ArgumentNullException(nameof(e164));
            this.Type = type;
            this.Label = label;
            this.TrunkId = trunkId;
            this.AgentId = agentId;
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.ProviderPhoneNumberId = providerPhoneNumberId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        public PhoneNumber()
        {
        }

    }
}