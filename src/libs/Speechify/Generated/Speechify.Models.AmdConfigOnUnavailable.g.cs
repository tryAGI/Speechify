
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Action when AMD returns category=machine-unavailable (mailbox full or disconnected).
    /// </summary>
    public sealed partial class AmdConfigOnUnavailable
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AmdConfigOnUnavailableActionJsonConverter))]
        public global::Speechify.AmdConfigOnUnavailableAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AmdConfigOnUnavailable" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AmdConfigOnUnavailable(
            global::Speechify.AmdConfigOnUnavailableAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AmdConfigOnUnavailable" /> class.
        /// </summary>
        public AmdConfigOnUnavailable()
        {
        }

    }
}