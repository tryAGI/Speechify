
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBatchCallResponse
    {
        /// <summary>
        /// A batch of outbound calls dispatched to a list of recipients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.BatchCall Batch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchCallResponse" /> class.
        /// </summary>
        /// <param name="batch">
        /// A batch of outbound calls dispatched to a list of recipients.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBatchCallResponse(
            global::Speechify.BatchCall batch)
        {
            this.Batch = batch ?? throw new global::System.ArgumentNullException(nameof(batch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchCallResponse" /> class.
        /// </summary>
        public CreateBatchCallResponse()
        {
        }

    }
}