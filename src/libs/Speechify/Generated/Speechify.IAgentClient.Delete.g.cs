#nullable enable

namespace Speechify
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Delete Agent<br/>
        /// Delete a voice agent. Conversations and attached tools remain. The<br/>
        /// agent's tests are deleted with it; their run history is retained.<br/>
        /// Refused with `409 agent_in_use` while a live phone number still<br/>
        /// routes to the agent, including the agent a webhook binding<br/>
        /// provisioned for its number; `used_by` names the numbers. Unbind them<br/>
        /// (`DELETE /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`,<br/>
        /// which also clears a webhook binding) and the delete proceeds.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string agentId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Agent<br/>
        /// Delete a voice agent. Conversations and attached tools remain. The<br/>
        /// agent's tests are deleted with it; their run history is retained.<br/>
        /// Refused with `409 agent_in_use` while a live phone number still<br/>
        /// routes to the agent, including the agent a webhook binding<br/>
        /// provisioned for its number; `used_by` names the numbers. Unbind them<br/>
        /// (`DELETE /v1/agents/{agent_id}/phone-numbers/{phone_number_id}`,<br/>
        /// which also clears a webhook binding) and the delete proceeds.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteAsResponseAsync(
            string agentId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}