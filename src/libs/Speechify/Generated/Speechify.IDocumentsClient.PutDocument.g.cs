#nullable enable

namespace Speechify
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Put Document<br/>
        /// Write (create or replace) a document at this id. 201 for a new<br/>
        /// document, 200 for a new version of an existing one. `data` must be a<br/>
        /// JSON object of at most 256 KiB; its top-level scalar fields become the<br/>
        /// queryable projection.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="documentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.StoreDocument> PutDocumentAsync(
            string storeId,
            string collection,
            string documentId,

            global::Speechify.WriteStoreDocumentRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Put Document<br/>
        /// Write (create or replace) a document at this id. 201 for a new<br/>
        /// document, 200 for a new version of an existing one. `data` must be a<br/>
        /// JSON object of at most 256 KiB; its top-level scalar fields become the<br/>
        /// queryable projection.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="documentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.StoreDocument>> PutDocumentAsResponseAsync(
            string storeId,
            string collection,
            string documentId,

            global::Speechify.WriteStoreDocumentRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Put Document<br/>
        /// Write (create or replace) a document at this id. 201 for a new<br/>
        /// document, 200 for a new version of an existing one. `data` must be a<br/>
        /// JSON object of at most 256 KiB; its top-level scalar fields become the<br/>
        /// queryable projection.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="documentId"></param>
        /// <param name="speechifyVersion"></param>
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
        global::System.Threading.Tasks.Task<global::Speechify.StoreDocument> PutDocumentAsync(
            string storeId,
            string collection,
            string documentId,
            object data,
            string? speechifyVersion = default,
            string? id = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}