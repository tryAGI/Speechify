#nullable enable

namespace Speechify
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Get Skill<br/>
        /// Retrieve one skill at its latest version, or at the version named by<br/>
        /// `?version=`. An unknown version is a 404 `skill_version_not_found`<br/>
        /// rather than a fall back to the latest - a caller asking for one body<br/>
        /// is never handed a different one.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="version"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Skill> GetAsync(
            string skillId,
            int? version = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Skill<br/>
        /// Retrieve one skill at its latest version, or at the version named by<br/>
        /// `?version=`. An unknown version is a 404 `skill_version_not_found`<br/>
        /// rather than a fall back to the latest - a caller asking for one body<br/>
        /// is never handed a different one.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="version"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Skill>> GetAsResponseAsync(
            string skillId,
            int? version = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}