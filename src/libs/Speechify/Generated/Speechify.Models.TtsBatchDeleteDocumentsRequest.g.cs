
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for DELETE /v1/knowledge-bases/{id}/documents/batch. All<br/>
    /// ids must belong to the supplied KB; capped at 200 ids per<br/>
    /// call.
    /// </summary>
    public sealed partial class TtsBatchDeleteDocumentsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsBatchDeleteDocumentsRequest" /> class.
        /// </summary>
        /// <param name="ids"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsBatchDeleteDocumentsRequest(
            global::System.Collections.Generic.IList<string> ids)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsBatchDeleteDocumentsRequest" /> class.
        /// </summary>
        public TtsBatchDeleteDocumentsRequest()
        {
        }

    }
}