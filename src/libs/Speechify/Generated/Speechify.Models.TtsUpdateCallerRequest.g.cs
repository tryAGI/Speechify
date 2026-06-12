
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH payload. Omitted fields are unchanged; present fields<br/>
    /// overwrite. Empty string clears nullable text columns; `metadata`<br/>
    /// replaces the JSONB blob in full when supplied.
    /// </summary>
    public sealed partial class TtsUpdateCallerRequest
    {
        /// <summary>
        /// Operator-editable display name. Empty string clears the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Optional handle into the customer's own CRM. Empty string clears the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ref")]
        public string? ExternalRef { get; set; }

        /// <summary>
        /// Replacement metadata JSONB. Must not be `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateCallerRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Operator-editable display name. Empty string clears the column.
        /// </param>
        /// <param name="externalRef">
        /// Optional handle into the customer's own CRM. Empty string clears the column.
        /// </param>
        /// <param name="metadata">
        /// Replacement metadata JSONB. Must not be `null`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsUpdateCallerRequest(
            string? displayName,
            string? externalRef,
            object? metadata)
        {
            this.DisplayName = displayName;
            this.ExternalRef = externalRef;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsUpdateCallerRequest" /> class.
        /// </summary>
        public TtsUpdateCallerRequest()
        {
        }

    }
}