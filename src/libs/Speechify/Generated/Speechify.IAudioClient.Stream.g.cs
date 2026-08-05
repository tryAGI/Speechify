#nullable enable

namespace Speechify
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Stream Speech<br/>
        /// Synthesize speech and stream the audio back as it is generated, for<br/>
        /// low-latency playback. Set `output_format` in the body for explicit<br/>
        /// codec/sample-rate/bitrate control (e.g. `pcm_16000` or `ulaw_8000` for<br/>
        /// telephony), or fall back to the Accept header for the container; the<br/>
        /// response is raw audio bytes (HTTP chunked). For Base64-encoded audio<br/>
        /// with speech-mark metadata in a single JSON response, use<br/>
        /// POST /v1/audio/speech.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="accept"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamAsync(

            global::Speechify.GetStreamRequest request,
            string? speechifyVersion = default,
            global::Speechify.V1AudioStreamPostParametersAccept? accept = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Speech<br/>
        /// Synthesize speech and stream the audio back as it is generated, for<br/>
        /// low-latency playback. Set `output_format` in the body for explicit<br/>
        /// codec/sample-rate/bitrate control (e.g. `pcm_16000` or `ulaw_8000` for<br/>
        /// telephony), or fall back to the Accept header for the container; the<br/>
        /// response is raw audio bytes (HTTP chunked). For Base64-encoded audio<br/>
        /// with speech-mark metadata in a single JSON response, use<br/>
        /// POST /v1/audio/speech.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="accept"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamAsStreamAsync(

            global::Speechify.GetStreamRequest request,
            string? speechifyVersion = default,
            global::Speechify.V1AudioStreamPostParametersAccept? accept = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Speech<br/>
        /// Synthesize speech and stream the audio back as it is generated, for<br/>
        /// low-latency playback. Set `output_format` in the body for explicit<br/>
        /// codec/sample-rate/bitrate control (e.g. `pcm_16000` or `ulaw_8000` for<br/>
        /// telephony), or fall back to the Accept header for the container; the<br/>
        /// response is raw audio bytes (HTTP chunked). For Base64-encoded audio<br/>
        /// with speech-mark metadata in a single JSON response, use<br/>
        /// POST /v1/audio/speech.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="accept"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<byte[]>> StreamAsResponseAsync(

            global::Speechify.GetStreamRequest request,
            string? speechifyVersion = default,
            global::Speechify.V1AudioStreamPostParametersAccept? accept = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Speech<br/>
        /// Synthesize speech and stream the audio back as it is generated, for<br/>
        /// low-latency playback. Set `output_format` in the body for explicit<br/>
        /// codec/sample-rate/bitrate control (e.g. `pcm_16000` or `ulaw_8000` for<br/>
        /// telephony), or fall back to the Accept header for the container; the<br/>
        /// response is raw audio bytes (HTTP chunked). For Base64-encoded audio<br/>
        /// with speech-mark metadata in a single JSON response, use<br/>
        /// POST /v1/audio/speech.
        /// </summary>
        /// <param name="speechifyVersion"></param>
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
        /// Model used for audio synthesis. Defaults to `simba-3.0`, which is streaming-native and multilingual: it officially supports English plus `de-DE`, `es-ES`, `es-MX`, `fr-FR`, `it-IT` and `pt-BR`, and routes each request to its English or its multilingual training based on `language` (falling back to the voice's locale when `language` is omitted). `simba-3.2` is the streaming-native model with the lowest TTFB and richest expressivity, and the recommended Simba 3 model; it is English only, so a non-English voice returns 400. `simba-english` and `simba-multilingual` are the legacy Simba 1.6 models, kept for compatibility.<br/>
        /// Default Value: simba-3.0
        /// </param>
        /// <param name="options">
        /// GetStreamOptionsRequest is the wrapper for request parameters to the client
        /// </param>
        /// <param name="outputFormat">
        /// The output audio format as a `codec_sampleRate_bitrate` string. Takes precedence over the `Accept` header when set, so you can request formats the `Accept` enum does not cover (e.g. `pcm_16000`, `ulaw_8000`). `wav_*` formats are not supported on streaming - use `POST /v1/audio/speech` for wav.
        /// </param>
        /// <param name="voiceId">
        /// Id of the voice to be used for synthesizing speech. Refer to /v1/voices endpoint for available voices
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamAsync(
            string input,
            string voiceId,
            string? speechifyVersion = default,
            global::Speechify.V1AudioStreamPostParametersAccept? accept = default,
            string? language = default,
            global::Speechify.GetStreamRequestModel? model = default,
            global::Speechify.GetStreamOptionsRequest? options = default,
            global::Speechify.AudioStreamOutputFormat? outputFormat = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}