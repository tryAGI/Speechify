#nullable enable

namespace Speechify
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Delete Document<br/>
        /// Delete one document. `If-Match` makes the delete conditional on the<br/>
        /// `revision` you read, so it never removes a version written since.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="documentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="ifMatch"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteDocumentAsync(
            string storeId,
            string collection,
            string documentId,
            string? speechifyVersion = default,
            string? ifMatch = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Document<br/>
        /// Delete one document. `If-Match` makes the delete conditional on the<br/>
        /// `revision` you read, so it never removes a version written since.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="collection"></param>
        /// <param name="documentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="ifMatch"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteDocumentAsResponseAsync(
            string storeId,
            string collection,
            string documentId,
            string? speechifyVersion = default,
            string? ifMatch = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}