#nullable enable

namespace Speechify
{
    public partial interface ICredentialsClient
    {
        /// <summary>
        /// Update Credential<br/>
        /// Rotate a credential's secret and/or rename it, in place, keeping the<br/>
        /// same id so every referencing config picks up the change with no<br/>
        /// re-wiring. Because the vault is write-only, rotation is the only way<br/>
        /// to change a stored secret. The kind is immutable: a rotated `config`<br/>
        /// must populate the same block as the credential's existing kind.
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Credential> UpdateAsync(
            string credentialId,

            global::Speechify.UpdateCredentialRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Credential<br/>
        /// Rotate a credential's secret and/or rename it, in place, keeping the<br/>
        /// same id so every referencing config picks up the change with no<br/>
        /// re-wiring. Because the vault is write-only, rotation is the only way<br/>
        /// to change a stored secret. The kind is immutable: a rotated `config`<br/>
        /// must populate the same block as the credential's existing kind.
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Credential>> UpdateAsResponseAsync(
            string credentialId,

            global::Speechify.UpdateCredentialRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Credential<br/>
        /// Rotate a credential's secret and/or rename it, in place, keeping the<br/>
        /// same id so every referencing config picks up the change with no<br/>
        /// re-wiring. Because the vault is write-only, rotation is the only way<br/>
        /// to change a stored secret. The kind is immutable: a rotated `config`<br/>
        /// must populate the same block as the credential's existing kind.
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="name">
        /// New human-readable label, unique per workspace.
        /// </param>
        /// <param name="projectId">
        /// Move the credential between scopes: a `proj_...` id scopes it to<br/>
        /// that project, an explicit null makes it workspace-shared,<br/>
        /// omitted leaves it unchanged. Scoping to a project is refused<br/>
        /// with `409 cross_project_reference` while tools or agents outside<br/>
        /// that project still reference the credential (the response lists<br/>
        /// them); making it shared always succeeds. A project-pinned API<br/>
        /// key may only scope a credential to its own project.
        /// </param>
        /// <param name="config">
        /// Kind-specific credential payload, used on WRITES only (create and<br/>
        /// rotate). Exactly one block is populated — the one named by the<br/>
        /// credential's `kind`. The secret fields are write-only: they are<br/>
        /// accepted here but are NEVER returned on reads — a read returns the<br/>
        /// masked `CredentialConfigView` instead.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Credential> UpdateAsync(
            string credentialId,
            string? speechifyVersion = default,
            string? name = default,
            string? projectId = default,
            global::Speechify.CredentialConfig? config = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}