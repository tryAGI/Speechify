
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
        /// Discriminates the auth flow a credential carries. The matching<br/>
        /// `config.&lt;kind&gt;` block is the one that must be populated.
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
        /// `config.&lt;kind&gt;` block is the one that must be populated.
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
        public CreateCredentialRequest(
            string name,
            global::Speechify.CredentialKind kind,
            global::Speechify.CredentialConfig config)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
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