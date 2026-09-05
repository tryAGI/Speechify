#nullable enable

namespace Speechify
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Update Skill<br/>
        /// Update a skill. The two halves behave differently on purpose:<br/>
        /// `name` and `description` are labels and edit in place, while<br/>
        /// `instructions`, `tool_ids`, `knowledge_base_ids` and `variables` are<br/>
        /// the body - touching any of them MINTS A NEW VERSION and leaves every<br/>
        /// existing attachment on the version it pinned. Agents move when someone<br/>
        /// moves them, never because the catalog changed.<br/>
        /// A present list replaces rather than appends.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Skill> UpdateAsync(
            string skillId,

            global::Speechify.UpdateSkillRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Skill<br/>
        /// Update a skill. The two halves behave differently on purpose:<br/>
        /// `name` and `description` are labels and edit in place, while<br/>
        /// `instructions`, `tool_ids`, `knowledge_base_ids` and `variables` are<br/>
        /// the body - touching any of them MINTS A NEW VERSION and leaves every<br/>
        /// existing attachment on the version it pinned. Agents move when someone<br/>
        /// moves them, never because the catalog changed.<br/>
        /// A present list replaces rather than appends.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Skill>> UpdateAsResponseAsync(
            string skillId,

            global::Speechify.UpdateSkillRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Skill<br/>
        /// Update a skill. The two halves behave differently on purpose:<br/>
        /// `name` and `description` are labels and edit in place, while<br/>
        /// `instructions`, `tool_ids`, `knowledge_base_ids` and `variables` are<br/>
        /// the body - touching any of them MINTS A NEW VERSION and leaves every<br/>
        /// existing attachment on the version it pinned. Agents move when someone<br/>
        /// moves them, never because the catalog changed.<br/>
        /// A present list replaces rather than appends.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="instructions"></param>
        /// <param name="toolIds"></param>
        /// <param name="knowledgeBaseIds"></param>
        /// <param name="variables"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Skill> UpdateAsync(
            string skillId,
            string? speechifyVersion = default,
            string? name = default,
            string? description = default,
            string? instructions = default,
            global::System.Collections.Generic.IList<string>? toolIds = default,
            global::System.Collections.Generic.IList<string>? knowledgeBaseIds = default,
            global::System.Collections.Generic.Dictionary<string, string>? variables = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}