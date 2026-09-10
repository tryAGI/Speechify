#nullable enable

namespace Speechify
{
    public partial interface IRoutesClient
    {
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
        /// (`/app/*` with `file_root` and `file_index`). Where-clause values and<br/>
        /// the document id may be `{{query.x}}`, `{{path.x}}` or `{{body.x}}`<br/>
        /// templates bound from the consumer's request, or `{{user.x}}` claims of<br/>
        /// the verified caller on a `user_token`, `workspace` or `owner` API; a<br/>
        /// clause whose template is absent is skipped. On those three modes a<br/>
        /// written document is stamped `user_identity` as the caller and only<br/>
        /// they can replace or merge it. Two bindings are refused at write time:<br/>
        /// `{{user.*}}` on an API that names no caller, and a clause on<br/>
        /// `user_identity` bound from a request template, which would let any<br/>
        /// caller read any user's rows.<br/>
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
        /// (`/app/*` with `file_root` and `file_index`). Where-clause values and<br/>
        /// the document id may be `{{query.x}}`, `{{path.x}}` or `{{body.x}}`<br/>
        /// templates bound from the consumer's request, or `{{user.x}}` claims of<br/>
        /// the verified caller on a `user_token`, `workspace` or `owner` API; a<br/>
        /// clause whose template is absent is skipped. On those three modes a<br/>
        /// written document is stamped `user_identity` as the caller and only<br/>
        /// they can replace or merge it. Two bindings are refused at write time:<br/>
        /// `{{user.*}}` on an API that names no caller, and a clause on<br/>
        /// `user_identity` bound from a request template, which would let any<br/>
        /// caller read any user's rows.<br/>
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
        /// (`/app/*` with `file_root` and `file_index`). Where-clause values and<br/>
        /// the document id may be `{{query.x}}`, `{{path.x}}` or `{{body.x}}`<br/>
        /// templates bound from the consumer's request, or `{{user.x}}` claims of<br/>
        /// the verified caller on a `user_token`, `workspace` or `owner` API; a<br/>
        /// clause whose template is absent is skipped. On those three modes a<br/>
        /// written document is stamped `user_identity` as the caller and only<br/>
        /// they can replace or merge it. Two bindings are refused at write time:<br/>
        /// `{{user.*}}` on an API that names no caller, and a clause on<br/>
        /// `user_identity` bound from a request template, which would let any<br/>
        /// caller read any user's rows.<br/>
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
        /// ends in `*`, file_root and file_index for a whole published tree).
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