
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `PATCH /v1/credentials/{id}`. Rotates a credential's secret<br/>
    /// and/or renames it in place, keeping the same id so every referencing<br/>
    /// config picks up the change. Both fields are optional; provide at least<br/>
    /// one. The kind is immutable — a rotated `config` must populate the same<br/>
    /// block as the credential's existing kind.
    /// </summary>
    public sealed partial class UpdateCredentialRequest
    {
        /// <summary>
        /// New human-readable label, unique per workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
            global::Speechify.CredentialConfig? config)
        {
            this.Name = name;
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