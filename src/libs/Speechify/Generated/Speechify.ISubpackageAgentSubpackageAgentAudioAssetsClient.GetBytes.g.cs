#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentAudioAssetsClient
    {
        /// <summary>
        /// Get Audio Asset Bytes<br/>
        /// Stream the raw WAV bytes for an audio asset. Byte-stream<br/>
        /// sibling of the metadata endpoint at /v1/agents/audio-assets/{audio_asset_id}.<br/>
        /// The LiveKit worker fetches through here for the play_audio<br/>
        /// builtin; SDK consumers can also download originals. Returns 404<br/>
        /// for missing / soft-deleted / foreign-tenant assets.
        /// </summary>
        /// <param name="audioAssetId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetBytesAsync(
            string audioAssetId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Audio Asset Bytes<br/>
        /// Stream the raw WAV bytes for an audio asset. Byte-stream<br/>
        /// sibling of the metadata endpoint at /v1/agents/audio-assets/{audio_asset_id}.<br/>
        /// The LiveKit worker fetches through here for the play_audio<br/>
        /// builtin; SDK consumers can also download originals. Returns 404<br/>
        /// for missing / soft-deleted / foreign-tenant assets.
        /// </summary>
        /// <param name="audioAssetId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetBytesAsStreamAsync(
            string audioAssetId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Audio Asset Bytes<br/>
        /// Stream the raw WAV bytes for an audio asset. Byte-stream<br/>
        /// sibling of the metadata endpoint at /v1/agents/audio-assets/{audio_asset_id}.<br/>
        /// The LiveKit worker fetches through here for the play_audio<br/>
        /// builtin; SDK consumers can also download originals. Returns 404<br/>
        /// for missing / soft-deleted / foreign-tenant assets.
        /// </summary>
        /// <param name="audioAssetId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<byte[]>> GetBytesAsResponseAsync(
            string audioAssetId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}