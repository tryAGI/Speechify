#nullable enable

namespace Speechify
{
    public partial interface IAudioAssetsClient
    {
        /// <summary>
        /// List Audio Assets<br/>
        /// List every non-deleted audio asset in the caller's workspace.<br/>
        /// Audio assets are pre-recorded WAV clips (intro jingles, legal<br/>
        /// disclaimers, hold cues) referenced from `play_audio` flow nodes<br/>
        /// and the corresponding system builtin. Cursor-paginated: omit<br/>
        /// `cursor` for the first page; walk pages while `has_more` is true<br/>
        /// (default page size 50, max 200).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListAudioAssetsResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Audio Assets<br/>
        /// List every non-deleted audio asset in the caller's workspace.<br/>
        /// Audio assets are pre-recorded WAV clips (intro jingles, legal<br/>
        /// disclaimers, hold cues) referenced from `play_audio` flow nodes<br/>
        /// and the corresponding system builtin. Cursor-paginated: omit<br/>
        /// `cursor` for the first page; walk pages while `has_more` is true<br/>
        /// (default page size 50, max 200).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListAudioAssetsResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}