#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsWorkspacesClient
    {
        /// <summary>
        /// Transfer Workspace Owner<br/>
        /// Transfer ownership of the current workspace atomically. Promotes<br/>
        /// the target member to owner and demotes the caller to admin in a<br/>
        /// single transaction. Owner-only; admins cannot hand off a role<br/>
        /// they were never granted. Prefer this over two PATCH calls to<br/>
        /// `/v1/tenants/current/members/{user_uid}`: a sole-owner caller<br/>
        /// cannot demote themselves first without tripping the last-owner<br/>
        /// guard, which this endpoint sidesteps by promoting before<br/>
        /// demoting.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task TransferWorkspaceOwnerAsync(

            global::Speechify.TtsTransferOwnershipRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer Workspace Owner<br/>
        /// Transfer ownership of the current workspace atomically. Promotes<br/>
        /// the target member to owner and demotes the caller to admin in a<br/>
        /// single transaction. Owner-only; admins cannot hand off a role<br/>
        /// they were never granted. Prefer this over two PATCH calls to<br/>
        /// `/v1/tenants/current/members/{user_uid}`: a sole-owner caller<br/>
        /// cannot demote themselves first without tripping the last-owner<br/>
        /// guard, which this endpoint sidesteps by promoting before<br/>
        /// demoting.
        /// </summary>
        /// <param name="userUid">
        /// Firebase UID of the member who will become the new owner.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task TransferWorkspaceOwnerAsync(
            string userUid,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}