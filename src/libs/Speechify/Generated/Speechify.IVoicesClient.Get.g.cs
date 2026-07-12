#nullable enable

namespace Speechify
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Voice<br/>
        /// Fetch a single voice by id - a shared catalogue voice or one of<br/>
        /// the caller's own personal (cloned) voices. A personal voice that<br/>
        /// belongs to another workspace returns 404, identical to an<br/>
        /// unknown id, so voice inventory is never enumerable across tenants.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.GetVoice> GetAsync(
            string voiceId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Voice<br/>
        /// Fetch a single voice by id - a shared catalogue voice or one of<br/>
        /// the caller's own personal (cloned) voices. A personal voice that<br/>
        /// belongs to another workspace returns 404, identical to an<br/>
        /// unknown id, so voice inventory is never enumerable across tenants.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.GetVoice>> GetAsResponseAsync(
            string voiceId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}