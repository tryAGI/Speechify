
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Batch row plus all recipients for the detail view.
    /// </summary>
    public sealed partial class TtsGetBatchCallResponse
    {
        /// <summary>
        /// A batch of outbound calls dispatched to a list of recipients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsBatchCall Batch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsBatchRecipient> Recipients { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetBatchCallResponse" /> class.
        /// </summary>
        /// <param name="batch">
        /// A batch of outbound calls dispatched to a list of recipients.
        /// </param>
        /// <param name="recipients"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsGetBatchCallResponse(
            global::Speechify.TtsBatchCall batch,
            global::System.Collections.Generic.IList<global::Speechify.TtsBatchRecipient> recipients)
        {
            this.Batch = batch ?? throw new global::System.ArgumentNullException(nameof(batch));
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetBatchCallResponse" /> class.
        /// </summary>
        public TtsGetBatchCallResponse()
        {
        }

    }
}