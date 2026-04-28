
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Batch-run payload. Total expanded runs across all entries are<br/>
    /// capped at 100 per call.
    /// </summary>
    public sealed partial class TtsRunBatchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsBatchRunEntry> Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRunBatchRequest" /> class.
        /// </summary>
        /// <param name="entries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsRunBatchRequest(
            global::System.Collections.Generic.IList<global::Speechify.TtsBatchRunEntry> entries)
        {
            this.Entries = entries ?? throw new global::System.ArgumentNullException(nameof(entries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRunBatchRequest" /> class.
        /// </summary>
        public TtsRunBatchRequest()
        {
        }
    }
}