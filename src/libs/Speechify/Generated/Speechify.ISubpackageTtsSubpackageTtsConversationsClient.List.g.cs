#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsConversationsClient
    {
        /// <summary>
        /// List<br/>
        /// List conversations owned by the caller, ordered by most recent.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsListConversationsResponse> ListAsync(
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}