#nullable enable

namespace Speechify
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Update Team<br/>
        /// Update a team's name, description, manager, and/or members. Merge-patch<br/>
        /// semantics: an omitted field is left unchanged, `manager_agent_id: null`<br/>
        /// clears the manager, and a `members` array replaces the whole roster.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Team> UpdateAsync(
            string teamId,

            global::Speechify.UpdateTeamRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Team<br/>
        /// Update a team's name, description, manager, and/or members. Merge-patch<br/>
        /// semantics: an omitted field is left unchanged, `manager_agent_id: null`<br/>
        /// clears the manager, and a `members` array replaces the whole roster.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Team>> UpdateAsResponseAsync(
            string teamId,

            global::Speechify.UpdateTeamRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Team<br/>
        /// Update a team's name, description, manager, and/or members. Merge-patch<br/>
        /// semantics: an omitted field is left unchanged, `manager_agent_id: null`<br/>
        /// clears the manager, and a `members` array replaces the whole roster.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="managerAgentId"></param>
        /// <param name="members"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Team> UpdateAsync(
            string teamId,
            string? speechifyVersion = default,
            string? name = default,
            string? description = default,
            string? managerAgentId = default,
            global::System.Collections.Generic.IList<global::Speechify.TeamMemberInput>? members = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}