
#nullable enable

namespace Speechify
{
    /// <summary>
    /// none variant
    /// </summary>
    public sealed partial class MCPAuthVariant1
    {
        /// <summary>
        /// Discriminator value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.MCPAuthVariant1TypeJsonConverter))]
        public global::Speechify.MCPAuthVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPAuthVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// Discriminator value: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPAuthVariant1(
            global::Speechify.MCPAuthVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPAuthVariant1" /> class.
        /// </summary>
        public MCPAuthVariant1()
        {
        }

    }
}