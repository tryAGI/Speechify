#nullable enable

namespace Speechify
{
    public partial interface IHostedApisClient
    {
        /// <summary>
        /// Update Hosted API<br/>
        /// Update a hosted API (merge-patch). Switching to `public` is refused<br/>
        /// while a `run` route exists: an anonymous caller must not start runs<br/>
        /// that spend the workspace's budget.<br/>
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
        /// while a `run` route exists: an anonymous caller must not start runs<br/>
        /// that spend the workspace's budget.<br/>
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
        /// while a `run` route exists: an anonymous caller must not start runs<br/>
        /// that spend the workspace's budget.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="authMode"></param>
        /// <param name="corsOrigins"></param>
        /// <param name="enabled">
        /// A paused API answers 503 to every consumer request.
        /// </param>
        /// <param name="dailyRunCap"></param>
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
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}