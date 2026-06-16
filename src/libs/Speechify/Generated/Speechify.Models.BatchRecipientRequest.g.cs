
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
        /// Per-recipient variable overrides injected into the agent prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_vars")]
        public global::System.Collections.Generic.Dictionary<string, string>? DynamicVars { get; set; }

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
        /// <param name="dynamicVars">
        /// Per-recipient variable overrides injected into the agent prompt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRecipientRequest(
            string phone,
            global::System.Collections.Generic.Dictionary<string, string>? dynamicVars)
        {
            this.Phone = phone ?? throw new global::System.ArgumentNullException(nameof(phone));
            this.DynamicVars = dynamicVars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRecipientRequest" /> class.
        /// </summary>
        public BatchRecipientRequest()
        {
        }

    }
}