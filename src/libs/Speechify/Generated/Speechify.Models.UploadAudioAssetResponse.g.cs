
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadAudioAssetResponse
    {
        /// <summary>
        /// Metadata for a pre-recorded WAV clip stored in the workspace's<br/>
        /// audio-asset bucket. Bytes are immutable once uploaded — to<br/>
        /// replace a clip, upload a new asset and update any references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AudioAsset Asset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAudioAssetResponse" /> class.
        /// </summary>
        /// <param name="asset">
        /// Metadata for a pre-recorded WAV clip stored in the workspace's<br/>
        /// audio-asset bucket. Bytes are immutable once uploaded — to<br/>
        /// replace a clip, upload a new asset and update any references.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadAudioAssetResponse(
            global::Speechify.AudioAsset asset)
        {
            this.Asset = asset ?? throw new global::System.ArgumentNullException(nameof(asset));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAudioAssetResponse" /> class.
        /// </summary>
        public UploadAudioAssetResponse()
        {
        }

    }
}