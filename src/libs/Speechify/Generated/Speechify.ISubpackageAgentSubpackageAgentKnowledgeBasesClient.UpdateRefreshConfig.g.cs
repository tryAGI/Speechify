#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Update Refresh Config<br/>
        /// Update the per-document auto-refresh state. Only meaningful<br/>
        /// for url-sourced documents; file and text rows reject the<br/>
        /// request.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="documentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RefreshConfig> UpdateRefreshConfigAsync(
            string kbId,
            string documentId,

            global::Speechify.UpdateRefreshConfigRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Refresh Config<br/>
        /// Update the per-document auto-refresh state. Only meaningful<br/>
        /// for url-sourced documents; file and text rows reject the<br/>
        /// request.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="documentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.RefreshConfig>> UpdateRefreshConfigAsResponseAsync(
            string kbId,
            string documentId,

            global::Speechify.UpdateRefreshConfigRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Refresh Config<br/>
        /// Update the per-document auto-refresh state. Only meaningful<br/>
        /// for url-sourced documents; file and text rows reject the<br/>
        /// request.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="documentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="enabled"></param>
        /// <param name="intervalDays"></param>
        /// <param name="autoRemoveEnabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RefreshConfig> UpdateRefreshConfigAsync(
            string kbId,
            string documentId,
            string? speechifyVersion = default,
            bool? enabled = default,
            int? intervalDays = default,
            bool? autoRemoveEnabled = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}