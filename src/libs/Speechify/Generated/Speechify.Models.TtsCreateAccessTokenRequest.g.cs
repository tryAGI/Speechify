
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsCreateAccessTokenRequest
    {
        /// <summary>
        /// in: body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsCreateAccessTokenRequestGrantTypeJsonConverter))]
        public global::Speechify.TtsCreateAccessTokenRequestGrantType GrantType { get; set; }

        /// <summary>
        /// The scope, or a space-delimited list of scopes the token is requested for<br/>
        /// in: body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsCreateAccessTokenRequestScopeJsonConverter))]
        public global::Speechify.TtsCreateAccessTokenRequestScope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateAccessTokenRequest" /> class.
        /// </summary>
        /// <param name="grantType">
        /// in: body
        /// </param>
        /// <param name="scope">
        /// The scope, or a space-delimited list of scopes the token is requested for<br/>
        /// in: body
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateAccessTokenRequest(
            global::Speechify.TtsCreateAccessTokenRequestGrantType grantType,
            global::Speechify.TtsCreateAccessTokenRequestScope? scope)
        {
            this.GrantType = grantType;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateAccessTokenRequest" /> class.
        /// </summary>
        public TtsCreateAccessTokenRequest()
        {
        }
    }
}