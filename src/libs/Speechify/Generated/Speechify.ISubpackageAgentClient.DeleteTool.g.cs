#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// Delete Agent Tool<br/>
        /// Remove a tool from the agent. A built-in instance is deleted; an<br/>
        /// attached external tool is detached (the workspace definition<br/>
        /// survives and stays attachable elsewhere).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="toolId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteToolAsync(
            string agentId,
            string toolId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Agent Tool<br/>
        /// Remove a tool from the agent. A built-in instance is deleted; an<br/>
        /// attached external tool is detached (the workspace definition<br/>
        /// survives and stays attachable elsewhere).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="toolId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteToolAsResponseAsync(
            string agentId,
            string toolId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}