#nullable enable

namespace Speechify
{
    public partial interface ICredentialsClient
    {
        /// <summary>
        /// Create Credential<br/>
        /// Create a credential in the caller's workspace vault. `config` must<br/>
        /// carry exactly the one kind-specific block named by `kind` (e.g.<br/>
        /// `kind=bearer` requires `config.bearer`). Names are unique per<br/>
        /// workspace among active credentials. The response never carries the<br/>
        /// secret back: it returns the masked config with `*_set` markers.<br/>
        /// This is the first step of connecting an MCP server or a vendor's REST<br/>
        /// API: reference the returned `id` as `auth.credential_id` on an `mcp`<br/>
        /// or `openapi` tool (and on `import-openapi` when the vendor's document<br/>
        /// sits behind the same auth). A credential with no `project_id` is<br/>
        /// shared by every project; one scoped to a project can only back tools<br/>
        /// in that project. See `CredentialKind` for what each kind backs.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Credential> CreateAsync(

            global::Speechify.CreateCredentialRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Credential<br/>
        /// Create a credential in the caller's workspace vault. `config` must<br/>
        /// carry exactly the one kind-specific block named by `kind` (e.g.<br/>
        /// `kind=bearer` requires `config.bearer`). Names are unique per<br/>
        /// workspace among active credentials. The response never carries the<br/>
        /// secret back: it returns the masked config with `*_set` markers.<br/>
        /// This is the first step of connecting an MCP server or a vendor's REST<br/>
        /// API: reference the returned `id` as `auth.credential_id` on an `mcp`<br/>
        /// or `openapi` tool (and on `import-openapi` when the vendor's document<br/>
        /// sits behind the same auth). A credential with no `project_id` is<br/>
        /// shared by every project; one scoped to a project can only back tools<br/>
        /// in that project. See `CredentialKind` for what each kind backs.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Credential>> CreateAsResponseAsync(

            global::Speechify.CreateCredentialRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Credential<br/>
        /// Create a credential in the caller's workspace vault. `config` must<br/>
        /// carry exactly the one kind-specific block named by `kind` (e.g.<br/>
        /// `kind=bearer` requires `config.bearer`). Names are unique per<br/>
        /// workspace among active credentials. The response never carries the<br/>
        /// secret back: it returns the masked config with `*_set` markers.<br/>
        /// This is the first step of connecting an MCP server or a vendor's REST<br/>
        /// API: reference the returned `id` as `auth.credential_id` on an `mcp`<br/>
        /// or `openapi` tool (and on `import-openapi` when the vendor's document<br/>
        /// sits behind the same auth). A credential with no `project_id` is<br/>
        /// shared by every project; one scoped to a project can only back tools<br/>
        /// in that project. See `CredentialKind` for what each kind backs.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="name">
        /// Human-readable label, unique per workspace.
        /// </param>
        /// <param name="projectId">
        /// Optional project to scope this credential to (prefixed<br/>
        /// `proj_...` id): a scoped credential is referenceable only from<br/>
        /// tools in that project. Omit (or null) for workspace-shared -<br/>
        /// usable from every project. An unknown id returns 404<br/>
        /// project_not_found. A project-pinned API key creates into its<br/>
        /// own project and cannot name the shared tier.
        /// </param>
        /// <param name="kind">
        /// Discriminates the auth flow a credential carries. The matching<br/>
        /// `config.&lt;kind&gt;` block is the one that must be populated, and the only<br/>
        /// one.<br/>
        /// - `oauth2_client_credentials`: a `client_id` and `client_secret` the<br/>
        ///   platform exchanges at the vendor's `token_url` for a short-lived<br/>
        ///   access token (the OAuth2 client-credentials flow). Backs an `mcp` or<br/>
        ///   `openapi` tool whose `auth.type` is `oauth2_client_credentials`.<br/>
        /// - `bearer`: a static token sent as `Authorization: Bearer &lt;token&gt;`.<br/>
        ///   Backs an `mcp` or `openapi` tool whose `auth.type` is `bearer`, an<br/>
        ///   agent's custom LLM endpoint key, a custom model's key, and a<br/>
        ///   messaging channel's bot token.<br/>
        /// - `shared_secret`: a secret that is never sent anywhere; an inbound<br/>
        ///   callback's signature is verified against it, such as a messaging<br/>
        ///   channel's signing secret.<br/>
        /// - `oauth2_jwt`: a signing key for the JWT-bearer flow (RFC 7523).<br/>
        /// - `basic`: a username and password.<br/>
        /// - `custom_headers`: a set of header names and values.<br/>
        /// The vault stores `oauth2_jwt`, `basic` and `custom_headers`, but no<br/>
        /// tool auth type references them yet: an `mcp` or `openapi` tool<br/>
        /// authenticates with `bearer` or `oauth2_client_credentials` only.
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
        global::System.Threading.Tasks.Task<global::Speechify.Credential> CreateAsync(
            string name,
            global::Speechify.CredentialKind kind,
            global::Speechify.CredentialConfig config,
            string? speechifyVersion = default,
            string? projectId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}