
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechStreamEventDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.SpeechStreamEventDiscriminatorTypeJsonConverter))]
        public global::Speechify.SpeechStreamEventDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStreamEventDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechStreamEventDiscriminator(
            global::Speechify.SpeechStreamEventDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStreamEventDiscriminator" /> class.
        /// </summary>
        public SpeechStreamEventDiscriminator()
        {
        }

    }
}