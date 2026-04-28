#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsWorkspacesClient
    {
        /// <summary>
        /// Create Invite<br/>
        /// Create an invite to the current workspace. Owner or admin only.<br/>
        /// The response contains the invite token ONCE — subsequent list<br/>
        /// calls redact it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsInvite> CreateInviteAsync(

            global::Speechify.TtsCreateInviteRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Invite<br/>
        /// Create an invite to the current workspace. Owner or admin only.<br/>
        /// The response contains the invite token ONCE — subsequent list<br/>
        /// calls redact it.
        /// </summary>
        /// <param name="email">
        /// Email of the person to invite. Validated as an RFC 5322 address.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsInvite> CreateInviteAsync(
            string email,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}