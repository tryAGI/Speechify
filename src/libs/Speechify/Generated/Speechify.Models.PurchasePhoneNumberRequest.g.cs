
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/phone-numbers/purchase`. The `e164` must come<br/>
    /// from a recent `SearchAvailablePhoneNumbers` response.
    /// </summary>
    public sealed partial class PurchasePhoneNumberRequest
    {
        /// <summary>
        /// The E.164 number to buy. Must currently be in carrier inventory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("e164")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string E164 { get; set; }

        /// <summary>
        /// Optional human-readable label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Which carrier's Speechify-managed account to buy on. Optional;<br/>
        /// defaults to `twilio_purchased`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.PurchasedPhoneNumberProviderJsonConverter))]
        public global::Speechify.PurchasedPhoneNumberProvider? Provider { get; set; }

        /// <summary>
        /// Optional agent to bind the number to at purchase time.<br/>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchasePhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="e164">
        /// The E.164 number to buy. Must currently be in carrier inventory.
        /// </param>
        /// <param name="label">
        /// Optional human-readable label.
        /// </param>
        /// <param name="provider">
        /// Which carrier's Speechify-managed account to buy on. Optional;<br/>
        /// defaults to `twilio_purchased`.
        /// </param>
        /// <param name="agentId">
        /// Optional agent to bind the number to at purchase time.<br/>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PurchasePhoneNumberRequest(
            string e164,
            string? label,
            global::Speechify.PurchasedPhoneNumberProvider? provider,
            string? agentId)
        {
            this.E164 = e164 ?? throw new global::System.ArgumentNullException(nameof(e164));
            this.Label = label;
            this.Provider = provider;
            this.AgentId = agentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchasePhoneNumberRequest" /> class.
        /// </summary>
        public PurchasePhoneNumberRequest()
        {
        }

    }
}