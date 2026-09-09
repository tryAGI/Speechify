#nullable enable

namespace Speechify
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Delete Agent Tool<br/>
        /// Remove a tool from the agent. A built-in instance is deleted; an<br/>
        /// attached external tool is detached (the workspace definition<br/>
        /// survives and stays attachable elsewhere).<br/>
        /// A detached definition **keeps its name** in the agent's project, so<br/>
        /// creating a new tool under that name here is refused with `409<br/>
        /// tool_name_taken` even though the agent's tool list is empty. The<br/>
        /// definition is listed at `GET /v1/agents/tool-definitions` under the<br/>
        /// same id: re-attach it with `PUT /v1/agents/{agent_id}/tools/{tool_id}`,<br/>
        /// or delete it there to free the name.
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
        /// survives and stays attachable elsewhere).<br/>
        /// A detached definition **keeps its name** in the agent's project, so<br/>
        /// creating a new tool under that name here is refused with `409<br/>
        /// tool_name_taken` even though the agent's tool list is empty. The<br/>
        /// definition is listed at `GET /v1/agents/tool-definitions` under the<br/>
        /// same id: re-attach it with `PUT /v1/agents/{agent_id}/tools/{tool_id}`,<br/>
        /// or delete it there to free the name.
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