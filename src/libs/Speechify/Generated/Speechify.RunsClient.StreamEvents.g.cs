
#nullable enable

namespace Speechify
{
    public partial class RunsClient
    {


        private static readonly global::Speechify.EndPointSecurityRequirement s_StreamEventsSecurityRequirement0 =
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
        private static readonly global::Speechify.EndPointSecurityRequirement[] s_StreamEventsSecurityRequirements =
            new global::Speechify.EndPointSecurityRequirement[]
            {                s_StreamEventsSecurityRequirement0,
            };
        partial void PrepareStreamEventsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string agentId,
            ref string runId,
            ref string? speechifyVersion);
        partial void PrepareStreamEventsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string agentId,
            string runId,
            string? speechifyVersion);
        partial void ProcessStreamEventsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Stream Run Events<br/>
        /// Server-Sent Events stream of a run's progress, so a client can follow<br/>
        /// a long-running agent instead of polling it.<br/>
        /// Holds the connection open and tails the run's journal: a<br/>
        /// `run.step.added` event per step (its `data` is a RunStep object, the<br/>
        /// same shape List Run Steps returns), a `run.reply.delta` event for each<br/>
        /// piece of the agent's answer, as it writes it, a<br/>
        /// `run.status.changed` event when the run's status moves, and a terminal<br/>
        /// `run.ended` event carrying the final status and, when the run stopped<br/>
        /// short, its `incomplete_reason`. Consumers must ignore unknown event<br/>
        /// types.<br/>
        /// A picture or chart the agent makes arrives before the run ends: the<br/>
        /// `observation` step for the tool call that made it carries the file<br/>
        /// under `files`, so a client can show it the moment that step is<br/>
        /// delivered. `run.ended` lists every file the run produced.<br/>
        /// A run waiting on a human approval is not terminal: the stream reports<br/>
        /// `requires_action` and keeps tailing, so the client learns it has<br/>
        /// something to decide.<br/>
        /// ## The reply arrives as it is written<br/>
        /// `run.reply.delta` carries the agent's answer piece by piece, so a chat<br/>
        /// built on runs shows the answer forming instead of a spinner. It<br/>
        /// carries the answer and nothing else: what the agent writes on the way<br/>
        /// to it, such as the plan behind a tool call, never rides this event and<br/>
        /// reaches the stream only as the `content` of a `run.step.added` plan<br/>
        /// step. Appending the pieces in order gives the answer, so a piece can be<br/>
        /// shown the moment it arrives.<br/>
        /// Each piece names the journal position the answer is written at<br/>
        /// (`seq`) and how many characters of it precede the piece (`offset`).<br/>
        /// Append a piece whose `offset` equals what you hold; on any other<br/>
        /// `offset`, or a different `seq`, cut what you hold to that `offset`<br/>
        /// first. That only happens after a step was re-executed, and means the<br/>
        /// earlier text is void. Text is counted in Unicode code points.<br/>
        /// `run.ended` closes the answer, and its `output.reply` is the<br/>
        /// authoritative copy: replace what you hold with it. A `run.ended` with<br/>
        /// no `output` (the run failed, was cancelled, or stopped short) means the<br/>
        /// answer was abandoned mid-sentence - show it as such or drop it. A<br/>
        /// client that never subscribes to `run.reply.delta` sees exactly the<br/>
        /// stream it saw before the event existed.<br/>
        /// Not every run streams its answer, because not every model says which<br/>
        /// of its text is the answer while writing it. The platform default<br/>
        /// model does. An agent on another model or on a custom LLM endpoint, and<br/>
        /// a run with an `output_schema` (whose answer is not final until it is<br/>
        /// checked), answers whole: no pieces, and the reply on `run.ended`.<br/>
        /// Following a run costs nothing beyond the run: the stream is not<br/>
        /// metered, and its read load is a few small queries per second per<br/>
        /// subscriber, a little more while the answer is being written.<br/>
        /// ## The stream is expected to reconnect<br/>
        /// **The server closes the connection after 4 minutes whether or not the<br/>
        /// run has settled**, so a long run spans several connections. Only<br/>
        /// `run.ended` means the run is over - a closed socket does not. The<br/>
        /// response opens with `retry: 2000`, so a browser `EventSource`<br/>
        /// reconnects on its own; a hand-rolled client must do the same.<br/>
        /// Resume with the standard `Last-Event-ID` header. Step events carry<br/>
        /// their `seq` as the event id; reply pieces carry the seq of the last<br/>
        /// step plus the position reached in the text being written, so a<br/>
        /// reconnect continues exactly where it left off and never replays text<br/>
        /// the client already rendered. Status events carry no id, and an absent<br/>
        /// or unparseable `Last-Event-ID` replays the journal from the beginning<br/>
        /// rather than skipping it. On every connection, including a resume, the<br/>
        /// server emits one `run.status.changed` carrying the run's current<br/>
        /// status before it starts tailing. A `: keepalive` comment arrives every<br/>
        /// 15 seconds so an intermediary does not time the connection out while<br/>
        /// the agent is thinking.<br/>
        /// Same read access as List Run Steps, and the same<br/>
        /// `402 durable_runs_not_in_plan` on a workspace without the grant.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="runId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Speechify.AgentRunStreamEvent> StreamEventsAsync(
            string agentId,
            string runId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareStreamEventsArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                runId: ref runId,
                speechifyVersion: ref speechifyVersion);


            var __authorizations = global::Speechify.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_StreamEventsSecurityRequirements,
                operationName: "StreamEventsAsync");

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
                                path: $"/v1/agents/{agentId}/runs/{runId}/events",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Speechify.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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

                global::Speechify.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareStreamEventsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    agentId: agentId,
                    runId: runId,
                    speechifyVersion: speechifyVersion);

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
                                operationId: "StreamEvents",
                                methodName: "StreamEventsAsync",
                                pathTemplate: "$\"/v1/agents/{agentId}/runs/{runId}/events\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "StreamEvents",
                                methodName: "StreamEventsAsync",
                                pathTemplate: "$\"/v1/agents/{agentId}/runs/{runId}/events\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "StreamEvents",
                                methodName: "StreamEventsAsync",
                                pathTemplate: "$\"/v1/agents/{agentId}/runs/{runId}/events\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                ProcessStreamEventsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Speechify.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Speechify.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StreamEvents",
                                methodName: "StreamEventsAsync",
                                pathTemplate: "$\"/v1/agents/{agentId}/runs/{runId}/events\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "StreamEvents",
                                methodName: "StreamEventsAsync",
                                pathTemplate: "$\"/v1/agents/{agentId}/runs/{runId}/events\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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

                                var __streamedResponse = global::Speechify.AgentRunStreamEvent.FromJson(__content, JsonSerializerContext) ??
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
    }
}