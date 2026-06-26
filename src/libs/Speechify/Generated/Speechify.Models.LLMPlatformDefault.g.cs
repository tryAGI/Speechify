
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The provider/model pair an agent left on the "Platform default" picker<br/>
    /// entry resolves to at dispatch time. Introduced 2026-06-25 (pin<br/>
    /// `Speechify-Version: 2026-06-24` or earlier to receive the previous flat<br/>
    /// `platform_default_provider` / `platform_default_model` fields instead).
    /// </summary>
    public sealed partial class LLMPlatformDefault
    {
        /// <summary>
        /// Provider the "Platform default" picker entry resolves to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Model the "Platform default" picker entry resolves to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMPlatformDefault" /> class.
        /// </summary>
        /// <param name="provider">
        /// Provider the "Platform default" picker entry resolves to.
        /// </param>
        /// <param name="model">
        /// Model the "Platform default" picker entry resolves to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMPlatformDefault(
            string provider,
            string model)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMPlatformDefault" /> class.
        /// </summary>
        public LLMPlatformDefault()
        {
        }

    }
}