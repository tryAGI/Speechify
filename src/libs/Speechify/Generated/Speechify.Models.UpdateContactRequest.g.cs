
#nullable enable

namespace Speechify
{
    /// <summary>
    /// PATCH payload. Omitted fields are unchanged; present fields overwrite.<br/>
    /// An empty `display_name` clears the column; `metadata` replaces the<br/>
    /// stored blob in full when supplied.<br/>
    /// Neither field is nullable. Clearing is spelled `""` for<br/>
    /// `display_name` and `{}` for `metadata`; an explicit `null` is<br/>
    /// rejected with a 400 naming the field, never accepted as a no-op.
    /// </summary>
    public sealed partial class UpdateContactRequest
    {
        /// <summary>
        /// Operator-editable display name. Empty string clears the column; an explicit `null` is rejected with a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Replacement metadata JSONB. An explicit `null` is rejected with a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Operator-editable display name. Empty string clears the column; an explicit `null` is rejected with a 400.
        /// </param>
        /// <param name="metadata">
        /// Replacement metadata JSONB. An explicit `null` is rejected with a 400.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateContactRequest(
            string? displayName,
            object? metadata)
        {
            this.DisplayName = displayName;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactRequest" /> class.
        /// </summary>
        public UpdateContactRequest()
        {
        }

    }
}