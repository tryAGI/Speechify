#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// Get Agent Widget Config<br/>
        /// Return the embed-widget appearance config for an agent. Works<br/>
        /// unauthenticated for public agents; the body is cosmetic only.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WidgetConfig> GetWidgetConfigAsync(
            string agentId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Widget Config<br/>
        /// Return the embed-widget appearance config for an agent. Works<br/>
        /// unauthenticated for public agents; the body is cosmetic only.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.WidgetConfig>> GetWidgetConfigAsResponseAsync(
            string agentId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}