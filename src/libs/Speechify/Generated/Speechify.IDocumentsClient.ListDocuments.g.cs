#nullable enable

namespace Speechify
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// List Documents<br/>
        /// List a collection's documents, most recently updated first, bodies<br/>
        /// included unless `include_data=false`. For filters and ordering use<br/>
        /// `queryDocuments`.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="includeData"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.QueryStoreDocumentsResponse> ListDocumentsAsync(
            string storeId,
            string collection,
            string? cursor = default,
            int? limit = default,
            bool? includeData = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Documents<br/>
        /// List a collection's documents, most recently updated first, bodies<br/>
        /// included unless `include_data=false`. For filters and ordering use<br/>
        /// `queryDocuments`.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="includeData"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.QueryStoreDocumentsResponse>> ListDocumentsAsResponseAsync(
            string storeId,
            string collection,
            string? cursor = default,
            int? limit = default,
            bool? includeData = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}