#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsFlowClient
    {
        /// <summary>
        /// Roll Back Agent Flow<br/>
        /// Publish a prior flow version as the active graph.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsFlowVersion> RollbackAsync(
            string id,

            global::Speechify.TtsRollbackFlowRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Roll Back Agent Flow<br/>
        /// Publish a prior flow version as the active graph.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TtsFlowVersion>> RollbackAsResponseAsync(
            string id,

            global::Speechify.TtsRollbackFlowRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Roll Back Agent Flow<br/>
        /// Publish a prior flow version as the active graph.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId">
        /// The flow version to roll back to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsFlowVersion> RollbackAsync(
            string id,
            string versionId,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}