#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentConversationsClient
    {
        /// <summary>
        /// Stream Recording<br/>
        /// Proxy the GCS-stored audio recording for a conversation through<br/>
        /// the Cloud Run service identity. Returns OGG/Opus bytes (LiveKit<br/>
        /// room-composite egress default). The response is streamed so a<br/>
        /// long recording does not buffer in memory; `&lt;audio src&gt;` consumers<br/>
        /// can seek directly. Only present when the agent had<br/>
        /// `save_audio_recording` enabled at session start.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamRecordingAsync(
            string id,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Recording<br/>
        /// Proxy the GCS-stored audio recording for a conversation through<br/>
        /// the Cloud Run service identity. Returns OGG/Opus bytes (LiveKit<br/>
        /// room-composite egress default). The response is streamed so a<br/>
        /// long recording does not buffer in memory; `&lt;audio src&gt;` consumers<br/>
        /// can seek directly. Only present when the agent had<br/>
        /// `save_audio_recording` enabled at session start.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamRecordingAsStreamAsync(
            string id,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Recording<br/>
        /// Proxy the GCS-stored audio recording for a conversation through<br/>
        /// the Cloud Run service identity. Returns OGG/Opus bytes (LiveKit<br/>
        /// room-composite egress default). The response is streamed so a<br/>
        /// long recording does not buffer in memory; `&lt;audio src&gt;` consumers<br/>
        /// can seek directly. Only present when the agent had<br/>
        /// `save_audio_recording` enabled at session start.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<byte[]>> StreamRecordingAsResponseAsync(
            string id,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}