
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A phone number in the workspace inventory. Bound to an agent via<br/>
    /// `agent_id`; unbound numbers are valid but non-functional until<br/>
    /// assigned.
    /// </summary>
    public sealed partial class TtsPhoneNumber
    {
        /// <summary>
        /// Prefixed wire identifier (`phone_&lt;26 char Crockford base32&gt;`).<br/>
        /// ADR 0015 Cluster 3 hard-break: URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404 as of Cluster 3.
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
        /// Where the number came from. Determines the provisioning and<br/>
        /// portability path.<br/>
        /// - `livekit` - LiveKit owns the carrier relationship; US inbound only.<br/>
        /// - `twilio` - Customer's own Twilio number bridged via Elastic SIP Trunk.<br/>
        /// - `byoc` - Any SIP provider using a customer-supplied trunk.<br/>
        /// - `twilio_purchased` - Bought through `POST /v1/agents/phone-numbers/purchase` on Speechify's master Twilio account; billed to Speechify.<br/>
        /// - `verified_caller_id` - Customer-verified outbound caller ID on<br/>
        ///   their own Twilio account (Twilio's OutgoingCallerIds resource).<br/>
        ///   Server-determined at import time: when an `e164` submitted with<br/>
        ///   `source=twilio` is not a full DID on the customer's account but<br/>
        ///   IS a verified caller ID, the resulting row gets this source.<br/>
        ///   Outbound-only, never agent-bindable, rides the customer's<br/>
        ///   existing shared Twilio trunk for outbound routing. Requires a<br/>
        ///   prior `twilio` full-DID import from the same account; without<br/>
        ///   it the import returns 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsPhoneNumberSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsPhoneNumberSource Source { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Speechify.TtsPhoneNumberCapability> Capabilities { get; set; }

        /// <summary>
        /// LiveKit's own phone number ID (populated for `source=livekit` only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit_phone_number_id")]
        public string? LivekitPhoneNumberId { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsPhoneNumber" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`phone_&lt;26 char Crockford base32&gt;`).<br/>
        /// ADR 0015 Cluster 3 hard-break: URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404 as of Cluster 3.
        /// </param>
        /// <param name="e164">
        /// The phone number in E.164 format (e.g. `+12025551234`).
        /// </param>
        /// <param name="source">
        /// Where the number came from. Determines the provisioning and<br/>
        /// portability path.<br/>
        /// - `livekit` - LiveKit owns the carrier relationship; US inbound only.<br/>
        /// - `twilio` - Customer's own Twilio number bridged via Elastic SIP Trunk.<br/>
        /// - `byoc` - Any SIP provider using a customer-supplied trunk.<br/>
        /// - `twilio_purchased` - Bought through `POST /v1/agents/phone-numbers/purchase` on Speechify's master Twilio account; billed to Speechify.<br/>
        /// - `verified_caller_id` - Customer-verified outbound caller ID on<br/>
        ///   their own Twilio account (Twilio's OutgoingCallerIds resource).<br/>
        ///   Server-determined at import time: when an `e164` submitted with<br/>
        ///   `source=twilio` is not a full DID on the customer's account but<br/>
        ///   IS a verified caller ID, the resulting row gets this source.<br/>
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
        /// <param name="livekitPhoneNumberId">
        /// LiveKit's own phone number ID (populated for `source=livekit` only).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsPhoneNumber(
            string id,
            string e164,
            global::Speechify.TtsPhoneNumberSource source,
            global::System.Collections.Generic.IList<global::Speechify.TtsPhoneNumberCapability> capabilities,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? label,
            string? trunkId,
            string? agentId,
            string? livekitPhoneNumberId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.E164 = e164 ?? throw new global::System.ArgumentNullException(nameof(e164));
            this.Source = source;
            this.Label = label;
            this.TrunkId = trunkId;
            this.AgentId = agentId;
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.LivekitPhoneNumberId = livekitPhoneNumberId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsPhoneNumber" /> class.
        /// </summary>
        public TtsPhoneNumber()
        {
        }

    }
}