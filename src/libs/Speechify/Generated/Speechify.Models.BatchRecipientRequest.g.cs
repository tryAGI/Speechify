
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One entry in a batch-call request.
    /// </summary>
    public sealed partial class BatchRecipientRequest
    {
        /// <summary>
        /// Recipient phone number in E.164 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Phone { get; set; }

        /// <summary>
        /// Per-recipient variable overrides injected into the agent prompt.<br/>
        /// Values may be any JSON type, matching the outbound-call and<br/>
        /// web-session `dynamic_variables` surfaces. CSV uploads carry<br/>
        /// string values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// Optional client-supplied correlation key, echoed back on the<br/>
        /// recipient read shape so results can be reconciled to the caller's<br/>
        /// own identifier (an order id, a CRM lead id). A CSV upload sets it<br/>
        /// from a `custom_id` column. Max 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRecipientRequest" /> class.
        /// </summary>
        /// <param name="phone">
        /// Recipient phone number in E.164 format.
        /// </param>
        /// <param name="dynamicVariables">
        /// Per-recipient variable overrides injected into the agent prompt.<br/>
        /// Values may be any JSON type, matching the outbound-call and<br/>
        /// web-session `dynamic_variables` surfaces. CSV uploads carry<br/>
        /// string values.
        /// </param>
        /// <param name="customId">
        /// Optional client-supplied correlation key, echoed back on the<br/>
        /// recipient read shape so results can be reconciled to the caller's<br/>
        /// own identifier (an order id, a CRM lead id). A CSV upload sets it<br/>
        /// from a `custom_id` column. Max 256 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRecipientRequest(
            string phone,
            object? dynamicVariables,
            string? customId)
        {
            this.Phone = phone ?? throw new global::System.ArgumentNullException(nameof(phone));
            this.DynamicVariables = dynamicVariables;
            this.CustomId = customId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRecipientRequest" /> class.
        /// </summary>
        public BatchRecipientRequest()
        {
        }

    }
}