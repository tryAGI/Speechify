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
        /// (`/app/*` with `file_root` and `file_index`); `tool` calls one read<br/>
        /// operation of an `openapi` tool definition in the API's project whose<br/>
        /// `approval` is null or `auto` (POST only, never on a public API, counted<br/>
        /// against `daily_read_cap`): the<br/>
        /// consumer's JSON body is the operation's arguments and the vendor's<br/>
        /// answer, after the operation's `response` mapping, is the response.<br/>
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
        /// (`/app/*` with `file_root` and `file_index`); `tool` calls one read<br/>
        /// operation of an `openapi` tool definition in the API's project whose<br/>
        /// `approval` is null or `auto` (POST only, never on a public API, counted<br/>
        /// against `daily_read_cap`): the<br/>
        /// consumer's JSON body is the operation's arguments and the vendor's<br/>
        /// answer, after the operation's `response` mapping, is the response.<br/>
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
        /// (`/app/*` with `file_root` and `file_index`); `tool` calls one read<br/>
        /// operation of an `openapi` tool definition in the API's project whose<br/>
        /// `approval` is null or `auto` (POST only, never on a public API, counted<br/>
        /// against `daily_read_cap`): the<br/>
        /// consumer's JSON body is the operation's arguments and the vendor's<br/>
        /// answer, after the operation's `response` mapping, is the response.<br/>
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
        /// `tool` (tool_id of an `openapi` tool definition and the `operation`<br/>
        /// on it: the POST body is the operation's arguments, held to its<br/>
        /// argument schema, and the vendor's answer after the operation's<br/>
        /// `response` mapping is the response, or `{"text": ...}` when the vendor<br/>
        /// answered text. Only an operation whose effective class is `read`, on a<br/>
        /// tool whose `approval` is null or `auto`, may be served, and never on a<br/>
        /// public API; a route write that names anything else is refused with 400<br/>
        /// `validation_failed` on `resolver.tool_id`. Because a definition can<br/>
        /// change after its route is written, every call re-checks it: an<br/>
        /// operation no longer classified `read`, or a tool whose `approval` is no<br/>
        /// longer null or `auto`, answers 403 `route_tool_not_readable`; a tool<br/>
        /// deleted, moved to another project, no longer of kind `openapi` or<br/>
        /// without the operation answers 409 `route_tool_unavailable`, which no<br/>
        /// retry clears until the route or the tool is fixed. Arguments that do<br/>
        /// not fit the schema answer 400 `validation_failed`; the definition's<br/>
        /// `max_requests_per_minute` and the vendor's own throttle both answer 429<br/>
        /// `route_upstream_rate_limited` with `Retry-After`; a vendor error<br/>
        /// answers 502 `route_upstream_error` with the vendor's status in<br/>
        /// `error.details.upstream_status`, and an unreachable vendor or a<br/>
        /// credential that no longer resolves answers 502 `route_upstream_error`<br/>
        /// without it).
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