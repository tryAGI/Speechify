
#nullable enable

namespace Speechify
{
    public partial class ToolDefinitionsClient
    {


        private static readonly global::Speechify.EndPointSecurityRequirement s_TestOpenAPICallSecurityRequirement0 =
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
        private static readonly global::Speechify.EndPointSecurityRequirement[] s_TestOpenAPICallSecurityRequirements =
            new global::Speechify.EndPointSecurityRequirement[]
            {                s_TestOpenAPICallSecurityRequirement0,
            };
        partial void PrepareTestOpenAPICallArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? speechifyVersion,
            global::Speechify.TestOpenAPICallRequest request);
        partial void PrepareTestOpenAPICallRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? speechifyVersion,
            global::Speechify.TestOpenAPICallRequest request);
        partial void ProcessTestOpenAPICallResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTestOpenAPICallResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Test OpenAPI Operation<br/>
        /// Call one operation of an `openapi` tool config that is not saved yet,<br/>
        /// through the same path a run and a live session execute it, and answer<br/>
        /// what the agent would read. Use it after<br/>
        /// `POST /v1/agents/tool-definitions/import-openapi` and before<br/>
        /// `POST /v1/agents/tool-definitions`, to check that the arguments reach<br/>
        /// the vendor and that a `pick` / `derive` / `max_items` mapping keeps<br/>
        /// what the agent needs.<br/>
        /// Read the result in this order. `error` is set only when no call was<br/>
        /// made: a config the create endpoint would refuse, an operation the<br/>
        /// config does not have, a write operation, or a credential that does not<br/>
        /// resolve or cannot mint a token. Otherwise `outcome` says how the call<br/>
        /// ended, and only `ok` is a preview that worked. On `ok` with a JSON answer, `raw` is the<br/>
        /// vendor's answer and `mapped` is the same answer after the operation's<br/>
        /// `response` mapping, so one call shows both sides; `observation` is<br/>
        /// what the agent reads, trimmed to its observation window.<br/>
        /// Only a read operation runs (declared `read`, or a GET or HEAD that<br/>
        /// declares no class): nobody approves a test call, so a write is<br/>
        /// answered with `error` set and never reaches the vendor. Nothing is<br/>
        /// persisted and the tool's own `max_requests_per_minute` does not apply,<br/>
        /// but the call does reach the vendor and counts against the vendor's<br/>
        /// own limits. It acts with a workspace credential, so it needs the<br/>
        /// `content.manage` permission a tool create does.<br/>
        /// A malformed request is a 400: a missing `operation`, `arguments` that<br/>
        /// are not an object, or a field this endpoint does not define, which is<br/>
        /// refused naming every unknown field.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.TestOpenAPICallResult> TestOpenAPICallAsync(

            global::Speechify.TestOpenAPICallRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await TestOpenAPICallAsResponseAsync(

                request: request,
                speechifyVersion: speechifyVersion,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Test OpenAPI Operation<br/>
        /// Call one operation of an `openapi` tool config that is not saved yet,<br/>
        /// through the same path a run and a live session execute it, and answer<br/>
        /// what the agent would read. Use it after<br/>
        /// `POST /v1/agents/tool-definitions/import-openapi` and before<br/>
        /// `POST /v1/agents/tool-definitions`, to check that the arguments reach<br/>
        /// the vendor and that a `pick` / `derive` / `max_items` mapping keeps<br/>
        /// what the agent needs.<br/>
        /// Read the result in this order. `error` is set only when no call was<br/>
        /// made: a config the create endpoint would refuse, an operation the<br/>
        /// config does not have, a write operation, or a credential that does not<br/>
        /// resolve or cannot mint a token. Otherwise `outcome` says how the call<br/>
        /// ended, and only `ok` is a preview that worked. On `ok` with a JSON answer, `raw` is the<br/>
        /// vendor's answer and `mapped` is the same answer after the operation's<br/>
        /// `response` mapping, so one call shows both sides; `observation` is<br/>
        /// what the agent reads, trimmed to its observation window.<br/>
        /// Only a read operation runs (declared `read`, or a GET or HEAD that<br/>
        /// declares no class): nobody approves a test call, so a write is<br/>
        /// answered with `error` set and never reaches the vendor. Nothing is<br/>
        /// persisted and the tool's own `max_requests_per_minute` does not apply,<br/>
        /// but the call does reach the vendor and counts against the vendor's<br/>
        /// own limits. It acts with a workspace credential, so it needs the<br/>
        /// `content.manage` permission a tool create does.<br/>
        /// A malformed request is a 400: a missing `operation`, `arguments` that<br/>
        /// are not an object, or a field this endpoint does not define, which is<br/>
        /// refused naming every unknown field.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TestOpenAPICallResult>> TestOpenAPICallAsResponseAsync(

            global::Speechify.TestOpenAPICallRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTestOpenAPICallArguments(
                httpClient: HttpClient,
                speechifyVersion: ref speechifyVersion,
                request: request);


            var __authorizations = global::Speechify.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TestOpenAPICallSecurityRequirements,
                operationName: "TestOpenAPICallAsync");

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
                                path: "/v1/agents/tool-definitions/test-openapi-call",
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
                PrepareTestOpenAPICallRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    speechifyVersion: speechifyVersion,
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
                                operationId: "TestOpenAPICall",
                                methodName: "TestOpenAPICallAsync",
                                pathTemplate: "\"/v1/agents/tool-definitions/test-openapi-call\"",
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
                                operationId: "TestOpenAPICall",
                                methodName: "TestOpenAPICallAsync",
                                pathTemplate: "\"/v1/agents/tool-definitions/test-openapi-call\"",
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
                                operationId: "TestOpenAPICall",
                                methodName: "TestOpenAPICallAsync",
                                pathTemplate: "\"/v1/agents/tool-definitions/test-openapi-call\"",
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
                ProcessTestOpenAPICallResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Speechify.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Speechify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TestOpenAPICall",
                                methodName: "TestOpenAPICallAsync",
                                pathTemplate: "\"/v1/agents/tool-definitions/test-openapi-call\"",
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
                                operationId: "TestOpenAPICall",
                                methodName: "TestOpenAPICallAsync",
                                pathTemplate: "\"/v1/agents/tool-definitions/test-openapi-call\"",
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
                            // The credential authenticated, but is not authorised for this resource - typically a workspace-role gate (owner / admin required) or a cross-tenant access attempt.
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::Speechify.Error? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Speechify.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::Speechify.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Speechify.ApiException<global::Speechify.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // A downstream dependency is degraded or the endpoint is intentionally disabled (e.g. phone-number purchase before ops setup).
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                global::Speechify.Error? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = global::Speechify.Error.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = global::Speechify.Error.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::Speechify.ApiException<global::Speechify.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_503,
                                    responseBody: __content_503,
                                    responseObject: __value_503,
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
                                ProcessTestOpenAPICallResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Speechify.TestOpenAPICallResult.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Speechify.AutoSDKHttpResponse<global::Speechify.TestOpenAPICallResult>(
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

                                    var __value = await global::Speechify.TestOpenAPICallResult.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Speechify.AutoSDKHttpResponse<global::Speechify.TestOpenAPICallResult>(
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
        /// Test OpenAPI Operation<br/>
        /// Call one operation of an `openapi` tool config that is not saved yet,<br/>
        /// through the same path a run and a live session execute it, and answer<br/>
        /// what the agent would read. Use it after<br/>
        /// `POST /v1/agents/tool-definitions/import-openapi` and before<br/>
        /// `POST /v1/agents/tool-definitions`, to check that the arguments reach<br/>
        /// the vendor and that a `pick` / `derive` / `max_items` mapping keeps<br/>
        /// what the agent needs.<br/>
        /// Read the result in this order. `error` is set only when no call was<br/>
        /// made: a config the create endpoint would refuse, an operation the<br/>
        /// config does not have, a write operation, or a credential that does not<br/>
        /// resolve or cannot mint a token. Otherwise `outcome` says how the call<br/>
        /// ended, and only `ok` is a preview that worked. On `ok` with a JSON answer, `raw` is the<br/>
        /// vendor's answer and `mapped` is the same answer after the operation's<br/>
        /// `response` mapping, so one call shows both sides; `observation` is<br/>
        /// what the agent reads, trimmed to its observation window.<br/>
        /// Only a read operation runs (declared `read`, or a GET or HEAD that<br/>
        /// declares no class): nobody approves a test call, so a write is<br/>
        /// answered with `error` set and never reaches the vendor. Nothing is<br/>
        /// persisted and the tool's own `max_requests_per_minute` does not apply,<br/>
        /// but the call does reach the vendor and counts against the vendor's<br/>
        /// own limits. It acts with a workspace credential, so it needs the<br/>
        /// `content.manage` permission a tool create does.<br/>
        /// A malformed request is a 400: a missing `operation`, `arguments` that<br/>
        /// are not an object, or a field this endpoint does not define, which is<br/>
        /// refused naming every unknown field.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="config">
        /// The `openapi` config exactly as `POST /v1/agents/tool-definitions`<br/>
        /// takes it, with the credential by reference. The whole config is<br/>
        /// validated, not only the operation called.
        /// </param>
        /// <param name="operation">
        /// The `id` of the operation to call, one of `config.operations[].id`;<br/>
        /// the same value a hosted API `tool` route's `operation` names.
        /// </param>
        /// <param name="arguments">
        /// The arguments the agent would pass: each param by its `name`, plus<br/>
        /// `body` when the operation takes one. Omitted, the call carries none.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.TestOpenAPICallResult> TestOpenAPICallAsync(
            global::Speechify.OpenAPIToolConfig config,
            string operation,
            string? speechifyVersion = default,
            object? arguments = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Speechify.TestOpenAPICallRequest
            {
                Config = config,
                Operation = operation,
                Arguments = arguments,
            };

            return await TestOpenAPICallAsync(
                speechifyVersion: speechifyVersion,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}