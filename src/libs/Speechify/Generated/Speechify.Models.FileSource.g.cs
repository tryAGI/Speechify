
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The run whose tool call produced this file. Present only on a file<br/>
    /// Speechify captured from a tool's response, absent on a customer upload.
    /// </summary>
    public sealed partial class FileSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        /// The journal step of the tool call that produced it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Step { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSource" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="step">
        /// The journal step of the tool call that produced it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSource(
            string runId,
            int step)
        {
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSource" /> class.
        /// </summary>
        public FileSource()
        {
        }

    }
}