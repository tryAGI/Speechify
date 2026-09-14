
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A secret in the workspace credentials vault. MCP and OpenAPI tools,<br/>
    /// custom LLM endpoints and messaging channels reference a credential by<br/>
    /// id rather than inlining a secret per row, so one secret is reused<br/>
    /// across many of them and rotated centrally.<br/>
    /// A credential is either workspace-shared (`project_id` null) -<br/>
    /// referenceable from every project - or scoped to exactly one<br/>
    /// project, referenceable only from tools in it.<br/>
    /// The vault is write-only: `config` here is the masked<br/>
    /// `CredentialConfigView` (non-secret fields plus `*_set` markers).<br/>
    /// Secret values are never returned; rotate them via<br/>
    /// `PATCH /v1/credentials/{credential_id}`.
    /// </summary>
    public sealed partial class Credential
    {
        /// <summary>
        /// Workspace-scoped credential identifier (prefixed external id).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable label, unique per workspace among active<br/>
        /// credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The project this credential is scoped to (prefixed external<br/>
        /// id). Null means workspace-shared - usable from every project.<br/>
        /// Credentials have no Default project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.CredentialKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.CredentialKind Kind { get; set; }

        /// <summary>
        /// The masked, read-safe projection of a credential's config. Returned<br/>
        /// on every read (list / get / create / rotate response). Non-secret<br/>
        /// fields (token URLs, client ids, issuer, header names) pass through;<br/>
        /// each secret is replaced by a `*_set` boolean. Secret values are never<br/>
        /// returned - to change one, rotate it via `PATCH /v1/credentials/{credential_id}`.<br/>
        /// Exactly one block is populated, matching the credential's `kind`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.CredentialConfigView Config { get; set; }

        /// <summary>
        /// Dependency tracking for a credential: the resources that reference it,<br/>
        /// so a rotate/delete can't silently break a live integration. `count` is<br/>
        /// the total; `references` lists them (empty when unreferenced).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.CredentialUsedBy UsedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Credential" /> class.
        /// </summary>
        /// <param name="id">
        /// Workspace-scoped credential identifier (prefixed external id).
        /// </param>
        /// <param name="name">
        /// Human-readable label, unique per workspace among active<br/>
        /// credentials.
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
        /// The masked, read-safe projection of a credential's config. Returned<br/>
        /// on every read (list / get / create / rotate response). Non-secret<br/>
        /// fields (token URLs, client ids, issuer, header names) pass through;<br/>
        /// each secret is replaced by a `*_set` boolean. Secret values are never<br/>
        /// returned - to change one, rotate it via `PATCH /v1/credentials/{credential_id}`.<br/>
        /// Exactly one block is populated, matching the credential's `kind`.
        /// </param>
        /// <param name="usedBy">
        /// Dependency tracking for a credential: the resources that reference it,<br/>
        /// so a rotate/delete can't silently break a live integration. `count` is<br/>
        /// the total; `references` lists them (empty when unreferenced).
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="projectId">
        /// The project this credential is scoped to (prefixed external<br/>
        /// id). Null means workspace-shared - usable from every project.<br/>
        /// Credentials have no Default project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Credential(
            string id,
            string name,
            global::Speechify.CredentialKind kind,
            global::Speechify.CredentialConfigView config,
            global::Speechify.CredentialUsedBy usedBy,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? projectId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId;
            this.Kind = kind;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.UsedBy = usedBy ?? throw new global::System.ArgumentNullException(nameof(usedBy));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Credential" /> class.
        /// </summary>
        public Credential()
        {
        }

    }
}