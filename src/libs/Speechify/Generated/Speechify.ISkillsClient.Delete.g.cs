#nullable enable

namespace Speechify
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Delete Skill<br/>
        /// Delete a skill. Refused with 409 `skill_in_use` while any agent still<br/>
        /// has it attached: deleting it would change every one of their prompts at<br/>
        /// once, which is what the version pin exists to prevent. Detach it first.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string skillId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Skill<br/>
        /// Delete a skill. Refused with 409 `skill_in_use` while any agent still<br/>
        /// has it attached: deleting it would change every one of their prompts at<br/>
        /// once, which is what the version pin exists to prevent. Detach it first.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteAsResponseAsync(
            string skillId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}