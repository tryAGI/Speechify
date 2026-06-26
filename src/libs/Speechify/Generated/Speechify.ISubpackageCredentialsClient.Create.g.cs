#nullable enable

namespace Speechify
{
    public partial interface ISubpackageCredentialsClient
    {
        /// <summary>
        /// Create Credential<br/>
        /// Create a credential in the caller's workspace. `config` must<br/>
        /// carry exactly the one kind-specific block named by `kind` (e.g.<br/>
        /// `kind=bearer` requires `config.bearer`). Names are unique per<br/>
        /// workspace among active credentials.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Credential> CreateAsync(

            global::Speechify.CreateCredentialRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Credential<br/>
        /// Create a credential in the caller's workspace. `config` must<br/>
        /// carry exactly the one kind-specific block named by `kind` (e.g.<br/>
        /// `kind=bearer` requires `config.bearer`). Names are unique per<br/>
        /// workspace among active credentials.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Credential>> CreateAsResponseAsync(

            global::Speechify.CreateCredentialRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Credential<br/>
        /// Create a credential in the caller's workspace. `config` must<br/>
        /// carry exactly the one kind-specific block named by `kind` (e.g.<br/>
        /// `kind=bearer` requires `config.bearer`). Names are unique per<br/>
        /// workspace among active credentials.
        /// </summary>
        /// <param name="name">
        /// Human-readable label, unique per workspace.
        /// </param>
        /// <param name="kind">
        /// Discriminates the auth flow a credential carries. The matching<br/>
        /// `config.&lt;kind&gt;` block is the one that must be populated.
        /// </param>
        /// <param name="config">
        /// Kind-specific credential payload. Exactly one block is<br/>
        /// populated — the one named by the credential's `kind`. The<br/>
        /// block IS the secret; it is echoed back decrypted on reads.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Credential> CreateAsync(
            string name,
            global::Speechify.CredentialKind kind,
            global::Speechify.CredentialConfig config,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}