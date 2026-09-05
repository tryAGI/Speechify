#nullable enable

namespace Speechify
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Create Document<br/>
        /// Write a document, minting an id when none is given. Prefer `putDocument`<br/>
        /// with a stable id you derive from the content, so a retry never<br/>
        /// duplicates. Bounded by the store's document limit (409<br/>
        /// `store_document_limit_reached`).<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.StoreDocument> CreateDocumentAsync(
            string storeId,
            string collection,

            global::Speechify.WriteStoreDocumentRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Document<br/>
        /// Write a document, minting an id when none is given. Prefer `putDocument`<br/>
        /// with a stable id you derive from the content, so a retry never<br/>
        /// duplicates. Bounded by the store's document limit (409<br/>
        /// `store_document_limit_reached`).<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.StoreDocument>> CreateDocumentAsResponseAsync(
            string storeId,
            string collection,

            global::Speechify.WriteStoreDocumentRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Document<br/>
        /// Write a document, minting an id when none is given. Prefer `putDocument`<br/>
        /// with a stable id you derive from the content, so a retry never<br/>
        /// duplicates. Bounded by the store's document limit (409<br/>
        /// `store_document_limit_reached`).<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="id">
        /// On `createDocument`, the id to write at (letters, digits, `_ . - : ~ @ +`, at most 200);<br/>
        /// minted when absent. Ignored on `putDocument` / `updateDocument`, where the URL names it.
        /// </param>
        /// <param name="data">
        /// The document body (a JSON object, at most 256 KiB). On `updateDocument`, the fields to merge; a null removes a field.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.StoreDocument> CreateDocumentAsync(
            string storeId,
            string collection,
            object data,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? id = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}