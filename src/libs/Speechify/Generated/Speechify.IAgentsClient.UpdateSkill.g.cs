#nullable enable

namespace Speechify
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update Agent Skill<br/>
        /// Move this agent's pin to another version, or switch the skill off<br/>
        /// without detaching it (the pin survives, so switching it back on<br/>
        /// restores the same body). Moving the pin re-runs the tool-name and<br/>
        /// knowledge checks against the version being moved to.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="skillId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentSkill> UpdateSkillAsync(
            string agentId,
            string skillId,

            global::Speechify.UpdateAgentSkillRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Skill<br/>
        /// Move this agent's pin to another version, or switch the skill off<br/>
        /// without detaching it (the pin survives, so switching it back on<br/>
        /// restores the same body). Moving the pin re-runs the tool-name and<br/>
        /// knowledge checks against the version being moved to.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="skillId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentSkill>> UpdateSkillAsResponseAsync(
            string agentId,
            string skillId,

            global::Speechify.UpdateAgentSkillRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Skill<br/>
        /// Move this agent's pin to another version, or switch the skill off<br/>
        /// without detaching it (the pin survives, so switching it back on<br/>
        /// restores the same body). Moving the pin re-runs the tool-name and<br/>
        /// knowledge checks against the version being moved to.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="skillId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="version"></param>
        /// <param name="enabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentSkill> UpdateSkillAsync(
            string agentId,
            string skillId,
            string? speechifyVersion = default,
            int? version = default,
            bool? enabled = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}