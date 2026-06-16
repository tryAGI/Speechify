
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAudioAssetsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.AudioAsset> Assets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAudioAssetsResponse" /> class.
        /// </summary>
        /// <param name="assets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAudioAssetsResponse(
            global::System.Collections.Generic.IList<global::Speechify.AudioAsset> assets)
        {
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAudioAssetsResponse" /> class.
        /// </summary>
        public ListAudioAssetsResponse()
        {
        }

    }
}