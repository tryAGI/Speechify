
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The verification answer for one clip.<br/>
    /// One field, and no confidence score: a score is a gradient, and a public<br/>
    /// gradient turns "does this carry the mark" into "adjust the clip until<br/>
    /// the number drops". Use `POST /v1/audio/watermark/detect` if you need it.<br/>
    /// `watermarked: true` is positive evidence the audio came from Speechify<br/>
    /// synthesis. `watermarked: false` is the absence of that evidence, not<br/>
    /// proof of a negative - see the endpoint description.
    /// </summary>
    public sealed partial class WatermarkVerificationResponse
    {
        /// <summary>
        /// Whether the clip carries the Speechify watermark.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermarked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Watermarked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkVerificationResponse" /> class.
        /// </summary>
        /// <param name="watermarked">
        /// Whether the clip carries the Speechify watermark.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkVerificationResponse(
            bool watermarked)
        {
            this.Watermarked = watermarked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkVerificationResponse" /> class.
        /// </summary>
        public WatermarkVerificationResponse()
        {
        }

    }
}