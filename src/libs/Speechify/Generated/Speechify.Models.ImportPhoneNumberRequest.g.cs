
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/phone-numbers`. The required fields vary by<br/>
    /// `provider` - see the individual provider descriptions.
    /// </summary>
    public sealed partial class ImportPhoneNumberRequest
    {
        /// <summary>
        /// The phone number in E.164 format. For `provider=livekit` this<br/>
        /// is the number you want LiveKit to purchase. For `provider=twilio`,<br/>
        /// `provider=telnyx`, and `provider=byoc` it is the number you<br/>
        /// already own.
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
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.PhoneNumberProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.PhoneNumberProvider Provider { get; set; }

        /// <summary>
        /// Optional human-readable label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// For `provider=byoc`: the SIP trunk to bind this number to.<br/>
        /// Prefixed wire identifier (`trunk_&lt;26 char Crockford base32&gt;`).<br/>
        /// Not required for `provider=livekit`, `provider=twilio`, or<br/>
        /// `provider=telnyx`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trunk_id")]
        public string? TrunkId { get; set; }

        /// <summary>
        /// Optional agent to bind on import. Prefixed wire identifier<br/>
        /// (`agent_&lt;26 char Crockford base32&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Twilio credentials for the one-click import flow. Used only when<br/>
        /// `provider=twilio`. The Account SID and Auth Token are used to<br/>
        /// provision an Elastic SIP Trunk on the customer's Twilio account<br/>
        /// pointing at LiveKit's SIP endpoint, then stored for future trunk<br/>
        /// management operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilio")]
        public global::Speechify.TwilioImportSpec? Twilio { get; set; }

        /// <summary>
        /// Telnyx connection details for the bring-your-own-connection import<br/>
        /// flow. Used only when `provider=telnyx`. You provision an FQDN<br/>
        /// connection on your Telnyx account whose inbound calls forward to<br/>
        /// Speechify's LiveKit SIP ingress, assign the number to it, then import<br/>
        /// by passing the connection's id. A second number on the same connection<br/>
        /// reuses the one shared trunk + dispatch rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telnyx")]
        public global::Speechify.TelnyxImportSpec? Telnyx { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportPhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="e164">
        /// The phone number in E.164 format. For `provider=livekit` this<br/>
        /// is the number you want LiveKit to purchase. For `provider=twilio`,<br/>
        /// `provider=telnyx`, and `provider=byoc` it is the number you<br/>
        /// already own.
        /// </param>
        /// <param name="provider">
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
        /// <param name="label">
        /// Optional human-readable label.
        /// </param>
        /// <param name="trunkId">
        /// For `provider=byoc`: the SIP trunk to bind this number to.<br/>
        /// Prefixed wire identifier (`trunk_&lt;26 char Crockford base32&gt;`).<br/>
        /// Not required for `provider=livekit`, `provider=twilio`, or<br/>
        /// `provider=telnyx`.
        /// </param>
        /// <param name="agentId">
        /// Optional agent to bind on import. Prefixed wire identifier<br/>
        /// (`agent_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="twilio">
        /// Twilio credentials for the one-click import flow. Used only when<br/>
        /// `provider=twilio`. The Account SID and Auth Token are used to<br/>
        /// provision an Elastic SIP Trunk on the customer's Twilio account<br/>
        /// pointing at LiveKit's SIP endpoint, then stored for future trunk<br/>
        /// management operations.
        /// </param>
        /// <param name="telnyx">
        /// Telnyx connection details for the bring-your-own-connection import<br/>
        /// flow. Used only when `provider=telnyx`. You provision an FQDN<br/>
        /// connection on your Telnyx account whose inbound calls forward to<br/>
        /// Speechify's LiveKit SIP ingress, assign the number to it, then import<br/>
        /// by passing the connection's id. A second number on the same connection<br/>
        /// reuses the one shared trunk + dispatch rule.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportPhoneNumberRequest(
            string e164,
            global::Speechify.PhoneNumberProvider provider,
            string? label,
            string? trunkId,
            string? agentId,
            global::Speechify.TwilioImportSpec? twilio,
            global::Speechify.TelnyxImportSpec? telnyx)
        {
            this.E164 = e164 ?? throw new global::System.ArgumentNullException(nameof(e164));
            this.Provider = provider;
            this.Label = label;
            this.TrunkId = trunkId;
            this.AgentId = agentId;
            this.Twilio = twilio;
            this.Telnyx = telnyx;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportPhoneNumberRequest" /> class.
        /// </summary>
        public ImportPhoneNumberRequest()
        {
        }

    }
}