
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One pre-shared secret. Unlike every other credential kind it is never<br/>
    /// placed on an outbound request: it is the key an INBOUND callback's<br/>
    /// signature is verified against, which is how a messaging provider<br/>
    /// authenticates itself to a channel front door.
    /// </summary>
    public sealed partial class SharedSecretConfig
    {
        /// <summary>
        /// The shared secret, for example a Slack app's signing secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSecretConfig" /> class.
        /// </summary>
        /// <param name="secret">
        /// The shared secret, for example a Slack app's signing secret.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedSecretConfig(
            string secret)
        {
            this.Secret = secret ?? throw new global::System.ArgumentNullException(nameof(secret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSecretConfig" /> class.
        /// </summary>
        public SharedSecretConfig()
        {
        }

    }
}