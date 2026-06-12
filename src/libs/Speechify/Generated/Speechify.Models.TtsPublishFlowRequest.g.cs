
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional body for POST /v1/agents/{id}/flow/publish.
    /// </summary>
    public sealed partial class TtsPublishFlowRequest
    {
        /// <summary>
        /// Optional changelog note recorded on the published version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsPublishFlowRequest" /> class.
        /// </summary>
        /// <param name="notes">
        /// Optional changelog note recorded on the published version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsPublishFlowRequest(
            string? notes)
        {
            this.Notes = notes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsPublishFlowRequest" /> class.
        /// </summary>
        public TtsPublishFlowRequest()
        {
        }

    }
}