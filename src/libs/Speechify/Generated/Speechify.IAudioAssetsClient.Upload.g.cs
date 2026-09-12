#nullable enable

namespace Speechify
{
    public partial interface IAudioAssetsClient
    {
        /// <summary>
        /// Upload Audio Asset<br/>
        /// Upload a new audio asset. The body is a multipart/form-data<br/>
        /// request with a single `file` field carrying the WAV bytes.<br/>
        /// The WAV is validated server-side against a strict format<br/>
        /// contract — PCM 16-bit signed, mono, 48000 Hz, ≤30s, ≤4 MiB —<br/>
        /// before any bytes hit storage. The format matches what voice<br/>
        /// agents play back natively, so clips stream with no transcoding;<br/>
        /// convert MP3 sources with `ffmpeg -i in.mp3 -ar 48000 -ac 1<br/>
        /// -sample_fmt s16 out.wav`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AudioAsset> UploadAsync(

            global::Speechify.UploadRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Audio Asset<br/>
        /// Upload a new audio asset. The body is a multipart/form-data<br/>
        /// request with a single `file` field carrying the WAV bytes.<br/>
        /// The WAV is validated server-side against a strict format<br/>
        /// contract — PCM 16-bit signed, mono, 48000 Hz, ≤30s, ≤4 MiB —<br/>
        /// before any bytes hit storage. The format matches what voice<br/>
        /// agents play back natively, so clips stream with no transcoding;<br/>
        /// convert MP3 sources with `ffmpeg -i in.mp3 -ar 48000 -ac 1<br/>
        /// -sample_fmt s16 out.wav`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AudioAsset>> UploadAsResponseAsync(

            global::Speechify.UploadRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Audio Asset<br/>
        /// Upload a new audio asset. The body is a multipart/form-data<br/>
        /// request with a single `file` field carrying the WAV bytes.<br/>
        /// The WAV is validated server-side against a strict format<br/>
        /// contract — PCM 16-bit signed, mono, 48000 Hz, ≤30s, ≤4 MiB —<br/>
        /// before any bytes hit storage. The format matches what voice<br/>
        /// agents play back natively, so clips stream with no transcoding;<br/>
        /// convert MP3 sources with `ffmpeg -i in.mp3 -ar 48000 -ac 1<br/>
        /// -sample_fmt s16 out.wav`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="projectId">
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </param>
        /// <param name="file">
        /// The WAV file bytes. Must be PCM 16-bit signed, mono,<br/>
        /// 48000 Hz, ≤30s duration, ≤4 MiB total.
        /// </param>
        /// <param name="filename">
        /// The WAV file bytes. Must be PCM 16-bit signed, mono,<br/>
        /// 48000 Hz, ≤30s duration, ≤4 MiB total.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AudioAsset> UploadAsync(
            byte[] file,
            string filename,
            string? speechifyVersion = default,
            string? projectId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Audio Asset<br/>
        /// Upload a new audio asset. The body is a multipart/form-data<br/>
        /// request with a single `file` field carrying the WAV bytes.<br/>
        /// The WAV is validated server-side against a strict format<br/>
        /// contract — PCM 16-bit signed, mono, 48000 Hz, ≤30s, ≤4 MiB —<br/>
        /// before any bytes hit storage. The format matches what voice<br/>
        /// agents play back natively, so clips stream with no transcoding;<br/>
        /// convert MP3 sources with `ffmpeg -i in.mp3 -ar 48000 -ac 1<br/>
        /// -sample_fmt s16 out.wav`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="projectId">
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </param>
        /// <param name="file">
        /// The WAV file bytes. Must be PCM 16-bit signed, mono,<br/>
        /// 48000 Hz, ≤30s duration, ≤4 MiB total.
        /// </param>
        /// <param name="filename">
        /// The WAV file bytes. Must be PCM 16-bit signed, mono,<br/>
        /// 48000 Hz, ≤30s duration, ≤4 MiB total.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AudioAsset> UploadAsync(
            global::System.IO.Stream file,
            string filename,
            string? speechifyVersion = default,
            string? projectId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Audio Asset<br/>
        /// Upload a new audio asset. The body is a multipart/form-data<br/>
        /// request with a single `file` field carrying the WAV bytes.<br/>
        /// The WAV is validated server-side against a strict format<br/>
        /// contract — PCM 16-bit signed, mono, 48000 Hz, ≤30s, ≤4 MiB —<br/>
        /// before any bytes hit storage. The format matches what voice<br/>
        /// agents play back natively, so clips stream with no transcoding;<br/>
        /// convert MP3 sources with `ffmpeg -i in.mp3 -ar 48000 -ac 1<br/>
        /// -sample_fmt s16 out.wav`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="projectId">
        /// Optional workspace project to place this resource in (prefixed<br/>
        /// `proj_...` id). Omit for the implicit Default project. An<br/>
        /// unknown id returns 404 project_not_found.
        /// </param>
        /// <param name="file">
        /// The WAV file bytes. Must be PCM 16-bit signed, mono,<br/>
        /// 48000 Hz, ≤30s duration, ≤4 MiB total.
        /// </param>
        /// <param name="filename">
        /// The WAV file bytes. Must be PCM 16-bit signed, mono,<br/>
        /// 48000 Hz, ≤30s duration, ≤4 MiB total.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AudioAsset>> UploadAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            string? speechifyVersion = default,
            string? projectId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}