#nullable enable

namespace Speechify
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Archive Project<br/>
        /// Archive a project. From then on nothing new starts or bills inside<br/>
        /// it: conversation and widget sessions, outbound and inbound calls,<br/>
        /// batch calls, test runs, knowledge-base imports, and synthesis or<br/>
        /// gateway requests on a credential pinned to the project are all<br/>
        /// refused with the coded `409 project_archived`. Work already in<br/>
        /// flight is left to finish. Everything in the project stays readable<br/>
        /// and its configuration stays editable, and the project still answers<br/>
        /// by id.<br/>
        /// Idempotent: archiving an archived project is a no-op. Reverse it<br/>
        /// with the unarchive operation.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ArchiveAsync(
            string projectId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Archive Project<br/>
        /// Archive a project. From then on nothing new starts or bills inside<br/>
        /// it: conversation and widget sessions, outbound and inbound calls,<br/>
        /// batch calls, test runs, knowledge-base imports, and synthesis or<br/>
        /// gateway requests on a credential pinned to the project are all<br/>
        /// refused with the coded `409 project_archived`. Work already in<br/>
        /// flight is left to finish. Everything in the project stays readable<br/>
        /// and its configuration stays editable, and the project still answers<br/>
        /// by id.<br/>
        /// Idempotent: archiving an archived project is a no-op. Reverse it<br/>
        /// with the unarchive operation.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> ArchiveAsResponseAsync(
            string projectId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}