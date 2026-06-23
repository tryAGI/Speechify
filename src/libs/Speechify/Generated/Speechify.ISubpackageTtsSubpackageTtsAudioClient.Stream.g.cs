#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAudioClient
    {
        /// <summary>
        /// Stream Speech<br/>
        /// Synthesize speech and stream the audio back as it is generated, for<br/>
        /// low-latency playback. The Accept header selects the audio container;<br/>
        /// the response is raw audio bytes (HTTP chunked). For Base64-encoded<br/>
        /// audio with speech-mark metadata in a single JSON response, use<br/>
        /// POST /v1/audio/speech.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamAsync(
            global::Speechify.V1AudioStreamPostParametersAccept accept,

            global::Speechify.GetStreamRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Speech<br/>
        /// Synthesize speech and stream the audio back as it is generated, for<br/>
        /// low-latency playback. The Accept header selects the audio container;<br/>
        /// the response is raw audio bytes (HTTP chunked). For Base64-encoded<br/>
        /// audio with speech-mark metadata in a single JSON response, use<br/>
        /// POST /v1/audio/speech.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamAsStreamAsync(
            global::Speechify.V1AudioStreamPostParametersAccept accept,

            global::Speechify.GetStreamRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Speech<br/>
        /// Synthesize speech and stream the audio back as it is generated, for<br/>
        /// low-latency playback. The Accept header selects the audio container;<br/>
        /// the response is raw audio bytes (HTTP chunked). For Base64-encoded<br/>
        /// audio with speech-mark metadata in a single JSON response, use<br/>
        /// POST /v1/audio/speech.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<byte[]>> StreamAsResponseAsync(
            global::Speechify.V1AudioStreamPostParametersAccept accept,

            global::Speechify.GetStreamRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Speech<br/>
        /// Synthesize speech and stream the audio back as it is generated, for<br/>
        /// low-latency playback. The Accept header selects the audio container;<br/>
        /// the response is raw audio bytes (HTTP chunked). For Base64-encoded<br/>
        /// audio with speech-mark metadata in a single JSON response, use<br/>
        /// POST /v1/audio/speech.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="input">
        /// Plain text or SSML to be synthesized to speech.<br/>
        /// Refer to https://docs.speechify.ai/docs/api-limits for the input size limits.<br/>
        /// Emotion, Pitch and Speed Rate are configured in the ssml input, please refer to the ssml documentation for more information: https://docs.speechify.ai/docs/ssml#prosody
        /// </param>
        /// <param name="language">
        /// Language of the input. Follow the format of an ISO 639-1 language code and an ISO 3166-1 region code, separated by a hyphen, e.g. en-US.<br/>
        /// Please refer to the list of the supported languages and recommendations regarding this parameter: https://docs.speechify.ai/docs/language-support.
        /// </param>
        /// <param name="model">
        /// Model used for audio synthesis. `simba-english` is optimized for English, `simba-multilingual` for non-English or mixed input. `simba-3.0` is the streaming-native model with lower TTFB and richer expressivity. Currently English only; multilingual coming soon. Non-English voices return 400 until multilingual support ships.<br/>
        /// Default Value: simba-english
        /// </param>
        /// <param name="options">
        /// GetStreamOptionsRequest is the wrapper for request parameters to the client
        /// </param>
        /// <param name="voiceId">
        /// Id of the voice to be used for synthesizing speech. Refer to /v1/voices endpoint for available voices
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamAsync(
            global::Speechify.V1AudioStreamPostParametersAccept accept,
            string input,
            string voiceId,
            string? language = default,
            global::Speechify.GetStreamRequestModel? model = default,
            global::Speechify.GetStreamOptionsRequest? options = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}