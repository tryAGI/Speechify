
#nullable enable

namespace Speechify
{
    public partial class RoutesClient
    {


        private static readonly global::Speechify.EndPointSecurityRequirement s_CreateRouteSecurityRequirement0 =
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
        private static readonly global::Speechify.EndPointSecurityRequirement[] s_CreateRouteSecurityRequirements =
            new global::Speechify.EndPointSecurityRequirement[]
            {                s_CreateRouteSecurityRequirement0,
            };
        partial void PrepareCreateRouteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string apiId,
            ref string? speechifyVersion,
            ref string? idempotencyKey,
            global::Speechify.CreateHostedAPIRouteRequest request);
        partial void PrepareCreateRouteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string apiId,
            string? speechifyVersion,
            string? idempotencyKey,
            global::Speechify.CreateHostedAPIRouteRequest request);
        partial void ProcessCreateRouteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRouteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Route<br/>
        /// Add a route: a method + path answered by a resolver. `store_query`,<br/>
        /// `store_document` and `store_aggregate` serve a store; `store_write`<br/>
        /// lands the POST body as a document (`write_mode` create / replace /<br/>
        /// merge; POST only, never on a public API, counted against<br/>
        /// `daily_write_cap`, deduplicated on `Idempotency-Key`); `run_latest`<br/>
        /// serves the newest structured output of a schedule trigger's runs;<br/>
        /// `run` starts a run through a webhook trigger per request (POST only,<br/>
        /// never on a public API) and waits up to `wait_seconds` before answering<br/>
        /// 202 with a handle to poll at `/_runs/{run_id}`; `file` serves one<br/>
        /// published file, or a whole published tree when the path ends in `*`<br/>
        /// (`/app/*` with `file_root` and `file_index`); `tool` calls one read<br/>
        /// operation of an `openapi` tool definition, or one tool of an `mcp`<br/>
        /// tool definition's server, in the API's project whose `approval` is<br/>
        /// null or `auto` (POST only, never on a public API, counted against<br/>
        /// `daily_read_cap`): the consumer's JSON body is the arguments and the<br/>
        /// connector's answer, after the tool's response mapping, is the<br/>
        /// response. An `mcp` route pins the tool's input schema as<br/>
        /// `resolver.input_schema` when it is written.<br/>
        /// Where-clause values and<br/>
        /// the document id may be `{{query.x}}`, `{{path.x}}` or `{{body.x}}`<br/>
        /// templates bound from the consumer's request, or `{{user.x}}` claims of<br/>
        /// the verified caller on a `user_token`, `workspace` or `owner` API; a<br/>
        /// clause whose template is absent is skipped. On those three modes a<br/>
        /// written document is stamped `user_identity` as the caller and only<br/>
        /// they can replace or merge it. Two bindings are refused at write time:<br/>
        /// `{{user.*}}` on an API that names no caller, and a clause on<br/>
        /// `user_identity` bound from a request template, which would let any<br/>
        /// caller read any user's rows.<br/>
        /// On an API with `mcp_enabled`, every enabled route except a `file`<br/>
        /// route is also an MCP tool. The tool's name comes from the route's<br/>
        /// `name`: every run of characters outside letters, digits, `_` and `-`<br/>
        /// becomes `_`, leading and trailing `_` are dropped, and the result is<br/>
        /// cut to 64 characters. A route with no name is listed under a name<br/>
        /// built from its method and path (`post_issues_open`), and a name two<br/>
        /// routes would share takes `_2`, `_3` in route order, so read the names<br/>
        /// from the face's `tools/list` rather than deriving them. The route's<br/>
        /// `description` is what the client's model reads to choose the tool,<br/>
        /// falling back to the operation's summary on a `tool` route. Name and<br/>
        /// describe a route for that reader.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.HostedAPIRoute> CreateRouteAsync(
            string apiId,

            global::Speechify.CreateHostedAPIRouteRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateRouteAsResponseAsync(
                apiId: apiId,

                request: request,
                speechifyVersion: speechifyVersion,
                idempotencyKey: idempotencyKey,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create Route<br/>
        /// Add a route: a method + path answered by a resolver. `store_query`,<br/>
        /// `store_document` and `store_aggregate` serve a store; `store_write`<br/>
        /// lands the POST body as a document (`write_mode` create / replace /<br/>
        /// merge; POST only, never on a public API, counted against<br/>
        /// `daily_write_cap`, deduplicated on `Idempotency-Key`); `run_latest`<br/>
        /// serves the newest structured output of a schedule trigger's runs;<br/>
        /// `run` starts a run through a webhook trigger per request (POST only,<br/>
        /// never on a public API) and waits up to `wait_seconds` before answering<br/>
        /// 202 with a handle to poll at `/_runs/{run_id}`; `file` serves one<br/>
        /// published file, or a whole published tree when the path ends in `*`<br/>
        /// (`/app/*` with `file_root` and `file_index`); `tool` calls one read<br/>
        /// operation of an `openapi` tool definition, or one tool of an `mcp`<br/>
        /// tool definition's server, in the API's project whose `approval` is<br/>
        /// null or `auto` (POST only, never on a public API, counted against<br/>
        /// `daily_read_cap`): the consumer's JSON body is the arguments and the<br/>
        /// connector's answer, after the tool's response mapping, is the<br/>
        /// response. An `mcp` route pins the tool's input schema as<br/>
        /// `resolver.input_schema` when it is written.<br/>
        /// Where-clause values and<br/>
        /// the document id may be `{{query.x}}`, `{{path.x}}` or `{{body.x}}`<br/>
        /// templates bound from the consumer's request, or `{{user.x}}` claims of<br/>
        /// the verified caller on a `user_token`, `workspace` or `owner` API; a<br/>
        /// clause whose template is absent is skipped. On those three modes a<br/>
        /// written document is stamped `user_identity` as the caller and only<br/>
        /// they can replace or merge it. Two bindings are refused at write time:<br/>
        /// `{{user.*}}` on an API that names no caller, and a clause on<br/>
        /// `user_identity` bound from a request template, which would let any<br/>
        /// caller read any user's rows.<br/>
        /// On an API with `mcp_enabled`, every enabled route except a `file`<br/>
        /// route is also an MCP tool. The tool's name comes from the route's<br/>
        /// `name`: every run of characters outside letters, digits, `_` and `-`<br/>
        /// becomes `_`, leading and trailing `_` are dropped, and the result is<br/>
        /// cut to 64 characters. A route with no name is listed under a name<br/>
        /// built from its method and path (`post_issues_open`), and a name two<br/>
        /// routes would share takes `_2`, `_3` in route order, so read the names<br/>
        /// from the face's `tools/list` rather than deriving them. The route's<br/>
        /// `description` is what the client's model reads to choose the tool,<br/>
        /// falling back to the operation's summary on a `tool` route. Name and<br/>
        /// describe a route for that reader.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.HostedAPIRoute>> CreateRouteAsResponseAsync(
            string apiId,

            global::Speechify.CreateHostedAPIRouteRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateRouteArguments(
                httpClient: HttpClient,
                apiId: ref apiId,
                speechifyVersion: ref speechifyVersion,
                idempotencyKey: ref idempotencyKey,
                request: request);


            var __authorizations = global::Speechify.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateRouteSecurityRequirements,
                operationName: "CreateRouteAsync");

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
                                path: $"/v1/apis/{apiId}/routes",
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
                PrepareCreateRouteRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    apiId: apiId!,
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
                                operationId: "CreateRoute",
                                methodName: "CreateRouteAsync",
                                pathTemplate: "$\"/v1/apis/{apiId}/routes\"",
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
                                operationId: "CreateRoute",
                                methodName: "CreateRouteAsync",
                                pathTemplate: "$\"/v1/apis/{apiId}/routes\"",
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
                                operationId: "CreateRoute",
                                methodName: "CreateRouteAsync",
                                pathTemplate: "$\"/v1/apis/{apiId}/routes\"",
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
                ProcessCreateRouteResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Speechify.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Speechify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateRoute",
                                methodName: "CreateRouteAsync",
                                pathTemplate: "$\"/v1/apis/{apiId}/routes\"",
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
                                operationId: "CreateRoute",
                                methodName: "CreateRouteAsync",
                                pathTemplate: "$\"/v1/apis/{apiId}/routes\"",
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
                            // The request conflicts with the current resource state - e.g. duplicate, optimistic-concurrency mismatch, or last-owner guard.
                            if ((int)__response.StatusCode == 409)
                            {
                                string? __content_409 = null;
                                global::System.Exception? __exception_409 = null;
                                global::Speechify.Error? __value_409 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_409 = global::Speechify.Error.FromJson(__content_409, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_409 = global::Speechify.Error.FromJson(__content_409, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_409 = __ex;
                                }


                                throw global::Speechify.ApiException<global::Speechify.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_409,
                                    responseBody: __content_409,
                                    responseObject: __value_409,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Rate limit or concurrency limit exceeded. `error.code` says which ceiling, and they need different responses: `rate_limited` is the request-rate budget (slow down), `concurrency_limit_reached` is a workspace-wide concurrency ceiling (fewer at once, or raise it), and `conversation_turn_in_progress` is contention over one named conversation (keep one message in flight on it). Every 429 carries `Retry-After` and the request-rate budget headers; the active-call cap also carries `RateLimit-Remaining-Calls: 0`.
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
                            // An unexpected server-side error occurred. Safe to retry with exponential backoff for idempotent requests.
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::Speechify.Error? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::Speechify.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::Speechify.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Speechify.ApiException<global::Speechify.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
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
                                ProcessCreateRouteResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Speechify.HostedAPIRoute.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Speechify.AutoSDKHttpResponse<global::Speechify.HostedAPIRoute>(
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

                                    var __value = await global::Speechify.HostedAPIRoute.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Speechify.AutoSDKHttpResponse<global::Speechify.HostedAPIRoute>(
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
        /// Create Route<br/>
        /// Add a route: a method + path answered by a resolver. `store_query`,<br/>
        /// `store_document` and `store_aggregate` serve a store; `store_write`<br/>
        /// lands the POST body as a document (`write_mode` create / replace /<br/>
        /// merge; POST only, never on a public API, counted against<br/>
        /// `daily_write_cap`, deduplicated on `Idempotency-Key`); `run_latest`<br/>
        /// serves the newest structured output of a schedule trigger's runs;<br/>
        /// `run` starts a run through a webhook trigger per request (POST only,<br/>
        /// never on a public API) and waits up to `wait_seconds` before answering<br/>
        /// 202 with a handle to poll at `/_runs/{run_id}`; `file` serves one<br/>
        /// published file, or a whole published tree when the path ends in `*`<br/>
        /// (`/app/*` with `file_root` and `file_index`); `tool` calls one read<br/>
        /// operation of an `openapi` tool definition, or one tool of an `mcp`<br/>
        /// tool definition's server, in the API's project whose `approval` is<br/>
        /// null or `auto` (POST only, never on a public API, counted against<br/>
        /// `daily_read_cap`): the consumer's JSON body is the arguments and the<br/>
        /// connector's answer, after the tool's response mapping, is the<br/>
        /// response. An `mcp` route pins the tool's input schema as<br/>
        /// `resolver.input_schema` when it is written.<br/>
        /// Where-clause values and<br/>
        /// the document id may be `{{query.x}}`, `{{path.x}}` or `{{body.x}}`<br/>
        /// templates bound from the consumer's request, or `{{user.x}}` claims of<br/>
        /// the verified caller on a `user_token`, `workspace` or `owner` API; a<br/>
        /// clause whose template is absent is skipped. On those three modes a<br/>
        /// written document is stamped `user_identity` as the caller and only<br/>
        /// they can replace or merge it. Two bindings are refused at write time:<br/>
        /// `{{user.*}}` on an API that names no caller, and a clause on<br/>
        /// `user_identity` bound from a request template, which would let any<br/>
        /// caller read any user's rows.<br/>
        /// On an API with `mcp_enabled`, every enabled route except a `file`<br/>
        /// route is also an MCP tool. The tool's name comes from the route's<br/>
        /// `name`: every run of characters outside letters, digits, `_` and `-`<br/>
        /// becomes `_`, leading and trailing `_` are dropped, and the result is<br/>
        /// cut to 64 characters. A route with no name is listed under a name<br/>
        /// built from its method and path (`post_issues_open`), and a name two<br/>
        /// routes would share takes `_2`, `_3` in route order, so read the names<br/>
        /// from the face's `tools/list` rather than deriving them. The route's<br/>
        /// `description` is what the client's model reads to choose the tool,<br/>
        /// falling back to the operation's summary on a `tool` route. Name and<br/>
        /// describe a route for that reader.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="method"></param>
        /// <param name="path">
        /// Lowercase segments of letters, digits, `. _ -` or a `{param}`; `/openapi.json`, `/_runs` and `/mcp` are reserved.
        /// </param>
        /// <param name="name">
        /// The route's name, 1-128 letters, digits, spaces, `.`, `_` or `-`.<br/>
        /// On an API with `mcp_enabled` the MCP tool's name comes from it:<br/>
        /// each run of other characters (a space included) becomes `_`,<br/>
        /// leading and trailing `_` are dropped, and the result is cut to 64<br/>
        /// characters. A route with no name is listed under a name built from<br/>
        /// its method and path, and a name two routes would share takes `_2`,<br/>
        /// `_3` in route order; the face's `tools/list` is the authority. Pick<br/>
        /// a verb-first name a model can choose by.
        /// </param>
        /// <param name="description">
        /// What the route does. On an API with `mcp_enabled` it is the MCP<br/>
        /// tool description a client's model reads to choose the tool, so say<br/>
        /// what it returns and when to call it; a `tool` route with none falls<br/>
        /// back to the operation's summary.
        /// </param>
        /// <param name="resolver">
        /// What answers a route. `type` selects the fields that apply:<br/>
        /// `store_query` (store_id, collection, where, order_by, limit),<br/>
        /// `store_document` (store_id, collection, document_id),<br/>
        /// `store_aggregate` (store_id, collection, where, group_by, metrics:<br/>
        /// a summary in one request, from the same implementation as the<br/>
        /// collection's `aggregate` operation),<br/>
        /// `store_write` (store_id, collection, write_mode, document_id: the<br/>
        /// request body lands as a document, the fast path past a run for the<br/>
        /// one thing a read resolver cannot do; POST only, never on a public<br/>
        /// API, and on an API that names its caller the document is that<br/>
        /// person's),<br/>
        /// `run_latest` (trigger_id of a schedule trigger),<br/>
        /// `run` (trigger_id of a webhook trigger, wait_seconds),<br/>
        /// `file` (file_path of one published file; or, on a route whose path<br/>
        /// ends in `*`, file_root and file_index for a whole published tree),<br/>
        /// `tool` (tool_id of an `openapi` or `mcp` tool definition and the<br/>
        /// `operation` on it, an openapi operation's id or one of the MCP<br/>
        /// server's tools by name: the POST body is the arguments, held to their<br/>
        /// schema, and the connector's answer after the tool's response mapping<br/>
        /// is the response. An openapi vendor's JSON comes back as it came, or<br/>
        /// `{"text": ...}` when it answered text; an MCP tool answers its<br/>
        /// structured content, its text when that text is JSON, `{"text": ...}`<br/>
        /// for plain text, or `{"content": [...]}` with every block as the server<br/>
        /// sent it when one is not text. For an `mcp` tool the route write lists<br/>
        /// the server's tools and pins the chosen tool's input schema on the<br/>
        /// route as `input_schema`, so the MCP face and every call use the pin<br/>
        /// and an upstream change reaches no consumer until the route is written<br/>
        /// again. An operation whose effective class is `read`, on a tool whose<br/>
        /// `approval` is null or `auto`, may be served on any API but a public<br/>
        /// one. An operation that is not a read is served only on a route with<br/>
        /// `allow_write: true`, on an API whose `auth_mode` names a person<br/>
        /// (`owner`, `workspace` or `user_token`), and still only with an<br/>
        /// `approval` of null or `auto`: a write through a route acts for the<br/>
        /// member or end user calling, who is sent to the connector as<br/>
        /// `Speechify-User-Identity`, a service account is refused, every write<br/>
        /// counts against `daily_write_cap` (429 `route_write_limit_reached`) and<br/>
        /// claims the caller's `Idempotency-Key` so a retry replays the first<br/>
        /// answer. A route write that breaks any of this is refused with 400<br/>
        /// `validation_failed` on `resolver.tool_id`, `resolver.operation` or<br/>
        /// `resolver.allow_write`, as is an MCP server that cannot be listed.<br/>
        /// Because a definition can change after its route is written, every call<br/>
        /// re-checks it: an operation no longer classified `read` on a route not<br/>
        /// switched to writes, or a tool whose `approval` is no longer null or<br/>
        /// `auto`, answers 403 `route_tool_not_readable`; a tool<br/>
        /// deleted, moved to another project, or without the operation (an MCP<br/>
        /// server that no longer lists the tool) answers 409<br/>
        /// `route_tool_unavailable`, which no<br/>
        /// retry clears until the route or the tool is fixed, and names which<br/>
        /// of the three happened in `error.details.reason` (`tool_deleted`,<br/>
        /// `tool_moved`, `operation_removed`). Both refusals carry what the API's<br/>
        /// owner changes to fix the route in `error.details.fix`. Arguments that do<br/>
        /// not fit the schema answer 400 `validation_failed`; the definition's<br/>
        /// `max_requests_per_minute` and the vendor's own throttle both answer 429<br/>
        /// `route_upstream_rate_limited` with `Retry-After`; a vendor error<br/>
        /// answers 502 `route_upstream_error` with the vendor's status in<br/>
        /// `error.details.upstream_status`, an MCP tool that reports an error<br/>
        /// answers it with the tool's own message in `error.details.tool_error`,<br/>
        /// and an unreachable vendor or a credential that no longer resolves<br/>
        /// answers 502 `route_upstream_error` without either).
        /// </param>
        /// <param name="responseSchema"></param>
        /// <param name="cacheTtlSeconds"></param>
        /// <param name="enabled">
        /// Enabled when omitted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.HostedAPIRoute> CreateRouteAsync(
            string apiId,
            global::Speechify.CreateHostedApiRouteRequestMethod method,
            string path,
            global::Speechify.HostedAPIResolver resolver,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? name = default,
            string? description = default,
            object? responseSchema = default,
            int? cacheTtlSeconds = default,
            bool? enabled = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Speechify.CreateHostedAPIRouteRequest
            {
                Method = method,
                Path = path,
                Name = name,
                Description = description,
                Resolver = resolver,
                ResponseSchema = responseSchema,
                CacheTtlSeconds = cacheTtlSeconds,
                Enabled = enabled,
            };

            return await CreateRouteAsync(
                apiId: apiId,
                speechifyVersion: speechifyVersion,
                idempotencyKey: idempotencyKey,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}