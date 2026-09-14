
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Bearer auth for an MCP server or an OpenAPI tool's REST API, and for<br/>
    /// fetching an OpenAPI document behind that auth. References a workspace<br/>
    /// credential of kind `bearer` by id; its token is sent as<br/>
    /// `Authorization: Bearer &lt;token&gt;`. The secret lives in the credentials<br/>
    /// vault and is resolved server-side when a call is made, never inlined<br/>
    /// on the tool.
    /// </summary>
    public sealed partial class MCPAuthVariant2
    {
        /// <summary>
        /// Discriminator value: bearer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.MCPAuthVariant2TypeJsonConverter))]
        public global::Speechify.MCPAuthVariant2Type Type { get; set; }

        /// <summary>
        /// `cred_&lt;crockford&gt;` id of a `bearer` credential in the workspace<br/>
        /// vault. Create the credential first via `POST /v1/credentials`,<br/>
        /// then reference it here. It must be workspace-shared or in the<br/>
        /// tool's own project.
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
        /// Initializes a new instance of the <see cref="MCPAuthVariant2" /> class.
        /// </summary>
        /// <param name="credentialId">
        /// `cred_&lt;crockford&gt;` id of a `bearer` credential in the workspace<br/>
        /// vault. Create the credential first via `POST /v1/credentials`,<br/>
        /// then reference it here. It must be workspace-shared or in the<br/>
        /// tool's own project.
        /// </param>
        /// <param name="type">
        /// Discriminator value: bearer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPAuthVariant2(
            string credentialId,
            global::Speechify.MCPAuthVariant2Type type)
        {
            this.Type = type;
            this.CredentialId = credentialId ?? throw new global::System.ArgumentNullException(nameof(credentialId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPAuthVariant2" /> class.
        /// </summary>
        public MCPAuthVariant2()
        {
        }

    }
}