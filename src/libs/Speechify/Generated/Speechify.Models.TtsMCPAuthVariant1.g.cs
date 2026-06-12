
#nullable enable

namespace Speechify
{
    /// <summary>
    /// none variant
    /// </summary>
    public sealed partial class TtsMCPAuthVariant1
    {
        /// <summary>
        /// Discriminator value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsMCPAuthVariant1TypeJsonConverter))]
        public global::Speechify.TtsMCPAuthVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsMCPAuthVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// Discriminator value: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsMCPAuthVariant1(
            global::Speechify.TtsMCPAuthVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsMCPAuthVariant1" /> class.
        /// </summary>
        public TtsMCPAuthVariant1()
        {
        }

    }
}