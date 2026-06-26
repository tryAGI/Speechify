
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialConfigViewBearer
    {
        /// <summary>
        /// Whether a bearer token is stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_set")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TokenSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigViewBearer" /> class.
        /// </summary>
        /// <param name="tokenSet">
        /// Whether a bearer token is stored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialConfigViewBearer(
            bool tokenSet)
        {
            this.TokenSet = tokenSet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigViewBearer" /> class.
        /// </summary>
        public CredentialConfigViewBearer()
        {
        }

    }
}