
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CredentialConfigViewSharedSecret
    {
        /// <summary>
        /// Whether a shared secret is stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_set")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SecretSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigViewSharedSecret" /> class.
        /// </summary>
        /// <param name="secretSet">
        /// Whether a shared secret is stored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialConfigViewSharedSecret(
            bool secretSet)
        {
            this.SecretSet = secretSet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigViewSharedSecret" /> class.
        /// </summary>
        public CredentialConfigViewSharedSecret()
        {
        }

    }
}