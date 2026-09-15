#nullable enable

namespace Speechify
{
    public partial interface IRoutesClient
    {
        /// <summary>
        /// Mount a Connector<br/>
        /// Publish a connector's operations onto the API in one call: one `tool`<br/>
        /// route per operation of an `openapi` tool definition, or per tool its<br/>
        /// `mcp` server lists, named `&lt;name_prefix&gt;__&lt;operation&gt;` at<br/>
        /// `&lt;path_prefix&gt;/&lt;operation&gt;`, so two connectors' tools stay apart on<br/>
        /// the MCP face and inside its 64-character tool names.<br/>
        /// Send `dry_run: true` first. The answer lists every operation with<br/>
        /// its effective `action_class` and `approval`, whether a route can serve<br/>
        /// it, and the `action` a mount takes: `create`, `update` (an MCP tool<br/>
        /// whose input schema changed since its route was written; `changes`<br/>
        /// names what), `unchanged`, `skip` (with the `reason`: not selected, not<br/>
        /// a read, not auto-approved, a name or path already taken, or the route<br/>
        /// cap) or `stale` (a route whose operation the connector no longer<br/>
        /// offers, or can no longer serve; it is reported and never deleted,<br/>
        /// since a consumer may still call it). The same call without `dry_run`<br/>
        /// writes every create and update in one transaction and returns the<br/>
        /// written `route` on each.<br/>
        /// Every answer carries a `plan_digest`. Send the preview's digest with<br/>
        /// the apply: the apply plans again inside its transaction and writes<br/>
        /// only when that plan still has the digest, so a tool the server changed<br/>
        /// or a route edited after you reviewed is never written unseen. When it<br/>
        /// differs the apply writes nothing and answers 409 `mount_plan_changed`<br/>
        /// with the current plan, as a dry run answers it, in<br/>
        /// `error.details.plan`; review that and apply again with its digest,<br/>
        /// under a new `Idempotency-Key` if you sent one, since a key replays its<br/>
        /// first answer, this 409 included. The digest covers every operation the<br/>
        /// connector offers and every route the API holds for it whatever<br/>
        /// `operations` selects, so a preview of everything and an apply of a<br/>
        /// selection share one. An apply without it writes whatever the mount<br/>
        /// plans at that moment.<br/>
        /// Mounting again is the refresh. Every route the API holds for the<br/>
        /// connector is compared with what it offers now, whatever its name,<br/>
        /// path or the selection, so an upstream change is seen as a diff before<br/>
        /// anyone's client sees it. `operations` selects what to create; omit it<br/>
        /// to create a route for every operation a route can serve. A route an<br/>
        /// owner renamed or moved keeps its name and path on refresh.<br/>
        /// The route write's rules apply to every operation: the connector must<br/>
        /// be in the API's project (409 `cross_project_reference`), an MCP server<br/>
        /// must be reachable with its credential to be listed (400<br/>
        /// `validation_failed` on `tool_id` with the server's reason), and a<br/>
        /// public API mounts nothing. An API holds at most 200 routes; a mount<br/>
        /// that would pass the cap skips what does not fit. Without a<br/>
        /// `plan_digest`, a route changed while the mount was being planned<br/>
        /// answers 409 `api_route_conflict`; mount again.<br/>
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
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPIMount> MountRoutesAsync(
            string apiId,

            global::Speechify.MountHostedAPIRoutesRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Mount a Connector<br/>
        /// Publish a connector's operations onto the API in one call: one `tool`<br/>
        /// route per operation of an `openapi` tool definition, or per tool its<br/>
        /// `mcp` server lists, named `&lt;name_prefix&gt;__&lt;operation&gt;` at<br/>
        /// `&lt;path_prefix&gt;/&lt;operation&gt;`, so two connectors' tools stay apart on<br/>
        /// the MCP face and inside its 64-character tool names.<br/>
        /// Send `dry_run: true` first. The answer lists every operation with<br/>
        /// its effective `action_class` and `approval`, whether a route can serve<br/>
        /// it, and the `action` a mount takes: `create`, `update` (an MCP tool<br/>
        /// whose input schema changed since its route was written; `changes`<br/>
        /// names what), `unchanged`, `skip` (with the `reason`: not selected, not<br/>
        /// a read, not auto-approved, a name or path already taken, or the route<br/>
        /// cap) or `stale` (a route whose operation the connector no longer<br/>
        /// offers, or can no longer serve; it is reported and never deleted,<br/>
        /// since a consumer may still call it). The same call without `dry_run`<br/>
        /// writes every create and update in one transaction and returns the<br/>
        /// written `route` on each.<br/>
        /// Every answer carries a `plan_digest`. Send the preview's digest with<br/>
        /// the apply: the apply plans again inside its transaction and writes<br/>
        /// only when that plan still has the digest, so a tool the server changed<br/>
        /// or a route edited after you reviewed is never written unseen. When it<br/>
        /// differs the apply writes nothing and answers 409 `mount_plan_changed`<br/>
        /// with the current plan, as a dry run answers it, in<br/>
        /// `error.details.plan`; review that and apply again with its digest,<br/>
        /// under a new `Idempotency-Key` if you sent one, since a key replays its<br/>
        /// first answer, this 409 included. The digest covers every operation the<br/>
        /// connector offers and every route the API holds for it whatever<br/>
        /// `operations` selects, so a preview of everything and an apply of a<br/>
        /// selection share one. An apply without it writes whatever the mount<br/>
        /// plans at that moment.<br/>
        /// Mounting again is the refresh. Every route the API holds for the<br/>
        /// connector is compared with what it offers now, whatever its name,<br/>
        /// path or the selection, so an upstream change is seen as a diff before<br/>
        /// anyone's client sees it. `operations` selects what to create; omit it<br/>
        /// to create a route for every operation a route can serve. A route an<br/>
        /// owner renamed or moved keeps its name and path on refresh.<br/>
        /// The route write's rules apply to every operation: the connector must<br/>
        /// be in the API's project (409 `cross_project_reference`), an MCP server<br/>
        /// must be reachable with its credential to be listed (400<br/>
        /// `validation_failed` on `tool_id` with the server's reason), and a<br/>
        /// public API mounts nothing. An API holds at most 200 routes; a mount<br/>
        /// that would pass the cap skips what does not fit. Without a<br/>
        /// `plan_digest`, a route changed while the mount was being planned<br/>
        /// answers 409 `api_route_conflict`; mount again.<br/>
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.HostedAPIMount>> MountRoutesAsResponseAsync(
            string apiId,

            global::Speechify.MountHostedAPIRoutesRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Mount a Connector<br/>
        /// Publish a connector's operations onto the API in one call: one `tool`<br/>
        /// route per operation of an `openapi` tool definition, or per tool its<br/>
        /// `mcp` server lists, named `&lt;name_prefix&gt;__&lt;operation&gt;` at<br/>
        /// `&lt;path_prefix&gt;/&lt;operation&gt;`, so two connectors' tools stay apart on<br/>
        /// the MCP face and inside its 64-character tool names.<br/>
        /// Send `dry_run: true` first. The answer lists every operation with<br/>
        /// its effective `action_class` and `approval`, whether a route can serve<br/>
        /// it, and the `action` a mount takes: `create`, `update` (an MCP tool<br/>
        /// whose input schema changed since its route was written; `changes`<br/>
        /// names what), `unchanged`, `skip` (with the `reason`: not selected, not<br/>
        /// a read, not auto-approved, a name or path already taken, or the route<br/>
        /// cap) or `stale` (a route whose operation the connector no longer<br/>
        /// offers, or can no longer serve; it is reported and never deleted,<br/>
        /// since a consumer may still call it). The same call without `dry_run`<br/>
        /// writes every create and update in one transaction and returns the<br/>
        /// written `route` on each.<br/>
        /// Every answer carries a `plan_digest`. Send the preview's digest with<br/>
        /// the apply: the apply plans again inside its transaction and writes<br/>
        /// only when that plan still has the digest, so a tool the server changed<br/>
        /// or a route edited after you reviewed is never written unseen. When it<br/>
        /// differs the apply writes nothing and answers 409 `mount_plan_changed`<br/>
        /// with the current plan, as a dry run answers it, in<br/>
        /// `error.details.plan`; review that and apply again with its digest,<br/>
        /// under a new `Idempotency-Key` if you sent one, since a key replays its<br/>
        /// first answer, this 409 included. The digest covers every operation the<br/>
        /// connector offers and every route the API holds for it whatever<br/>
        /// `operations` selects, so a preview of everything and an apply of a<br/>
        /// selection share one. An apply without it writes whatever the mount<br/>
        /// plans at that moment.<br/>
        /// Mounting again is the refresh. Every route the API holds for the<br/>
        /// connector is compared with what it offers now, whatever its name,<br/>
        /// path or the selection, so an upstream change is seen as a diff before<br/>
        /// anyone's client sees it. `operations` selects what to create; omit it<br/>
        /// to create a route for every operation a route can serve. A route an<br/>
        /// owner renamed or moved keeps its name and path on refresh.<br/>
        /// The route write's rules apply to every operation: the connector must<br/>
        /// be in the API's project (409 `cross_project_reference`), an MCP server<br/>
        /// must be reachable with its credential to be listed (400<br/>
        /// `validation_failed` on `tool_id` with the server's reason), and a<br/>
        /// public API mounts nothing. An API holds at most 200 routes; a mount<br/>
        /// that would pass the cap skips what does not fit. Without a<br/>
        /// `plan_digest`, a route changed while the mount was being planned<br/>
        /// answers 409 `api_route_conflict`; mount again.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="toolId">
        /// The `openapi` or `mcp` tool definition to mount, in the API's project.
        /// </param>
        /// <param name="operations">
        /// The operations to create routes for: openapi operation ids or the<br/>
        /// MCP server's tool names. Omit to create a route for every operation<br/>
        /// a route can serve. Naming one the connector does not offer is 400<br/>
        /// `validation_failed` on `operations[i]`. Existing routes are compared<br/>
        /// whatever the selection.
        /// </param>
        /// <param name="namePrefix">
        /// Prefix of each created route's name, `&lt;name_prefix&gt;__&lt;operation&gt;`. Defaults to the tool's name with other characters as `_`.
        /// </param>
        /// <param name="pathPrefix">
        /// Path each created route sits under, `&lt;path_prefix&gt;/&lt;operation&gt;`; lowercase segments of letters, digits, `.`, `_` or `-`, with no `{param}` or `*`, and not under `/mcp`, `/openapi.json` or `/_runs`. Defaults to `/&lt;name_prefix&gt;` in lowercase.
        /// </param>
        /// <param name="dryRun">
        /// Answer what the mount would do and write nothing.
        /// </param>
        /// <param name="includeWrites">
        /// Create routes for operations that are not reads too, each with<br/>
        /// `allow_write: true`. Only an API whose `auth_mode` names a person<br/>
        /// takes them; the operation's `approval` must still be `auto`.<br/>
        /// Without it a write is a `skip` that says so.
        /// </param>
        /// <param name="planDigest">
        /// The `plan_digest` of the preview you reviewed. The apply writes<br/>
        /// only while the plan it computes inside its transaction still has<br/>
        /// this digest, and otherwise writes nothing and answers 409<br/>
        /// `mount_plan_changed` with the current plan. Omit it to apply what<br/>
        /// the mount plans now. Refused with `dry_run`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPIMount> MountRoutesAsync(
            string apiId,
            string toolId,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::System.Collections.Generic.IList<string>? operations = default,
            string? namePrefix = default,
            string? pathPrefix = default,
            bool? dryRun = default,
            bool? includeWrites = default,
            string? planDigest = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}