#nullable enable

namespace Speechify
{
    public partial interface IRoutesClient
    {
        /// <summary>
        /// Update Route<br/>
        /// Update a route (merge-patch); a changed method or resolver is re-validated.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="routeId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPIRoute> UpdateRouteAsync(
            string apiId,
            string routeId,

            global::Speechify.UpdateHostedAPIRouteRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Route<br/>
        /// Update a route (merge-patch); a changed method or resolver is re-validated.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="routeId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.HostedAPIRoute>> UpdateRouteAsResponseAsync(
            string apiId,
            string routeId,

            global::Speechify.UpdateHostedAPIRouteRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Route<br/>
        /// Update a route (merge-patch); a changed method or resolver is re-validated.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="routeId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="method"></param>
        /// <param name="path"></param>
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
        /// retry clears until the route or the tool is fixed. Arguments that do<br/>
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
        /// <param name="enabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPIRoute> UpdateRouteAsync(
            string apiId,
            string routeId,
            string? speechifyVersion = default,
            global::Speechify.UpdateHostedApiRouteRequestMethod? method = default,
            string? path = default,
            string? name = default,
            string? description = default,
            global::Speechify.HostedAPIResolver? resolver = default,
            object? responseSchema = default,
            int? cacheTtlSeconds = default,
            bool? enabled = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}