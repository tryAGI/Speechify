#nullable enable

namespace Speechify
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Project Stats<br/>
        /// What this project contains: a live count of every resource kind<br/>
        /// grouped under it. Credentials pinned to the project are deliberately<br/>
        /// not counted here, because listing API keys and service accounts is an<br/>
        /// account-level operation with its own authentication; use those<br/>
        /// endpoints directly. A derived resource (a conversation, caller, agent<br/>
        /// test, or batch call) counts against the project it was created in,<br/>
        /// even if its agent has since moved to another project. Returns 404 for<br/>
        /// missing or foreign-workspace projects.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ProjectStats> StatsAsync(
            string projectId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Project Stats<br/>
        /// What this project contains: a live count of every resource kind<br/>
        /// grouped under it. Credentials pinned to the project are deliberately<br/>
        /// not counted here, because listing API keys and service accounts is an<br/>
        /// account-level operation with its own authentication; use those<br/>
        /// endpoints directly. A derived resource (a conversation, caller, agent<br/>
        /// test, or batch call) counts against the project it was created in,<br/>
        /// even if its agent has since moved to another project. Returns 404 for<br/>
        /// missing or foreign-workspace projects.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ProjectStats>> StatsAsResponseAsync(
            string projectId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}