#nullable enable

namespace Speechify
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Update Document<br/>
        /// Shallow-merge `data` into the stored document (a JSON null removes a<br/>
        /// field) and write the result as a new version.<br/>
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
        global::System.Threading.Tasks.Task<global::Speechify.StoreDocument> UpdateDocumentAsync(
            string storeId,
            string collection,
            string documentId,

            global::Speechify.WriteStoreDocumentRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Document<br/>
        /// Shallow-merge `data` into the stored document (a JSON null removes a<br/>
        /// field) and write the result as a new version.<br/>
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.StoreDocument>> UpdateDocumentAsResponseAsync(
            string storeId,
            string collection,
            string documentId,

            global::Speechify.WriteStoreDocumentRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Document<br/>
        /// Shallow-merge `data` into the stored document (a JSON null removes a<br/>
        /// field) and write the result as a new version.<br/>
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
        global::System.Threading.Tasks.Task<global::Speechify.StoreDocument> UpdateDocumentAsync(
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