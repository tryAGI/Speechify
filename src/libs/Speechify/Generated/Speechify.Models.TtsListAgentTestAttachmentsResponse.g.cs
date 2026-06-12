
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsListAgentTestAttachmentsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestAttachment> Attachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListAgentTestAttachmentsResponse" /> class.
        /// </summary>
        /// <param name="attachments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListAgentTestAttachmentsResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestAttachment> attachments)
        {
            this.Attachments = attachments ?? throw new global::System.ArgumentNullException(nameof(attachments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListAgentTestAttachmentsResponse" /> class.
        /// </summary>
        public TtsListAgentTestAttachmentsResponse()
        {
        }

    }
}