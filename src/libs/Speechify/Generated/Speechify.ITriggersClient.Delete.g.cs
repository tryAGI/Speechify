#nullable enable

namespace Speechify
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Delete Agent Trigger<br/>
        /// Delete a trigger. A schedule stops firing; a webhook fire URL stops accepting.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="triggerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string agentId,
            string triggerId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Agent Trigger<br/>
        /// Delete a trigger. A schedule stops firing; a webhook fire URL stops accepting.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="triggerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteAsResponseAsync(
            string agentId,
            string triggerId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}