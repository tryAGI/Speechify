
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadRequest
    {
        /// <summary>
        /// The WAV file bytes. Must be PCM 16-bit signed, mono,<br/>
        /// 48000 Hz, ≤30s duration, ≤4 MiB total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The WAV file bytes. Must be PCM 16-bit signed, mono,<br/>
        /// 48000 Hz, ≤30s duration, ≤4 MiB total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// The WAV file bytes. Must be PCM 16-bit signed, mono,<br/>
        /// 48000 Hz, ≤30s duration, ≤4 MiB total.
        /// </param>
        /// <param name="filename">
        /// The WAV file bytes. Must be PCM 16-bit signed, mono,<br/>
        /// 48000 Hz, ≤30s duration, ≤4 MiB total.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadRequest(
            byte[] file,
            string filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRequest" /> class.
        /// </summary>
        public UploadRequest()
        {
        }

    }
}