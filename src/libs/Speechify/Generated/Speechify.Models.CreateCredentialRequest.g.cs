
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/credentials`.
    /// </summary>
    public sealed partial class CreateCredentialRequest
    {
        /// <summary>
        /// Human-readable label, unique per workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional project to scope this credential to (prefixed<br/>
        /// `proj_...` id): a scoped credential is referenceable only from<br/>
        /// tools in that project. Omit (or null) for workspace-shared -<br/>
        /// usable from every project. An unknown id returns 404<br/>
        /// project_not_found. A project-pinned API key creates into its<br/>
        /// own project and cannot name the shared tier.
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
        /// Kind-specific credential payload, used on WRITES only (create and<br/>
        /// rotate). Exactly one block is populated — the one named by the<br/>
        /// credential's `kind`. The secret fields are write-only: they are<br/>
        /// accepted here but are NEVER returned on reads — a read returns the<br/>
        /// masked `CredentialConfigView` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.CredentialConfig Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCredentialRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable label, unique per workspace.
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
        /// <param name="projectId">
        /// Optional project to scope this credential to (prefixed<br/>
        /// `proj_...` id): a scoped credential is referenceable only from<br/>
        /// tools in that project. Omit (or null) for workspace-shared -<br/>
        /// usable from every project. An unknown id returns 404<br/>
        /// project_not_found. A project-pinned API key creates into its<br/>
        /// own project and cannot name the shared tier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCredentialRequest(
            string name,
            global::Speechify.CredentialKind kind,
            global::Speechify.CredentialConfig config,
            string? projectId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId;
            this.Kind = kind;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCredentialRequest" /> class.
        /// </summary>
        public CreateCredentialRequest()
        {
        }

    }
}