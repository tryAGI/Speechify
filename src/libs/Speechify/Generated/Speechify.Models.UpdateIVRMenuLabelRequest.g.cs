
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Re-label one option in the stored menu_tree. The option is<br/>
    /// matched by its DTMF value; the label is the human-readable text<br/>
    /// rendered in the console + surfaced to the LLM at navigate time.
    /// </summary>
    public sealed partial class UpdateIVRMenuLabelRequest
    {
        /// <summary>
        /// DTMF value of the option to relabel (e.g. "1", "*", "#").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dtmf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dtmf { get; set; }

        /// <summary>
        /// New label. Capped at 256 chars server-side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIVRMenuLabelRequest" /> class.
        /// </summary>
        /// <param name="dtmf">
        /// DTMF value of the option to relabel (e.g. "1", "*", "#").
        /// </param>
        /// <param name="label">
        /// New label. Capped at 256 chars server-side.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateIVRMenuLabelRequest(
            string dtmf,
            string label)
        {
            this.Dtmf = dtmf ?? throw new global::System.ArgumentNullException(nameof(dtmf));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIVRMenuLabelRequest" /> class.
        /// </summary>
        public UpdateIVRMenuLabelRequest()
        {
        }

    }
}