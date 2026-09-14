
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `PATCH /v1/credentials/{credential_id}`. Rotates a credential's secret,<br/>
    /// renames it, and/or moves it between the workspace-shared tier and a<br/>
    /// project, in place, keeping the same id so every referencing<br/>
    /// config picks up the change. All fields are optional; provide at least<br/>
    /// one. The kind is immutable — a rotated `config` must populate the same<br/>
    /// block as the credential's existing kind.<br/>
    /// A rotated block must carry every required field again, and its<br/>
    /// optional fields keep their stored values when omitted: `scopes`,<br/>
    /// `audience` and `token_endpoint_auth_method` on<br/>
    /// `oauth2_client_credentials`, and `subject`, `scopes` and `key_id` on<br/>
    /// `oauth2_jwt`. So rotating a client secret alone never resets how the<br/>
    /// credential mints. Send an optional field empty (`""`, `[]`) or null to<br/>
    /// clear it; send `token_endpoint_auth_method: client_secret_post` to<br/>
    /// return to the default.
    /// </summary>
    public sealed partial class UpdateCredentialRequest
    {
        /// <summary>
        /// New human-readable label, unique per workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Move the credential between scopes: a `proj_...` id scopes it to<br/>
        /// that project, an explicit null makes it workspace-shared,<br/>
        /// omitted leaves it unchanged. Scoping to a project is refused<br/>
        /// with `409 cross_project_reference` while tools or agents outside<br/>
        /// that project still reference the credential (the response lists<br/>
        /// them); making it shared always succeeds. A project-pinned API<br/>
        /// key may only scope a credential to its own project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Kind-specific credential payload, used on WRITES only (create and<br/>
        /// rotate). Exactly one block is populated — the one named by the<br/>
        /// credential's `kind`. The secret fields are write-only: they are<br/>
        /// accepted here but are NEVER returned on reads — a read returns the<br/>
        /// masked `CredentialConfigView` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Speechify.CredentialConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCredentialRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCredentialRequest(
            string? name,
            string? projectId,
            global::Speechify.CredentialConfig? config)
        {
            this.Name = name;
            this.ProjectId = projectId;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCredentialRequest" /> class.
        /// </summary>
        public UpdateCredentialRequest()
        {
        }

    }
}