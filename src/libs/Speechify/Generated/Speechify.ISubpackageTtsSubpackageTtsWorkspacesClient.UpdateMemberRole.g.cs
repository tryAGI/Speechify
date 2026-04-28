#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsWorkspacesClient
    {
        /// <summary>
        /// Update Member Role<br/>
        /// Change a member's role. Owner only — admins may add or remove<br/>
        /// members but may not change roles. Refused with 409 when<br/>
        /// demoting the last remaining owner.
        /// </summary>
        /// <param name="userUid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsMember> UpdateMemberRoleAsync(
            string userUid,

            global::Speechify.TtsUpdateMemberRoleRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Member Role<br/>
        /// Change a member's role. Owner only — admins may add or remove<br/>
        /// members but may not change roles. Refused with 409 when<br/>
        /// demoting the last remaining owner.
        /// </summary>
        /// <param name="userUid"></param>
        /// <param name="role">
        /// Member's role within the workspace.<br/>
        /// - `owner`  - Full control, including deleting the workspace.<br/>
        /// - `admin`  - Manage members and invites; cannot change roles.<br/>
        /// - `member` - Standard access, no administrative rights.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsMember> UpdateMemberRoleAsync(
            string userUid,
            global::Speechify.TtsMemberRole role,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}