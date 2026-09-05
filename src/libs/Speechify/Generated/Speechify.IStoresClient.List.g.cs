#nullable enable

namespace Speechify
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// List Stores<br/>
        /// List the stores in the caller's workspace, most recently updated<br/>
        /// first. A store is the durable document + asset store a durable run<br/>
        /// writes to (through its store tools) and a hosted-API route serves.<br/>
        /// Cursor-paginated; walk pages while `has_more` is true.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListStoresResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Stores<br/>
        /// List the stores in the caller's workspace, most recently updated<br/>
        /// first. A store is the durable document + asset store a durable run<br/>
        /// writes to (through its store tools) and a hosted-API route serves.<br/>
        /// Cursor-paginated; walk pages while `has_more` is true.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListStoresResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}