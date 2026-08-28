
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The watermark detector's answer for one clip.<br/>
    /// `watermarked: true` is positive evidence the audio came from Speechify<br/>
    /// synthesis. `watermarked: false` is the absence of that evidence, not<br/>
    /// proof of a negative - see the endpoint description for the three reasons<br/>
    /// genuinely Speechify-generated audio can come back unmarked.
    /// </summary>
    public sealed partial class WatermarkDetectionResponse
    {
        /// <summary>
        /// Whether the clip carries the watermark, i.e. whether `confidence`<br/>
        /// cleared the service's configured bar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermarked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Watermarked { get; set; }

        /// <summary>
        /// The detector's score for this clip, in [0, 1]. Comparable only<br/>
        /// between checks made against the same detector version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkDetectionResponse" /> class.
        /// </summary>
        /// <param name="watermarked">
        /// Whether the clip carries the watermark, i.e. whether `confidence`<br/>
        /// cleared the service's configured bar.
        /// </param>
        /// <param name="confidence">
        /// The detector's score for this clip, in [0, 1]. Comparable only<br/>
        /// between checks made against the same detector version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkDetectionResponse(
            bool watermarked,
            double confidence)
        {
            this.Watermarked = watermarked;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkDetectionResponse" /> class.
        /// </summary>
        public WatermarkDetectionResponse()
        {
        }

    }
}