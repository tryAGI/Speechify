
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
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

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
        /// Which carrier's Speechify-managed account to buy on. Optional<br/>
        /// and best omitted: the platform picks the current carrier<br/>
        /// (`telnyx_purchased`). Passing the retired `twilio_purchased`<br/>
        /// returns `400 validation_failed`.
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
        /// Optional workspace-level intended-use declaration recorded with<br/>
        /// the purchase (replaces any earlier declaration). May be required<br/>
        /// by the workspace trust policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intended_use")]
        public global::Speechify.IntendedUse? IntendedUse { get; set; }

        /// <summary>
        /// Set true to record the ToS/consent attestation for this<br/>
        /// workspace. Recorded once - a repeat purchase never moves the<br/>
        /// original attestation's actor or timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tos_accepted")]
        public bool? TosAccepted { get; set; }

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
        /// <param name="projectId">
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </param>
        /// <param name="label">
        /// Optional human-readable label.
        /// </param>
        /// <param name="provider">
        /// Which carrier's Speechify-managed account to buy on. Optional<br/>
        /// and best omitted: the platform picks the current carrier<br/>
        /// (`telnyx_purchased`). Passing the retired `twilio_purchased`<br/>
        /// returns `400 validation_failed`.
        /// </param>
        /// <param name="agentId">
        /// Optional agent to bind the number to at purchase time.<br/>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="intendedUse">
        /// Optional workspace-level intended-use declaration recorded with<br/>
        /// the purchase (replaces any earlier declaration). May be required<br/>
        /// by the workspace trust policy.
        /// </param>
        /// <param name="tosAccepted">
        /// Set true to record the ToS/consent attestation for this<br/>
        /// workspace. Recorded once - a repeat purchase never moves the<br/>
        /// original attestation's actor or timestamp.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PurchasePhoneNumberRequest(
            string e164,
            string? projectId,
            string? label,
            global::Speechify.PurchasedPhoneNumberProvider? provider,
            string? agentId,
            global::Speechify.IntendedUse? intendedUse,
            bool? tosAccepted)
        {
            this.ProjectId = projectId;
            this.E164 = e164 ?? throw new global::System.ArgumentNullException(nameof(e164));
            this.Label = label;
            this.Provider = provider;
            this.AgentId = agentId;
            this.IntendedUse = intendedUse;
            this.TosAccepted = tosAccepted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchasePhoneNumberRequest" /> class.
        /// </summary>
        public PurchasePhoneNumberRequest()
        {
        }

    }
}