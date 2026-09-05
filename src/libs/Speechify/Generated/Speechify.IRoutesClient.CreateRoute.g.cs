#nullable enable

namespace Speechify
{
    public partial interface IRoutesClient
    {
        /// <summary>
        /// Create Route<br/>
        /// Add a route: a method + path answered by a resolver. `store_query` and<br/>
        /// `store_document` serve a store; `run_latest` serves the newest<br/>
        /// structured output of a schedule trigger's runs; `run` starts a run<br/>
        /// through a webhook trigger per request (POST only, never on a public<br/>
        /// API) and waits up to `wait_seconds` before answering 202 with a<br/>
        /// handle to poll at `/_runs/{run_id}`. Where-clause values and the<br/>
        /// document id may be `{{query.x}}`, `{{path.x}}` or `{{body.x}}`<br/>
        /// templates bound from the consumer's request; a clause whose template<br/>
        /// is absent is skipped.<br/>
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
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPIRoute> CreateRouteAsync(
            string apiId,

            global::Speechify.CreateHostedAPIRouteRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Route<br/>
        /// Add a route: a method + path answered by a resolver. `store_query` and<br/>
        /// `store_document` serve a store; `run_latest` serves the newest<br/>
        /// structured output of a schedule trigger's runs; `run` starts a run<br/>
        /// through a webhook trigger per request (POST only, never on a public<br/>
        /// API) and waits up to `wait_seconds` before answering 202 with a<br/>
        /// handle to poll at `/_runs/{run_id}`. Where-clause values and the<br/>
        /// document id may be `{{query.x}}`, `{{path.x}}` or `{{body.x}}`<br/>
        /// templates bound from the consumer's request; a clause whose template<br/>
        /// is absent is skipped.<br/>
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.HostedAPIRoute>> CreateRouteAsResponseAsync(
            string apiId,

            global::Speechify.CreateHostedAPIRouteRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Route<br/>
        /// Add a route: a method + path answered by a resolver. `store_query` and<br/>
        /// `store_document` serve a store; `run_latest` serves the newest<br/>
        /// structured output of a schedule trigger's runs; `run` starts a run<br/>
        /// through a webhook trigger per request (POST only, never on a public<br/>
        /// API) and waits up to `wait_seconds` before answering 202 with a<br/>
        /// handle to poll at `/_runs/{run_id}`. Where-clause values and the<br/>
        /// document id may be `{{query.x}}`, `{{path.x}}` or `{{body.x}}`<br/>
        /// templates bound from the consumer's request; a clause whose template<br/>
        /// is absent is skipped.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="method"></param>
        /// <param name="path">
        /// Lowercase segments of letters, digits, `. _ -` or a `{param}`; `/openapi.json` and `/_runs` are reserved.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="resolver">
        /// What answers a route. `type` selects the fields that apply:<br/>
        /// `store_query` (store_id, collection, where, order_by, limit),<br/>
        /// `store_document` (store_id, collection, document_id),<br/>
        /// `run_latest` (trigger_id of a schedule trigger),<br/>
        /// `run` (trigger_id of a webhook trigger, wait_seconds).
        /// </param>
        /// <param name="responseSchema"></param>
        /// <param name="cacheTtlSeconds"></param>
        /// <param name="enabled">
        /// Enabled when omitted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPIRoute> CreateRouteAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}