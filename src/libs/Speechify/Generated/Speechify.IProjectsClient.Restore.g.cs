#nullable enable

namespace Speechify
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Restore Project<br/>
        /// Walk back a purge. A purged project is recoverable for 30 days: its<br/>
        /// row and its contents are kept, hidden from every list and read, and<br/>
        /// permanently deleted only once the window expires.<br/>
        /// **What comes back:** the project and its resources - agents (with<br/>
        /// their tests), knowledge bases, tools and audio assets - exactly the<br/>
        /// rows the purge removed. A resource you had deleted yourself before the<br/>
        /// purge stays deleted.<br/>
        /// **What does NOT come back, on purpose:** every credential the purge<br/>
        /// revoked stays revoked, and every grant it cleared stays cleared. API<br/>
        /// keys and service accounts pinned to the project are not re-issued,<br/>
        /// vault credentials and webhook endpoints scoped to it are not<br/>
        /// undeleted, and member grants and pending-invite scopes are not<br/>
        /// restored. Bringing a credential or a grant back would re-grant access<br/>
        /// somebody deliberately ended, so the restore reports them under<br/>
        /// `still_revoked` instead. Re-create the credentials and re-grant the<br/>
        /// members the project still needs.<br/>
        /// The project returns ARCHIVED, the state it was purged from, so nothing<br/>
        /// dispatches or bills inside it until you unarchive it.<br/>
        /// Refused with `409 project_not_purged` when the project was never<br/>
        /// purged, `409 project_restore_window_expired` once the 30 days have<br/>
        /// passed, and `409 project_name_taken` when another project has taken<br/>
        /// this one's name since the purge (a purge frees the name immediately -<br/>
        /// rename the project holding it, then restore).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ProjectRestore> RestoreAsync(
            string projectId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore Project<br/>
        /// Walk back a purge. A purged project is recoverable for 30 days: its<br/>
        /// row and its contents are kept, hidden from every list and read, and<br/>
        /// permanently deleted only once the window expires.<br/>
        /// **What comes back:** the project and its resources - agents (with<br/>
        /// their tests), knowledge bases, tools and audio assets - exactly the<br/>
        /// rows the purge removed. A resource you had deleted yourself before the<br/>
        /// purge stays deleted.<br/>
        /// **What does NOT come back, on purpose:** every credential the purge<br/>
        /// revoked stays revoked, and every grant it cleared stays cleared. API<br/>
        /// keys and service accounts pinned to the project are not re-issued,<br/>
        /// vault credentials and webhook endpoints scoped to it are not<br/>
        /// undeleted, and member grants and pending-invite scopes are not<br/>
        /// restored. Bringing a credential or a grant back would re-grant access<br/>
        /// somebody deliberately ended, so the restore reports them under<br/>
        /// `still_revoked` instead. Re-create the credentials and re-grant the<br/>
        /// members the project still needs.<br/>
        /// The project returns ARCHIVED, the state it was purged from, so nothing<br/>
        /// dispatches or bills inside it until you unarchive it.<br/>
        /// Refused with `409 project_not_purged` when the project was never<br/>
        /// purged, `409 project_restore_window_expired` once the 30 days have<br/>
        /// passed, and `409 project_name_taken` when another project has taken<br/>
        /// this one's name since the purge (a purge frees the name immediately -<br/>
        /// rename the project holding it, then restore).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ProjectRestore>> RestoreAsResponseAsync(
            string projectId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}