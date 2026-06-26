
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A workspace-shared secret in the credentials vault. Tools (and<br/>
    /// future MCP servers) reference a credential by id rather than<br/>
    /// inlining a secret per row, so one OAuth / Basic / Bearer /<br/>
    /// headers blob is reused across many tools and rotated centrally.
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
        /// Discriminates the auth flow a credential carries. The matching<br/>
        /// `config.&lt;kind&gt;` block is the one that must be populated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.CredentialKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.CredentialKind Kind { get; set; }

        /// <summary>
        /// Kind-specific credential payload. Exactly one block is<br/>
        /// populated — the one named by the credential's `kind`. The<br/>
        /// block IS the secret; it is echoed back decrypted on reads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.CredentialConfig Config { get; set; }

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
        /// `config.&lt;kind&gt;` block is the one that must be populated.
        /// </param>
        /// <param name="config">
        /// Kind-specific credential payload. Exactly one block is<br/>
        /// populated — the one named by the credential's `kind`. The<br/>
        /// block IS the secret; it is echoed back decrypted on reads.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Credential(
            string id,
            string name,
            global::Speechify.CredentialKind kind,
            global::Speechify.CredentialConfig config,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
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