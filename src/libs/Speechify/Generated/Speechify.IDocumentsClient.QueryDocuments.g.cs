#nullable enable

namespace Speechify
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Query Documents<br/>
        /// Query a collection: filter on top-level scalar fields with `where`,<br/>
        /// order on one with `order_by`, page with `limit` + `cursor`. Values<br/>
        /// compare with JSON semantics (numbers as numbers, strings lexically, so<br/>
        /// ISO-8601 timestamps order as dates). A read carrying a body, hence a<br/>
        /// POST on a literal sub-path; `query` and `batch` are reserved document ids.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.QueryStoreDocumentsResponse> QueryDocumentsAsync(
            string storeId,
            string collection,

            global::Speechify.StoreDocumentQuery request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Documents<br/>
        /// Query a collection: filter on top-level scalar fields with `where`,<br/>
        /// order on one with `order_by`, page with `limit` + `cursor`. Values<br/>
        /// compare with JSON semantics (numbers as numbers, strings lexically, so<br/>
        /// ISO-8601 timestamps order as dates). A read carrying a body, hence a<br/>
        /// POST on a literal sub-path; `query` and `batch` are reserved document ids.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.QueryStoreDocumentsResponse>> QueryDocumentsAsResponseAsync(
            string storeId,
            string collection,

            global::Speechify.StoreDocumentQuery request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Documents<br/>
        /// Query a collection: filter on top-level scalar fields with `where`,<br/>
        /// order on one with `order_by`, page with `limit` + `cursor`. Values<br/>
        /// compare with JSON semantics (numbers as numbers, strings lexically, so<br/>
        /// ISO-8601 timestamps order as dates). A read carrying a body, hence a<br/>
        /// POST on a literal sub-path; `query` and `batch` are reserved document ids.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="where">
        /// Filters, ANDed. Only top-level string / number / boolean / null fields are queryable.
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="limit">
        /// Page size, 50 when omitted.
        /// </param>
        /// <param name="cursor">
        /// The `next_cursor` of the previous page; must belong to the same ordering.
        /// </param>
        /// <param name="includeData">
        /// Set false to return index rows only; bodies are included when omitted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.QueryStoreDocumentsResponse> QueryDocumentsAsync(
            string storeId,
            string collection,
            string? speechifyVersion = default,
            global::System.Collections.Generic.IList<global::Speechify.StoreWhereClause>? where = default,
            global::Speechify.StoreOrderBy? orderBy = default,
            int? limit = default,
            string? cursor = default,
            bool? includeData = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}