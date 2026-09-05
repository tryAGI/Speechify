#nullable enable

namespace Speechify
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Attach Skill To Agent<br/>
        /// Attach a skill to this agent, pinned to one version. Omit `version` to<br/>
        /// pin whatever is latest AT THIS MOMENT - the pin is a number, never a<br/>
        /// live pointer, so a later edit to the skill does not reach this agent.<br/>
        /// Idempotent: attaching again re-pins.<br/>
        /// Three refusals worth knowing. The agent and the skill must be in the<br/>
        /// same project (409 `cross_project_reference`). The skill's tools must<br/>
        /// not collide by name with anything the agent already answers to<br/>
        /// (409 `skill_tool_name_conflict`) - the model picks a tool by name.<br/>
        /// And any knowledge base the skill names must already be attached to the<br/>
        /// agent (409), because retrieval re-authorizes against the agent's own<br/>
        /// attachments and would refuse a skill-contributed base mid-call.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="skillId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentSkill> AttachSkillAsync(
            string agentId,
            string skillId,

            global::Speechify.AttachSkillRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach Skill To Agent<br/>
        /// Attach a skill to this agent, pinned to one version. Omit `version` to<br/>
        /// pin whatever is latest AT THIS MOMENT - the pin is a number, never a<br/>
        /// live pointer, so a later edit to the skill does not reach this agent.<br/>
        /// Idempotent: attaching again re-pins.<br/>
        /// Three refusals worth knowing. The agent and the skill must be in the<br/>
        /// same project (409 `cross_project_reference`). The skill's tools must<br/>
        /// not collide by name with anything the agent already answers to<br/>
        /// (409 `skill_tool_name_conflict`) - the model picks a tool by name.<br/>
        /// And any knowledge base the skill names must already be attached to the<br/>
        /// agent (409), because retrieval re-authorizes against the agent's own<br/>
        /// attachments and would refuse a skill-contributed base mid-call.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="skillId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AgentSkill>> AttachSkillAsResponseAsync(
            string agentId,
            string skillId,

            global::Speechify.AttachSkillRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach Skill To Agent<br/>
        /// Attach a skill to this agent, pinned to one version. Omit `version` to<br/>
        /// pin whatever is latest AT THIS MOMENT - the pin is a number, never a<br/>
        /// live pointer, so a later edit to the skill does not reach this agent.<br/>
        /// Idempotent: attaching again re-pins.<br/>
        /// Three refusals worth knowing. The agent and the skill must be in the<br/>
        /// same project (409 `cross_project_reference`). The skill's tools must<br/>
        /// not collide by name with anything the agent already answers to<br/>
        /// (409 `skill_tool_name_conflict`) - the model picks a tool by name.<br/>
        /// And any knowledge base the skill names must already be attached to the<br/>
        /// agent (409), because retrieval re-authorizes against the agent's own<br/>
        /// attachments and would refuse a skill-contributed base mid-call.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="skillId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="version">
        /// Version to pin. Omit to pin whatever is latest at this moment.
        /// </param>
        /// <param name="enabled">
        /// Defaults to true.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AgentSkill> AttachSkillAsync(
            string agentId,
            string skillId,
            string? speechifyVersion = default,
            int? version = default,
            bool? enabled = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}