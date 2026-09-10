
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HostedAPIUserTokenSecret
    {
        /// <summary>
        /// The plaintext signing secret, present on this response only. Sign end-user tokens with it (HS256).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Secret { get; set; }

        /// <summary>
        /// The masked form every later read shows as `user_token_secret_hint`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_hint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretHint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIUserTokenSecret" /> class.
        /// </summary>
        /// <param name="secret">
        /// The plaintext signing secret, present on this response only. Sign end-user tokens with it (HS256).
        /// </param>
        /// <param name="secretHint">
        /// The masked form every later read shows as `user_token_secret_hint`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedAPIUserTokenSecret(
            string secret,
            string secretHint)
        {
            this.Secret = secret ?? throw new global::System.ArgumentNullException(nameof(secret));
            this.SecretHint = secretHint ?? throw new global::System.ArgumentNullException(nameof(secretHint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIUserTokenSecret" /> class.
        /// </summary>
        public HostedAPIUserTokenSecret()
        {
        }

    }
}