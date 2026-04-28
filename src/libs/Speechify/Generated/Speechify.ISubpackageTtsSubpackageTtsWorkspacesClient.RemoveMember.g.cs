#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsWorkspacesClient
    {
        /// <summary>
        /// Remove Member<br/>
        /// Remove a member from the current workspace. Owner or admin<br/>
        /// only. The caller cannot remove themselves — use<br/>
        /// `POST /v1/tenants/current/members/leave` instead.
        /// </summary>
        /// <param name="userUid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveMemberAsync(
            string userUid,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}