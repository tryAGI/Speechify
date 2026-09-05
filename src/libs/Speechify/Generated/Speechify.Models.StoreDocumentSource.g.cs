
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The durable run (and its journal step) that wrote this version. Absent for a direct API write.
    /// </summary>
    public sealed partial class StoreDocumentSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        public int? Step { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDocumentSource" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="step"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreDocumentSource(
            string runId,
            int? step)
        {
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDocumentSource" /> class.
        /// </summary>
        public StoreDocumentSource()
        {
        }

    }
}