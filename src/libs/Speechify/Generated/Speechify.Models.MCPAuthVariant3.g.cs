
#nullable enable

namespace Speechify
{
    /// <summary>
    /// OAuth2 client-credentials auth for an MCP server or an OpenAPI tool's<br/>
    /// REST API, and for fetching an OpenAPI document behind that auth.<br/>
    /// References a workspace credential of kind `oauth2_client_credentials`<br/>
    /// by id. The platform mints an access token from the credential's<br/>
    /// `token_url`, sends it as `Authorization: Bearer &lt;token&gt;`, and reuses it<br/>
    /// until it nears expiry; the `token_url`, `client_id`, `client_secret`<br/>
    /// and `scopes` live in the vault and are resolved server-side, never<br/>
    /// inlined on the tool.
    /// </summary>
    public sealed partial class MCPAuthVariant3
    {
        /// <summary>
        /// Discriminator value: oauth2_client_credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.MCPAuthVariant3TypeJsonConverter))]
        public global::Speechify.MCPAuthVariant3Type Type { get; set; }

        /// <summary>
        /// `cred_&lt;crockford&gt;` id of an `oauth2_client_credentials` credential<br/>
        /// in the workspace vault. Create it first via `POST /v1/credentials`.<br/>
        /// It must be workspace-shared or in the tool's own project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CredentialId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPAuthVariant3" /> class.
        /// </summary>
        /// <param name="credentialId">
        /// `cred_&lt;crockford&gt;` id of an `oauth2_client_credentials` credential<br/>
        /// in the workspace vault. Create it first via `POST /v1/credentials`.<br/>
        /// It must be workspace-shared or in the tool's own project.
        /// </param>
        /// <param name="type">
        /// Discriminator value: oauth2_client_credentials
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPAuthVariant3(
            string credentialId,
            global::Speechify.MCPAuthVariant3Type type)
        {
            this.Type = type;
            this.CredentialId = credentialId ?? throw new global::System.ArgumentNullException(nameof(credentialId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPAuthVariant3" /> class.
        /// </summary>
        public MCPAuthVariant3()
        {
        }

    }
}