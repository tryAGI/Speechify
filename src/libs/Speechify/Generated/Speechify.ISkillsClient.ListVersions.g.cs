#nullable enable

namespace Speechify
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// List Skill Versions<br/>
        /// List a skill's version history, newest first. Each entry summarises its<br/>
        /// body rather than returning it; read a full body with<br/>
        /// `GET /v1/skills/{skill_id}?version=`. Versions are minted by updating<br/>
        /// the skill, never created directly.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListSkillVersionsResponse> ListVersionsAsync(
            string skillId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Skill Versions<br/>
        /// List a skill's version history, newest first. Each entry summarises its<br/>
        /// body rather than returning it; read a full body with<br/>
        /// `GET /v1/skills/{skill_id}?version=`. Versions are minted by updating<br/>
        /// the skill, never created directly.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListSkillVersionsResponse>> ListVersionsAsResponseAsync(
            string skillId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}