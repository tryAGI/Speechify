#nullable enable

namespace Speechify
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Create Team<br/>
        /// Compose a team: a `manager_agent_id` that orchestrates plus the<br/>
        /// `members` it delegates to. The manager and every member must be an<br/>
        /// agent in the caller's workspace. Idempotent via `Idempotency-Key`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Team> CreateAsync(

            global::Speechify.CreateTeamRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Team<br/>
        /// Compose a team: a `manager_agent_id` that orchestrates plus the<br/>
        /// `members` it delegates to. The manager and every member must be an<br/>
        /// agent in the caller's workspace. Idempotent via `Idempotency-Key`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Team>> CreateAsResponseAsync(

            global::Speechify.CreateTeamRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Team<br/>
        /// Compose a team: a `manager_agent_id` that orchestrates plus the<br/>
        /// `members` it delegates to. The manager and every member must be an<br/>
        /// agent in the caller's workspace. Idempotent via `Idempotency-Key`.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="projectId">
        /// The project to create it in. A project-pinned credential creates<br/>
        /// into its own project regardless, and naming a different one is<br/>
        /// refused rather than silently redirected. Omit for no project.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="managerAgentId"></param>
        /// <param name="members"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Team> CreateAsync(
            string name,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? projectId = default,
            string? description = default,
            string? managerAgentId = default,
            global::System.Collections.Generic.IList<global::Speechify.TeamMemberInput>? members = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}