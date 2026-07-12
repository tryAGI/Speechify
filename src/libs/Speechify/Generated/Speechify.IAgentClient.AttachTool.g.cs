#nullable enable

namespace Speechify
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Attach Tool<br/>
        /// Attach an existing workspace tool definition (webhook / client /<br/>
        /// MCP) to the agent by its definition id. Idempotent. To create and<br/>
        /// attach in one step, POST to `/v1/agents/{agent_id}/tools` instead.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="toolId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AttachToolAsync(
            string agentId,
            string toolId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach Tool<br/>
        /// Attach an existing workspace tool definition (webhook / client /<br/>
        /// MCP) to the agent by its definition id. Idempotent. To create and<br/>
        /// attach in one step, POST to `/v1/agents/{agent_id}/tools` instead.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="toolId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> AttachToolAsResponseAsync(
            string agentId,
            string toolId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}