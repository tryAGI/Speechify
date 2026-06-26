
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The masked, read-safe projection of a credential's config. Returned<br/>
    /// on every read (list / get / create / rotate response). Non-secret<br/>
    /// fields (token URLs, client ids, issuer, header names) pass through;<br/>
    /// each secret is replaced by a `*_set` boolean. Secret values are never<br/>
    /// returned — to change one, rotate it via `PATCH /v1/credentials/{id}`.<br/>
    /// Exactly one block is populated, matching the credential's `kind`.
    /// </summary>
    public sealed partial class CredentialConfigView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2_client_credentials")]
        public global::Speechify.CredentialConfigViewOauth2ClientCredentials? Oauth2ClientCredentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2_jwt")]
        public global::Speechify.CredentialConfigViewOauth2Jwt? Oauth2Jwt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basic")]
        public global::Speechify.CredentialConfigViewBasic? Basic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bearer")]
        public global::Speechify.CredentialConfigViewBearer? Bearer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_headers")]
        public global::Speechify.CredentialConfigViewCustomHeaders? CustomHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigView" /> class.
        /// </summary>
        /// <param name="oauth2ClientCredentials"></param>
        /// <param name="oauth2Jwt"></param>
        /// <param name="basic"></param>
        /// <param name="bearer"></param>
        /// <param name="customHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialConfigView(
            global::Speechify.CredentialConfigViewOauth2ClientCredentials? oauth2ClientCredentials,
            global::Speechify.CredentialConfigViewOauth2Jwt? oauth2Jwt,
            global::Speechify.CredentialConfigViewBasic? basic,
            global::Speechify.CredentialConfigViewBearer? bearer,
            global::Speechify.CredentialConfigViewCustomHeaders? customHeaders)
        {
            this.Oauth2ClientCredentials = oauth2ClientCredentials;
            this.Oauth2Jwt = oauth2Jwt;
            this.Basic = basic;
            this.Bearer = bearer;
            this.CustomHeaders = customHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigView" /> class.
        /// </summary>
        public CredentialConfigView()
        {
        }

    }
}