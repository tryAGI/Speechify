
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsAccessToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// Expiration time, in seconds from the issue time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public long? ExpiresIn { get; set; }

        /// <summary>
        /// The scope, or a space-delimited list of scopes the token is issued for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsAccessTokenScopeJsonConverter))]
        public global::Speechify.TtsAccessTokenScope? Scope { get; set; }

        /// <summary>
        /// Token type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsAccessTokenTokenTypeJsonConverter))]
        public global::Speechify.TtsAccessTokenTokenType? TokenType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAccessToken" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="expiresIn">
        /// Expiration time, in seconds from the issue time
        /// </param>
        /// <param name="scope">
        /// The scope, or a space-delimited list of scopes the token is issued for
        /// </param>
        /// <param name="tokenType">
        /// Token type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAccessToken(
            string? accessToken,
            long? expiresIn,
            global::Speechify.TtsAccessTokenScope? scope,
            global::Speechify.TtsAccessTokenTokenType? tokenType)
        {
            this.AccessToken = accessToken;
            this.ExpiresIn = expiresIn;
            this.Scope = scope;
            this.TokenType = tokenType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAccessToken" /> class.
        /// </summary>
        public TtsAccessToken()
        {
        }
    }
}