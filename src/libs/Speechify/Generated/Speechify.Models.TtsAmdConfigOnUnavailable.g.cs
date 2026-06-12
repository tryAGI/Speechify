
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Action when AMD returns category=machine-unavailable (mailbox full or disconnected).
    /// </summary>
    public sealed partial class TtsAmdConfigOnUnavailable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsAmdConfigOnUnavailableActionJsonConverter))]
        public global::Speechify.TtsAmdConfigOnUnavailableAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAmdConfigOnUnavailable" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAmdConfigOnUnavailable(
            global::Speechify.TtsAmdConfigOnUnavailableAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAmdConfigOnUnavailable" /> class.
        /// </summary>
        public TtsAmdConfigOnUnavailable()
        {
        }

    }
}