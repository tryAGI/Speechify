
#nullable enable

namespace Speechify
{
    /// <summary>
    /// bearer variant
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
        /// Bearer token. Write-only — never echoed back on reads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// True when a bearer token is configured. Read-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_set")]
        public bool? TokenSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPAuthVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Discriminator value: bearer
        /// </param>
        /// <param name="token">
        /// Bearer token. Write-only — never echoed back on reads.
        /// </param>
        /// <param name="tokenSet">
        /// True when a bearer token is configured. Read-only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPAuthVariant2(
            global::Speechify.MCPAuthVariant2Type type,
            string? token,
            bool? tokenSet)
        {
            this.Type = type;
            this.Token = token;
            this.TokenSet = tokenSet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPAuthVariant2" /> class.
        /// </summary>
        public MCPAuthVariant2()
        {
        }

    }
}