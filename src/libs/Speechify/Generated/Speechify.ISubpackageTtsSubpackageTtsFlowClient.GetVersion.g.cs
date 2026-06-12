#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsFlowClient
    {
        /// <summary>
        /// Get Agent Flow Version<br/>
        /// Return the full flow graph for a specific published version.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsGetFlowVersionResponse> GetVersionAsync(
            string id,
            string versionId,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Flow Version<br/>
        /// Return the full flow graph for a specific published version.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsGetFlowVersionResponse>> GetVersionAsResponseAsync(
            string id,
            string versionId,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}