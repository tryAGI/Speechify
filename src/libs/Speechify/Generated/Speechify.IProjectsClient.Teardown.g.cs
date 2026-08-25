#nullable enable

namespace Speechify
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Project Teardown Plan<br/>
        /// What deleting this project would do, in either mode, without doing<br/>
        /// it: whether a purge is available right now (`archived` and<br/>
        /// `purge_available`), every row holding the project open and which<br/>
        /// delete modes it refuses, what a purge would remove (a count per kind<br/>
        /// and a bounded sample of names), and the operational records a purge<br/>
        /// keeps. Nothing is mutated. Takes the same permission as the delete.<br/>
        /// Returns 404 for missing or foreign-workspace projects.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ProjectTeardown> TeardownAsync(
            string projectId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Project Teardown Plan<br/>
        /// What deleting this project would do, in either mode, without doing<br/>
        /// it: whether a purge is available right now (`archived` and<br/>
        /// `purge_available`), every row holding the project open and which<br/>
        /// delete modes it refuses, what a purge would remove (a count per kind<br/>
        /// and a bounded sample of names), and the operational records a purge<br/>
        /// keeps. Nothing is mutated. Takes the same permission as the delete.<br/>
        /// Returns 404 for missing or foreign-workspace projects.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ProjectTeardown>> TeardownAsResponseAsync(
            string projectId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}