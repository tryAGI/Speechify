#nullable enable

namespace Speechify
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create Project<br/>
        /// Create a project in the caller's workspace. Names are unique per<br/>
        /// workspace (case-insensitive). A workspace holds at most 100 live<br/>
        /// projects; at the cap the create refuses with<br/>
        /// `409 project_limit_reached` until one is deleted.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Project> CreateAsync(

            global::Speechify.CreateProjectRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Project<br/>
        /// Create a project in the caller's workspace. Names are unique per<br/>
        /// workspace (case-insensitive). A workspace holds at most 100 live<br/>
        /// projects; at the cap the create refuses with<br/>
        /// `409 project_limit_reached` until one is deleted.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Project>> CreateAsResponseAsync(

            global::Speechify.CreateProjectRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Project<br/>
        /// Create a project in the caller's workspace. Names are unique per<br/>
        /// workspace (case-insensitive). A workspace holds at most 100 live<br/>
        /// projects; at the cap the create refuses with<br/>
        /// `409 project_limit_reached` until one is deleted.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="name">
        /// Project name; unique per workspace (case-insensitive),<br/>
        /// surrounding whitespace is trimmed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Project> CreateAsync(
            string name,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}