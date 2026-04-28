#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsWorkspacesClient
    {
        /// <summary>
        /// Preview Invite<br/>
        /// Preview a workspace invite without authenticating. Returns the<br/>
        /// workspace name, inviter details, and expiry so the `/join/{token}`<br/>
        /// page can render before the recipient signs in. Anyone with the<br/>
        /// token can already accept, so this endpoint deliberately surfaces<br/>
        /// the same information a caller would see after accepting. Invalid<br/>
        /// tokens (unknown, expired, revoked, already-accepted, or pointing<br/>
        /// at a soft-deleted workspace) collapse to a single 404 to prevent<br/>
        /// enumeration.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsInvitePreview> PreviewInviteAsync(
            string token,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}