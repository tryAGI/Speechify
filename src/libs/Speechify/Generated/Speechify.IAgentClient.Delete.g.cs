#nullable enable

namespace Speechify
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Delete Agent<br/>
        /// Delete an agent, and with it everything that belonged only to that<br/>
        /// agent.<br/>
        /// **Goes with the agent**, immediately unreadable through every<br/>
        /// endpoint: its runs and their step journals and approvals, its<br/>
        /// conversations and the transcripts, messages and recordings inside<br/>
        /// them, what it learned about the people it spoke to, its triggers,<br/>
        /// share links, channel bindings, team memberships and the batch<br/>
        /// campaigns it dialled. A run that has not settled is asked to stop,<br/>
        /// including one parked waiting on a person or on a delegated child. These are removed for good 30 days<br/>
        /// later; until then the delete can still be walked back by support.<br/>
        /// **Survives the agent**, because it belongs to the workspace rather<br/>
        /// than to this agent: attached tools, knowledge bases, stores and<br/>
        /// skills (only the attachment is dropped), the agent's tests, phone<br/>
        /// numbers, and the teams it belonged to.<br/>
        /// **Kept regardless**, because it is accounting rather than content:<br/>
        /// the usage the workspace was billed for.<br/>
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
        /// Delete an agent, and with it everything that belonged only to that<br/>
        /// agent.<br/>
        /// **Goes with the agent**, immediately unreadable through every<br/>
        /// endpoint: its runs and their step journals and approvals, its<br/>
        /// conversations and the transcripts, messages and recordings inside<br/>
        /// them, what it learned about the people it spoke to, its triggers,<br/>
        /// share links, channel bindings, team memberships and the batch<br/>
        /// campaigns it dialled. A run that has not settled is asked to stop,<br/>
        /// including one parked waiting on a person or on a delegated child. These are removed for good 30 days<br/>
        /// later; until then the delete can still be walked back by support.<br/>
        /// **Survives the agent**, because it belongs to the workspace rather<br/>
        /// than to this agent: attached tools, knowledge bases, stores and<br/>
        /// skills (only the attachment is dropped), the agent's tests, phone<br/>
        /// numbers, and the teams it belonged to.<br/>
        /// **Kept regardless**, because it is accounting rather than content:<br/>
        /// the usage the workspace was billed for.<br/>
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