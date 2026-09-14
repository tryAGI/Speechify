
#nullable enable

namespace Speechify
{
    public partial class ToolDefinitionsClient
    {


        private static readonly global::Speechify.EndPointSecurityRequirement s_ImportOpenAPISecurityRequirement0 =
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
        private static readonly global::Speechify.EndPointSecurityRequirement[] s_ImportOpenAPISecurityRequirements =
            new global::Speechify.EndPointSecurityRequirement[]
            {                s_ImportOpenAPISecurityRequirement0,
            };
        partial void PrepareImportOpenAPIArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? speechifyVersion,
            global::Speechify.ImportOpenAPIRequest request);
        partial void PrepareImportOpenAPIRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? speechifyVersion,
            global::Speechify.ImportOpenAPIRequest request);
        partial void ProcessImportOpenAPIResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessImportOpenAPIResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Import OpenAPI Operations<br/>
        /// Compile a vendor's OpenAPI 3.x document into the operations an<br/>
        /// `openapi` tool can carry, without persisting anything. It is the<br/>
        /// second step of connecting a REST API: store the vendor credential<br/>
        /// with `POST /v1/credentials`, import the document here, choose and<br/>
        /// classify the operations the agent needs, preview one with<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call`, then create the<br/>
        /// tool with `POST /v1/agents/tool-definitions`.<br/>
        /// Pass the document by `spec_url` (an https URL fetched server-side,<br/>
        /// with the headers of the credential `auth` names when the document<br/>
        /// sits behind the vendor's own auth) or inline as `spec`, never both.<br/>
        /// Each entry of `operations` is already in the shape<br/>
        /// `OpenAPIToolConfig.operations` takes, in document order: copy the ones<br/>
        /// the agent should have (at most 40 per tool), and add `action_class`<br/>
        /// and `response` where you need them. Use each returned `id` verbatim<br/>
        /// rather than deriving it: it is the document's operationId made safe<br/>
        /// for a function name (a run of other characters becomes one `_`, a<br/>
        /// leading digit gains `op_`, at most 64 characters), or a name built<br/>
        /// from the method and path when the document has none, and an id two<br/>
        /// operations would share takes a numeric suffix. You may rename an id<br/>
        /// before saving. The agent calls each operation as<br/>
        /// `&lt;tool name&gt;__&lt;id&gt;`, which must fit 64 characters, so shorten the tool<br/>
        /// name or rename the id when it does not. `skipped` lists every<br/>
        /// operation that could not be represented, with the reason.<br/>
        /// The document's security schemes are not imported: the tool's own<br/>
        /// `auth` is `none`, `bearer` or `oauth2_client_credentials`. Never<br/>
        /// select an API key the document declares as a header or query<br/>
        /// parameter as a parameter, since the agent would have to supply its<br/>
        /// value.<br/>
        /// A refused `spec_url`, a credential that does not resolve or cannot<br/>
        /// mint a token, a fetch that fails and a document that does not parse<br/>
        /// all answer 200 with `error` set and `operations` empty. Only a<br/>
        /// malformed request is a 400: neither or both of `spec` and `spec_url`,<br/>
        /// or a field this endpoint does not define, which is refused naming<br/>
        /// every unknown field.<br/>
        /// Needs the `content.manage` permission, as creating a tool does: the<br/>
        /// fetch sends a referenced credential's headers to `spec_url`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.ImportOpenAPIResult> ImportOpenAPIAsync(

            global::Speechify.ImportOpenAPIRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ImportOpenAPIAsResponseAsync(

                request: request,
                speechifyVersion: speechifyVersion,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Import OpenAPI Operations<br/>
        /// Compile a vendor's OpenAPI 3.x document into the operations an<br/>
        /// `openapi` tool can carry, without persisting anything. It is the<br/>
        /// second step of connecting a REST API: store the vendor credential<br/>
        /// with `POST /v1/credentials`, import the document here, choose and<br/>
        /// classify the operations the agent needs, preview one with<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call`, then create the<br/>
        /// tool with `POST /v1/agents/tool-definitions`.<br/>
        /// Pass the document by `spec_url` (an https URL fetched server-side,<br/>
        /// with the headers of the credential `auth` names when the document<br/>
        /// sits behind the vendor's own auth) or inline as `spec`, never both.<br/>
        /// Each entry of `operations` is already in the shape<br/>
        /// `OpenAPIToolConfig.operations` takes, in document order: copy the ones<br/>
        /// the agent should have (at most 40 per tool), and add `action_class`<br/>
        /// and `response` where you need them. Use each returned `id` verbatim<br/>
        /// rather than deriving it: it is the document's operationId made safe<br/>
        /// for a function name (a run of other characters becomes one `_`, a<br/>
        /// leading digit gains `op_`, at most 64 characters), or a name built<br/>
        /// from the method and path when the document has none, and an id two<br/>
        /// operations would share takes a numeric suffix. You may rename an id<br/>
        /// before saving. The agent calls each operation as<br/>
        /// `&lt;tool name&gt;__&lt;id&gt;`, which must fit 64 characters, so shorten the tool<br/>
        /// name or rename the id when it does not. `skipped` lists every<br/>
        /// operation that could not be represented, with the reason.<br/>
        /// The document's security schemes are not imported: the tool's own<br/>
        /// `auth` is `none`, `bearer` or `oauth2_client_credentials`. Never<br/>
        /// select an API key the document declares as a header or query<br/>
        /// parameter as a parameter, since the agent would have to supply its<br/>
        /// value.<br/>
        /// A refused `spec_url`, a credential that does not resolve or cannot<br/>
        /// mint a token, a fetch that fails and a document that does not parse<br/>
        /// all answer 200 with `error` set and `operations` empty. Only a<br/>
        /// malformed request is a 400: neither or both of `spec` and `spec_url`,<br/>
        /// or a field this endpoint does not define, which is refused naming<br/>
        /// every unknown field.<br/>
        /// Needs the `content.manage` permission, as creating a tool does: the<br/>
        /// fetch sends a referenced credential's headers to `spec_url`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ImportOpenAPIResult>> ImportOpenAPIAsResponseAsync(

            global::Speechify.ImportOpenAPIRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareImportOpenAPIArguments(
                httpClient: HttpClient,
                speechifyVersion: ref speechifyVersion,
                request: request);


            var __authorizations = global::Speechify.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ImportOpenAPISecurityRequirements,
                operationName: "ImportOpenAPIAsync");

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
                                path: "/v1/agents/tool-definitions/import-openapi",
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
                PrepareImportOpenAPIRequest(
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
                                operationId: "ImportOpenAPI",
                                methodName: "ImportOpenAPIAsync",
                                pathTemplate: "\"/v1/agents/tool-definitions/import-openapi\"",
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
                                operationId: "ImportOpenAPI",
                                methodName: "ImportOpenAPIAsync",
                                pathTemplate: "\"/v1/agents/tool-definitions/import-openapi\"",
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
                                operationId: "ImportOpenAPI",
                                methodName: "ImportOpenAPIAsync",
                                pathTemplate: "\"/v1/agents/tool-definitions/import-openapi\"",
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
                ProcessImportOpenAPIResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Speechify.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Speechify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ImportOpenAPI",
                                methodName: "ImportOpenAPIAsync",
                                pathTemplate: "\"/v1/agents/tool-definitions/import-openapi\"",
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
                                operationId: "ImportOpenAPI",
                                methodName: "ImportOpenAPIAsync",
                                pathTemplate: "\"/v1/agents/tool-definitions/import-openapi\"",
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
                                ProcessImportOpenAPIResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Speechify.ImportOpenAPIResult.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Speechify.AutoSDKHttpResponse<global::Speechify.ImportOpenAPIResult>(
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

                                    var __value = await global::Speechify.ImportOpenAPIResult.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Speechify.AutoSDKHttpResponse<global::Speechify.ImportOpenAPIResult>(
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
        /// Import OpenAPI Operations<br/>
        /// Compile a vendor's OpenAPI 3.x document into the operations an<br/>
        /// `openapi` tool can carry, without persisting anything. It is the<br/>
        /// second step of connecting a REST API: store the vendor credential<br/>
        /// with `POST /v1/credentials`, import the document here, choose and<br/>
        /// classify the operations the agent needs, preview one with<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call`, then create the<br/>
        /// tool with `POST /v1/agents/tool-definitions`.<br/>
        /// Pass the document by `spec_url` (an https URL fetched server-side,<br/>
        /// with the headers of the credential `auth` names when the document<br/>
        /// sits behind the vendor's own auth) or inline as `spec`, never both.<br/>
        /// Each entry of `operations` is already in the shape<br/>
        /// `OpenAPIToolConfig.operations` takes, in document order: copy the ones<br/>
        /// the agent should have (at most 40 per tool), and add `action_class`<br/>
        /// and `response` where you need them. Use each returned `id` verbatim<br/>
        /// rather than deriving it: it is the document's operationId made safe<br/>
        /// for a function name (a run of other characters becomes one `_`, a<br/>
        /// leading digit gains `op_`, at most 64 characters), or a name built<br/>
        /// from the method and path when the document has none, and an id two<br/>
        /// operations would share takes a numeric suffix. You may rename an id<br/>
        /// before saving. The agent calls each operation as<br/>
        /// `&lt;tool name&gt;__&lt;id&gt;`, which must fit 64 characters, so shorten the tool<br/>
        /// name or rename the id when it does not. `skipped` lists every<br/>
        /// operation that could not be represented, with the reason.<br/>
        /// The document's security schemes are not imported: the tool's own<br/>
        /// `auth` is `none`, `bearer` or `oauth2_client_credentials`. Never<br/>
        /// select an API key the document declares as a header or query<br/>
        /// parameter as a parameter, since the agent would have to supply its<br/>
        /// value.<br/>
        /// A refused `spec_url`, a credential that does not resolve or cannot<br/>
        /// mint a token, a fetch that fails and a document that does not parse<br/>
        /// all answer 200 with `error` set and `operations` empty. Only a<br/>
        /// malformed request is a 400: neither or both of `spec` and `spec_url`,<br/>
        /// or a field this endpoint does not define, which is refused naming<br/>
        /// every unknown field.<br/>
        /// Needs the `content.manage` permission, as creating a tool does: the<br/>
        /// fetch sends a referenced credential's headers to `spec_url`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="specUrl">
        /// An https URL the server fetches the document from, with the headers<br/>
        /// of the credential `auth` names when it names one. A private or<br/>
        /// loopback address is refused. At most 2 MiB. Keep it as the tool's<br/>
        /// `spec_url` so a later import can refresh the operations.
        /// </param>
        /// <param name="spec">
        /// The document inline: a JSON object, or a string holding the JSON<br/>
        /// or YAML text. At most 2 MiB.
        /// </param>
        /// <param name="auth">
        /// How the platform authenticates to an MCP server or an OpenAPI tool's<br/>
        /// REST API: `none`, `bearer` or `oauth2_client_credentials`, a<br/>
        /// discriminated union over `type`. Other credential kinds (an API key<br/>
        /// in a custom header or query parameter, HTTP Basic) are not supported<br/>
        /// here.
        /// </param>
        /// <param name="baseUrl">
        /// Overrides the document's `servers` in the result's `base_url`: the<br/>
        /// regional or tenant host this workspace signed up to. The create<br/>
        /// endpoint requires https.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Speechify.ImportOpenAPIResult> ImportOpenAPIAsync(
            string? speechifyVersion = default,
            string? specUrl = default,
            global::Speechify.ImportOpenApiRequestSpec? spec = default,
            global::Speechify.MCPAuth? auth = default,
            string? baseUrl = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Speechify.ImportOpenAPIRequest
            {
                SpecUrl = specUrl,
                Spec = spec,
                Auth = auth,
                BaseUrl = baseUrl,
            };

            return await ImportOpenAPIAsync(
                speechifyVersion: speechifyVersion,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}