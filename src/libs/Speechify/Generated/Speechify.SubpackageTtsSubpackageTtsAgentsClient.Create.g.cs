
#nullable enable

namespace Speechify
{
    public partial class SubpackageTtsSubpackageTtsAgentsClient
    {


        private static readonly global::Speechify.EndPointSecurityRequirement s_CreateSecurityRequirement0 =
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
        private static readonly global::Speechify.EndPointSecurityRequirement[] s_CreateSecurityRequirements =
            new global::Speechify.EndPointSecurityRequirement[]
            {                s_CreateSecurityRequirement0,
            };
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Speechify.TtsCreateAgentRequest request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Speechify.TtsCreateAgentRequest request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Agent<br/>
        /// Create a voice agent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.TtsAgent> CreateAsync(

            global::Speechify.TtsCreateAgentRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create Agent<br/>
        /// Create a voice agent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsAgent>> CreateAsResponseAsync(

            global::Speechify.TtsCreateAgentRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Speechify.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateSecurityRequirements,
                operationName: "CreateAsync");

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
                                path: "/v1/agents",
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
                PrepareCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/v1/agents\"",
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
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
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
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/v1/agents\"",
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
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/v1/agents\"",
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
                ProcessCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Speechify.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Speechify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/v1/agents\"",
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
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/v1/agents\"",
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
                            // The request was malformed or failed validation. The response body is the standard `Error` envelope; for validation failures `error.fields` enumerates the offending fields as a `path -> message` map (code = `validation_failed`). 
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Speechify.TtsError? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Speechify.TtsError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Speechify.TtsError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Speechify.ApiException<global::Speechify.TtsError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Authentication is missing or invalid. The request did not carry a recognised credential (Firebase ID token, API key, or worker JWT). 
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::Speechify.TtsError? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Speechify.TtsError.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Speechify.TtsError.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Speechify.ApiException<global::Speechify.TtsError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Speechify.TtsAgent.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsAgent>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Speechify.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
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
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Speechify.TtsAgent.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsAgent>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Speechify.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
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
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Create Agent<br/>
        /// Create a voice agent.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="slug">
        /// Optional. Server derives slug from name with a random suffix when omitted; if you supply your own, a collision returns 400 'slug already taken'.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="firstMessage">
        /// Greeting spoken verbatim at session start when included in the agent's flow graph.
        /// </param>
        /// <param name="language">
        /// ISO 639-1 code. Defaults to 'en' when omitted.
        /// </param>
        /// <param name="llmProvider">
        /// LLM backend. Leave empty (or omit both `llm_provider` and<br/>
        /// `llm_model`) to use the platform default (today: Speechify<br/>
        /// Kimi K2.6, resolved server-side at dispatch). When set,<br/>
        /// must be paired with a non-empty `llm_model`; mixing a<br/>
        /// populated provider with an empty model is rejected as a<br/>
        /// 400. `custom` additionally requires `llm_base_url`.
        /// </param>
        /// <param name="llmModel">
        /// Chat model slug. Leave empty to use the platform default.<br/>
        /// For `openai` / `speechify` the (provider, model) pair must<br/>
        /// be in the allowed table; for `custom` it is free-form.
        /// </param>
        /// <param name="llmBaseUrl">
        /// Custom OpenAI/vLLM-compatible endpoint base URL. Required<br/>
        /// when `llm_provider` is `custom`, rejected otherwise.
        /// </param>
        /// <param name="llmApiKey">
        /// Bearer key for the custom endpoint. Write-only - stored<br/>
        /// encrypted, never returned (GET exposes `llm_api_key_set`).<br/>
        /// Optional even for `custom` (keyless endpoints); rejected<br/>
        /// for any other provider.
        /// </param>
        /// <param name="llmExtraBody">
        /// Optional JSON object forwarded verbatim to the custom<br/>
        /// endpoint as the chat.completions `extra_body` (reasoning /<br/>
        /// sampling knobs). Valid only when `llm_provider` is<br/>
        /// `custom`.
        /// </param>
        /// <param name="voiceId">
        /// Voice slug from the VMS catalog (see GET /v1/voices). Required — the server rejects writes with an unknown or empty slug.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature in the range 0.0–1.0. Defaults to 0.5 when omitted.
        /// </param>
        /// <param name="widgetConfig">
        /// Customer-editable appearance + behaviour payload for the<br/>
        /// embedded `&lt;speechify-agent&gt;` pill: button text, avatar style,<br/>
        /// orb colours, terms-and-conditions markdown, transcript display.<br/>
        /// Every field is optional - empty fields fall back to the<br/>
        /// widget's compile-time defaults.
        /// </param>
        /// <param name="isPublic">
        /// Defaults to false when omitted.
        /// </param>
        /// <param name="allowedOrigins"></param>
        /// <param name="hostnameAllowlist">
        /// Optional per-agent hostname allowlist (see Agent schema).
        /// </param>
        /// <param name="memoryEnabled">
        /// Defaults to false when omitted.
        /// </param>
        /// <param name="memoryRetentionDays">
        /// Defaults to 90 when omitted.
        /// </param>
        /// <param name="webhookUrl">
        /// Customer-facing post-call webhook URL.
        /// </param>
        /// <param name="webhookSecret">
        /// HMAC-SHA256 secret seed. Write-only — never echoed back on<br/>
        /// reads; clients see `webhook_secret_set: true` instead.
        /// </param>
        /// <param name="amd">
        /// AMD routing config. Optional on create; omitted means AMD off. See AMDConfig schema.
        /// </param>
        /// <param name="saveAudioRecording">
        /// When set, opts the agent into per-conversation audio recording. Defaults to false when omitted.
        /// </param>
        /// <param name="navigatorMode">
        /// When set, opts the agent into IVR-tuned turn handling. Defaults to false when omitted.
        /// </param>
        /// <param name="ivrMemoryEnabled">
        /// When omitted, defaults to true. Set to false to opt-out of the IVR-memory cache lookup for this agent.
        /// </param>
        /// <param name="ttsSpeakingRate"></param>
        /// <param name="ttsPlaybackRate">
        /// Post-process pitch-preserving time-stretch on the synthesized<br/>
        /// audio. See the field on Agent for semantics.
        /// </param>
        /// <param name="responseDelaySeconds">
        /// Per-agent override for the worker's endpointing min_delay on<br/>
        /// the VAD path (seconds). See the field on Agent for semantics.<br/>
        /// Range 0.0..5.0; null means use the stack default.
        /// </param>
        /// <param name="inactivityTimeoutSeconds">
        /// Per-agent silence-tolerance override in seconds. Send `0`<br/>
        /// to clear the override and fall back to the platform<br/>
        /// default. Negative values are rejected.
        /// </param>
        /// <param name="backgroundNoisePreset">
        /// Pre-mixed ambient bed slug. Send empty string ("") to<br/>
        /// disable the bed, which also clears `background_noise_volume`.
        /// </param>
        /// <param name="backgroundNoiseVolume">
        /// Volume of the background-noise bed (0..1). Ignored when<br/>
        /// `background_noise_preset` is empty.
        /// </param>
        /// <param name="sttOverride">
        /// Optional non-default streaming-STT stack for this agent.<br/>
        /// Omit to use the worker's default stack (today: whisper-v3).<br/>
        /// See the Agent schema for the full option semantics.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.TtsAgent> CreateAsync(
            string name,
            string prompt,
            string firstMessage,
            string voiceId,
            string? slug = default,
            string? language = default,
            global::Speechify.TtsCreateAgentRequestLlmProvider? llmProvider = default,
            string? llmModel = default,
            string? llmBaseUrl = default,
            string? llmApiKey = default,
            object? llmExtraBody = default,
            double? temperature = default,
            global::Speechify.TtsWidgetConfig? widgetConfig = default,
            bool? isPublic = default,
            global::System.Collections.Generic.IList<string>? allowedOrigins = default,
            global::System.Collections.Generic.IList<string>? hostnameAllowlist = default,
            bool? memoryEnabled = default,
            int? memoryRetentionDays = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            global::Speechify.TtsAMDConfig? amd = default,
            bool? saveAudioRecording = default,
            bool? navigatorMode = default,
            bool? ivrMemoryEnabled = default,
            double? ttsSpeakingRate = default,
            double? ttsPlaybackRate = default,
            double? responseDelaySeconds = default,
            int? inactivityTimeoutSeconds = default,
            global::Speechify.TtsCreateAgentRequestBackgroundNoisePreset? backgroundNoisePreset = default,
            double? backgroundNoiseVolume = default,
            global::Speechify.TtsCreateAgentRequestSttOverride? sttOverride = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Speechify.TtsCreateAgentRequest
            {
                Name = name,
                Slug = slug,
                Prompt = prompt,
                FirstMessage = firstMessage,
                Language = language,
                LlmProvider = llmProvider,
                LlmModel = llmModel,
                LlmBaseUrl = llmBaseUrl,
                LlmApiKey = llmApiKey,
                LlmExtraBody = llmExtraBody,
                VoiceId = voiceId,
                Temperature = temperature,
                WidgetConfig = widgetConfig,
                IsPublic = isPublic,
                AllowedOrigins = allowedOrigins,
                HostnameAllowlist = hostnameAllowlist,
                MemoryEnabled = memoryEnabled,
                MemoryRetentionDays = memoryRetentionDays,
                WebhookUrl = webhookUrl,
                WebhookSecret = webhookSecret,
                Amd = amd,
                SaveAudioRecording = saveAudioRecording,
                NavigatorMode = navigatorMode,
                IvrMemoryEnabled = ivrMemoryEnabled,
                TtsSpeakingRate = ttsSpeakingRate,
                TtsPlaybackRate = ttsPlaybackRate,
                ResponseDelaySeconds = responseDelaySeconds,
                InactivityTimeoutSeconds = inactivityTimeoutSeconds,
                BackgroundNoisePreset = backgroundNoisePreset,
                BackgroundNoiseVolume = backgroundNoiseVolume,
                SttOverride = sttOverride,
            };

            return await CreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}