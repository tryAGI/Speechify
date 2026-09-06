
#nullable enable

namespace Speechify
{
    public partial class RunsClient
    {


        private static readonly global::Speechify.EndPointSecurityRequirement s_CreateRunSecurityRequirement0 =
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
        private static readonly global::Speechify.EndPointSecurityRequirement[] s_CreateRunSecurityRequirements =
            new global::Speechify.EndPointSecurityRequirement[]
            {                s_CreateRunSecurityRequirement0,
            };
        partial void PrepareCreateRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string agentId,
            ref string? speechifyVersion,
            ref string? idempotencyKey,
            global::Speechify.CreateAgentRunRequest request);
        partial void PrepareCreateRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string agentId,
            string? speechifyVersion,
            string? idempotencyKey,
            global::Speechify.CreateAgentRunRequest request);
        partial void ProcessCreateRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRunResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Agent Run<br/>
        /// Enqueue a **durable async run**: hand the agent an instruction and get a<br/>
        /// run handle back immediately (`202`, status `queued`). The run executes on<br/>
        /// its own - poll it with `getRun` or receive a completion webhook - and it<br/>
        /// survives a deploy (it is backed by a durable job, not a request socket or<br/>
        /// a short-lived store). This is the managed-agent-platform primitive: start<br/>
        /// work, walk away, come back for the result.<br/>
        /// Idempotent via `Idempotency-Key`: a retry replays the first run instead of<br/>
        /// starting a duplicate (the `run_id` is the idempotency handle).<br/>
        /// ## Publish the agent first<br/>
        /// **Every workspace granted `durable_runs_access` is publish-gated**, so<br/>
        /// this is the first thing a new integration hits. Call<br/>
        /// `POST /v1/agents/{agent_id}/publish` before the first run, and again<br/>
        /// after any change to the agent's configuration: the gate is keyed to a<br/>
        /// fingerprint of that configuration, so an edited agent stops running<br/>
        /// until it is republished. Until it passes, this endpoint returns<br/>
        /// `422 agent_publish_gate_required`.<br/>
        /// Refused with `422 tool_transport_unsupported` when one of the agent's<br/>
        /// attached MCP tools uses the legacy `sse` transport, which durable runs<br/>
        /// cannot execute; the message names the tool. Switch it to<br/>
        /// `http_streamable` or detach it, then retry.<br/>
        /// Returns `429 concurrency_limit_reached` when the workspace already has<br/>
        /// 200 runs queued or running. Runs execute on a shared queue, so the<br/>
        /// ceiling is what keeps one workspace's backlog from delaying everyone<br/>
        /// else's next run; it is not a plan limit. `Retry-After` is a hint at the<br/>
        /// scale runs take, not a promise - what actually frees a slot is one of<br/>
        /// your own runs ending, so follow the ones you have with the event stream<br/>
        /// and start the next when one does.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.AgentRun> CreateRunAsync(
            string agentId,

            global::Speechify.CreateAgentRunRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateRunAsResponseAsync(
                agentId: agentId,

                request: request,
                speechifyVersion: speechifyVersion,
                idempotencyKey: idempotencyKey,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create Agent Run<br/>
        /// Enqueue a **durable async run**: hand the agent an instruction and get a<br/>
        /// run handle back immediately (`202`, status `queued`). The run executes on<br/>
        /// its own - poll it with `getRun` or receive a completion webhook - and it<br/>
        /// survives a deploy (it is backed by a durable job, not a request socket or<br/>
        /// a short-lived store). This is the managed-agent-platform primitive: start<br/>
        /// work, walk away, come back for the result.<br/>
        /// Idempotent via `Idempotency-Key`: a retry replays the first run instead of<br/>
        /// starting a duplicate (the `run_id` is the idempotency handle).<br/>
        /// ## Publish the agent first<br/>
        /// **Every workspace granted `durable_runs_access` is publish-gated**, so<br/>
        /// this is the first thing a new integration hits. Call<br/>
        /// `POST /v1/agents/{agent_id}/publish` before the first run, and again<br/>
        /// after any change to the agent's configuration: the gate is keyed to a<br/>
        /// fingerprint of that configuration, so an edited agent stops running<br/>
        /// until it is republished. Until it passes, this endpoint returns<br/>
        /// `422 agent_publish_gate_required`.<br/>
        /// Refused with `422 tool_transport_unsupported` when one of the agent's<br/>
        /// attached MCP tools uses the legacy `sse` transport, which durable runs<br/>
        /// cannot execute; the message names the tool. Switch it to<br/>
        /// `http_streamable` or detach it, then retry.<br/>
        /// Returns `429 concurrency_limit_reached` when the workspace already has<br/>
        /// 200 runs queued or running. Runs execute on a shared queue, so the<br/>
        /// ceiling is what keeps one workspace's backlog from delaying everyone<br/>
        /// else's next run; it is not a plan limit. `Retry-After` is a hint at the<br/>
        /// scale runs take, not a promise - what actually frees a slot is one of<br/>
        /// your own runs ending, so follow the ones you have with the event stream<br/>
        /// and start the next when one does.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentRun>> CreateRunAsResponseAsync(
            string agentId,

            global::Speechify.CreateAgentRunRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateRunArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                speechifyVersion: ref speechifyVersion,
                idempotencyKey: ref idempotencyKey,
                request: request);


            var __authorizations = global::Speechify.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateRunSecurityRequirements,
                operationName: "CreateRunAsync");

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
                                path: $"/v1/agents/{agentId}/runs",
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
            var __idempotencyKey = global::System.String.IsNullOrWhiteSpace(idempotencyKey)
                ? CreateIdempotencyKey()
                : idempotencyKey;
            __httpRequest.Headers.TryAddWithoutValidation("Idempotency-Key", __idempotencyKey);

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
                PrepareCreateRunRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    agentId: agentId!,
                    speechifyVersion: speechifyVersion,
                    idempotencyKey: idempotencyKey,
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
                                operationId: "CreateRun",
                                methodName: "CreateRunAsync",
                                pathTemplate: "$\"/v1/agents/{agentId}/runs\"",
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
                                operationId: "CreateRun",
                                methodName: "CreateRunAsync",
                                pathTemplate: "$\"/v1/agents/{agentId}/runs\"",
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
                                operationId: "CreateRun",
                                methodName: "CreateRunAsync",
                                pathTemplate: "$\"/v1/agents/{agentId}/runs\"",
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
                ProcessCreateRunResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Speechify.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Speechify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateRun",
                                methodName: "CreateRunAsync",
                                pathTemplate: "$\"/v1/agents/{agentId}/runs\"",
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
                                operationId: "CreateRun",
                                methodName: "CreateRunAsync",
                                pathTemplate: "$\"/v1/agents/{agentId}/runs\"",
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
                                global::Speechify.Error? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Speechify.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Speechify.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Speechify.ApiException<global::Speechify.Error>.Create(
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
                            // Authentication is missing or invalid. The request did not carry a recognised credential (console session token, API key, or worker JWT).
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::Speechify.Error? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Speechify.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Speechify.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Speechify.ApiException<global::Speechify.Error>.Create(
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
                            // The workspace has insufficient credits, or the request needs a plan tier the workspace is not on (e.g. voice cloning). Distinct from `Forbidden` so SDK consumers can drive upgrade UX.
                            if ((int)__response.StatusCode == 402)
                            {
                                string? __content_402 = null;
                                global::System.Exception? __exception_402 = null;
                                global::Speechify.Error? __value_402 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_402 = global::Speechify.Error.FromJson(__content_402, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_402 = global::Speechify.Error.FromJson(__content_402, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_402 = __ex;
                                }


                                throw global::Speechify.ApiException<global::Speechify.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_402,
                                    responseBody: __content_402,
                                    responseObject: __value_402,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The referenced resource does not exist or is not visible to the caller's workspace.
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::Speechify.Error? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Speechify.Error.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::Speechify.Error.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Speechify.ApiException<global::Speechify.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The request was well-formed but semantically rejected - typically a referential integrity violation (e.g. flow node references an audio asset in another workspace) or a state machine refusal.
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Speechify.Error? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Speechify.Error.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Speechify.Error.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Speechify.ApiException<global::Speechify.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Rate limit or concurrency limit exceeded. `error.code` distinguishes request-rate limiting (`rate_limited`) from concurrency exhaustion (`concurrency_limit_reached`). Carries `Retry-After` and the request-rate budget headers; a concurrency-exhaustion 429 also carries `RateLimit-Remaining-Calls: 0`.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::Speechify.Error? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Speechify.Error.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Speechify.Error.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::Speechify.ApiException<global::Speechify.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
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
                                ProcessCreateRunResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Speechify.AgentRun.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentRun>(
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

                                    var __value = await global::Speechify.AgentRun.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentRun>(
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
        /// Create Agent Run<br/>
        /// Enqueue a **durable async run**: hand the agent an instruction and get a<br/>
        /// run handle back immediately (`202`, status `queued`). The run executes on<br/>
        /// its own - poll it with `getRun` or receive a completion webhook - and it<br/>
        /// survives a deploy (it is backed by a durable job, not a request socket or<br/>
        /// a short-lived store). This is the managed-agent-platform primitive: start<br/>
        /// work, walk away, come back for the result.<br/>
        /// Idempotent via `Idempotency-Key`: a retry replays the first run instead of<br/>
        /// starting a duplicate (the `run_id` is the idempotency handle).<br/>
        /// ## Publish the agent first<br/>
        /// **Every workspace granted `durable_runs_access` is publish-gated**, so<br/>
        /// this is the first thing a new integration hits. Call<br/>
        /// `POST /v1/agents/{agent_id}/publish` before the first run, and again<br/>
        /// after any change to the agent's configuration: the gate is keyed to a<br/>
        /// fingerprint of that configuration, so an edited agent stops running<br/>
        /// until it is republished. Until it passes, this endpoint returns<br/>
        /// `422 agent_publish_gate_required`.<br/>
        /// Refused with `422 tool_transport_unsupported` when one of the agent's<br/>
        /// attached MCP tools uses the legacy `sse` transport, which durable runs<br/>
        /// cannot execute; the message names the tool. Switch it to<br/>
        /// `http_streamable` or detach it, then retry.<br/>
        /// Returns `429 concurrency_limit_reached` when the workspace already has<br/>
        /// 200 runs queued or running. Runs execute on a shared queue, so the<br/>
        /// ceiling is what keeps one workspace's backlog from delaying everyone<br/>
        /// else's next run; it is not a plan limit. `Retry-After` is a hint at the<br/>
        /// scale runs take, not a promise - what actually frees a slot is one of<br/>
        /// your own runs ending, so follow the ones you have with the event stream<br/>
        /// and start the next when one does.<br/>
        /// This endpoint is in beta: it is available to workspaces granted<br/>
        /// `durable_runs_access`, and every other workspace receives<br/>
        /// `402 durable_runs_not_in_plan`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="instruction">
        /// The task or goal to give the agent. The agent runs its brain against this over a short internal conversation and returns its result. The server's limit is 8000 **bytes**, so a mostly non-ASCII instruction reaches it before 8000 characters.
        /// </param>
        /// <param name="variables">
        /// Per-run values that seed the agent's flow variables (override its<br/>
        /// stored defaults). The agent's prompt renders against the result<br/>
        /// before every step: a declared variable the run does not supply<br/>
        /// takes its default, one the run supplies takes the run's value, and<br/>
        /// a placeholder nothing supplies renders empty. The reserved<br/>
        /// `system__caller_id`, `system__agent_id`, `system__language` and<br/>
        /// `system__memory` keys are bound by the platform. The `system__*` namespace and the legacy `memory`<br/>
        /// alias belong to the platform and are rejected with a 400 naming<br/>
        /// `variables`, the same rule a conversation applies: the run binds its<br/>
        /// own values there, including `system__caller_id` for the person it<br/>
        /// acts for.
        /// </param>
        /// <param name="maxTurns">
        /// Upper bound on the run's internal turn budget - one turn is one<br/>
        /// plan-act-observe cycle, so a run that calls three tools uses at<br/>
        /// least four. Defaults to 8 when omitted.<br/>
        /// **Clamped to the workspace's per-run ceiling** (5 on Free, 10<br/>
        /// on Starter, 20 on Pro, 30 on Scale, 50 on Enterprise; per-workspace<br/>
        /// overrides apply): the run's `input.max_turns` echoes the budget it<br/>
        /// actually got, and `GET /v1/workspaces/current/entitlements`<br/>
        /// (`max_run_turns`) reports the ceiling up front, so plan against<br/>
        /// that rather than the value you sent. An omitted `max_turns` takes<br/>
        /// the default, clamped to the ceiling. On Free the<br/>
        /// ceiling is *below* the default, so omitting this field there yields<br/>
        /// 5, not 8.<br/>
        /// A run that exhausts its budget settles `succeeded` with<br/>
        /// `incomplete_reason: max_turns_exhausted` and whatever answer it had<br/>
        /// reached. Schema repairs count against this budget too - see<br/>
        /// `output_schema`.
        /// </param>
        /// <param name="userIdentity">
        /// The person this run acts for, in your own vocabulary - the same<br/>
        /// field a conversation and a widget session take, so one workspace<br/>
        /// never has two answers to who a person is. The agent opens the run<br/>
        /// knowing what it has already learned about them, and what a run<br/>
        /// that succeeds learns from its instruction and its reply is<br/>
        /// written back under this value, exactly as a call writes memory.<br/>
        /// Omit it to run the agent for nobody in particular, which is how a<br/>
        /// run behaves with no memory of anyone and learns nothing. Must not begin with `user_`,<br/>
        /// `embed_` or `anon_`, which name identities the platform derives.<br/>
        /// Every tool the run calls is told this value: a webhook receives<br/>
        /// it as `user_identity` inside the signed body, an MCP server as<br/>
        /// the `Speechify-User-Identity` header, and it renders in a tool's<br/>
        /// templated URL or headers as `{{system__caller_id}}`. A connector<br/>
        /// you wrote can therefore look up that person's own third-party<br/>
        /// token, which is how you integrate a system Speechify holds no<br/>
        /// credentials for.
        /// </param>
        /// <param name="outputSchema">
        /// Optional JSON Schema (2020-12) the run's final answer must satisfy.<br/>
        /// When set, the agent answers with a JSON object, the platform<br/>
        /// validates it, and the conforming object is returned as<br/>
        /// `output.data`.<br/>
        /// The top level must be `type: object` - an array-typed or scalar<br/>
        /// schema is refused at create with `400`. At most 16 KiB.<br/>
        /// On a mismatch the platform re-asks the agent, feeding back up to 8<br/>
        /// of the violations. **At most two repair attempts, and each one<br/>
        /// spends a turn from `max_turns`** - so a schema-constrained run on a<br/>
        /// 5-turn ceiling has little room left for tool calls. Each attempt is<br/>
        /// journaled as an `observation` step whose `tool` is the reserved<br/>
        /// name `output_schema`, which a timeline renderer should expect<br/>
        /// alongside real tool names.<br/>
        /// A run that never produces a conforming object settles `succeeded`<br/>
        /// with `incomplete_reason: output_schema_violation` and no<br/>
        /// `output.data` - its prose answer is still on `output.reply`. The<br/>
        /// platform never returns an object the schema refused.
        /// </param>
        /// <param name="metadata">
        /// Up to 16 arbitrary key/value pairs echoed back on the run. Your own correlation ids belong here - the platform never reads them.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.AgentRun> CreateRunAsync(
            string agentId,
            string instruction,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            object? variables = default,
            int? maxTurns = default,
            string? userIdentity = default,
            object? outputSchema = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Speechify.CreateAgentRunRequest
            {
                Instruction = instruction,
                Variables = variables,
                MaxTurns = maxTurns,
                UserIdentity = userIdentity,
                OutputSchema = outputSchema,
                Metadata = metadata,
            };

            return await CreateRunAsync(
                agentId: agentId,
                speechifyVersion: speechifyVersion,
                idempotencyKey: idempotencyKey,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}