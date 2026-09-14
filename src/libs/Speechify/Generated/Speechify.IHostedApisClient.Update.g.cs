#nullable enable

namespace Speechify
{
    public partial interface IHostedApisClient
    {
        /// <summary>
        /// Update Hosted API<br/>
        /// Update a hosted API (merge-patch). Switching to `public` is refused<br/>
        /// while a `run` or `store_write` route exists: an anonymous caller must<br/>
        /// not start runs that spend the workspace's budget or write to a store,<br/>
        /// and it is refused outright where the workspace's policy does not allow<br/>
        /// internet-facing APIs (403 `hosted_api_public_refused`). Switching to a<br/>
        /// mode that names no caller (`consumer_key`, `public`) is refused while<br/>
        /// a route binds `{{user.*}}`: only `user_token`, `workspace` and `owner`<br/>
        /// supply a person. Switching to `public` is also refused while a `tool`<br/>
        /// route exists (a vendor call spends the workspace's vendor budget) and<br/>
        /// while `mcp_enabled` is on, and switching the MCP face on is refused on<br/>
        /// a `public` API (400 `validation_failed` naming `mcp_enabled`).<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPI> UpdateAsync(
            string apiId,

            global::Speechify.UpdateHostedAPIRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Hosted API<br/>
        /// Update a hosted API (merge-patch). Switching to `public` is refused<br/>
        /// while a `run` or `store_write` route exists: an anonymous caller must<br/>
        /// not start runs that spend the workspace's budget or write to a store,<br/>
        /// and it is refused outright where the workspace's policy does not allow<br/>
        /// internet-facing APIs (403 `hosted_api_public_refused`). Switching to a<br/>
        /// mode that names no caller (`consumer_key`, `public`) is refused while<br/>
        /// a route binds `{{user.*}}`: only `user_token`, `workspace` and `owner`<br/>
        /// supply a person. Switching to `public` is also refused while a `tool`<br/>
        /// route exists (a vendor call spends the workspace's vendor budget) and<br/>
        /// while `mcp_enabled` is on, and switching the MCP face on is refused on<br/>
        /// a `public` API (400 `validation_failed` naming `mcp_enabled`).<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.HostedAPI>> UpdateAsResponseAsync(
            string apiId,

            global::Speechify.UpdateHostedAPIRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Hosted API<br/>
        /// Update a hosted API (merge-patch). Switching to `public` is refused<br/>
        /// while a `run` or `store_write` route exists: an anonymous caller must<br/>
        /// not start runs that spend the workspace's budget or write to a store,<br/>
        /// and it is refused outright where the workspace's policy does not allow<br/>
        /// internet-facing APIs (403 `hosted_api_public_refused`). Switching to a<br/>
        /// mode that names no caller (`consumer_key`, `public`) is refused while<br/>
        /// a route binds `{{user.*}}`: only `user_token`, `workspace` and `owner`<br/>
        /// supply a person. Switching to `public` is also refused while a `tool`<br/>
        /// route exists (a vendor call spends the workspace's vendor budget) and<br/>
        /// while `mcp_enabled` is on, and switching the MCP face on is refused on<br/>
        /// a `public` API (400 `validation_failed` naming `mcp_enabled`).<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="name"></param>
        /// <param name="description">
        /// What the API is for; also the instructions an MCP client hands its model when `mcp_enabled` is on.
        /// </param>
        /// <param name="authMode"></param>
        /// <param name="corsOrigins"></param>
        /// <param name="enabled">
        /// A paused API answers 503 to every consumer request.
        /// </param>
        /// <param name="dailyRunCap"></param>
        /// <param name="dailyReadCap"></param>
        /// <param name="dailyWriteCap"></param>
        /// <param name="mcpEnabled">
        /// Switch the MCP face at `POST &lt;base_url&gt;/mcp` on or off. Refused with<br/>
        /// 400 `validation_failed` naming `mcp_enabled` when the API is, or is<br/>
        /// being made, `public`. Allow up to 15 seconds for the switch, like<br/>
        /// any route change, to reach every server.
        /// </param>
        /// <param name="userTokenJwksUrl">
        /// Replace the registered key set; an empty string removes it, after which the signing secret verifies tokens again.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPI> UpdateAsync(
            string apiId,
            string? speechifyVersion = default,
            string? name = default,
            string? description = default,
            global::Speechify.UpdateHostedApiRequestAuthMode? authMode = default,
            global::System.Collections.Generic.IList<string>? corsOrigins = default,
            bool? enabled = default,
            int? dailyRunCap = default,
            int? dailyReadCap = default,
            int? dailyWriteCap = default,
            bool? mcpEnabled = default,
            string? userTokenJwksUrl = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}