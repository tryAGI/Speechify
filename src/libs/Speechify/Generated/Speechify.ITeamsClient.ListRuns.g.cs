#nullable enable

namespace Speechify
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List Team Runs<br/>
        /// **List a team's runs**, newest first: the team's run history. Only the<br/>
        /// team's ROOT runs are returned - the ones started with `runTeam`. Each<br/>
        /// member's delegated child run is attributed to the member agent that ran<br/>
        /// it; read a run's children with `listRunChildren`.<br/>
        /// A run started directly against the team's manager agent (`createRun`) is<br/>
        /// NOT a team run and never appears here.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListAgentRunsResponse> ListRunsAsync(
            string teamId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Team Runs<br/>
        /// **List a team's runs**, newest first: the team's run history. Only the<br/>
        /// team's ROOT runs are returned - the ones started with `runTeam`. Each<br/>
        /// member's delegated child run is attributed to the member agent that ran<br/>
        /// it; read a run's children with `listRunChildren`.<br/>
        /// A run started directly against the team's manager agent (`createRun`) is<br/>
        /// NOT a team run and never appears here.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListAgentRunsResponse>> ListRunsAsResponseAsync(
            string teamId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}