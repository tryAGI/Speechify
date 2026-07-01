#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentAudioAssetsClient
    {
        /// <summary>
        /// Delete Audio Asset<br/>
        /// Soft-delete an audio asset. The underlying GCS object is<br/>
        /// retained so any flow node or tool still referencing the asset<br/>
        /// keeps working until the config is updated; the agent runtime logs<br/>
        /// and skips on a missing row at session start (fail-soft).
        /// </summary>
        /// <param name="audioAssetId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string audioAssetId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Audio Asset<br/>
        /// Soft-delete an audio asset. The underlying GCS object is<br/>
        /// retained so any flow node or tool still referencing the asset<br/>
        /// keeps working until the config is updated; the agent runtime logs<br/>
        /// and skips on a missing row at session start (fail-soft).
        /// </summary>
        /// <param name="audioAssetId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteAsResponseAsync(
            string audioAssetId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}