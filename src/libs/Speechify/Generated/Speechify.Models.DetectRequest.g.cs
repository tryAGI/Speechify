
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DetectRequest
    {
        /// <summary>
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its confidence is<br/>
        /// not worth acting on, and below half a second it always<br/>
        /// reports zero.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its confidence is<br/>
        /// not worth acting on, and below half a second it always<br/>
        /// reports zero.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectRequest" /> class.
        /// </summary>
        /// <param name="audio">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its confidence is<br/>
        /// not worth acting on, and below half a second it always<br/>
        /// reports zero.
        /// </param>
        /// <param name="audioname">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its confidence is<br/>
        /// not worth acting on, and below half a second it always<br/>
        /// reports zero.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectRequest(
            byte[] audio,
            string audioname)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectRequest" /> class.
        /// </summary>
        public DetectRequest()
        {
        }

    }
}