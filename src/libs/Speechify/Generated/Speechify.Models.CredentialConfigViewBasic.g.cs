
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialConfigViewBasic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Whether a password is stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password_set")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PasswordSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigViewBasic" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="passwordSet">
        /// Whether a password is stored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialConfigViewBasic(
            string username,
            bool passwordSet)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.PasswordSet = passwordSet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialConfigViewBasic" /> class.
        /// </summary>
        public CredentialConfigViewBasic()
        {
        }

    }
}