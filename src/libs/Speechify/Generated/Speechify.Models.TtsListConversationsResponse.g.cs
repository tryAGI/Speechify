
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsListConversationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsConversation> Conversations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListConversationsResponse" /> class.
        /// </summary>
        /// <param name="conversations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListConversationsResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsConversation> conversations)
        {
            this.Conversations = conversations ?? throw new global::System.ArgumentNullException(nameof(conversations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListConversationsResponse" /> class.
        /// </summary>
        public TtsListConversationsResponse()
        {
        }
    }
}