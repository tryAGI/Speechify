
#nullable enable

namespace Speechify
{
    public partial class AudioClient
    {


        private static readonly global::Speechify.EndPointSecurityRequirement s_StreamWithTimestampsSecurityRequirement0 =
            new global::Speechify.EndPointSecurityRequirement
            {
                Authorizations = new global::Speechify.EndPointAuthorizationRequirement[]
                {                    new global::Speechify.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Speechify.EndPointSecurityRequirement[] s_StreamWithTimestampsSecurityRequirements =
            new global::Speechify.EndPointSecurityRequirement[]
            {                s_StreamWithTimestampsSecurityRequirement0,
            };
        partial void PrepareStreamWithTimestampsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? speechifyVersion,
            ref global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept? accept,
            global::Speechify.GetStreamRequest request);
        partial void PrepareStreamWithTimestampsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? speechifyVersion,
            global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept? accept,
            global::Speechify.GetStreamRequest request);
        partial void ProcessStreamWithTimestampsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Stream Speech With Timestamps<br/>
        /// Synthesize speech and stream it back together with word-level speech<br/>
        /// marks, for text highlighting, captions and audio-text synchronization<br/>
        /// while the audio is still arriving.<br/>
        /// The response is a Server-Sent Events stream. Each `speech.chunk` event<br/>
        /// carries a Base64-encoded run of audio, the speech marks that became<br/>
        /// final with it, or both - a chunk may carry only one of the two, and the<br/>
        /// last chunk of a stream is often marks-only. A terminal `speech.done`<br/>
        /// event ends the stream; there is no `[DONE]` sentinel. Ignore any event<br/>
        /// type you do not recognize, so that new event types do not break your<br/>
        /// integration.<br/>
        /// Speech-mark times are absolute milliseconds from the start of the<br/>
        /// synthesis, so concatenate the audio chunks into one stream and apply the<br/>
        /// marks against that single timeline. Which chunk a mark arrives on is a<br/>
        /// delivery detail and carries no meaning. Times stay correct for every<br/>
        /// `output_format`: changing the codec or sample rate does not change the<br/>
        /// duration.<br/>
        /// Speech marks are produced by the streaming-native models. The default<br/>
        /// `simba-3.0` and `simba-3.2` both serve this route; the legacy<br/>
        /// `simba-english` and `simba-multilingual` models return 400<br/>
        /// `speech_marks_unsupported` here.<br/>
        /// For Base64-encoded audio and speech marks in one non-streamed JSON<br/>
        /// response, on any model, use POST /v1/audio/speech.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="accept"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Speechify.SpeechStreamEvent> StreamWithTimestampsAsync(

            global::Speechify.GetStreamRequest request,
            string? speechifyVersion = default,
            global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept? accept = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareStreamWithTimestampsArguments(
                httpClient: HttpClient,
                speechifyVersion: ref speechifyVersion,
                accept: ref accept,
                request: request);


            var __authorizations = global::Speechify.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_StreamWithTimestampsSecurityRequirements,
                operationName: "StreamWithTimestampsAsync");

            using var __timeoutCancellationTokenSource = global::Speechify.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Speechify.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Speechify.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Speechify.PathBuilder(
                                path: "/v1/audio/stream/with-timestamps",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Speechify.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

            if (speechifyVersion != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Speechify-Version", speechifyVersion.ToString());
            }
            if (accept != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Accept", accept?.ToValueString() ?? string.Empty);
            }

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Speechify.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareStreamWithTimestampsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    speechifyVersion: speechifyVersion,
                    accept: accept,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Speechify.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Speechify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StreamWithTimestamps",
                                methodName: "StreamWithTimestampsAsync",
                                pathTemplate: "\"/v1/audio/stream/with-timestamps\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Speechify.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Speechify.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Speechify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StreamWithTimestamps",
                                methodName: "StreamWithTimestampsAsync",
                                pathTemplate: "\"/v1/audio/stream/with-timestamps\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Speechify.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Speechify.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Speechify.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Speechify.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Speechify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StreamWithTimestamps",
                                methodName: "StreamWithTimestampsAsync",
                                pathTemplate: "\"/v1/audio/stream/with-timestamps\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Speechify.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessStreamWithTimestampsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Speechify.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Speechify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StreamWithTimestamps",
                                methodName: "StreamWithTimestampsAsync",
                                pathTemplate: "\"/v1/audio/stream/with-timestamps\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Speechify.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Speechify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StreamWithTimestamps",
                                methodName: "StreamWithTimestampsAsync",
                                pathTemplate: "\"/v1/audio/stream/with-timestamps\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
                            {
                                string? __content = null;
                                try
                                {
                                    __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);
                                }
                                catch (global::System.Exception)
                                {
                                }

                                throw global::Speechify.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __ex,
                                    responseBody: __content,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::Speechify.SpeechStreamEvent.FromJson(__content, JsonSerializerContext) ??
                                                       throw global::Speechify.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Stream Speech With Timestamps<br/>
        /// Synthesize speech and stream it back together with word-level speech<br/>
        /// marks, for text highlighting, captions and audio-text synchronization<br/>
        /// while the audio is still arriving.<br/>
        /// The response is a Server-Sent Events stream. Each `speech.chunk` event<br/>
        /// carries a Base64-encoded run of audio, the speech marks that became<br/>
        /// final with it, or both - a chunk may carry only one of the two, and the<br/>
        /// last chunk of a stream is often marks-only. A terminal `speech.done`<br/>
        /// event ends the stream; there is no `[DONE]` sentinel. Ignore any event<br/>
        /// type you do not recognize, so that new event types do not break your<br/>
        /// integration.<br/>
        /// Speech-mark times are absolute milliseconds from the start of the<br/>
        /// synthesis, so concatenate the audio chunks into one stream and apply the<br/>
        /// marks against that single timeline. Which chunk a mark arrives on is a<br/>
        /// delivery detail and carries no meaning. Times stay correct for every<br/>
        /// `output_format`: changing the codec or sample rate does not change the<br/>
        /// duration.<br/>
        /// Speech marks are produced by the streaming-native models. The default<br/>
        /// `simba-3.0` and `simba-3.2` both serve this route; the legacy<br/>
        /// `simba-english` and `simba-multilingual` models return 400<br/>
        /// `speech_marks_unsupported` here.<br/>
        /// For Base64-encoded audio and speech marks in one non-streamed JSON<br/>
        /// response, on any model, use POST /v1/audio/speech.
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
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Speechify.SpeechStreamEvent> StreamWithTimestampsAsync(
            string input,
            string voiceId,
            string? speechifyVersion = default,
            global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept? accept = default,
            string? language = default,
            global::Speechify.GetStreamRequestModel? model = default,
            global::Speechify.GetStreamOptionsRequest? options = default,
            global::Speechify.AudioStreamOutputFormat? outputFormat = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Speechify.GetStreamRequest
            {
                Input = input,
                Language = language,
                Model = model,
                Options = options,
                OutputFormat = outputFormat,
                VoiceId = voiceId,
            };

            var __enumerable = StreamWithTimestampsAsync(
                speechifyVersion: speechifyVersion,
                accept: accept,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}