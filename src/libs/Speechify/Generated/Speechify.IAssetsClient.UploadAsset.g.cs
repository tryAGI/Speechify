#nullable enable

namespace Speechify
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Upload Asset<br/>
        /// Upload one file (multipart form field `file`, at most 25 MiB). The<br/>
        /// part's content type is stored and served back from `bytes_path`.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.StoreAsset> UploadAssetAsync(
            string storeId,

            global::Speechify.UploadAssetRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Asset<br/>
        /// Upload one file (multipart form field `file`, at most 25 MiB). The<br/>
        /// part's content type is stored and served back from `bytes_path`.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.StoreAsset>> UploadAssetAsResponseAsync(
            string storeId,

            global::Speechify.UploadAssetRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Asset<br/>
        /// Upload one file (multipart form field `file`, at most 25 MiB). The<br/>
        /// part's content type is stored and served back from `bytes_path`.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="file">
        /// The file to store (at most 25 MiB).
        /// </param>
        /// <param name="filename">
        /// The file to store (at most 25 MiB).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.StoreAsset> UploadAssetAsync(
            string storeId,
            byte[] file,
            string filename,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Asset<br/>
        /// Upload one file (multipart form field `file`, at most 25 MiB). The<br/>
        /// part's content type is stored and served back from `bytes_path`.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="file">
        /// The file to store (at most 25 MiB).
        /// </param>
        /// <param name="filename">
        /// The file to store (at most 25 MiB).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.StoreAsset> UploadAssetAsync(
            string storeId,
            global::System.IO.Stream file,
            string filename,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Asset<br/>
        /// Upload one file (multipart form field `file`, at most 25 MiB). The<br/>
        /// part's content type is stored and served back from `bytes_path`.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="file">
        /// The file to store (at most 25 MiB).
        /// </param>
        /// <param name="filename">
        /// The file to store (at most 25 MiB).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.StoreAsset>> UploadAssetAsResponseAsync(
            string storeId,
            global::System.IO.Stream file,
            string filename,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}