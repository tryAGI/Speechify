#nullable enable

namespace Speechify
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// List Stores<br/>
        /// List the stores in the caller's workspace, most recently updated<br/>
        /// first. A store is a workspace-owned database of JSON documents in<br/>
        /// named collections, Firestore-shaped: filter on top-level scalar<br/>
        /// fields, order on one, page with a cursor, and aggregate in one<br/>
        /// request; no joins, nested-field filters, full-text search or SQL, on<br/>
        /// purpose. A durable run writes it through its store tools, a hosted-API<br/>
        /// route serves it, and your own backend reads and writes it here.<br/>
        /// Uploaded bytes are not stores: a file is its own resource at<br/>
        /// `/v1/files`.<br/>
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
        /// first. A store is a workspace-owned database of JSON documents in<br/>
        /// named collections, Firestore-shaped: filter on top-level scalar<br/>
        /// fields, order on one, page with a cursor, and aggregate in one<br/>
        /// request; no joins, nested-field filters, full-text search or SQL, on<br/>
        /// purpose. A durable run writes it through its store tools, a hosted-API<br/>
        /// route serves it, and your own backend reads and writes it here.<br/>
        /// Uploaded bytes are not stores: a file is its own resource at<br/>
        /// `/v1/files`.<br/>
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