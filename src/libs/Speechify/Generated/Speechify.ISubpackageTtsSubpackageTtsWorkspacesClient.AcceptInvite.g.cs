#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsWorkspacesClient
    {
        /// <summary>
        /// Accept Invite<br/>
        /// Accept a workspace invite. The authenticated caller is joined<br/>
        /// to the invite's workspace as a member. Expired, revoked, or<br/>
        /// already-accepted tokens return 404 to avoid token enumeration.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsTenant> AcceptInviteAsync(
            string token,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}