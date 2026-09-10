#nullable enable

namespace Speechify
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Aggregate Documents<br/>
        /// Count, sum, average, min or max over a collection, filtered with the<br/>
        /// same `where` a query takes and optionally grouped by one field, in<br/>
        /// one request. It runs on each document's indexed projection (its<br/>
        /// top-level string / number / boolean / null fields), never on the<br/>
        /// bodies: a nested value does not exist to it, a string longer than 256<br/>
        /// characters groups by its first 256 and the answer says<br/>
        /// `key_truncated` when that happened, and at most 100 groups come back,<br/>
        /// largest first (`groups_truncated`). A read carrying a body, hence a<br/>
        /// POST on a literal sub-path; `aggregate` is a reserved document id.<br/>
        /// This is the last operation the query surface takes. A store is a<br/>
        /// Firestore-shaped document store: filter, order, page and aggregate on<br/>
        /// top-level fields. No joins, nested-field filters, full-text search or<br/>
        /// SQL follow; a customer who needs more brings their own database<br/>
        /// through a webhook or MCP tool, or pulls a collection into a run's<br/>
        /// sandbox.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.StoreAggregateResponse> AggregateDocumentsAsync(
            string storeId,
            string collection,

            global::Speechify.StoreAggregateQuery request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Aggregate Documents<br/>
        /// Count, sum, average, min or max over a collection, filtered with the<br/>
        /// same `where` a query takes and optionally grouped by one field, in<br/>
        /// one request. It runs on each document's indexed projection (its<br/>
        /// top-level string / number / boolean / null fields), never on the<br/>
        /// bodies: a nested value does not exist to it, a string longer than 256<br/>
        /// characters groups by its first 256 and the answer says<br/>
        /// `key_truncated` when that happened, and at most 100 groups come back,<br/>
        /// largest first (`groups_truncated`). A read carrying a body, hence a<br/>
        /// POST on a literal sub-path; `aggregate` is a reserved document id.<br/>
        /// This is the last operation the query surface takes. A store is a<br/>
        /// Firestore-shaped document store: filter, order, page and aggregate on<br/>
        /// top-level fields. No joins, nested-field filters, full-text search or<br/>
        /// SQL follow; a customer who needs more brings their own database<br/>
        /// through a webhook or MCP tool, or pulls a collection into a run's<br/>
        /// sandbox.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.StoreAggregateResponse>> AggregateDocumentsAsResponseAsync(
            string storeId,
            string collection,

            global::Speechify.StoreAggregateQuery request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Aggregate Documents<br/>
        /// Count, sum, average, min or max over a collection, filtered with the<br/>
        /// same `where` a query takes and optionally grouped by one field, in<br/>
        /// one request. It runs on each document's indexed projection (its<br/>
        /// top-level string / number / boolean / null fields), never on the<br/>
        /// bodies: a nested value does not exist to it, a string longer than 256<br/>
        /// characters groups by its first 256 and the answer says<br/>
        /// `key_truncated` when that happened, and at most 100 groups come back,<br/>
        /// largest first (`groups_truncated`). A read carrying a body, hence a<br/>
        /// POST on a literal sub-path; `aggregate` is a reserved document id.<br/>
        /// This is the last operation the query surface takes. A store is a<br/>
        /// Firestore-shaped document store: filter, order, page and aggregate on<br/>
        /// top-level fields. No joins, nested-field filters, full-text search or<br/>
        /// SQL follow; a customer who needs more brings their own database<br/>
        /// through a webhook or MCP tool, or pulls a collection into a run's<br/>
        /// sandbox.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="where">
        /// Filters, ANDed, the same ones a query takes.
        /// </param>
        /// <param name="groupBy">
        /// One projected field to group by. A string that reaches the index's 256-byte limit may have been cut there, and the answer says so.
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.StoreAggregateResponse> AggregateDocumentsAsync(
            string storeId,
            string collection,
            global::System.Collections.Generic.IList<global::Speechify.StoreAggregateMetric> metrics,
            string? speechifyVersion = default,
            global::System.Collections.Generic.IList<global::Speechify.StoreWhereClause>? where = default,
            string? groupBy = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}